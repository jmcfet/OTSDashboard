using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

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
        List<ShirtInfo> shirtsNotDone, bottomsNotDone, topsNotDone,houseHolds;
        List<missingPieceInfo> missingorders;
        List<CustomerInfo> cprInfo;
        List<GarmentIds> gids;
        OTSAccess dal = new OTSAccess();
        private void Dbresults_Loaded(object sender, RoutedEventArgs e)
        {

            
            ShowResults();
            Timer timer = new Timer(Timer_Tick,null,0,1000);
           

        }


        private void Timer_Tick(object sender)
        {
            Application.Current.Dispatcher.Invoke(
                DispatcherPriority.SystemIdle,
                new Action(()=>
                {
                    ShowResults();
                    last.Content = string.Format("update {0}", DateTime.Now.ToShortTimeString());
                }));
        }

        void ShowResults()
        {
            shirtsNotDone = dal.getItemCount("Shirts");
            shirts.Content = string.Format("Shirts {0}", shirtsNotDone.Count);
            topsNotDone = dal.getItemCount("tops");
            tops.Content = string.Format("tops {0}", topsNotDone.Count);
            bottomsNotDone = dal.getItemCount("bottoms");
            bottoms.Content = string.Format("bottoms {0}", bottomsNotDone.Count);
            houseHolds = dal.getItemCount("Household");
            households.Content = string.Format("Household {0}", houseHolds.Count);
            missingorders = dal.FindMissingOrders("test");
            missing.Content = string.Format("missing {0}", missingorders.Count);
            cprInfo = dal.getCPRCounts();
            cpr.Content = string.Format("CPR {0}", cprInfo.Count);

        }
        private void shirts_Click(object sender, RoutedEventArgs e)
        {
           
            details.ItemsSource = shirtsNotDone;
        }
        private void bottoms_Click(object sender, RoutedEventArgs e)
        {
            details.ItemsSource = bottomsNotDone;
        }
        private void tops_Click(object sender, RoutedEventArgs e)
        {
            details.ItemsSource = topsNotDone;
        }
        private void house_Click(object sender, RoutedEventArgs e)
        {
            details.ItemsSource = houseHolds;
        }

        private void missing_Click(object sender, RoutedEventArgs e)
        {
            details.ItemsSource = missingorders;
        }

        private void cpr_Click(object sender, RoutedEventArgs e)
        {
            details.ItemsSource = cprInfo;
        }

        //private void Garments_Click(object sender, RoutedEventArgs e)
        //{
        //    details.ItemsSource = gids;
        //}
    }
}
