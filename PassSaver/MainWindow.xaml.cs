using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace PassSaver
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

        private void MenuItem_File_New_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Create New Database";
            saveFileDialog.FileName = "Database";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "PassSaver PSDX Files |*.psdx" + "| All Files |*.*";


            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, "");
            }

        }

        private void MenuItem_View_ChangeLang_Eng_Click(object sender, RoutedEventArgs e)
        {

            App.ChangeCulture(new CultureInfo("en-US"));

        }

        private void MenuItem_View_ChangeLang_Ru_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("ru-RU"));

        }        
    }
}
