namespace WatchDog.Maui;

public partial class RegisterScreen : ContentPage
{
	public RegisterScreen()
	{
		InitializeComponent();
	}

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(UsernameEntry.Text) || string.IsNullOrWhiteSpace(PasswordEntry.Text) || string.IsNullOrWhiteSpace(ConfirmPasswordEntry.Text))
        {
            RegisterStatusLabel.Text = "Por favor, preencha todos os campos.";
            return;
        }

        if (PasswordEntry.Text != ConfirmPasswordEntry.Text)
        {
            RegisterStatusLabel.Text = "As senhas n�o coincidem.";
            return;
        }

        // Simula��o de cadastro (conectar API)
        bool isRegistered = Register(UsernameEntry.Text, PasswordEntry.Text);

        if (isRegistered)
        {
            RegisterStatusLabel.Text = "Cadastro bem-sucedido!";
            await Navigation.PopAsync();
        }
        else
        {
            RegisterStatusLabel.Text = "Erro ao cadastrar usu�rio.";
        }
    }

    // M�todo de registro (simula��o)
    private bool Register(string username, string password)
    {
        // Fazer a l�gica de verificar no banco de dados
        return username != "admin"; // Impedindo o cadastro de um usu�rio j� existente.
    }
}