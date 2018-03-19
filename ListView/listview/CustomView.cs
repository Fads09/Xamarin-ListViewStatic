using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace listview
{
    public class CustomView : ContentPage
    {
        public ObservableCollection<Custom> custom { get; set; }
        public CustomView()
        {
            custom = new ObservableCollection<Custom>();
            ListView lstView = new ListView();
            lstView.RowHeight = 100;
            this.Title = "Custom Cells";
            lstView.ItemTemplate = new DataTemplate(typeof(CustomViewCell));
            custom.Add(new Custom{ Name = "Monkey1", Image = "image2.jpg" });
            custom.Add(new Custom { Name = "Monkey2", Image = "monkey.jpg" });
            custom.Add(new Custom { Name = "Monkey3", Image = "monky2.jpg" });
            lstView.ItemsSource = custom;
            Content = lstView;
        }

        public class CustomViewCell : ViewCell
        {
            public CustomViewCell()
            {
                
                var image = new Image();
                var nameLabel = new Label();
               
               
                var horizontalLayout = new StackLayout();

           
                nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
                image.SetBinding(Image.SourceProperty, new Binding("Image"));
                horizontalLayout.Orientation = StackOrientation.Horizontal;
                horizontalLayout.HorizontalOptions = LayoutOptions.Fill;
                image.HorizontalOptions = LayoutOptions.End;
                nameLabel.FontSize = 20;
                horizontalLayout.Children.Add(nameLabel);
                horizontalLayout.Children.Add(image);

           
                View = horizontalLayout;
            }
        }
    }
}

