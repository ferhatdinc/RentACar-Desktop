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
    }
}
