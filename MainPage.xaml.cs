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

namespace ModExam
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        List<Книжный> Book = BaseClass.Base.Книжный.ToList();
        int kolvo = 0;
        int sum = 0;
        double dis;
        int flag = 0;
        public MainPage()
        {
            InitializeComponent();
            LVBook.ItemsSource = Book;
        }

        private void LVBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {          
            kolvo = LVBook.SelectedItems.Count;
            BTNKorzina.Visibility = Visibility.Visible;            
            int index = LVBook.SelectedIndex + 1;
            List<Книжный> B = BaseClass.Base.Книжный.Where(x => x.ID == index).ToList();
            foreach (Книжный item in B)
            {
                for (int i = 0; i < B.Count; i++)
                {                   
                    sum = sum + Convert.ToInt32(item.Цена);
                }
            }

        }

        private void BTNKorzina_Click(object sender, RoutedEventArgs e)
        {
            BTNToKorzina.Visibility = Visibility.Visible;
            TBKolvo.Text = "";
            TBDiscount.Text = "";
            TBCost.Text = "";
                      
            TBKolvo.Text = "Кол-во выбранных книг: " + Convert.ToString(kolvo);
            int result =  WSDiscount.Libr.SumDis(sum,dis);
            if (kolvo < 3)
            {
                TBDiscount.Text = "Скидка: 0%";
            }
            if (kolvo > 2 && kolvo<6)
            {
                TBDiscount.Text = "Скидка: 5%";
                dis = 0.05;
            }
            if (kolvo > 5 && kolvo < 11)
            {
                TBDiscount.Text = "Скидка: 10%";
                dis = 0.1;
            }
            if (kolvo > 10)
            {
                TBDiscount.Text = "Скидка: 15%";
                dis = 0.15;
            }
            if (dis == 0)
            {
                TBCost.Text = "Стоимость покупки: " + sum + " руб.";
            }
            TBCost.Text = "Стоимость покупки: " + result + " руб.";
        }

       
    }
}
