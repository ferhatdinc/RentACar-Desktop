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

        private void frmUpdateCar_Load(object sender, EventArgs e)
        {
            using(var CarService = new CarServiceSoapClient())
            {
                var cars = CarService.GetCars(2);//login olan şirketin id si
                dgwCars.DataSource = cars;
                CarService.Close();
            }

        }

        private void btnAracSec_Click(object sender, EventArgs e)
        {
            txtCarId.Text = dgwCars.SelectedRows[0].Cells[0].Value.ToString();
            txtAirbagCount.Text = dgwCars.SelectedRows[0].Cells[10].Value.ToString();
            txtBrand.Text = dgwCars.SelectedRows[0].Cells[4].Value.ToString();
            txtCarKm.Text= dgwCars.SelectedRows[0].Cells[9].Value.ToString();
            txtCarId.Text = "2"; //buraya loginden alınan id gelecek
            txtMaxKm.Text= dgwCars.SelectedRows[0].Cells[8].Value.ToString();
            txtMinCustomerAge.Text= dgwCars.SelectedRows[0].Cells[7].Value.ToString();
            txtMinLicenceAge.Text= dgwCars.SelectedRows[0].Cells[6].Value.ToString();
            txtModel.Text= dgwCars.SelectedRows[0].Cells[5].Value.ToString();
            txtPhotoUrl.Text= dgwCars.SelectedRows[0].Cells[14].Value.ToString();
            txtRentPrice.Text= dgwCars.SelectedRows[0].Cells[13].Value.ToString();
            txtSeatCount.Text= dgwCars.SelectedRows[0].Cells[12].Value.ToString();
            txtTrunkVolume.Text= dgwCars.SelectedRows[0].Cells[11].Value.ToString();
            

        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            CarRequestDto UpdatedCar = new CarRequestDto();
            //car ID gelecek 
            UpdatedCar.CarBrand = txtBrand.Text;
            UpdatedCar.CarKM = int.Parse(txtCarKm.Text);
            UpdatedCar.AirBagCount = byte.Parse(txtAirbagCount.Text);
            UpdatedCar.CarModel = txtModel.Text;
            UpdatedCar.CarPhotoURL = txtPhotoUrl.Text;
            UpdatedCar.CarPriceForRent = decimal.Parse(txtRentPrice.Text);
            UpdatedCar.CarSeatCount = byte.Parse(txtSeatCount.Text);
            UpdatedCar.MinCustomerAge = byte.Parse(txtMinCustomerAge.Text);
            UpdatedCar.MinDrivingLicenseAge = byte.Parse(txtMinLicenceAge.Text);
            UpdatedCar.MaxKmPerDay = int.Parse(txtMaxKm.Text);
            UpdatedCar.CarTrunkVolume = short.Parse(txtTrunkVolume.Text);
            using (var CarService = new CarServiceSoapClient())
            {
                CarService.UpdateCar(UpdatedCar);
                CarService.Close();
            }
        }
    }
}
