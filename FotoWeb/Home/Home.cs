using Spark.Web.FubuMVC.ViewCreation;

namespace FotoWeb.Home
{
    public class HomeViewModel
    {
        private string _image;

        public string ImageUploader
        {
            get { return _image; }
            set { _image = value; }
        }
    }
    
    public class HomeController
    {
        public HomeViewModel Home()
        {
            return new HomeViewModel();
        }
    }
}
