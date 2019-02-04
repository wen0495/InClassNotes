using Review_Classes;
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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> Students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string idAsString = id.Text;
            Student a = new Student();
            a.SoonerID = Convert.ToInt32(id.Text);
            a.FirstName = name.Text;
            a.GPA = Convert.ToDouble(gpa.Text);
            Students.Add(a);
            // var futureDate = Convert.ToDateTime("02/12/2018");
            DateTime studentDOB = Convert.ToDateTime(dob.Text);
            DateTime x = studentDOB.AddDays(50); // add 50 days to whatever the user input --> so that will deal with month changes or something by itself
            DateTime rightNow = DateTime.Now;
            var diff = rightNow - studentDOB;

            output.Text = $"Hello, {a.FirstName} ({a.SoonerID}), your gpa is {a.GPA}, and your date of birth is {studentDOB}";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
