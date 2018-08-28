using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class journal_model
    {
        public journal_model()
        {
            JournalDate = DateTime.Today;
        }

        public string JournalNo { get; set; }

        public string AccountName { get; set; }

        public string AccountAddress { get; set; }

        public DateTime JournalDate { get; set; }

        public decimal Amount { get; set; }
    }
}
