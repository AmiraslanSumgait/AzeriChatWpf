using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            string time = DateTime.Now.Minute.ToString();
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("HH:mm");
            lblTime.Content = formattedDate;
            
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
                "Deyirler yalan danismaq olmaz dogrunuda deyende xetirlerine dəyir!","Sevmək bu qədər gözəlsə, kim bilir sevməyi yaradan nə qədər gözəldir","İnsanlar əylənə bildikləri ilə yoldaş,paylaşa bildikləri ilə dost,ağlaya bildikləri ilə qardaş olurlar","Biz qardaş dediyimiz insanlar üçün ölməyədə gedərik gömməyədə."
                ,
             };

            Random random = new Random();
            int index = random.Next(randowRequests.Count);
            return randowRequests[index];

        }

        BrushConverter bc = new BrushConverter();
        public int Count { get; set; } = 0;

        private void message()
        {
            UserControl1 userControl1 = new UserControl1();
            userControl1.Border.Background = (Brush)bc.ConvertFrom("#E3E7D3");
            chatList.HorizontalAlignment = HorizontalAlignment.Left;
            userControl1.DataText.Text = GetResponseRandom();
            userControl1.DataText.FontSize = 15;
            userControl1.Border.Margin = new Thickness(10,40,0,0);
            chatList.Items.Add(userControl1);

        }
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
          
            UserControl1 userControl = new UserControl1();
            userControl.DataText.Text = txtBoxMessage.Text;
            userControl.DataText.FontSize = 15;
            chatList.HorizontalAlignment = HorizontalAlignment.Right;
            userControl.Border.Margin = new Thickness(250,20,0,0);
            chatList.Items.Add(userControl);
            txtBoxMessage.Clear();
            message();





        }
    }
}
