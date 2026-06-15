using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        List<SampleWork> sampleworks = new List<SampleWork> {
         new SampleWork (1,"Sample Work one","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ.","images/thumbs/01.jpg" ),
         new SampleWork (1,"Sample Work two","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ.","images/thumbs/02.jpg" ),
         new SampleWork (1,"Sample Work three","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ.","images/thumbs/03.jpg" ),
         new SampleWork (1,"Sample Work four","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ.","images/thumbs/04.jpg" ),
         new SampleWork (1,"Sample Work five","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ.","images/thumbs/05.jpg" ),
         new SampleWork (1,"Sample Work six","لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ.","images/thumbs/06.jpg" )
         };
        public IActionResult Index()
        {
            ViewBag.Header = "This is The Header Of This Website";
            ViewData["Info"] = "\r\n        لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و\r\n        متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و\r\n        کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد، کتابهای زیادی در شصت و سه درصد گذشته حال و آینده،\r\n        شناخت فراوان جامعه و متخصصان را می طلبد، تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی\r\n        الخصوص طراحان خلاقی، و فرهنگ پیشرو در زبان فارسی ایجاد کرد، در این صورت می توان امید داشت که تمام و\r\n        دشواری موجود در ارائه راهکارها، و شرایط سخت تایپ به پایان رسد و زمان مورد نیاز شامل حروفچینی دستاوردهای\r\n        اصلی، و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.";
            return View(sampleworks);
        }

    }
}
