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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    class FLAT
    {
        public int Count;
        public int S;
        public int Stage;
        public string Adr;
        public int Price;
        public void vod(int count, int s, int stage, string adr, int price)
        {
            Count = count;
            S = s;
            Stage = stage;
            Adr = adr;
            Price = price;
        }
        public void Display()
        {
            MessageBox.Show($"Квартира расположена на улице {Adr}, на {Stage} этаже имеет {Count} комнат(ы), с общей площадью {S} кв м. Её цена на данный момент {Price} рублей", "Ответ");
        }
    }

    public partial class MainWindow : Window
    {
        FLAT fl = new FLAT();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            int Count = int.Parse(AA.Text);
            int S = int.Parse(BB.Text);
            int Stage = int.Parse(CC.Text);
            string Adr = DD.Text;
            int Price = int.Parse(EE.Text);

            fl.vod(Count, S, Stage, Adr, Price);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            fl.Display();
        }
    }
}
