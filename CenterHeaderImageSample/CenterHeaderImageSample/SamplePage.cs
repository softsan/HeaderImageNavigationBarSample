using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CenterHeaderImageSample
{
    public class SamplePage : ContentPage
    {
        public SamplePage()
        {

            var name = new Entry() {Placeholder = "Name"};
            var city = new Entry() { Placeholder = "City" };
            var address = new Entry() { Placeholder = "Address" };

            var button = new Button()
            {
                Text = "submit",
          
                // VerticalOptions = LayoutOptions.CenterAndExpand,
                
            };

           

            var layout = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                Children = { name,city,address,button }
            };
            
            NavigationPage.SetHasNavigationBar(this, true);
            Content = layout;

        }
    }
}
