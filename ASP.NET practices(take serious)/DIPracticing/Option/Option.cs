namespace DIPracticing.Option
{
    public class Option : IOptionTransient, IOptionScoped, IOptionSingleton
    {
        public Guid Id { get; set; }

        public Option()
        { 
            Id = Guid.NewGuid();
        }
    }
}
