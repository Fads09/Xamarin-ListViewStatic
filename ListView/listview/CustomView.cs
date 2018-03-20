using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace listview
{
    public class CustomView : ContentPage
    {
        public ObservableCollection<Custom> contacts { get; set; }
        public CustomView()
        {
            contacts = new ObservableCollection<Custom>();
            ListView lstView = new ListView();
            lstView.RowHeight = 60;
            this.Title = "Contacts";
            lstView.ItemTemplate = new DataTemplate(typeof(CustomContactsCell));
            contacts.Add(new Custom { Name = "Andrew Jones", PhoneNumber = "(222)222-2222" });
            contacts.Add(new Custom { Name = "Catherine McMillen", PhoneNumber = "(333)333-3333" });
            contacts.Add(new Custom { Name = "Chris Lesson", PhoneNumber = "(444)444-4444" });
            contacts.Add(new Custom { Name = "David Allison", PhoneNumber = "(555)555-5555" });
            contacts.Add(new Custom { Name = "Emanuel Garcia", PhoneNumber = "(666)666-6666" });
            contacts.Add(new Custom { Name = "Frank Green", PhoneNumber = "(777)777-7777" });

            lstView.ItemsSource = contacts;
            Content = lstView;
        }

        public class CustomContactsCell : ViewCell
        {
            public CustomContactsCell()
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

