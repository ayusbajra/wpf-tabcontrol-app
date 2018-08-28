using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class invoice_repo
    {
        public void SaveInvoice(invoice_model invoiceModel)
        {

        }

        public invoice_model GetSingleInvoice(int id)
        {
            return new invoice_model()
            {
                InvoiceNo = "INV-001-2018",
                CustomerName = "Bibek",
                CustomerAddress = "Baneshwor, Kathmandu",
                Amount = 150000,
                InvoiceDate = DateTime.Today
            };
        }

        public List<invoice_model> GetAllInvoice()
        {
            return new List<invoice_model>()
            {
                new invoice_model() { InvoiceNo = "INV-002-2018", CustomerName = "Bhagwan", CustomerAddress = "Sano Bharang, Kathmandu", Amount = 456132, InvoiceDate = DateTime.Today },
                new invoice_model() { InvoiceNo = "INV-003-2018", CustomerName = "Ayush", CustomerAddress = "Kamal Pokhari, Kathmandu", Amount = 123665, InvoiceDate = DateTime.Today },
                new invoice_model() { InvoiceNo = "INV-004-2018", CustomerName = "Suman", CustomerAddress = "Kalanki, Kathmandu", Amount = 49856, InvoiceDate = DateTime.Today },
                new invoice_model() { InvoiceNo = "INV-005-2018", CustomerName = "Shanker", CustomerAddress = "Kalanki, Kathmandu", Amount = 145162, InvoiceDate = DateTime.Today },
                new invoice_model() { InvoiceNo = "INV-006-2018", CustomerName = "Sairash", CustomerAddress = "Kirtipur, Kathmandu", Amount = 45148, InvoiceDate = DateTime.Today },
            };
        }
    }
}
