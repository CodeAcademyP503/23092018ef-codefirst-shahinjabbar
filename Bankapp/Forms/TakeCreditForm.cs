using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Bankapp.Models;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace Bankapp.Forms
{
    public partial class TakeCreditForm : Form
    {
        public TakeCreditForm()
        {
            InitializeComponent();
        }

        private void TakeCreditForm_Load(object sender, EventArgs e)
        {
            using (BankAppDbContext bc = new BankAppDbContext())
            {
                List<Customer> customers = bc.Customers.Where(x => x.Id > 0).ToList();
                comboBox1.Items.Add(bc.Customers.ToList().Last().Name);
            }
        }

        private void btb_addcredit_Click(object sender, EventArgs e)
        {
            using (BankAppDbContext bn = new BankAppDbContext())
            {
                try
                {
                    if (txbx_amount.Text != null)
                    {
                      
                        Credit credit = new Credit()
                        {
                            Amount = Convert.ToDecimal(txbx_amount.Text),
                            GivenDate = dateTimePicker1.Value,
                            CustomerId =bn.Customers.ToList().Last().Id
                        };
                        bn.Credits.Add(credit);
                        bn.SaveChanges();
                        ShowAllForm showAllForm = new ShowAllForm();
                        showAllForm.ShowDialog();
                    }
                }
                catch (DbEntityValidationException exp)
                {
                    foreach (var item in exp.EntityValidationErrors)
                    {
                        foreach (var i in item.ValidationErrors)
                        {
                            label2.Text += i.ErrorMessage + "\n";
                        }
                    }
                }
            }
        }
    }
}
