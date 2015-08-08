using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;

namespace Shop.WpfProj.Interfaces
{
    public interface ITestViewModel
    {
        RelayCommand ShowText { get; set; }
        string Text { get; set; }
    }
}
