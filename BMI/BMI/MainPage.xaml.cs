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
        }
        private async void NavigateToSetup(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Setup());
        }



    }

}
