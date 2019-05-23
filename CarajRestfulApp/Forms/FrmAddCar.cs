using CarajRestfulApp.Models;
using Newtonsoft.Json;
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
    public partial class FrmAddCar : Form
    {
        public FrmAddCar()
        {
            InitializeComponent();
        }

        private async void BtnAddCar_ClickAsync(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient()) //Fix
            {
                CarAddRequestDto NewCar = new CarAddRequestDto
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
                    CarTrunkVolume = short.Parse(txtTrunkVolume.Text),
                    CompanyID = FrmMain.RCompany.CompanyID
                };
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix
                var serializedNewCar = JsonConvert.SerializeObject(NewCar);
                var content = new StringContent(serializedNewCar, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("car/AddCar", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Successfull");
                }
            }
        }
    }
}
