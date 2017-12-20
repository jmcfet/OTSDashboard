
using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections;
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
        private Object thisLock = new Object();
        string lastDisplayed;

        private void Dbresults_Loaded(object sender, RoutedEventArgs e)
        {
            
            GetResults();
            ShowResults();
            timer = new System.Timers.Timer();
            timer.Elapsed += Timer_Tick;
            timer.Interval = 2000;
            timer.Start();

        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            lock (thisLock)
            {
                GetResults();
                Application.Current.Dispatcher.Invoke(
                    DispatcherPriority.SystemIdle,
                    new Action(() =>
                    {

                        ShowResults();
                        last.Content = string.Format("update {0}", DateTime.Now.ToShortTimeString());
                        if (lastDisplayed != null )
                            ShowDetails();
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
    
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            string content = but.Content.ToString();
            lastDisplayed = content.Split(' ')[0];
            timer.Stop();
            ShowDetails();
            timer.Start();
            //   details.ItemsSource = shirtsNotDone;

        }
        void ShowDetails()
        {
            
                switch (lastDisplayed)
                {
                    case "Shirts":
                        DisplayDetails(shirtsNotDone);
                        break;
                    case "tops":
                        DisplayDetails(topsNotDone);
                        break;
                    case "bottoms":
                        DisplayDetails(bottomsNotDone);
                        break;
                    case "Household":
                        DisplayDetails(houseHolds);
                        break;
                    case "missing":
                        DisplayDetails(missingorders);
                        break;
                    case "rackmissing":
                        DisplayDetails(missingOnrrack);
                        break;
                case "CPR":
                    DisplayDetails(cprInfo);
                    break;

            }
        }
   
        private void cpr_Click(object sender, RoutedEventArgs e)
        {
            details.ItemsSource = cprInfo;
        }
        private void Missingonrack_Click(object sender, RoutedEventArgs e)
        {
            details.ItemsSource = missingOnrrack;
           
        }
       
        void DisplayDetails<T>(List<T> list)
        {
          
            details.ItemsSource = list;
            
        }
        //private void Garments_Click(object sender, RoutedEventArgs e)
        //{
        //    details.ItemsSource = gids;
        //}
    }
}
