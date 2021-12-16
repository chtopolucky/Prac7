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

namespace Пр5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Pair firstPair = new Pair();// создаём объект содержащий первую пару
        Pair secondPair = new Pair();// создаём объект содержащий первую пару
        Pair resultMultiply=new Pair(); // объект содержащий результат умножения

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                firstPair.One = Convert.ToInt32(OneValue.Text);// записываем в текст бокс первое число первой пары
                firstPair.Second = Convert.ToInt32(TwoValue.Text);// записываем в текст бокс второе число первой пары
                secondPair.One = Convert.ToInt32(ThirdValue.Text);// записываем в текст бокс первое число второй пары
                secondPair.Second = Convert.ToInt32(FourValue.Text);// записываем в текст бокс второе число второй пары
                //rezultMultiply = firstPair.Multiply(secondPair);
                //rezultMultiplyingFirstPair.Text = rezultMultiply.One.ToString();
                //rezultMultiplyingSecondPair.Text = rezultMultiply.Second.ToString();

                resultMultiply = firstPair * secondPair;
                resultMultiplyingFirstPair.Text = resultMultiply.One.ToString();
                resultMultiplyingSecondPair.Text = resultMultiply.Second.ToString();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №7 Вариант 11\nВыполнил студент группы ИСП-31 Обухов С\nЗадание: Использовать класс Pair (пара четных чисел). Определить производный класс треугольник RightAngled с полями - катетами. Определить методы вычисления гипотенузы и площади треугольника.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Question);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            OneValue.Clear();
            TwoValue.Clear();
            ThirdValue.Clear();
            FourValue.Clear();
            resultMultiplyingFirstPair.Clear();
            resultMultiplyingSecondPair.Clear();
            DoubleFirstPair.Clear();
            DoubleSecondPair.Clear();
            areaOneTriangle.Clear();
            areaSecondTriangle.Clear();
            hypoenuseOneTriangle.Clear();
            hypoenuseSecondTriangle.Clear();
        }
        private void DoubleFirstPair_Click(object sender, RoutedEventArgs e)
        {
            firstPair.Multiply();
            DoubleFirstPair.Text = firstPair.One.ToString() + ";" + firstPair.Second.ToString();
        }

        private void DoubleSecondPair_Click(object sender, RoutedEventArgs e)
        {
            secondPair.Multiply();
            DoubleSecondPair.Text = secondPair.One.ToString() + ";" + secondPair.Second.ToString();
        }
        RightAngled firstPairTwoClass = new RightAngled();
        RightAngled secondPairTwoClass = new RightAngled();
        private void HypoenuseOneTriangle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                firstPairTwoClass.One = Convert.ToInt32(OneValue.Text);
                firstPairTwoClass.Second = Convert.ToInt32(TwoValue.Text);
                hypoenuseOneTriangle.Text = firstPairTwoClass.AnswerHypoenuse().ToString();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void HypoenuseSecondTriangle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                secondPairTwoClass.One = Convert.ToInt32(ThirdValue.Text);
                secondPairTwoClass.Second = Convert.ToInt32(FourValue.Text);
                hypoenuseSecondTriangle.Text = secondPairTwoClass.AnswerHypoenuse().ToString();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AreaOneTriangle_Click(object sender, RoutedEventArgs e)
        {
            areaOneTriangle.Text = firstPairTwoClass.AnswerArea().ToString();
        }

        private void AreaSecondTriangle_Click(object sender, RoutedEventArgs e)
        {
            areaSecondTriangle.Text = secondPairTwoClass.AnswerArea().ToString();
        }
    }
}
