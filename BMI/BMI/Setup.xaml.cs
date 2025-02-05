using BMI.models;
using CommunityToolkit.Maui.Alerts;
namespace BMI;

public partial class Setup : ContentPage
{
	public Setup()
	{
		InitializeComponent();
	}

	public async void SaveData(object sender, EventArgs e)
	{
		bool fehler = false;
		if(string.IsNullOrEmpty(UsernameInput.Text))
		{
			fehler = true;
		}
		if(!double.TryParse(WeightInput.Text, out double result) || string.IsNullOrEmpty(WeightInput.Text))
		{
			fehler = true;
		}
		if(!double.TryParse(HeightInput.Text, out double height) || string.IsNullOrEmpty(HeightInput.Text))
		{
			fehler = true;
		}
        if (!int.TryParse(AgeInput.Text, out int age) || string.IsNullOrEmpty(AgeInput.Text))
        {
            fehler = true;
        }
        if (Male.IsChecked == false && Female.IsChecked == false)
        {
			fehler = true;
        }
		if(fehler == false)
		{
            AppData.User.Name = UsernameInput.Text;
			AppData.User.Weight = result;
            AppData.User.Height = height;
			AppData.User.Age = age;
            if (Male.IsChecked == true)
            {
                AppData.User.Gender = "Male";
            }
            else
            {
                AppData.User.Gender = "Female";
            }
            AppData.User.BMI = CalculateBMI();
            if (DeviceInfo.Platform == DevicePlatform.Android || DeviceInfo.Platform == DevicePlatform.iOS)		// Platform check!!! Toast works only on PHONES
            {
                await Toast.Make("Data saved.").Show();
            }
            else
            {
                await DisplayAlert("Success", "Data have been saved!", "OK");
            }
        } else
		{
			await DisplayAlert("Wrong input", "Please try again! Wrong input", "OK");
		}
    }

    public double CalculateBMI()
    {
		double bmi = AppData.User.Weight / ((AppData.User.Height / 100) * (AppData.User.Height / 100));
        return bmi;
    }

    private void OnChangeBoxChange(object sender, CheckedChangedEventArgs e)
	{
		if(sender == Male)
		{
			Female.IsChecked = !Male.IsChecked;
		} 
		else
		{
			Male.IsChecked = !Female.IsChecked;
		}
	}
}