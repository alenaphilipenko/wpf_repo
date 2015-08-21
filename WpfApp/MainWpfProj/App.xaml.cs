using System.Windows;
using Shop.WpfProj;
using Shop.WpfProj.TestView;
using Shop.WpfProj.View;
using SimpleInjector;

namespace MainWpfProj
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var container = new Container();
            WpfProjPackage.RegisterViewModels(container);

            var mainWindow = container.GetInstance<TestWindow>();

            mainWindow.Show();

        }
    }
}
