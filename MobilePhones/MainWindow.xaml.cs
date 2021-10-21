using Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MobilePhones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        BindingList<MobilePhone> lsMPhone = new BindingList<MobilePhone>();
        private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            lsMPhone.Add(new MobilePhone
            {
                PhoneName = "Samsung Galaxy S21 Ultra",
                Image = "Images/Phone01.png",
                Manufacturer = "SamSung",
                Price = 27350000
            });

            lsMPhone.Add(new MobilePhone
            {
                PhoneName = "Samsung Galaxy S21 5G",
                Image = "Images/Phone02.png",
                Manufacturer = "SamSung",
                Price = 17990000
            });
            
            lsMPhone.Add(new MobilePhone
            {
                PhoneName = "Samsung Galaxy Z Ford3",
                Image = "Images/Phone03.png",
                Manufacturer = "SamSung",
                Price = 43990000
            });

            lsMPhone.Add(new MobilePhone
            {
                PhoneName = "iPhone 13 Pro",
                Image = "Images/Phone04.png",
                Manufacturer = "Apple",
                Price = 30990000
            });

            lsMPhone.Add(new MobilePhone
            {
                PhoneName = "iPhone 12",
                Image = "Images/Phone05.png",
                Manufacturer = "Apple",
                Price = 20490000
            });

            lsMPhone.Add(new MobilePhone
            {
                PhoneName = "iPhone XR",
                Image = "Images/Phone06.png",
                Manufacturer = "Apple",
                Price = 13490000
            });

            lsMPhone.Add(new MobilePhone
            {
                PhoneName = "Xiaomi Mi 11 5G",
                Image = "Images/Phone07.png",
                Manufacturer = "Xiaomi",
                Price = 16990000
            });

            lsMPhone.Add(new MobilePhone
            {
                PhoneName = "Xiaomi Mi 11 Lite",
                Image = "Images/Phone08.png",
                Manufacturer = "Xiaomi",
                Price = 7990000
            });

            lsMPhone.Add(new MobilePhone
            {
                PhoneName = "Oppo Reno6 Pro 5G",
                Image = "Images/Phone09.png",
                Manufacturer = "Oppo",
                Price = 18490000
            });

            lsMPhone.Add(new MobilePhone
            {
                PhoneName = "Oppo Find X3 Pro 5G",
                Image = "Images/Phone10.png",
                Manufacturer = "Oppo",
                Price = 23990000
            });

            lsvMobilePhone.ItemsSource = lsMPhone;
        }

        private void tbItemHome_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            double tabItemHeight = tbItemHome.ActualHeight;
            double groupbox = gbxAction.ActualHeight;

            if (tbItemHome.IsMinimized)
            {
                this.Height = 415 + (int)tabItemHeight + (int)groupbox;
            }
            else
            {
                this.Height = 415 + (int)tabItemHeight;
            }

            Debug.WriteLine(tabItemHeight);
            Debug.WriteLine(groupbox);
        }

        private void deleteMenu_Click(object sender, RoutedEventArgs e)
        {
            var index = lsvMobilePhone.SelectedIndex;
            int sizeList = lsMPhone.Count();

            if (index >= 0 && index <= sizeList)
            {
                lsMPhone.RemoveAt(index);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lsMPhone.Add(new MobilePhone
            {
                PhoneName = "Samsung Galaxy Z Ford3",
                Image = "Images/Phone03.png",
                Manufacturer = "SamSung",
                Price = 43990000
            });
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var index = lsvMobilePhone.SelectedIndex;
            int sizeList = lsMPhone.Count();
            
            if (index >=0 && index <= sizeList)
            {
                lsMPhone.RemoveAt(index);
            }
        }
    }
}
