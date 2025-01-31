using BMI.models;
using BMI.Models;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            welcomeMessage.Text = "Welcome " + AppData.User.Name;
        }

        

       
    }

}
