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

namespace BindingList
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

        BindingList<Book> lsBook = new BindingList<Book>();
        private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {

            lsBook.Add(new Book()
            {
                BookName = "Chủ nghĩa khắc kỷ",
                CoverImage = "Images/Book01.png",
                Author = "William B.Arvine",
                PublishedYear = "2017"
            });
            
            lsBook.Add(new Book()
            {
                BookName = "Cuộc đời kỳ lạ của Nikola Tesla",
                CoverImage = "Images/Book02.png",
                Author = "Nguyễn Hưởng (dịch)",
                PublishedYear = "2015"
            });

            lsBook.Add(new Book()
            {
                BookName = "Nhật ký Đặng Thị Thùy Trâm",
                CoverImage = "Images/Book03.png",
                Author = "NXB Hội Nhà văn",
                PublishedYear = "2003"
            });

            lsBook.Add(new Book()
            {
                BookName = "Cuộc Thập Tự Chinh Thứ Nhất – Tiếng Gọi Từ Phương Đông",
                CoverImage = "Images/Book04.png",
                Author = "Peter Frankopan",
                PublishedYear = "2005"
            });

            lsBook.Add(new Book()
            {
                BookName = "Uống Trà Cùng Trạng",
                CoverImage = "Images/Book05.png",
                Author = "Nguyễn Hữu Nam",
                PublishedYear = "2014"
            });
            
            lsBook.Add(new Book()
            {
                BookName = "Sói Già Phố Wall – Phần I",
                CoverImage = "Images/Book06.png",
                Author = "Jordan Belfort",
                PublishedYear = "2010"
            });

            lsBook.Add(new Book()
            {
                BookName = "Cuốn Theo Chiều Gió",
                CoverImage = "Images/Book07.png",
                Author = "Margaret Mitchell",
                PublishedYear = "1936"
            });

            lsBook.Add(new Book()
            {
                BookName = "Giết Con Chim Nhại",
                CoverImage = "Images/Book08.png",
                Author = "Harper Lee",
                PublishedYear = "2010"
            });

            lsBook.Add(new Book()
            {
                BookName = "Đất Rừng Phương Nam",
                CoverImage = "Images/Book09.png",
                Author = "Đoàn Giỏi",
                PublishedYear = "2005"
            });

            lsBook.Add(new Book()
            {
                BookName = "Trò Chơi Của Ender",
                CoverImage = "Images/Book10.png",
                Author = "Orson Scott Card",
                PublishedYear = "2019"
            });

            lsvBook.ItemsSource = lsBook;
        }

        private void deleteMenu_Click(object sender, RoutedEventArgs e)
        {
            var index = lsvBook.SelectedIndex;
            int n = lsBook.Count();
            if (index >= 0 && index < n)
            {
                lsBook.RemoveAt(index);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lsBook.Add(new Book()
            {
                BookName = "Đất Rừng Phương Nam",
                CoverImage = "Images/Book09.png",
                Author = "Đoàn Giỏi",
                PublishedYear = "2005"
            });
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var index = lsvBook.SelectedIndex;
            int n = lsBook.Count();
            if (index >= 0 && index < n)
            {
                lsBook.RemoveAt(index);
            }
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


    }
}
