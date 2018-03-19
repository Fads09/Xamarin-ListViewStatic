using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace listview
{
    public class imageView : ViewCell
    {
        public imageView()
        {
            var image = new Image
            {
                Source = ImageSource.FromFile("monkey.jpg"),
                HeightRequest = 50,
            };

            var image1 = new Image
            {
                Source = ImageSource.FromFile("image2.jpg"),
                HeightRequest = 50,
            };
            var image2 = new Image
            {
                Source = ImageSource.FromFile("monky2.jpg"),
                HeightRequest = 50,
            };

  

            var stackLayout = new StackLayout
            {
                Padding = new Thickness(20, 5, 5, 5),
                Orientation = StackOrientation.Vertical,
                Children = {
                    image,
                    new Label { Text = "", VerticalOptions = LayoutOptions.Center }
                }
            };
            var stackLayout1 = new StackLayout
            {
                Padding = new Thickness(20, 5, 5, 5),
                Orientation = StackOrientation.Vertical,
                Children = {
                   image1, 
                    new Label { Text = "", VerticalOptions = LayoutOptions.Center }
                }
            };
            var stackLayout2 = new StackLayout
            {
                Padding = new Thickness(20, 5, 5, 5),
                Orientation = StackOrientation.Vertical,
                Children = {
                   image2,
                    new Label { Text = "", VerticalOptions = LayoutOptions.Center }
                }
            };

            var stack = new StackLayout
            {
                Padding = new Thickness(20, 5, 5, 5),
                Orientation = StackOrientation.Vertical,
                Children = {
                    stackLayout, stackLayout1, stackLayout2
                }
            };
         

            View = stack;
        }
    }

}