using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PrevisaoDoTempo
{
    public partial class PrevisaoDoTempo : Form
    {
        private static readonly string baseUrl = "https://api.open-meteo.com/v1/forecast";
        public class Capital
        {
            public string Nome { get; set; }
            public string Estado { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }

        private List<Capital> capitais = new List<Capital>
        {
            new Capital { Nome = "Maceió", Estado = "AL", Latitude = -9.66, Longitude = -35.73 },
            new Capital { Nome = "Macapá", Estado = "AP", Latitude = 0.03, Longitude = -51.06 },
            new Capital { Nome = "Manaus", Estado = "AM", Latitude = -3.11, Longitude = -60.02 },
            new Capital { Nome = "Salvador", Estado = "BA", Latitude = -12.97, Longitude = -38.50 },
            new Capital { Nome = "Fortaleza", Estado = "CE", Latitude = -3.71, Longitude = -38.54 },
            new Capital { Nome = "Brasília", Estado = "DF", Latitude = -15.78, Longitude = -47.92 },
            new Capital { Nome = "Vitória", Estado = "ES", Latitude = -20.31, Longitude = -40.31 },
            new Capital { Nome = "Goiânia", Estado = "GO", Latitude = -16.68, Longitude = -49.26 },
            new Capital { Nome = "São Luís", Estado = "MA", Latitude = -2.53, Longitude = -44.28 },
            new Capital { Nome = "Cuiabá", Estado = "MT", Latitude = -15.60, Longitude = -56.09 },
            new Capital { Nome = "Campo Grande", Estado = "MS", Latitude = -20.46, Longitude = -54.62 },
            new Capital { Nome = "Belo Horizonte", Estado = "MG", Latitude = -19.91, Longitude = -43.93 },
            new Capital { Nome = "Belém", Estado = "PA", Latitude = -1.45, Longitude = -48.50 },
            new Capital { Nome = "João Pessoa", Estado = "PB", Latitude = -7.11, Longitude = -34.86 },
            new Capital { Nome = "Curitiba", Estado = "PR", Latitude = -25.42, Longitude = -49.27 },
            new Capital { Nome = "Recife", Estado = "PE", Latitude = -8.04, Longitude = -34.87 },
            new Capital { Nome = "Teresina", Estado = "PI", Latitude = -5.08, Longitude = -42.80 },
            new Capital { Nome = "Rio de Janeiro", Estado = "RJ", Latitude = -22.90, Longitude = -43.17 },
            new Capital { Nome = "Natal", Estado = "RN", Latitude = -5.79, Longitude = -35.21 },
            new Capital { Nome = "Porto Alegre", Estado = "RS", Latitude = -30.03, Longitude = -51.21 },
            new Capital { Nome = "Porto Velho", Estado = "RO", Latitude = -8.76, Longitude = -63.90 },
            new Capital { Nome = "Boa Vista", Estado = "RR", Latitude = 2.82, Longitude = -60.67 },
            new Capital { Nome = "Florianópolis", Estado = "SC", Latitude = -27.59, Longitude = -48.5 },
            new Capital { Nome = "São Paulo", Estado = "SP", Latitude = -23.55, Longitude = -46.63 },
            new Capital { Nome = "Aracaju", Estado = "SE", Latitude = -10.94, Longitude = -37.07 },
            new Capital { Nome = "Palmas", Estado = "TO", Latitude = -10.24, Longitude = -48.32 },
            new Capital { Nome = "Presidente Prudente", Estado = "SP", Latitude = -22.12, Longitude = -51.38 }
        };

        private string ObterDescricaoClima(int weatherCode)
        {
            return weatherCode switch
            {
                0 => "Céu limpo",
                1 => "Parcialmente nublado",
                2 => "Parcialmente nublado",
                3 => "Nublado",
                45 => "Névoa",
                48 => "Névoa gelada",
                51 => "Chuvisco leve",
                53 => "Chuvisco moderado",
                55 => "Chuvisco intenso",
                56 => "Chuvisco leve e congelante",
                57 => "Chuvisco intenso e congelante",
                61 => "Chuva leve",
                63 => "Chuva moderada",
                65 => "Chuva intensa",
                66 => "Chuva leve e congelante",
                67 => "Chuva intensa e congelante",
                71 => "Neve leve",
                73 => "Neve moderada",
                75 => "Neve intensa",
                77 => "Granizo",
                80 => "Aguaceiro leve",
                81 => "Aguaceiro moderado",
                82 => "Aguaceiro forte",
                85 => "Aguaceiro de neve leve",
                86 => "Aguaceiro de neve intenso",
                95 => "Tempestade moderada",
                96 => "Tempestade com granizo leve",
                99 => "Tempestade com granizo forte",
                _ => "Código de clima desconhecido"
            };
        }

        private async Task ObterDadosClimaAsync(double latitude, double longitude, string cidade)
        {
            rtbRetorno.Text = "";
            using (HttpClient client = new HttpClient())
            {
                string url = $"{baseUrl}?latitude={latitude}&longitude={longitude}&current_weather=true";
                rtbRetorno.Text += url;
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (responseBody.StartsWith("["))
                    {
                        JArray dadosClimaArray = JArray.Parse(responseBody);

                        JObject dadosClima = (JObject)dadosClimaArray[0];

                        string temperatura = dadosClima["current_weather"]["temperature"] + "°C";
                        string velocidadeVento = dadosClima["current_weather"]["windspeed"] + " km/h";
                        int weatherCode = (int)dadosClima["current_weather"]["weathercode"];
                        string descricaoClima = ObterDescricaoClima(weatherCode);

                        rtbRetorno.Text += "Cidade: " + cidade + "\nClima: " + descricaoClima + "\nTemperatura: " + temperatura +"\nVelocidade do Vento: " + velocidadeVento;
                    }
                    else
                    {
                        JObject dadosClima = JObject.Parse(responseBody);

                        string temperatura = dadosClima["current_weather"]["temperature"] + "°C";
                        string velocidadeVento = dadosClima["current_weather"]["windspeed"] + " km/h";
                        int weatherCode = (int)dadosClima["current_weather"]["weathercode"];
                        string descricaoClima = ObterDescricaoClima(weatherCode);

                        rtbRetorno.Text += "Cidade: " + cidade + "\nClima: " + descricaoClima + "\nTemperatura: " + temperatura + "\nVelocidade do Vento: " + velocidadeVento;
                    }
                }
                catch (JsonReaderException e)
                {
                    MessageBox.Show("Erro ao processar JSON: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public PrevisaoDoTempo()
        {
            InitializeComponent();
            cbCidades.SelectedIndex = 0;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            string cidadeSelecionada = cbCidades.Text;

            var capital = capitais.FirstOrDefault(c => $"{c.Nome} - {c.Estado}".Equals(cidadeSelecionada, StringComparison.OrdinalIgnoreCase));

            if (capital != null)
            {
                await ObterDadosClimaAsync(capital.Latitude, capital.Longitude, $"{capital.Nome} - {capital.Estado}");
            }
            else
            {
                MessageBox.Show("Cidade não encontrada na lista de capitais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
