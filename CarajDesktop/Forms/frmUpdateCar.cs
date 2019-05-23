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
    public partial class frmUpdateCar : Form
    {
        public frmUpdateCar()
        {
            InitializeComponent();
        }

        private void FrmUpdateCar_Load(object sender, EventArgs e)
        {
            using(var CarService = new CarServiceSoapClient())
            {
                var cars = CarService.GetCars(frmMain.Company.CompanyID);//login olan şirketin id si
                dgwCars.DataSource = cars;
                CarService.Close();
            }

        }

        private void BtnAracSec_Click(object sender, EventArgs e)
        {
            txtCarId.Text = dgwCars.SelectedRows[0].Cells[0].Value.ToString();
            txtAirbagCount.Text = dgwCars.SelectedRows[0].Cells[10].Value.ToString();
            txtBrand.Text = dgwCars.SelectedRows[0].Cells[4].Value.ToString();
            txtCarKm.Text= dgwCars.SelectedRows[0].Cells[9].Value.ToString(); 
            txtMaxKm.Text= dgwCars.SelectedRows[0].Cells[8].Value.ToString();
            txtMinCustomerAge.Text= dgwCars.SelectedRows[0].Cells[7].Value.ToString();
            txtMinLicenceAge.Text= dgwCars.SelectedRows[0].Cells[6].Value.ToString();
            txtModel.Text= dgwCars.SelectedRows[0].Cells[5].Value.ToString();
            txtPhotoUrl.Text= dgwCars.SelectedRows[0].Cells[14].Value.ToString();
            txtRentPrice.Text= dgwCars.SelectedRows[0].Cells[13].Value.ToString();
            txtSeatCount.Text= dgwCars.SelectedRows[0].Cells[12].Value.ToString();
            txtTrunkVolume.Text= dgwCars.SelectedRows[0].Cells[11].Value.ToString();
            

        }

        private void BtnUpdateCar_Click(object sender, EventArgs e)
        { 
            using (var CarService = new CarServiceSoapClient())
            {
                CarRequestDto UpdatedCar = new CarRequestDto
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
                CarService.UpdateCar(UpdatedCar,int.Parse(txtCarId.Text));
                CarService.Close();
            }
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

        private void dgwCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
