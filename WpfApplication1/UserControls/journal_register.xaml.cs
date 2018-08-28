using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for journal_register.xaml
    /// </summary>
    public partial class journal_register : UserControl
    {
        journal_viewmodel journalVM = new journal_viewmodel();
        journal_repo journalRepo = new journal_repo();

        public journal_register()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            journalVM.JournalModelList = journalRepo.GetAllJournal();

            this.DataContext = journalVM;
        }
    }
}
