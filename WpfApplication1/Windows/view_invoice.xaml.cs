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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for view_invoice.xaml
    /// </summary>
    public partial class view_invoice : Window
    {
        invoice_model invoiceModel = new invoice_model();
        invoice_repo invoiceRepo = new invoice_repo();

        public view_invoice(invoice_model model)
        {
            InitializeComponent();

            invoiceModel = model;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = invoiceModel;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            invoiceRepo.SaveInvoice(invoiceModel);
            this.Close();
        }
    }
}
