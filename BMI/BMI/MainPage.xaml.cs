using BMI.models;
using BMI.Models;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        //Person user = new Person("Tomas", 75, 174, 31);
        public MainPage()
        {
            InitializeComponent();
            welcomeMessage.Text = "Welcome " + AppData.User.GetName();
        }

        

       
    }

}
