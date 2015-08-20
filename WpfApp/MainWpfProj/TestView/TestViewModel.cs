using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Shop.WpfProj.Interfaces;

namespace Shop.WpfProj.TestView
{
    public class TestViewModel : ViewModelBase, ITestViewModel
    {
        private int width = 25;
        private string text = "Test Button works!(default text)";

        public TestViewModel()
        {
            ShowText = new RelayCommand(() =>
            {
                Text = "Relay Command works";
                Shop.WebApi ff = new Shop.WpfProj.Controllers.UsersController();
                //ff.
            }
            //, () =>
            //{
            //    return false;
            //}
            );
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                RaisePropertyChanged(()=>Text);
            }
        }

        public RelayCommand ShowText { get; set; }
    }
}
