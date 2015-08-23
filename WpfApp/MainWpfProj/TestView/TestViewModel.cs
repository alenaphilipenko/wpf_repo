using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

        public TestViewModel(IWebApiConnector connector)
        {
            ShowText = new RelayCommand(() =>
            {
                Text = "Relay Command works";
                var client = connector.CreateConnection();
                HttpResponseMessage response = client.GetAsync("api/users/ReturnSquare/6").Result;
                //Shop.WebApi ff = new Shop.WpfProj.Controllers.UsersController();
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
                RaisePropertyChanged(() => Text);
            }
        }

        public RelayCommand ShowText { get; set; }
    }
}
