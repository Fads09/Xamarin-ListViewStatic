using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace listview
{
    public class imageListView : ContentPage
    {
        public imageListView()
        {
            var listView = new ListView();

            listView.HasUnevenRows = true;

            // https://en.wikipedia.org/wiki/Stephen_Hawking
            listView.ItemsSource = new[] {
                new Image {Source = ImageSource.FromUri(new Uri("https://xamarin.com/content/images/pages/forms/example-app.png"))},
                new Image {Source = "image2.jpg"},
                new Image {Source = "monkey.jpg"},


            };
            listView.ItemTemplate = new DataTemplate(typeof(view));


            Padding = new Thickness(0, 20, 0, 0);
            Content = listView;
        }
    }
}

