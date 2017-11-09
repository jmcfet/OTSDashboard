using DataAccessLayer;
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

namespace DashBoard
{
    /// <summary>
    /// Interaction logic for DbQuerys.xaml
    /// </summary>
    public partial class DbQuerys : UserControl
    {
        public DbQuerys()
        {
            InitializeComponent();
            Loaded += Dbresults_Loaded;
        }
        List<ShirtInfo> shirtsNotDone;
        List<missingPieceInfo> missingorders;
        private void Dbresults_Loaded(object sender, RoutedEventArgs e)
        {
            OTSAccess dal = new OTSAccess();
           
             shirtsNotDone = dal.getShirtCount();
            shirts.Content = string.Format("Shirts {0}", shirtsNotDone.Count);
            missingorders = dal.FindMissingOrders("test");
            missing.Content = string.Format("missing {0}", missingorders.Count);
            //  data.ItemsSource = dal.FindMissingOrders("test");
        }

        private void shirts_Click(object sender, RoutedEventArgs e)
        {
            details.ItemsSource = shirtsNotDone;
        }

        private void missing_Click(object sender, RoutedEventArgs e)
        {
            details.ItemsSource = missingorders;
        }
    }
}
