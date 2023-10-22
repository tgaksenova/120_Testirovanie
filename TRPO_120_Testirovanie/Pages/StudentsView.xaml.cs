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
            //Testirovanie testirovanie = new Testirovanie();
            //var req = from s in App.StudenInformationList
            //          select new { s.StudentID, s.Group.GroupNumber, s.FirstName, s.SecondName, s.Patronymic };
            //students.ItemsSource = req.ToList();
            //testirovanie.Dispose();
            students.ItemsSource = App.StudenInformationList;
            Filter.ItemsSource = App.groups;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount >= 2)
            {
                dynamic stud = students.SelectedItem;
                App.mainPage.dbFrame.Navigate(new Add_Edit(stud.StudentID));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var parent = (StackPanel)VisualTreeHelper.GetParent((FrameworkElement)sender);
            string a="";
            foreach (var item in parent.Children)
            {
                if (item.GetType().ToString()== "System.Windows.Controls.TextBlock")
                {
                    TextBlock textBlock = (TextBlock)item;
                    if (textBlock.Name== "studentId")
                    {
                        a = textBlock.Text.Replace("Номер студенческого: ", ""); ;
                        break;
                    }
                }
            }
            if (a!="") {
                var aInt = Convert.ToInt32(a);
                Testirovanie testirovanie = new Testirovanie();
                testirovanie.StudenInformation.Remove(testirovanie.StudenInformation.Single(x=>x.StudentID==aInt));
                testirovanie.SaveChanges();
                foreach (var item in testirovanie.StudenInformation)
                {
                    var aboba = item.GroupID;
                    item.Group = testirovanie.Group.Single(x => x.ID == aboba);
                }
                testirovanie.SaveChanges();
                App.StudenInformationList = testirovanie.StudenInformation.ToList();
                testirovanie.Dispose();
                App.studentsView = new StudentsView();
                App.mainPage.dbFrame.Navigate(App.studentsView);
            }
        }

        private void Filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                if (App.mainPage.dbFrame.NavigationService.Content.GetType().ToString().Replace("TRPO_120_Testirovanie.", "") == "StudentsView")
                {
                    App.studentsView.students.ItemsSource = App.StudenInformationList.Where(x => x.FirstName.ToLower().Contains(App.mainPage.Search.Text.ToLower()) || x.SecondName.ToLower().Contains(App.mainPage.Search.Text.ToLower()) || x.Patronymic.ToLower().Contains(App.mainPage.Search.Text.ToLower())).ToList();
                }
            }
            catch (System.NullReferenceException ex)
            {
                App.studentsView.students.ItemsSource = App.StudenInformationList;
                throw ex;
                
            }

            this.students.ItemsSource = ((List<StudenInformation>)students.ItemsSource).Where(x=>x.Group.GroupNumber== Filter.SelectedValue.ToString());
        }
    }
}
