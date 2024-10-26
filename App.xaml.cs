using jescobarS3.Views;
using jescobarS3.Views.HomeCalificacion;

namespace jescobarS3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Login());
            
        }
     
    }

}
