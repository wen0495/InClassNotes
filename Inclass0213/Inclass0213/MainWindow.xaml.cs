using System;
using System.Collections.Generic;
using System.IO;
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

namespace Inclass0213
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            var result = dlg.ShowDialog();

            txtSelectFile.Text = dlg.FileName;
        }

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(txtSelectFile.Text))
            {

                var lines = File.ReadLines(txtSelectFile.Text);
                
                foreach(var line in lines)
                {
                    txtReadFile.Text = line;
                }

                
            }
        }
    }
}
