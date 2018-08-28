using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class purchase_model
    {
        public purchase_model()
        {
            PurchaseDate = DateTime.Today;
        }

        public string PurchaseNo { get; set; }

        public string SupplierName { get; set; }

        public string SupplierAddress { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal Amount { get; set; }
    }
}
