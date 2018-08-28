using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class invoice_model
    {
        public invoice_model()
        {
            InvoiceDate = DateTime.Today;
        }

        public string InvoiceNo { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal Amount { get; set; }
    }
}
