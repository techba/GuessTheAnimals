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
using System.Xml;
using System.IO;
using GuessTheAnimals.ViewModel;
using Microsoft.Win32;

namespace GuessTheAnimals.Views
{
    /// <summary>
    /// Interaction logic for AddAnimalView.xaml
    /// </summary>
    public partial class AddAnimalView : UserControl
    {
        public AddAnimalView()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            bool? result = open.ShowDialog();

            if (result == true)
            {
                string filepath = open.FileName; // Stores Original Path in Textbox    
                ImageSource imgsource = new BitmapImage(new Uri(filepath)); // Just show The File In Image when we browse It
                //Clientimg.Source = imgsource;
                string name = System.IO.Path.GetFileName(filepath);
                string destinationPath = GetDestinationPath(name, "images");

                File.Copy(filepath, destinationPath, true);
                txtImgLoc.Text = destinationPath;
            }

        }
        private static String GetDestinationPath(string filename, string foldername)
        {
            String appStartPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            appStartPath = String.Format(appStartPath + "\\{0}\\" + filename, foldername);
            return appStartPath;
        }
    }
}
