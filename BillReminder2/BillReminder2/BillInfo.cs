using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BillReminder2
{
    public partial class BillReminder : Form
    {

        public BillReminder()
        {
            InitializeComponent();

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string BillName = BillNameBox.Text;
            string Amount = AmountBox.Text;
            DateTime BillDue = DateSelector.Value;

            if (String.IsNullOrWhiteSpace(BillName) ||
                String.IsNullOrWhiteSpace(Amount))
            {
                MessageBox.Show("All fields must be filled.");

                return;
            }

            Bill NewBill = new Bill(BillName, Amount, BillDue);

            MessageBox.Show(NewBill.ToString());

        }
    }
}
