using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeCoffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized;

        }

        private void AddControler(Control control)
        {
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(control);
            control.BringToFront();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            AddControler(dashboard);
        }

        private void btn_chashier_Click(object sender, EventArgs e)
        {
            AddChashier addChashier = new AddChashier();
            AddControler(addChashier);
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            AddControler(products);
        }

        private void btn_Custmer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            AddControler(customer);
        }

        private void close_click(object sender,EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to  exit? "," Confirmation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to  Sing out? ", " Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
