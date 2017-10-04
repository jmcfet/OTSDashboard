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
    /// Interaction logic for cpr.xaml
    /// </summary>
    public partial class cpr : UserControl
    {
        public cpr()
        {
            InitializeComponent();
            Loaded += Dbresults_Loaded;
        }

        private void Dbresults_Loaded(object sender, RoutedEventArgs e)
        {
            OTSAccess dal = new OTSAccess();

            data.ItemsSource = dal.getCPRCounts();
        }
    }
}
