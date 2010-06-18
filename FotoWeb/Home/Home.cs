using Spark.Web.FubuMVC.ViewCreation;

namespace FotoWeb.Home
{
    public class HomeViewModel
    {
    }

    public class HomeController
    {
        public HomeViewModel Home()
        {
            return new HomeViewModel();
        }
    }
}
