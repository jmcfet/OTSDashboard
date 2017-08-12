
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;  
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ToDay.Text = DateTime.Now.ToLongDateString();
            ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
            string StoreConnectionString = connections["Store1Entities"].ConnectionString;
        //    AssemblyConnectionString = connections["AssemblyEntities"].ConnectionString;

            OTSAccess dal = new OTSAccess(StoreConnectionString);     
            dal.GetEmployee(1);
            string error = string.Empty;
            System.Collections.ObjectModel.ObservableCollection<Category> cats =   dal.GetCats(out error);
        }

        private void bcs_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Repos\OnSpot17\OnTheSpot\bin\Debug\OnTheSpot.exe");
        }

        private void qcs_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
