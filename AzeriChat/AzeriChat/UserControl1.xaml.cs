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

namespace AzeriChat
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            string time = DateTime.Now.Minute.ToString();
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("HH:mm");
            //TimeText.Text = DateTime.Now.Hour.ToString();
            //TimeText.Text += ":";
            //TimeText.Text += DateTime.Now.Minute.ToString();
            TimeText.Text = formattedDate;
        }
    }
}
