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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearFormHandler(object sender, RoutedEventArgs e)
        {
            foreach(var tb in Grid.Children.OfType<TextBox>())
                tb.Text = "";
        }

        private void FillSampleDataHandler(object sender, RoutedEventArgs e)
        {
            var student = StudentData.TestStudents.First();
            FirstNameField.Text = student.FirstName;
            MiddleNameField.Text = student.MiddleName;
            LastNameField.Text = student.LastName;
            FacultyField.Text = student.Faculty;
            SpecialityField.Text = student.Speciality;
            OkcField.Text = student.EducationDegree;
            StatusField.Text = student.Status;
            FacultyNumberField.Text = student.FacultyNumber;
            CourseField.Text = student.Course.ToString();
            FlowField.Text = student.Flow.ToString();
            GroupField.Text = student.Group.ToString();
        }

        private void DisableFieldsHandler(object sender, RoutedEventArgs e)
        {
            foreach (var tb in Grid.Children.OfType<TextBox>())
                tb.IsEnabled = false;
        }

        private void EnableFieldsHandler(object sender, RoutedEventArgs e)
        {
            foreach (var tb in Grid.Children.OfType<TextBox>())
                tb.IsEnabled = true;
        }
    }
}