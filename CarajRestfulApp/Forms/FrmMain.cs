using CarajRestfulApp.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarajRestfulApp.Forms
{
    public partial class FrmMain : Form
    {
        private Dictionary<Type, Form> ActiveForms;
        public static Boolean isLogin = false;
        public static JObject company;//key value
        public FrmMain()
        {

            InitializeComponent();
            this.ActiveForms = new Dictionary<Type, Form>();
        }
        private void ShowForm<TSource>() where TSource : Form
        {
            Form form = null;
            if (this.ActiveForms.ContainsKey(typeof(TSource)))
            {
                form = this.ActiveForms[typeof(TSource)];
                form.WindowState = FormWindowState.Normal;
                form.Activate();
            }
            else
            {
                form = Activator.CreateInstance<TSource>();
                form.MdiParent = this;
                form.FormClosed += Form_FormClosed;
                form.Show();

                this.ActiveForms.Add(typeof(TSource), form);
            }
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ActiveForms.Remove(sender.GetType());
        }
        private void ReservationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<FrmReservationDetails>();

        }
        string link = "http://165.22.91.48/api/";
        private async void BtnLogin_ClickAsync(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                    link + "auth/CompanyLogin?companyname=" + txtCompanyName.Text + "&password=" + txtPassword.Text,
                     new StringContent(txtCompanyName.Text, Encoding.UTF8, "application/json"));

                if (response.StatusCode.GetHashCode()==200)
                {
                    var model = response.Content.ReadAsAsync<JObject>().Result;
                    // company.CompanyID = model.Company;
                    company = model;
                    MessageBox.Show("Hoşgeldin "+company["companyID"]);//company name olarak değişecek
                    this.gbLogin.Visible = false;
                }
            }
            
        }
    }
}
