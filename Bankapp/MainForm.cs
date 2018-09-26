using Bankapp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankapp.Forms;
using System.Windows.Forms;

namespace Bankapp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_takecredit_Click(object sender, EventArgs e)
        {
            using (BankAppDbContext bc = new BankAppDbContext())
            {
                try
                {

                    Customer customer = new Customer()
                    {
                        Name = txbx_name.Text,
                        Surname = txbx_surname.Text,
                        PassportNumber = Convert.ToInt32(txbx_passportnumber.Text)
                    };

                    bc.Customers.Add(customer);
                    bc.SaveChanges();

                    TakeCreditForm takeCreditForm = new TakeCreditForm();
                    takeCreditForm.ShowDialog();
                }
                catch (DbEntityValidationException exp)
                {
                    foreach (var item in exp.EntityValidationErrors)
                    {
                        label4.Text = "";
                        foreach (var i in item.ValidationErrors)
                        {
                            label4.Text += i.ErrorMessage + "\n";
                        }
                    }
                }
            }
        }
    }
}
