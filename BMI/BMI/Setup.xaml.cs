using BMI.Models;
namespace BMI;

public partial class Setup : ContentPage
{
	public Setup(ProfilViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
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