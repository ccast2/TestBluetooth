using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestXamarin
{
    public class app : Application
    {

        protected static INombre objetoNombre;
        public static Label etiqueta;

        public static EventoBluetooth bluetoothManager = EventoBluetooth.getInstance();

        public app()
        {
            etiqueta = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Welcome to Xamarin Forms!"
            };

            // The root page of your application
            var content = new ContentPage
            {
                Title = "TestXamarin",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        etiqueta
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
