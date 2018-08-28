using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class purchase_repo
    {
        public void SavePurchase()
        {

        }

        public purchase_model GetSinglePurchase(int id)
        {
            return new purchase_model()
            {
                PurchaseNo = "PUR-001-2018",
                PurchaseDate = DateTime.Today,
                SupplierName = "View Sonic Pvt. Ltd.",
                SupplierAddress = "New Road, Kathmandu",
                Amount = 450000
            };
        }

        public List<purchase_model> GetAllPurchase()
        {
            return new List<purchase_model>()
            {
                new purchase_model() { PurchaseNo = "PUR-002-2018", PurchaseDate = DateTime.Today, SupplierName = "Microsmart Pvt. Ltd.", SupplierAddress = "Kalimati, Kathmandu", Amount = 65210 },
                new purchase_model() { PurchaseNo = "PUR-003-2018", PurchaseDate = DateTime.Today, SupplierName = "ASUS Pvt. Ltd.", SupplierAddress = "Sanepa, Lalitpur", Amount = 594856 },
                new purchase_model() { PurchaseNo = "PUR-004-2018", PurchaseDate = DateTime.Today, SupplierName = "MSI Pvt. Ltd.", SupplierAddress = "Pulchowk, Lalitpur", Amount = 265989 },
                new purchase_model() { PurchaseNo = "PUR-005-2018", PurchaseDate = DateTime.Today, SupplierName = "NVidia Pvt. Ltd.", SupplierAddress = "Naxal, Kathmandu", Amount = 785645 },
                new purchase_model() { PurchaseNo = "PUR-006-2018", PurchaseDate = DateTime.Today, SupplierName = "Dell Pvt. Ltd.", SupplierAddress = "Kumaripati, Lalitpur", Amount = 235645 },
                new purchase_model() { PurchaseNo = "PUR-007-2018", PurchaseDate = DateTime.Today, SupplierName = "Samsung Pvt. Ltd.", SupplierAddress = "Thapathali, Kathmandu", Amount = 485926 },
                new purchase_model() { PurchaseNo = "PUR-008-2018", PurchaseDate = DateTime.Today, SupplierName = "Apple Pvt. Ltd.", SupplierAddress = "Lazimpat, Kathmandu", Amount = 154859 }
            };
        }
    }
}
