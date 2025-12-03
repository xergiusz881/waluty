using Newtonsoft.Json;

namespace waluty
{
    public partial class Form1 : Form
    {
        double USDRate;
        double GBPRate;
        double CHFRate;
        double EurRate;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadFromAPI(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.nbp.pl/");

                string query = "api/exchangerates/tables/A";

                HttpResponseMessage response = client.GetAsync(query).Result;

                string json = response.Content.ReadAsStringAsync().Result;



                apirespons apirespons = JsonConvert.DeserializeObject<apirespons[]>(json)[0];

                //double EURRate = apirespons.rates[7].mid;



                USDRate = apirespons.rates[1].mid;

                TextBox11.Text = "Dzisiejszy kurs USD to: " + USDRate.ToString();

                GBPRate = apirespons.rates[10].mid;

                TextBox2.Text = "Dzisiejszy kurs GBP to: " + GBPRate.ToString();

                CHFRate = apirespons.rates[9].mid;

                TextBox3.Text = "Dzisiejszy kurs CHF to: " + CHFRate.ToString();

                EurRate = apirespons.rates[7].mid;
                TextBox4.Text = "Dzisiejszy kurs Eur to: " + EurRate.ToString();
            }
        }

        private void convert(object sender, EventArgs e)
        {
            double sourceAmount = Convert.ToDouble(sAmout.Text);

            double plnAmount = 0.0;
            if (USD_IN.Checked)
            {
                plnAmount = sourceAmount * USDRate;
            }
            else if (GBP_IN.Checked)
            {
                plnAmount = sourceAmount * GBPRate;
            }
            else if (CHF_IN.Checked)
            {
                plnAmount = sourceAmount * CHFRate;
            }
            else if (EUR_IN.Checked)
            {
                plnAmount = sourceAmount * EurRate;
            }
            else
            {
                plnAmount = sourceAmount;
            }
            double destinationAmount = 0.0;
            if (USD_OUT.Checked)
            {
                destinationAmount = plnAmount / USDRate;
            }
            else if (GBP_OUT.Checked)
            {
                destinationAmount = plnAmount / GBPRate;
            }
            else if (CHF_OUT.Checked)
            {
                destinationAmount = plnAmount / CHFRate;
            }
            else if (EUR_OUT.Checked)
            {
                destinationAmount = plnAmount / EurRate;
            }
            else
            {
                destinationAmount = plnAmount;
            }
        }
    }
}

