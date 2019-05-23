using CarajRestfulApp.Models;
using Newtonsoft.Json;
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
    public partial class FrmNewReservation : Form
    {
        public FrmNewReservation()
        {
            InitializeComponent();
        }
        private static JArray Cars;
        private async void BtnDoReservations_ClickAsync(object sender, EventArgs e)
        {
            
            using (HttpClient client = new HttpClient()) //Fix
            {
                RentDetailsRequestDto NewRent = new RentDetailsRequestDto
                {
                    CustomerID = int.Parse(txtCustomerId.Text),
                    CarID = int.Parse(txtCarId.Text),
                    RentStartDate = tpDateFirst.Value,
                    RentEndDate = tpDateLast.Value,
                    StartingKilometer = int.Parse(txtFirsrKM.Text),
                    EndingKilometer = int.Parse(txtLastKM.Text),
                    Pricing = decimal.Parse(txtAmount.Text)
                };
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix
                var serializedNewRent = JsonConvert.SerializeObject(NewRent);
                var content = new StringContent(serializedNewRent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("company/CreateRent", content ); 
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Successfull");
                }
            }
        }

        private void BtnReservationRequest_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient()) //Fix
            {
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix
                HttpResponseMessage response = client.GetAsync("company/GetRentalRequests?CompanyID=" + FrmMain.RCompany.CompanyID).Result;
                //End Point Name https://localhost:44300/car/getcars Query String Example bla bla car/getcars?blabla
                if (response.IsSuccessStatusCode)
                {
                    var model = response.Content.ReadAsAsync<JArray>().Result;
                    dgwCarList.DataSource = model;
                }
            }
        }

        private void btnSelectCar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCarId.Text = dgwCarList.SelectedRows[0].Cells[0].Value.ToString();
                txtFirsrKM.Text = dgwCarList.SelectedRows[0].Cells[9].Value.ToString();
                TimeSpan kalangun = tpDateLast.Value - tpDateFirst.Value;
                double toplamGun = Math.Ceiling(kalangun.TotalDays);
                txtAmount.Text = (toplamGun * double.Parse(dgwCarList.SelectedRows[0].Cells[13].Value.ToString())).ToString();
            }
            catch {
                MessageBox.Show("Please Select Car in Car List");
                dgwCarList.DataSource = Cars;

            }

        }

        private void tpDateLast_ValueChanged(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient()) //Fix
            {
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix
                HttpResponseMessage response = client.GetAsync("Car/GetAvailableCarByCompanyID?first="+tpDateFirst.Value.ToString("MM/dd/yyyy HH:mm") + "&last="+tpDateLast.Value.ToString("MM/dd/yyyy HH:mm")+"&CompanyID="+ FrmMain.RCompany.CompanyID).Result;
                
                if (response.IsSuccessStatusCode)
                {
                    var model = response.Content.ReadAsAsync<JArray>().Result;
                    dgwCarList.DataSource = model;
                }
            }
        }

        private void FrmNewReservation_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient()) //Fix
            {
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix
                HttpResponseMessage response = client.GetAsync("Car/GetCars?id=" + FrmMain.RCompany.CompanyID).Result;

                if (response.IsSuccessStatusCode)
                {
                    var model = response.Content.ReadAsAsync<JArray>().Result;
                    Cars = model;
                    dgwCarList.DataSource = model;
                }
            }
        }
    }
}
