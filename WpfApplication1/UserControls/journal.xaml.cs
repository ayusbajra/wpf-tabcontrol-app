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
    /// Interaction logic for journal.xaml
    /// </summary>
    public partial class journal : UserControl
    {
        journal_model journalModel = new journal_model();

        public journal()
        {
            InitializeComponent();

            this.DataContext = journalModel;
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
                if (tab.Header == "Journal")
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
