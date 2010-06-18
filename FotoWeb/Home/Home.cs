using FubuMVC.Core.View;

namespace FotoWeb
{
    public class HomeViewModel
    {
    }

    public class HomeInputModel
    {
        
    }
    public class  HomeView : FubuPage<HomeViewModel>{}

    public class HomeController
    {
        public HomeViewModel Home(HomeInputModel inputModel)
        {
            return new HomeViewModel();
        }
    }
}
