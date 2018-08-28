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
    /// Interaction logic for purchase.xaml
    /// </summary>
    public partial class purchase : UserControl
    {
        purchase_model purchaseModel = new purchase_model();
        purchase_repo purchaseRepo = new purchase_repo();

        public purchase()
        {
            InitializeComponent();

            this.DataContext = purchaseModel;
        }

        public purchase(int id)
        {
            InitializeComponent();

            purchaseModel = purchaseRepo.GetSinglePurchase(id);

            this.DataContext = purchaseModel;
        }

        private void Tax_Click(object sender, RoutedEventArgs e)
        {
            tax_scheme taxScheme = new tax_scheme();
            taxScheme.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            taxScheme.ShowDialog();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
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
                if (tab.Header == "Purchase")
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
