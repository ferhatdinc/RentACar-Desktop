using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarajRestfulApp.Forms
{
    public partial class FrmCarBring : Form
    {
        public FrmCarBring()
        {
            InitializeComponent();
        }

        private void FrmCarBring_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient()) //Fix
            {
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix
                HttpResponseMessage response = client.GetAsync("company/outside?CompanyID=" + int.Parse(FrmMain.RCompany.CompanyID.ToString())).Result;
                //End Point Name https://localhost:44300/car/getcars Query String Example bla bla car/getcars?blabla
                if (response.IsSuccessStatusCode)
                {
                    var model = response.Content.ReadAsAsync<JArray>().Result;
                    dgwRezervationDetails.DataSource = model;
                }
            }
        }

        private void btnKayitSec_Click(object sender, EventArgs e)
        {
            try
            {
                txtCarID.Text = dgwRezervationDetails.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Please Pick A Car");
            }
            
        }

        private async void btnCarBring_ClickAsync(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient()) //Fix
            {
                 
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix 
                var response =await client.GetAsync("Car/RentCarReturn?endKm="+txtEndingKM.Text+"&CarID="+txtCarID.Text);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Successfull");
                }
            }
            }
        }
    }
