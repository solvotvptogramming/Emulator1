using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Emulator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Gimnazia1Entities db;
        public MainWindow()
        {
            InitializeComponent();
             
            db = new Gimnazia1Entities();
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
         
            var DT = DateTime.Now;
            var Gui = System.Guid.NewGuid();
            db = new Gimnazia1Entities();
            var customers = db.Set<pLogData>();
            db.pLogData.Add(new pLogData {TimeVal = DT, NumCom = 376, IDComp = 1, Par1 = 3, Par2 = 0, Par3 = 125, Par4 = 1, Event = 32,
            IndexKey = 50363649,RazdIndex = 1, HozOrgan = 4, HozGuest = 1, Remark = "1: Вход   Турникет 1,   Считыватель 1, Прибор 125", DoorIndex = 1, Mode = 1, DeviceTime = DT,
            VEvent = 0, ZReserv = 33, ZoneIndex = 1, ReaderIndex = 1, Sign = 0, tpRzdIndex = 1, tpPar4 = null, IndexZone = 1, tpIndex = 8, GUID = Gui , IdComment = null

            });
            db.SaveChanges();
            MessageBox.Show("Готово");
        }   
    }
}
