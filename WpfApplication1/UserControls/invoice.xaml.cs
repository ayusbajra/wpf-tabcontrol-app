using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for invoice.xaml
    /// </summary>
    public partial class invoice : UserControl
    {
        invoice_model invoiceModel = new invoice_model();
        invoice_repo invoiceRepo = new invoice_repo();

        public invoice()
        {
            InitializeComponent();

            this.DataContext = invoiceModel;
        }

        public invoice(int id)
        {
            InitializeComponent();

            invoiceModel = invoiceRepo.GetSingleInvoice(id);

            this.DataContext = invoiceModel;
        }

        private void Tax_Click(object sender, RoutedEventArgs e)
        {
            tax_scheme taxScheme = new tax_scheme();
            taxScheme.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            taxScheme.ShowDialog();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            view_invoice viewInvoice = new view_invoice(invoiceModel);
            viewInvoice.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            viewInvoice.ShowDialog();

            Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void Close()
        {
            MainWindow parentWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

            foreach (ActionTabItem tab in parentWindow.vmd.Tabs)
            {
                if (tab.Header == "Invoice")
                {
                    parentWindow.vmd.Tabs.Remove(tab);
                    break;
                }
            }

            if (parentWindow.vmd.Tabs.Count() == 0)
            {
                parentWindow.actionTabs.Visibility = Visibility.Collapsed;
            }
        }
    }
}
