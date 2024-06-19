using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp502;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int _age;
    
    private int _weight;
    private int _notEnoughWeight = 20;
    private int _normalWeight = 25;
    private int _overweight = 30;
    private int _obesityToDegree = 40;
    private int _majorObesity = 200;

    public MainWindow()
    {
        InitializeComponent ();
    }
    
    private void calculation_Onclick(object sender, RoutedEventArgs e) 
    {
        
        if (int.TryParse(visual_growth.Text, out _age) && int.TryParse(visual_weight.Text, out _weight))  // не знаю как это работает > int.TryParse( out )
        {
            string answer;

            if (_age <= 24)
            {
                
                if (_weight <= _notEnoughWeight)
                    answer = "Низкий вес";
                else if (_weight <= _normalWeight)
                    answer = "Нормальный вес";
                else if (_weight <= _overweight)
                    answer = "Избыточный вес";
                else if (_weight <= _obesityToDegree)
                    answer = "Ожирение 1-2 степени";
                else
                    
                    answer = "Вы макс максбетов?";
            }
            else if (_age <= 34)
            {
                if (_weight <= _notEnoughWeight + 1)
                    answer = "Низкий вес";
                else if (_weight <= _normalWeight + 1)
                    answer = "Нормальный вес";
                else if (_weight <= _overweight + 1)
                    answer = "Избыточный вес";
                else if (_weight <= _obesityToDegree + 1)
                    answer = "Ожирение 1-2 степени";
                else
                    answer = "Вы макс максбетов?";
            }
            else if (_age <= 44)
            {
                if (_weight <= _notEnoughWeight + 2)
                    answer = "Низкий вес";
                else if (_weight <= _normalWeight + 2)
                    answer = "Нормальный вес";
                else if (_weight <= _overweight + 2)
                    answer = "Избыточный вес";
                else if (_weight <= _obesityToDegree + 2)
                    answer = "Ожирение 1-2 степени";
                else
                    answer = "Вы макс максбетов?";
            }
            else if (_age <= 54)
            {
                if (_weight <= _notEnoughWeight + 3)
                    answer = "Низкий вес";
                else if (_weight <= _normalWeight + 3)
                    answer = "Нормальный вес";
                else if (_weight <= _overweight + 3)
                    answer = "Избыточный вес";
                else if (_weight <= _obesityToDegree + 3)
                    answer = "Ожирение 1-2 степени";
                else
                    answer = "Вы макс максбетов?";
            }
            else if (_age <= 64)
            {
                if (_weight <= _notEnoughWeight + 4)
                    answer = "Низкий вес";
                else if (_weight <= _normalWeight + 4)
                    answer = "Нормальный вес";
                else if (_weight <= _overweight + 4)
                    answer = "Избыточный вес";
                else if (_weight <= _obesityToDegree + 4)
                    answer = "Ожирение 1-2 степени";
                else
                    answer = "Вы макс максбетов?";
            }
            else if (_age <= 100)
            {
                if (_weight <= _notEnoughWeight + 5)
                    answer = "Низкий вес";
                else if (_weight <= _normalWeight + 5)
                    answer = "Нормальный вес";
                else if (_weight <= _overweight + 5)
                    answer = "Избыточный вес";
                else if (_weight <= _obesityToDegree + 5)
                    answer = "Ожирение 1-2 степени";
                
                else
                    answer = "Вы макс максбетов?";
            }
            else
            {
                answer = "Возраст не поддерживается";
            }

            visual_answer.Text = answer;
        }
        else
        {
            visual_answer.Text = "Некорректный ввод";
        }
    }
}
