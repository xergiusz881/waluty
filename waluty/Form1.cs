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

                richTextBox1.Text = json;
            }
        }
    }
}
