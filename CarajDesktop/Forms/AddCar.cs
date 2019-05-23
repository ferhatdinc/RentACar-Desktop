using CarajDesktop.CarService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarajDesktop.Forms
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            CarRequestDto car = new CarRequestDto
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

            using (var CarService = new CarServiceSoapClient())
            {
                CarService.AddCar(car,frmMain.Company.CompanyID);
                CarService.Close();
            }
            
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

        private void txtCompanyID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinLicenceAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
