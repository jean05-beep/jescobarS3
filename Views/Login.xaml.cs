using jescobarS3.Views.HomeCalificacion;

namespace jescobarS3.Views;

public partial class Login : ContentPage
{
    private readonly string[] users = ["Carlos", "Ana", "Jose"];
    private readonly string[] passwords = ["carlos123", "ana123", "jose123"];

    public Login()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        for (int i = 0; i < users.Length; i++)
        {
            if (username == users[i] && password == passwords[i])
            {
                await Navigation.PushAsync(new Estudiante());
                return;
            }
        }
        await DisplayAlert("Error", "Usuario o contraseña incorrectos.", "OK");
    }
}