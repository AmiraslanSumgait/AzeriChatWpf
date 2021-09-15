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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void dragMe(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {
            }
        }
        static public string GetResponseRandom()
        {
            List<string> randowRequests = new List<string>
            {
                "Adam kisi olar","Davay ged yat","Qesey oprem","Adam kimi danis","Ozune hormet elemiyenden day ne gozduyesen"
            };

            Random random = new Random();
            int index = random.Next(randowRequests.Count);
            return randowRequests[index];

        }

        BrushConverter bc = new BrushConverter();
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {

            TextBlock textBlock = new TextBlock()
            {
                Margin = new Thickness(230, 0, 0, 0),
                Text = txtBoxMessage.Text,
                TextAlignment = TextAlignment.Center,
                FontSize = 20,
                TextWrapping = TextWrapping.Wrap,
                Background = (Brush)bc.ConvertFrom("#FF9067F8"),
            };
            TextBlock textBlock1 = new TextBlock()
            {
                Margin = new Thickness(5),
                Text = GetResponseRandom(),
                TextAlignment = TextAlignment.Left,
                FontSize = 20,
                TextWrapping = TextWrapping.Wrap,
                Background = (Brush)bc.ConvertFrom("#FFFFFF"),
                Foreground = (Brush)bc.ConvertFrom("#000000")
            };

            chatList.Items.Add(textBlock);
            chatList.Items.Add(textBlock1);
            txtBoxMessage.Clear();

        }
    }
}
