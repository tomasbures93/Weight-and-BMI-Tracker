namespace BMI;

public partial class Setup : ContentPage
{
	public Setup()
	{
		InitializeComponent();
	}

	public void SaveData(object sender, EventArgs e)
	{
		// will save data 
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