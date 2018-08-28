using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication1
{
    /// view model for the TabControl To bind on
    public class ActionTabViewModal
    {
        // These Are the tabs that will be bound to the TabControl 
        public ObservableCollection<ActionTabItem> Tabs { get; set; }

        public ActionTabViewModal()
        {
            Tabs = new ObservableCollection<ActionTabItem>();
        }

        public void Populate()
        {
            // Add A tab to TabControl With a specific header and Content(UserControl)
            Tabs.Add(new ActionTabItem { Header = "Invoice Register", Content = new invoice_register() });
        }
    }
}
