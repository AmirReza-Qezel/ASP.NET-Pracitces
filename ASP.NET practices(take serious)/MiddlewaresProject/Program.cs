using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Use(async (context, next) =>
{
    var test = context.Request.Query["test"];
    if (!string.IsNullOrEmpty(test))
        context.Items.Add("test",test);
    await next.Invoke();
});
app.Use(async (context,next)=>
{
    bool testbool = context.Items.TryGetValue("test", out var test);
    if (testbool)
        await context.Response.WriteAsync($"this is a {test} \n");
    await next.Invoke();
});
app.Map("/branch1", appBuilder =>
{
    appBuilder.Map("/branch11", MethodOfHonor());

    appBuilder.Use(async (context, next) =>
    {
        await context.Response.WriteAsync("this is the middle of branch1 \n");
        await next.Invoke();
    });
    appBuilder.Run(async context =>
    {
        await context.Response.WriteAsync("this is the end of branch1 \n\n");
    });
});
app.UseWhen(context => context.Request.Query.ContainsKey("test"), appBuilder =>
{
    // This middleware only runs if the condition is true
    appBuilder.Use(async (context, next) =>
    {
        context.Items["test"] = context.Request.Query["test"];
        await context.Response.WriteAsync("Condition met! Running special middleware.\n");
        await next.Invoke();
    });
});
//app.MapWhen(context => context.Request.Query.ContainsKey("test"), appBuilder =>
//{
//    // This middleware only runs if the condition is true
//    appBuilder.Use(async (context, next) =>
//    {
//        context.Items["test"] = context.Request.Query["test"];
//        await context.Response.WriteAsync("Condition met! Running special middleware.\n");
//        await next.Invoke();
//    });
//});
app.Run(async context =>
{
    await context.Response.WriteAsync("Hi People of the computer\n");
});


app.Run();


 Action<IApplicationBuilder> MethodOfHonor()
{
    return builder =>
    {
        builder.Run(async context =>
        {
            await context.Response.WriteAsync(T.Ithon("this is branch11"));
        });
    };
};


public static class T
{
    public static string Ithon(this string p1)
    {
        string a = p1.Trim();
        return a;
    }
}