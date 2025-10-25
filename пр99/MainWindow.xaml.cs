using System;
using System.IO;
using System.Text;
using System.Windows;
using Microsoft.Win32;

namespace np9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();

          
            var openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = @"data\Text2.txt";
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
        }

        private void открытьToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";

            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == String.Empty) return;

     
            try
            {
                var Читатель = new System.IO.StreamReader(

            }
            catch (System.IO.FileNotFoundException Ситуация)
            {
                MessageBox.Show(Ситуация.Message + "\nНет такого файла",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            catch (Exception Ситуация)
            {
             
                MessageBox.Show(Ситуация.Message,
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        
        private void сохранитьКакToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";


            if (saveFileDialog1.ShowDialog() == true)
            {
                try
                {
                    var Писатель = new System.IO.StreamWriter(

                    Писатель.Close();
                }
                catch (Exception Ситуация)
                {
                
                    MessageBox.Show(Ситуация.Message,
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }

     
        private void выходToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
