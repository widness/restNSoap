using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AmountForm
{
	public partial class Form1 : Form
	{
		ServRef_wcf_online.PPSI_ServiceWCFClient clientWCF = new ServRef_wcf_online.PPSI_ServiceWCFClient();

		//string baseUri = "http://153.109.124.35:81/ppsiRest/api/user";
		string baseUri = "http://153.109.124.35:81/RiedoBaletRest/api/user";

		private void button1_Click(object sender, EventArgs e)
		{
			int iDuser = Convert.ToInt32(textBox3.Text);

			using (HttpClient httpClient = new HttpClient())
			{
				string uri = baseUri +"/"+ iDuser;
				Task<string> response = httpClient.GetStringAsync(uri);
				string username = JsonConvert.DeserializeObject<string>(response.Result);

				MessageBox.Show("Bonjour. \nVotre nom d'utilisateur est " + username);
			}
		}

		private void charge_Click(object sender, EventArgs e)
		{
			string username = textBox1.Text;
			int amount = Convert.ToInt32(textBox2.Text);

			clientWCF.AddAmount(amount, username);
		}

		private void check_Click(object sender, EventArgs e)
		{
			string username = textBox1.Text;
			double amount = clientWCF.GetAvailableAmount(username);

			MessageBox.Show("Bonjour. \nVotre avoir disponible est de " + amount);
		}











		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

	}
}
