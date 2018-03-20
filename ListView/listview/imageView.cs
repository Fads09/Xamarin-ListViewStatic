using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace listview
{
    public class ImageView : ContentPage
    {
        public ObservableCollection<Images> images { get; set; }
        public ImageView()
        {
            images = new ObservableCollection<Images>();
            ListView lstView = new ListView();
            lstView.RowHeight = 100;
            this.Title = "Image Cells";
            lstView.ItemTemplate = new DataTemplate(typeof(ImageViewCell));
            images.Add(new Images { Image = "image2.jpg" });
            images.Add(new Images { Image = "monkey.jpg" });
            images.Add(new Images { Image = "monky2.jpg" });
            images.Add(new Images { Image = "cat.jpg" });
            images.Add(new Images { Image = "dog.jpg" });
            images.Add(new Images { Image = "owl.jpg" });

            lstView.ItemsSource = images;
            Content = lstView;
        }

        public class ImageViewCell : ViewCell
        {
            public ImageViewCell()
            {

                var image = new Image();
                var nameLabel = new Label();


                var horizontalLayout = new StackLayout();


                nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
                image.SetBinding(Image.SourceProperty, new Binding("Image"));
                horizontalLayout.Orientation = StackOrientation.Horizontal;
                horizontalLayout.HorizontalOptions = LayoutOptions.Center;
                image.HorizontalOptions = LayoutOptions.End;
                nameLabel.FontSize = 20;
                horizontalLayout.Children.Add(nameLabel);
                horizontalLayout.Children.Add(image);


                View = horizontalLayout;
            }
        }
    }
}

