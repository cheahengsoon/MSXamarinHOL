using System;
using Xamarin.Forms;

namespace Phoneword
{
    public class CallHistoryPage : ContentPage
    {
        public CallHistoryPage()
        {
            Padding = new Thickness(20, Device.OnPlatform(40, 20, 20), 20, 20);
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Spacing = 15,
                Children = {
                    new ListView
                    {
                        ItemsSource = App.PhoneNumbers
                    }
                }
            };
        }
    }
}
