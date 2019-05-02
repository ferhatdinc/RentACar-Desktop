using CarajDesktop.CarService;
using CarajDesktop.CompanyService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarajDesktop.Forms
{
    public partial class frmNewReservation : Form
    {
        public frmNewReservation()
        {
            InitializeComponent();
        }
        private int CompanyID = frmMain.Company.CompanyID;
        private void BtnDoReservations_Click(object sender, EventArgs e)
        {
            RentDetailsRequestDto NewRent = new RentDetailsRequestDto
            {
                Pricing = decimal.Parse(txtAmount.Text),
                CarID = int.Parse(txtCarId.Text),
                CustomerID = int.Parse(txtCustomerId.Text),
                RentStartDate = tpDateFirst.Value,
                RentEndDate = tpDateLast.Value,
                StartingKilometer = int.Parse(txtFirsrKM.Text)
            };
            using (var companyService = new CompanyServiceSoapClient())
            {
                companyService.CreateRent(NewRent);
                companyService.Close();
            }
        }

        private void FrmNewReservation_Load(object sender, EventArgs e)
        {
            using (var CarService = new CarServiceSoapClient())
            {
                var cars = CarService.GetCars(frmMain.Company.CompanyID);
                dgwCarList.DataSource = cars;
                CarService.Close();

            }
        }

        private void BtnSelectCar_Click(object sender, EventArgs e)
        {
            /*txtCarId.Text = dgwCars.SelectedRows[0].Cells[0].Value.ToString();
            txtAirbagCount.Text = dgwCars.SelectedRows[0].Cells[10].Value.ToString();
            txtBrand.Text = dgwCars.SelectedRows[0].Cells[4].Value.ToString();
            txtCarKm.Text = dgwCars.SelectedRows[0].Cells[9].Value.ToString();
            txtCarId.Text = "2"; //buraya loginden alınan id gelecek
            txtMaxKm.Text = dgwCars.SelectedRows[0].Cells[8].Value.ToString();
            txtMinCustomerAge.Text = dgwCars.SelectedRows[0].Cells[7].Value.ToString();
            txtMinLicenceAge.Text = dgwCars.SelectedRows[0].Cells[6].Value.ToString();
            txtModel.Text = dgwCars.SelectedRows[0].Cells[5].Value.ToString();
            txtPhotoUrl.Text = dgwCars.SelectedRows[0].Cells[14].Value.ToString();
            txtRentPrice.Text = dgwCars.SelectedRows[0].Cells[13].Value.ToString();
            txtSeatCount.Text = dgwCars.SelectedRows[0].Cells[12].Value.ToString();
            txtTrunkVolume.Text = dgwCars.SelectedRows[0].Cells[11].Value.ToString(); */

            txtCarId.Text = dgwCarList.SelectedRows[0].Cells[0].Value.ToString();
            txtFirsrKM.Text = dgwCarList.SelectedRows[0].Cells[9].Value.ToString();
            TimeSpan kalangun = tpDateLast.Value - tpDateFirst.Value;
            double toplamGun = Math.Ceiling(kalangun.TotalDays);
            txtAmount.Text = (toplamGun * double.Parse(dgwCarList.SelectedRows[0].Cells[13].Value.ToString())).ToString();


        }

        private void TpDateLast_ValueChanged(object sender, EventArgs e)
        {
            using (var CarService = new CarServiceSoapClient())
            {
                var cars = CarService.GetAvailableCarByCompanyID(tpDateFirst.Value, tpDateLast.Value, CompanyID);
                dgwCarList.DataSource = cars;  
                CarService.Close();
                
            }
            
        }

        private void BtnReservationRequest_Click(object sender, EventArgs e)
        {
            using (var CompanyService = new CompanyServiceSoapClient())
            {
                var cars = CompanyService.GetRentalRequests(CompanyID);
                dgwCarList.DataSource = cars;
                CompanyService.Close();

            }
        }
    }
}
