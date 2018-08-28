using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class journal_repo
    {
        public void SaveJournal()
        {

        }

        public journal_model GetSingleJournal(int id)
        {
            return new journal_model()
            {
                JournalNo = "JOU-001-2018",
                JournalDate = DateTime.Today,
                AccountName = "Deepak",
                AccountAddress = "Bhaiharawa, Lumbini",
                Amount = 846175
            };
        }

        public List<journal_model> GetAllJournal()
        {
            return new List<journal_model>()
            {
                new journal_model() { JournalNo = "JOU-002-2018", JournalDate = DateTime.Today, AccountName = "Coca Cola Pvt. Ltd.", AccountAddress = "Balaju, Kathmandu", Amount = 956132 },
                new journal_model() { JournalNo = "JOU-003-2018", JournalDate = DateTime.Today, AccountName = "Pepsi Pvt. Ltd.", AccountAddress = "Nayabazar, Kathmandu", Amount = 542589 },
                new journal_model() { JournalNo = "JOU-004-2018", JournalDate = DateTime.Today, AccountName = "Yamaha Pvt. Ltd.", AccountAddress = "Tripureshwor, Kathmandu", Amount = 941556 },
                new journal_model() { JournalNo = "JOU-005-2018", JournalDate = DateTime.Today, AccountName = "Suzuki Pvt. Ltd.", AccountAddress = "Kamal Pokhari, Kathmandu", Amount = 481256 },
                new journal_model() { JournalNo = "JOU-006-2018", JournalDate = DateTime.Today, AccountName = "Honda Pvt. Ltd.", AccountAddress = "Jamal, Kathmandu", Amount = 542165 },
                new journal_model() { JournalNo = "JOU-007-2018", JournalDate = DateTime.Today, AccountName = "OnePlus Pvt. Ltd.", AccountAddress = "New Road, Kathmandu", Amount = 784556 },
                new journal_model() { JournalNo = "JOU-008-2018", JournalDate = DateTime.Today, AccountName = "Nokia Pvt. Ltd.", AccountAddress = "Pulchowk, Lalitpur", Amount = 451256 }
            };
        }
    }
}
