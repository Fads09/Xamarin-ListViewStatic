using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace listview
{
    public class CustomView : ContentPage
    {
        public ObservableCollection<VeggieViewModel> veggies { get; set; }
        public CustomView()
        {
            veggies = new ObservableCollection<VeggieViewModel>();
            ListView lstView = new ListView();
            lstView.RowHeight = 60;
            this.Title = "Contacts";
            lstView.ItemTemplate = new DataTemplate(typeof(CustomVeggieCell));
            veggies.Add(new VeggieViewModel { Name = "Andrew Jones", PhoneNumber = "(222)222-2222" });
            veggies.Add(new VeggieViewModel { Name = "Catherine McMillen", PhoneNumber = "(333)333-3333" });
            veggies.Add(new VeggieViewModel { Name = "Chris Lesson", PhoneNumber = "(444)444-4444" });
            veggies.Add(new VeggieViewModel { Name = "David Allison", PhoneNumber = "(555)555-5555" });
            veggies.Add(new VeggieViewModel { Name = "Emanuel Garcia", PhoneNumber = "(666)666-6666" });
            veggies.Add(new VeggieViewModel { Name = "Frank Green", PhoneNumber = "(777)777-7777" });

            lstView.ItemsSource = veggies;
            Content = lstView;
        }

        public class CustomVeggieCell : ViewCell
        {
            public CustomVeggieCell()
            {
                //instantiate each of our views
                var PhoneNumber = new Label();
                var nameLabel = new Label();
              
                var verticaLayout = new StackLayout();
                var horizontalLayout = new StackLayout() {  };

                //set bindings
                nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
                PhoneNumber.SetBinding(Label.TextProperty, new Binding("PhoneNumber"));

                //Set properties for desired design
                horizontalLayout.Orientation = StackOrientation.Horizontal;
                horizontalLayout.HorizontalOptions = LayoutOptions.Fill;
                nameLabel.FontSize = 20;
                PhoneNumber.FontSize = 18;

                //add views to the view hierarchy
                verticaLayout.Children.Add(nameLabel);
                verticaLayout.Children.Add(PhoneNumber);
                horizontalLayout.Children.Add(verticaLayout);

                // add to parent view
                View = horizontalLayout;
            }
        }
    }
}

