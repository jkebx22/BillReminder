using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillReminder2
{
    class Bill
    {
        public string BillName { get; set; }
        public string Amount { get; set; }
        DateTime BillDue { get; set; }

        public Bill(string BillName, string Amount, DateTime BillDue)
        {
            this.BillName = BillName;
            this.Amount = Amount;
            this.BillDue = BillDue;
        }

        public override string ToString()
        {
            string Output = String.Format("{0}, {1}, {2}", BillName, Amount, BillDue);
            return Output;
        }

    }
}
