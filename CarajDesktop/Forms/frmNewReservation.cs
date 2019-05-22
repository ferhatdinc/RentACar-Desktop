using CarajDesktop.CarService;
using CarajDesktop.CompanyService;
using CarajDesktop.CustomerService;
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
                double NetAge=0;
                int minAge=1;
                using (var CarService = new CarServiceSoapClient())
                {
                    using (var CustomerService = new CustomerServiceSoapClient())
                    {
                        foreach (var item in CustomerService.GetAllCustomer())
                        {
                            if (int.Parse(txtCustomerId.Text)==item.CustomerId)
                            {
                                TimeSpan CustomerAge = System.DateTime.Now - item.CustomerBirthdate;
                                NetAge = Math.Ceiling(CustomerAge.TotalDays/365);
                                minAge= CarService.GetCar(int.Parse(txtCarId.Text)).MinCustomerAge;
                            }
                        }
                    }
                }
                if (minAge <= NetAge)
                {
                    companyService.CreateRent(NewRent);
                }
                else MessageBox.Show("Yaşınız Bu Aracı Kiralamaya Uygun Değil");
                
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
            //dgw den alınan bilgiler txt lere dolduruluyor
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
