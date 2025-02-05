using BMI.models;
using Microsoft.Maui.Controls;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if(AppData.User.Name == "")
            {
                welcomeMessage.Text = "Welcome";
            } else
            {
                welcomeMessage.Text = "Welcome " + AppData.User.Name;
                BMI.Text = AppData.User.BMI.ToString();
            }
        }
        private async void NavigateToSetup(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Setup());
        }

        private async void Refresh(object sender, EventArgs e)
        {
            welcomeMessage.Text = "Welcome " + AppData.User.Name;
            BMI.Text = AppData.User.BMI.ToString("F2");
        }


    }

}
