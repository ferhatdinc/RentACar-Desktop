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
    }
}
