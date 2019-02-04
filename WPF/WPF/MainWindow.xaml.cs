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
            string idAsString = id.Text;
            Student a = new Student();
            a.SoonerID = Convert.ToInt32(idAsString);
            a.FirstName = name.Text;
            a.GPA = Convert.ToDouble(gpa.Text);
            Students.Add(a);
            var futureDate = Convert.ToDateTime("1/15/2020");
            //DateTime rightNow = DateTime.Now;
            DateTime studentDOB = Convert.ToDateTime(dob.Text);
            var x = studentDOB.AddDays(50);
            DateTime rightNow = DateTime.Now;
            var diff = rightNow - studentDOB;

            output.Text = $"Hello, {a.FirstName} ({a.SoonerID})";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
