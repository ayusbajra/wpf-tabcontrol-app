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
using WpfApplication1.UserControls;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ActionTabViewModal vmd;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize viewModel
            vmd = new ActionTabViewModal();

            // Populate the view model tabs
            vmd.Populate();

            this.DataContext = vmd;
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            ActionTabItem item = (ActionTabItem)(sender as Button).DataContext;
            // This event will be thrown when on a close image clicked
            vmd.Tabs.Remove(item);

            if(vmd.Tabs.Count() == 0)
            {
                actionTabs.Visibility = Visibility.Collapsed;
            }

            this.DataContext = vmd;
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            tabControlVisibility();

            // Add A tab to TabControl With a specific header and Content(UserControl)
            vmd.Tabs.Add(new ActionTabItem { Header = "Acount", Content = new account() });
            // Set newly created tab as active tab
            actionTabs.SelectedIndex = vmd.Tabs.Count() - 1;

            this.DataContext = vmd;
        }

        private void AccountCategory_Click(object sender, RoutedEventArgs e)
        {
            tabControlVisibility();

            // Add A tab to TabControl With a specific header and Content(UserControl)
            vmd.Tabs.Add(new ActionTabItem { Header = "Account Category", Content = new account_category() });
            // Set newly created tab as active tab
            actionTabs.SelectedIndex = vmd.Tabs.Count() - 1;

            this.DataContext = vmd;
        }

        private void Entry_Click(object sender, RoutedEventArgs e)
        {
            tabControlVisibility();

            object header = (sender as MenuItem).Header;

            // Check if tab is already opened
            // If not opened, open new tab and set it to active
            // Else if already opened, set it to active
            if (!tabExists(header))
            {
                switch (header.ToString())
                {
                    case "Purchase":
                        {
                            // Add A tab to TabControl With a specific header and Content(UserControl)
                            vmd.Tabs.Add(new ActionTabItem { Header = header.ToString(), Content = new purchase() });
                        }
                        break;
                    case "Invoice":
                        {
                            // Add A tab to TabControl With a specific header and Content(UserControl)
                            vmd.Tabs.Add(new ActionTabItem { Header = header.ToString(), Content = new invoice() });
                        }
                        break;
                    case "Journal":
                        {
                            // Add A tab to TabControl With a specific header and Content(UserControl)
                            vmd.Tabs.Add(new ActionTabItem { Header = header.ToString(), Content = new journal() });
                        }
                        break;
                    default:
                        break;
                }

                // Set newly created tab as active tab
                actionTabs.SelectedIndex = vmd.Tabs.Count() - 1;
            }
            else
            {
                reopenTab(header);
            }

            this.DataContext = vmd;
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            tabControlVisibility();

            object header = (sender as MenuItem).Header;

            // Check if tab is already opened
            // If not opened, open new tab and set it to active
            // Else if already opened, set it to active
            if (!tabExists(header))
            {
                switch (header.ToString())
                {
                    case "Purchase Register":
                        {
                            // Add A tab to TabControl With a specific header and Content(UserControl)
                            vmd.Tabs.Add(new ActionTabItem { Header = header.ToString(), Content = new purchase_register() });
                        }
                        break;
                    case "Invoice Register":
                        {
                            // Add A tab to TabControl With a specific header and Content(UserControl)
                            vmd.Tabs.Add(new ActionTabItem { Header = header.ToString(), Content = new invoice_register() });
                        }
                        break;
                    case "Journal Register":
                        {
                            // Add A tab to TabControl With a specific header and Content(UserControl)
                            vmd.Tabs.Add(new ActionTabItem { Header = header.ToString(), Content = new journal_register() });
                        }
                        break;
                    default:
                        break;
                }

                // Set newly created tab as active tab
                actionTabs.SelectedIndex = vmd.Tabs.Count() - 1;
            }
            else
            {
                reopenTab(header);
            }

            this.DataContext = vmd;
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            tabControlVisibility();

            object header = (sender as MenuItem).Header;

            // Check if tab is already opened
            // If not opened, open new tab and set it to active
            // Else if already opened, set it to active
            if (!tabExists(header))
            {
                switch (header.ToString())
                {
                    case "Settings 1":
                        {
                            // Add A tab to TabControl With a specific header and Content(UserControl)
                            vmd.Tabs.Add(new ActionTabItem { Header = header.ToString(), Content = new settings1() });
                        }
                        break;
                    case "Settings 2":
                        {
                            // Add A tab to TabControl With a specific header and Content(UserControl)
                            vmd.Tabs.Add(new ActionTabItem { Header = header.ToString(), Content = new settings2() });
                        }
                        break;
                    case "Settings 3":
                        {
                            // Add A tab to TabControl With a specific header and Content(UserControl)
                            vmd.Tabs.Add(new ActionTabItem { Header = header.ToString(), Content = new settings3() });
                        }
                        break;
                    default:
                        break;
                }

                // Set newly created tab as active tab
                actionTabs.SelectedIndex = vmd.Tabs.Count() - 1;
            }
            else
            {
                reopenTab(header);
            }

            this.DataContext = vmd;
        }

        private void tabControlVisibility()
        {
            actionTabs.Visibility = Visibility.Visible;
        }

        public bool tabExists(object header)
        {
            foreach (ActionTabItem tab in vmd.Tabs)
            {
                if (tab.Header == header.ToString())
                {
                    return true;
                }
            }

            return false;
        }

        public void reopenTab(object header)
        {
            int index = 0;

            foreach (ActionTabItem tab in vmd.Tabs)
            {
                if (tab.Header == header.ToString())
                {
                    break;
                }
                else
                {
                    index++;
                }
            }

            actionTabs.SelectedIndex = index;
        }
    }
}
