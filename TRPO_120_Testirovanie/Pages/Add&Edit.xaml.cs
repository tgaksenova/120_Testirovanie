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
    /// Логика взаимодействия для Add_Edit.xaml
    /// </summary>
    public partial class Add_Edit : Page
    {
        public Add_Edit()
        {
            InitializeComponent();
            List<Group> groups = App.groups;
            groupChoise.ItemsSource = groups;
            groupChoise.SelectedIndex = 1;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Testirovanie testirovanie = new Testirovanie();

            if (FirstName.Text == "" | StudID.Text == "" | SecondName.Text == "" | Patronymic.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                var req = from x in App.groups
                          where x.GroupNumber == groupChoise.SelectedValue.ToString()
                          select x.ID;
                StudenInformation student = new StudenInformation
                {
                    StudentID = Convert.ToInt32(StudID.Text),
                    GroupID = Convert.ToInt32(req.First()),
                    FirstName = FirstName.Text,
                    SecondName = SecondName.Text,
                    Patronymic = Patronymic.Text
                };

                App.StudenInformationList.Add(student);
                testirovanie.StudenInformation.Add(student);
                testirovanie.SaveChanges();
                testirovanie.Dispose();
            }

            App.mainPage = new MainPage("Преподаватель");
            App.studentsView = new StudentsView();
            App.mainPage.dbFrame.Navigate(App.studentsView);
        }
    }
}
