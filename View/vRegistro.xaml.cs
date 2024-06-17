namespace JPillajoS3.View;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        UserManager.AddUser(username, password);
        Navigation.PushAsync(new vLogin(username, password));

    }
}