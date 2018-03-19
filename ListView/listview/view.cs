using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace listview
{
    public class view : ViewCell
    {
        public view()
        {
            var label1 = new Label
            {
                Text = "Label 1",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };
            label1.SetBinding(Label.TextProperty, new Binding("."));

            View = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(15, 5, 5, 5),
                Children = { label1 }
            };
        }


       
    }
}
