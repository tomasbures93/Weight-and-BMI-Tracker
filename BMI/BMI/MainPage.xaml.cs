using BMI.models;
using BMI.Models;
using CommunityToolkit.Maui.Alerts;
using Microsoft.Maui.Controls;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        private readonly PersonDBContext _dbContext;
        private User _user;
        /*
        TO DO
        1) AboutPage
        2) AppShell rework
        3) BMI page delete
        4) ChartPage
        5) MainPage
        6) SetupPage
        7) SaveData - SQlite database - working on it
        8) Proper Test
        */

        public MainPage(PersonDBContext dbContext, User user)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _user = user;

            if(File.Exists(Path.Combine(FileSystem.AppDataDirectory, "Database.db")) == true)
            {
                DisplayAlert("Database is ready","Database is ready", "ok");
                // Tested and database is there
            } else
            {
                DisplayAlert("Database is not ready", "Database is not ready", "ok");
            }
            if(dbContext.Personen.FirstOrDefault().UserName == "User")
            {
                var viewModel = (ProfilViewModel)BindingContext;
                Navigation.PushAsync(new Setup(viewModel));
            } 
            else
            {
                welcomeMessage.Text = dbContext.Personen.FirstOrDefault().UserName;
                CalculateAndDisplayBMI();
            }     
        }
        private async void NavigateToSetup(object sender, EventArgs e)
        {
            var viewModel = (ProfilViewModel)BindingContext;
            await Navigation.PushAsync(new Setup(viewModel));
        }

        private void CalculateAndDisplayBMI()
        {
            var bmi = _user.BMIcalc;
            BMI.Text = $"Your BMI is {bmi:F2}";
        }
    }

}
