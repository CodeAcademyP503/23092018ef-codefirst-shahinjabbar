using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Bankapp.Models;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankapp.Forms
{
    public partial class ShowAllForm : Form
    {
        public ShowAllForm()
        {
            InitializeComponent();
        }

        private void ShowAllForm_Load(object sender, EventArgs e)
        {
            using (BankAppDbContext bn = new BankAppDbContext())
            {
                var names = bn.Customers.ToList();

                var view = from cr in bn.Credits
                           join cu in bn.Customers on cr.CustomerId equals cu.Id
                           group cr by cu.Name into g
                           select new
                           {
                               CustomerName = g.Key,
                               TotalAmount = g.Sum(x => x.Amount)
                           };
                
                dataGridView1.DataSource = view.ToList();
            }

        }
    }
}
