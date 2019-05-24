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
                StringBuilder builder = new StringBuilder();
                builder.AppendFormat("******" + FrmMain.RCompany.CompanyName + "********\n");
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix 
                var response = await client.GetAsync("Car/RentCarReturn?endKm=" + txtEndingKM.Text + "&CarID=" + txtCarID.Text);
                if (response.IsSuccessStatusCode)
                {
                    var CustomerResponse = await client.GetAsync("Company/GetCustomer?customerID=" + dgwRezervationDetails.SelectedRows[0].Cells[0].Value.ToString());
                    if (CustomerResponse.IsSuccessStatusCode)
                    {
                        Customer C = new Customer();
                        C = CustomerResponse.Content.ReadAsAsync<Customer>().Result;
                        builder.AppendFormat("Fatura Tarihi : " + System.DateTime.Now.ToShortTimeString().ToString() + "\n" +
                            "Name : " + C.CustomerName + C.CustomerSurname + "\n");
                    }
                    var carResponse = await client.GetAsync("Car/GetCar?id=" + dgwRezervationDetails.SelectedRows[0].Cells[1].Value.ToString());
                    if (carResponse.IsSuccessStatusCode)
                    {
                        Car car = new Car();
                        var model = carResponse.Content.ReadAsAsync<JObject>().Result;
                        car = JsonConvert.DeserializeObject<Car>(model.ToString()); 
                        builder.AppendFormat("Car Marka : " + car.CarBrand + "\n");
                        builder.AppendFormat("Car Model : " + car.CarModel + "\n");

                    }

                    var rentDetailsResponse = client.GetAsync("company/GetOneRentDetail?RentDetailID=" + dgwRezervationDetails.SelectedRows[0].Cells[9].Value.ToString()).Result;
                    if (rentDetailsResponse.IsSuccessStatusCode)
                    {

                        //RentDetailsRequestDto car = new RentDetailsRequestDto();
                        var model = rentDetailsResponse.Content.ReadAsAsync<JObject>().Result;
                        var car = JsonConvert.DeserializeObject<RentDetailsRequestDto>(model.ToString());
                        builder.AppendFormat("Rent Start : " + car.RentStartDate.ToString() + "\n");
                        builder.AppendFormat("Rent End: " + car.RentEndDate.ToString() + "\n");
                        builder.AppendFormat("KM Start : " + car.StartingKilometer.ToString() + "\n");
                        builder.AppendFormat("KM End: " + txtEndingKM.Text + "\n");
                        builder.AppendFormat("Pricing : " + car.Pricing.ToString() + "\n");

                    }
                    MessageBox.Show(builder.ToString());
                }
            }
        }
    }
}

