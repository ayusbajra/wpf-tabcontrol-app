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
    /// Interaction logic for purchase_register.xaml
    /// </summary>
    public partial class purchase_register : UserControl
    {
        purchase_viewmodel purchaseVM = new purchase_viewmodel();
        purchase_repo purchaseRepo = new purchase_repo();

        public purchase_register()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            purchaseVM.PurchaseModelList = purchaseRepo.GetAllPurchase();

            this.DataContext = purchaseVM;
        }

        private void Adjust_Click(object sender, RoutedEventArgs e)
        {
            MainWindow parentWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

            // Add A tab to TabControl With a specific header and Content(UserControl)
            parentWindow.vmd.Tabs.Add(new ActionTabItem { Header = "Purchase", Content = new purchase(1) });
            // Set newly created tab as active tab
            parentWindow.actionTabs.SelectedIndex = parentWindow.vmd.Tabs.Count() - 1;
        }
    }
}
