using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.WpfProj.Interfaces;
using Shop.WpfProj.TestView;
using SimpleInjector;

namespace Shop.WpfProj
{
    public class WpfProjPackage
    {
        public static void RegisterViewModels(Container container)
        {
            container.Register<ITestViewModel, TestViewModel>();
        }
    }
}
