using System;
using Xamarin.Forms;

namespace listview
{
    
    public class App : Application 
    {
        public App()
        {
           

            var tabsCs = new TabbedPage { Title = "ListView" };
            tabsCs.Children.Add(new test { Title = "Basic", Icon = "" });
            //tabsCs.Children.Add(new imageView { Title = "Image", Icon = "" });
            tabsCs.Children.Add(new CustomView { Title = "Custom", Icon = "" });
            MainPage = tabsCs;



        }
    }
}

