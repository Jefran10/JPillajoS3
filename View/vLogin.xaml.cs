namespace JPillajoS3.View;

public partial class vLogin : ContentPage
{

    private string _username;
    private string _password;

    public vLogin()
	{
		InitializeComponent();
	}

    public vLogin(string username, string password)
    {
        InitializeComponent();
        _username = username;
        _password = password;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        string enteredUsername = usernameEntry.Text;
        string enteredPassword = passwordEntry.Text;

        if (UserManager.ValidateCredentials(enteredUsername, enteredPassword))
        {

            Navigation.PushAsync(new vHome(enteredUsername));
        }
        else
        {
          
            DisplayAlert("Error", "Las credenciales no son válidas.", "Aceptar");
        }
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }

}
