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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Indicator.xaml
    /// </summary>
    public partial class Indicator : UserControl
    {
        public static readonly DependencyProperty ValueProperty =
        DependencyProperty.Register(
        nameof(Value),
        typeof(double),
        typeof(Indicator),
        new FrameworkPropertyMetadata(
        default(double),
        0,
        null,
        new CoerceValueCallback(CoerceMvValue)));

        private static object CoerceMvValue(DependencyObject d, object baseValue)
        {
            double v=(double)baseValue;
            if (v < 0)
            {
                return 0;
            }
            if (v > 180)
            {
                return 180;
            }
            return v;
        }

        public double Value
        {
            get => (double)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
        public Indicator()
        {
            InitializeComponent();
        }
    }
}
