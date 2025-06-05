using System.Net.Http.Json;
using System.Text.Json;

namespace CUEVA.E_Prueba_2;

public partial class Jokes_Api : ContentPage
{
    public Jokes_Api()
    {
        InitializeComponent();
        _=CargarChiste();
    }

    private async void OnOtroChisteClicked(object sender, EventArgs e)
    {
        await CargarChiste();
    }

    private async Task CargarChiste()
    {
        try
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
            var joke = JsonSerializer.Deserialize<Joke>(json);

            if (joke != null)
            {
                Chiste.Text = $"{joke.setup}\n\n{joke.punchline}";
            }
            else
            {
                Chiste.Text = "No se pudo cargar el chiste.";
            }
        }
        catch (Exception ex)
        {
            Chiste.Text = $"Ocurrió un error al cargar el chiste: {ex.Message}";
        }
    }

    public class Joke
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }
}
