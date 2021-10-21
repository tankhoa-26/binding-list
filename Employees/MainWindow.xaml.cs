using Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Employees
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

        BindingList<Employee> lsEmployee = new BindingList<Employee>();
        private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            lsEmployee.Add(new Employee
            {
                FullName = "Lý Quốc Quân",
                Email = "lqquan@gmail.com",
                Address = "189/17B đường Lạc Long Quân, phường 9, quận Tân Bình",
                PhoneNumber = "0938604830",
                Avatar = "Images/A01.png"
            });

            lsEmployee.Add(new Employee
            {
                FullName = "Ngô Hoàng Long",
                Email = "nhlong@hotmail.com",
                Address = "192/2/6 đường Nguyễn Hữu Cảnh, phường Thống Nhất",
                PhoneNumber = "0978523639",
                Avatar = "Images/A02.png"
            });

            lsEmployee.Add(new Employee
            {
                FullName = "Tôn Diễm Thúy",
                Email = "diemthuyton2000@gmail.com",
                Address = "188 đường Nguyễn Thái Học, Quận 1",
                PhoneNumber = "0962782216",
                Avatar = "Images/A03.png"
            });

            lsEmployee.Add(new Employee
            {
                FullName = "Nguyễn Yến Trinh",
                Email = "nyentrinh2206@gmail.com",
                Address = "263/10 Lê Quang Định, phường 14, quận Bình Thạnh",
                PhoneNumber = "0388411660",
                Avatar = "Images/A04.png"
            });

            lsEmployee.Add(new Employee
            {
                FullName = "Nguyễn Đức Toàn",
                Email = "ductoan_yoot@gmail.com",
                Address = "29/3 đường Nguyễn Văn Trỗi, phường Bửu Long, TP Biên Hòa",
                PhoneNumber = "0382412588",
                Avatar = "Images/A05.png"
            });

            lsEmployee.Add(new Employee
            {
                FullName = "Nguyễn Ngọc Khang",
                Email = "khangnguyen_hcmus@gmail.com",
                Address = "20/11 đường Nguyễn Văn Thủ, phường Dakao, Quận 1",
                PhoneNumber = "0882911774",
                Avatar = "Images/A06.png"
            });

            lsEmployee.Add(new Employee
            {
                FullName = "Bùi Minh Thiện",
                Email = "bmthien_hcmus@gmail.com",
                Address = "504 phố Cửa Đại, Hội An",
                PhoneNumber = "0388923025",
                Avatar = "Images/A07.png"
            });

            lsEmployee.Add(new Employee
            {
                FullName = "Võ Hồng Quân",
                Email= "vhongquan0908@gmail.com",
                Address = "226/41 Đường 3/2, phường 11, Quận 10",
                PhoneNumber = "0350762390",
                Avatar = "Images/A08.png"
            });

            lsEmployee.Add(new Employee
            {
                FullName = "Phạm Tấn Sinh",
                Email = "sinhtanpham123@gmail.com",
                Address = "113 Tháp Mười - Quận 6",
                PhoneNumber = "088572167",
                Avatar = "Images/A09.png"
            });

            lsEmployee.Add(new Employee
            {
                FullName = "Huỳnh Ngọc Liên",
                Email = "ngoclien2204@gmail.com",
                Address = "240-192 Hai Bà Trưng, Quận 1",
                PhoneNumber = "0838243657",
                Avatar = "Images/A10.png"
            });
            lsvEmployee.ItemsSource = lsEmployee;
        }

        private void tbItemHome_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var index = lsvEmployee.SelectedIndex;
            int sizeList = lsEmployee.Count();

            if(index >=0 && index < sizeList)
            {
                lsEmployee.RemoveAt(index);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lsEmployee.Add(new Employee
            {
                FullName = "Võ Hồng Quân",
                Email = "vhongquan0908@gmail.com",
                Address = "226/41 Đường 3/2, phường 11, Quận 10",
                PhoneNumber = "0350762390",
                Avatar = "Images/A08.png"
            });
        }

        private void deleteMenu_Click(object sender, RoutedEventArgs e)
        {
            var index = lsvEmployee.SelectedIndex;
            int sizeList = lsEmployee.Count();

            if (index >= 0 && index < sizeList)
            {
                lsEmployee.RemoveAt(index);
            }
        }
    }
}
