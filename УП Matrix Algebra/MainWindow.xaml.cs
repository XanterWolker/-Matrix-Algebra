using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;



namespace УП_Matrix_Algebra
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int n1 = 6;
            int m1 = 8;
            int[,] arr1 = new int[n1, m1];
            
            

            Random r1 = new Random();
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    arr1[i, j] = r1.Next(0, 2);

                   Matrix.Text += Convert.ToString(arr1[i, j] + " ");
                }
                Matrix.Text += "\n";
            }

            int n2 = 6;
            int m2 = 8;
            int[,] arr2 = new int[n2, m2];


            
            
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    arr2[i, j] = r1.Next(0, 2);

                    Matrix2.Text += Convert.ToString(arr2[i, j] + " ");
                }
                Matrix2.Text += "\n";
            }


        }










        private void Tb_Field_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tb_Field2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Enter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Mult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Subtract_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
