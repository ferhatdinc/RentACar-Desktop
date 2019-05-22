using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarajRestfulApp.Forms
{
    public partial class FrmMain : Form
    {
        private Dictionary<Type, Form> ActiveForms;
        public static Boolean isLogin = false;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.gbLogin.Visible = false;
        }
    }
}
