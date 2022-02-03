using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public static class PartfolioImages
    {
        private static List<PartfolioImageDetails> image = new List<PartfolioImageDetails>()
       {
           new PartfolioImageDetails{Id=1,title="Travel",location="post-1.jpg"},
           new PartfolioImageDetails{Id=2,title="Cooking",location="post-2.jpg"},
           new PartfolioImageDetails{Id=3,title="Web Design",location="post-3.jpg"}
       };
        // BlogeImage
        public static List<PartfolioImageDetails> AllImage() => image;



        private static List<PartfolioImageDetails> work = new List<PartfolioImageDetails>()
       {
           new PartfolioImageDetails{Id=1,title="Lorem impsum dolor",location="work-1.jpg"},
           new PartfolioImageDetails{Id=2,title="Loreda Cuno Nere",location="work-2.jpg"},
           new PartfolioImageDetails{Id=3,title="Mavrito Lana Dere",location="work-3.jpg"},
           new PartfolioImageDetails{Id=4,title="Bindo Laro Cado",location="work-4.jpg"},
           new PartfolioImageDetails{Id=5,title="Studio Lena Mado",location="work-5.jpg"},
           new PartfolioImageDetails{Id=5,title="Studio Big Bang",location="work-6.jpg"}
       };
        // Work Image
        public static List<PartfolioImageDetails> WorkImage() => work;

        //Testimonials 
        private static List<PartfolioImageDetails> testimonials = new List<PartfolioImageDetails>()
       {
           new PartfolioImageDetails{Id=1,title="Xavi Alonso",location="testimonial-2.jpg"},
           new PartfolioImageDetails{Id=2,title="Marta Socrate",location="testimonial-4.jpg"},
           
       };
        // Work Image
        public static List<PartfolioImageDetails> Testimonials() => testimonials;
    }

    public class PartfolioImageDetails
    {
        public int Id{ get; set; }
        public string title { get; set; }
        public string location { get; set; }
    }
}
