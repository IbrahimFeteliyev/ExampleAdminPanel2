using Example.Models;

namespace Example.ViewModel
{
    public class HomeVM
    {
        public Masthead Masthead { get; set; }
        public List<About> Abouts { get; set; }
        public List<Contactme> Contactmes { get; set; }
        public List<Portfolio> Portfolios { get; set; }

    }
}
