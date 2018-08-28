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
    /// Interaction logic for invoice_register.xaml
    /// </summary>
    public partial class invoice_register : UserControl
    {
        invoice_viewmodel invoiceVM = new invoice_viewmodel();
        invoice_repo invoiceRepo = new invoice_repo();

        public invoice_register()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            invoiceVM.InvoiceModelList = invoiceRepo.GetAllInvoice();

            this.DataContext = invoiceVM;
        }

        private void Adjust_Click(object sender, RoutedEventArgs e)
        {
            MainWindow parentWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

            // Add A tab to TabControl With a specific header and Content(UserControl)
            parentWindow.vmd.Tabs.Add(new ActionTabItem { Header = "Invoice", Content = new invoice(1) });
            // Set newly created tab as active tab
            parentWindow.actionTabs.SelectedIndex = parentWindow.vmd.Tabs.Count() - 1;
        }
    }
}
