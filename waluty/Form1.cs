using Newtonsoft.Json;

namespace waluty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.nbp.pl/");

                string query = "api/exchangerates/tables/A";

                HttpResponseMessage response = client.GetAsync(query).Result;

                string json = response.Content.ReadAsStringAsync().Result;

                //richTextBox1.Text = json;

                apirespons apirespons = JsonConvert.DeserializeObject<apirespons[]>(json)[0];

                double EURRate = apirespons.rates[7].mid;

                richTextBox1.Text = "Dzisiejszy kurs Eur to: " + EURRate.ToString();
            }
        }
    }
}
