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

namespace KarenHarte_S00182304
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Loading the phone details
            Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
            Phone p2 = new Phone("iPhone", 600, "IOS", "/images/apple.png", "/images/iphone11.png");

            //Adding the phone details
            List<Phone> phoneList = new List<Phone>();
            phoneList.Add(p1);
            phoneList.Add(p2);

            //Populating them to the list box
            PhoneDetailsLB.ItemsSource = phoneList;
        }

        private void PhoneDetailsLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Get the selected item
            Phone selectedPhone = PhoneDetailsLB.SelectedItem as Phone;

            //Display Price
            PriceTBx.Text = selectedPhone.Price.ToString("C");

            //PhoneImageBox.Source = selectedPhone.Phone_Image.To;
        }
    }
}
