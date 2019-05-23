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
    public partial class FrmUpdateCar : Form
    {
        public FrmUpdateCar()
        {
            InitializeComponent();
        }

        private void btnAracSec_Click(object sender, EventArgs e)
        {
            txtCarId.Text = dgwCars.SelectedRows[0].Cells[0].Value.ToString();
            txtAirbagCount.Text = dgwCars.SelectedRows[0].Cells[10].Value.ToString();
            txtBrand.Text = dgwCars.SelectedRows[0].Cells[4].Value.ToString();
            txtCarKm.Text = dgwCars.SelectedRows[0].Cells[9].Value.ToString();
            txtMaxKm.Text = dgwCars.SelectedRows[0].Cells[8].Value.ToString();
            txtMinCustomerAge.Text = dgwCars.SelectedRows[0].Cells[7].Value.ToString();
            txtMinLicenceAge.Text = dgwCars.SelectedRows[0].Cells[6].Value.ToString();
            txtModel.Text = dgwCars.SelectedRows[0].Cells[5].Value.ToString();
            txtPhotoUrl.Text = dgwCars.SelectedRows[0].Cells[14].Value.ToString();
            txtRentPrice.Text = dgwCars.SelectedRows[0].Cells[13].Value.ToString();
            txtSeatCount.Text = dgwCars.SelectedRows[0].Cells[12].Value.ToString();
            txtTrunkVolume.Text = dgwCars.SelectedRows[0].Cells[11].Value.ToString();
        }

        private void txtMinLicenceAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtPhotoUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRentPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeatCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTrunkVolume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAirbagCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaxKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinCustomerAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarId_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnUpdateCar_ClickAsync(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient()) //Fix
            {
                CarRequestDto UpdateCar = new CarRequestDto
                {
                    CarBrand = txtBrand.Text,
                    CarKM = int.Parse(txtCarKm.Text),
                    AirBagCount = byte.Parse(txtAirbagCount.Text),
                    CarModel = txtModel.Text,
                    CarPhotoURL = txtPhotoUrl.Text,
                    CarPriceForRent = decimal.Parse(txtRentPrice.Text),
                    CarSeatCount = byte.Parse(txtSeatCount.Text),
                    MinCustomerAge = byte.Parse(txtMinCustomerAge.Text),
                    MinDrivingLicenseAge = byte.Parse(txtMinLicenceAge.Text),
                    MaxKmPerDay = int.Parse(txtMaxKm.Text),
                    CarTrunkVolume = short.Parse(txtTrunkVolume.Text)
                };
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix
                var serializedUpdateCar = JsonConvert.SerializeObject(UpdateCar);
                var content = new StringContent(serializedUpdateCar, Encoding.UTF8, "application/json");
                await client.PostAsync("Car/UpdateCar?CarID="+int.Parse(txtCarId.Text), content);
              //  if (response.IsSuccessStatusCode)
//{
              //      MessageBox.Show("Successfull");
               // }
            }
        }

        private void dgwCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUpdateCar_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient()) //Fix
            {
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix
                HttpResponseMessage response = client.GetAsync("car/GetCars?id=" + FrmMain.RCompany.CompanyID).Result;
                //End Point Name https://localhost:44300/car/getcars Query String Example bla bla car/getcars?blabla
                if (response.IsSuccessStatusCode)
                {
                    var model = response.Content.ReadAsAsync<JArray>().Result;
                    dgwCars.DataSource = model;
                }
            }
        }
    }
}
