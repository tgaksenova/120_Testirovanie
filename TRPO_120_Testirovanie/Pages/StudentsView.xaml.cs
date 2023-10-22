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
using TRPO_Testirovanie;

namespace TRPO_120_Testirovanie
{
    /// <summary>
    /// Логика взаимодействия для StudentsView.xaml
    /// </summary>
    public partial class StudentsView : Page
    {
        public StudentsView()
        {
            InitializeComponent();
            Testirovanie testirovanie = new Testirovanie();
            var req = from s in App.StudenInformationList
                      select new { s.StudentID, s.Group.GroupNumber, s.FirstName, s.SecondName, s.Patronymic };
            students.ItemsSource = req.ToList();
        }
    }
}
