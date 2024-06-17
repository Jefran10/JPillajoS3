namespace JPillajoS3.View;

public partial class vHome : ContentPage
{
	public vHome()
	{
		InitializeComponent();
	}

    public vHome(string username)
    {
        InitializeComponent();
        userLabel.Text = $"{username}!";
    }
}