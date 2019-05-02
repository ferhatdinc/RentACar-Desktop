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

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            CarRequestDto car = new CarRequestDto();
            car.CarBrand = txtBrand.Text;
            car.CarKM = int.Parse(txtCarKm.Text);
            car.AirBagCount = byte.Parse(txtAirbagCount.Text);
            car.CarModel = txtModel.Text;
            car.CarPhotoURL = txtPhotoUrl.Text;
            car.CarPriceForRent = decimal.Parse(txtRentPrice.Text);
            car.CarSeatCount = byte.Parse(txtSeatCount.Text);
            car.MinCustomerAge = byte.Parse(txtMinCustomerAge.Text);
            car.MinDrivingLicenseAge = byte.Parse(txtMinLicenceAge.Text);
            car.MaxKmPerDay = int.Parse(txtMaxKm.Text);
            car.CarTrunkVolume = short.Parse(txtTrunkVolume.Text);
            
            using (var CarService = new CarServiceSoapClient())
            {
                CarService.AddCar(car,frmMain.Company.CompanyID);
                CarService.Close();
            }
            
        }
    }
}
