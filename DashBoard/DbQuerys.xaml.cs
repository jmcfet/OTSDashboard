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
        System.Timers.Timer timer;
        public DbQuerys()
        {
            InitializeComponent();
            Loaded += Dbresults_Loaded;
        }
        List<ShirtInfo> shirtsNotDone, bottomsNotDone, topsNotDone,houseHolds;
        List<missingPieceInfo> missingorders;
        List<CustomerInfo> cprInfo;
        List<GarmentIds> gids;
        List<OrdersLostOnRacktoMissingRackLocationData> missingOnrrack;
        OTSAccess dal = new OTSAccess();
        private void Dbresults_Loaded(object sender, RoutedEventArgs e)
        {

            GetResults();
            ShowResults();
            timer = new System.Timers.Timer();
            timer.Elapsed += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();

        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            bool bFree = true;
            if (bFree)
            {
                bFree = false;
                GetResults();
                Application.Current.Dispatcher.Invoke(
                    DispatcherPriority.SystemIdle,
                    new Action(() =>
                    {

                        ShowResults();
                        last.Content = string.Format("update {0}", DateTime.Now.ToShortTimeString());
                        bFree = true;
                    }));
               
            }
        }
        void GetResults()
        {
            shirtsNotDone = dal.getItemCount("Shirts");
           
            topsNotDone = dal.getItemCount("tops");
            
            bottomsNotDone = dal.getItemCount("bottoms");
           
            houseHolds = dal.getItemCount("Household");
           
            missingorders = dal.FindMissingOrders("test");
            
            cprInfo = dal.getCPRCounts();
            missingOnrrack = dal.OrdersLostOnRacktoMissingRackLocation();

        }
        void ShowResults()
        {
            
            shirts.Content = string.Format("Shirts {0}", shirtsNotDone.Count);
            
            tops.Content = string.Format("tops {0}", topsNotDone.Count);
            
            bottoms.Content = string.Format("bottoms {0}", bottomsNotDone.Count);
            
            households.Content = string.Format("Household {0}", houseHolds.Count);
            
            missing.Content = string.Format("missing {0}", missingorders.Count);
           
            cpr.Content = string.Format("CPR {0}", cprInfo.Count);
            Missingonrack.Content = string.Format("rackmissing {0}", missingOnrrack.Count);

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
        private void Missingonrack_Click(object sender, RoutedEventArgs e)
        {
            details.ItemsSource = missingOnrrack;
        }

        //private void Garments_Click(object sender, RoutedEventArgs e)
        //{
        //    details.ItemsSource = gids;
        //}
    }
}
