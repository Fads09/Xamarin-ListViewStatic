using System;
using Xamarin.Forms;

namespace listview
{
    
    public class App : Application 
    {
        public App()
        {
           

            var tabsCs = new TabbedPage { Title = "ListView" };
            tabsCs.Children.Add(new Test { Title = "Basic", Icon = "" });
            tabsCs.Children.Add(new ImageView { Title = "Image", Icon = "" });
            tabsCs.Children.Add(new CustomView { Title = "Custom", Icon = "" });
            MainPage = tabsCs;



        }
    }
}

