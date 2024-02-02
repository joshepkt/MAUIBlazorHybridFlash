using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class HomePageViewModel
    {
        public HomePageViewModel()
        {
            //simulate a "long" running db call
            Task.Run(() => { Thread.Sleep(500); });
        }
    }
}
