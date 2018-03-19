using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace listview
{
    public class test : ContentPage
    {
        public test()
        {
            var listView = new ListView();

            listView.HasUnevenRows = true;

            // https://en.wikipedia.org/wiki/Stephen_Hawking
            listView.ItemsSource = new[] {
                "Hawking was born on 8 January 1942 in Oxford to Frank " +
                "and Isobel Hawking Hawking's mother was Scottish.",
               @" Despite their families' financial constraints," +
                " both parents attended the University of Oxford" +
                ", where Frank read medicine and Isobel read Philosophy," +
                " Politics and Economics. While Isobel worked as a secretary for a medical research institute, Frank was a medical researcher.",
                @"While Isobel worked as a secretary for a medical research institute,Frank was a medical researcher.",
                @"Hawking had two younger sisters, Philippa and Mary, and an adopted brother, Edward.",
                @"In 1950, when Hawking's father became head of the division of parasitology at the National Institute for Medical Research, the family moved to St Albans, Hertfordshire",
                @"In St Albans, the family were considered highly intelligent and somewhat eccentric; meals were often spent with each person silently reading a book. ",
                @"They lived a frugal existence in a large, cluttered, and poorly maintained house and travelled in a converted London taxicab.",
                @"During one of Hawking's father's frequent absences working in Africa, the rest of the family spent four months in Majorca visiting his mother's friend Beryl and her husband, the poet Robert Graves."

            };
            listView.ItemTemplate = new DataTemplate(typeof(view));

           
            Padding = new Thickness(0, 20, 0, 0);
            Content = listView;
        }
    }
}

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

