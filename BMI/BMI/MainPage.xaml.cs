using BMI.models;
using Microsoft.Maui.Controls;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            welcomeMessage.Text = "Welcome " + AppData.User.Name;

#if ANDROID
            // For Android platform, load the Android-specific view
            Content = new MainPage().Content;
#elif WINDOWS
            // For Windows platform, load the Windows-specific view
            Content = new MainPageWindows().Content;
#else
            // Default view for other platforms
            Content = new Label { Text = "Default view" };
#endif
        }




    }

}
