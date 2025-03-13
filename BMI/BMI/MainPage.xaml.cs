using BMI.models;
using CommunityToolkit.Maui.Alerts;
using Microsoft.Maui.Controls;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        private readonly PersonDBContext _dbContext;

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

        public MainPage(PersonDBContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;

            if(File.Exists(Path.Combine(FileSystem.AppDataDirectory, "Database.db")) == true)
            {
                Toast.Make("Database is ready");
                // Tested and database is there
            } else
            {
                Toast.Make("Problem with DB");
            }

            welcomeMessage.Text = dbContext.Personen.FirstOrDefault().UserName;
        }
        private async void NavigateToSetup(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Setup());
        }


    }

}
