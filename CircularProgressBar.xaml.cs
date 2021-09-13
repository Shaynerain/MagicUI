using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace MagicUI
{
    /// <summary>
    /// CircularProgressBar.xaml 的交互逻辑
    /// </summary>
    public partial class CircularProgressBar : ProgressBar
    {
        public CircularProgressBar()
        {
            InitializeComponent();
        }


        public double ArcThickness
        {
            get { return (double)GetValue(ArcThicknessProperty); }
            set { SetValue(ArcThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArcThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArcThicknessProperty =
            DependencyProperty.Register("ArcThickness", typeof(double), typeof(CircularProgressBar), new PropertyMetadata((double)10));




        public Brush TextBrush
        {
            get { return (Brush)GetValue(TextBrushProperty); }
            set { SetValue(TextBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBrushProperty =
            DependencyProperty.Register("TextBrush", typeof(Brush), typeof(CircularProgressBar),
                new PropertyMetadata(Brushes.Black));


    }

    public class ValueConver : IMultiValueConverter
    {
        private double maxValue { get; set; }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            maxValue = (double)values[1];
            double v = ((double)values[0] / (double)values[1] * 100);
            return v.ToString("0.0");
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var obj = new object[2];
            obj[1] = maxValue;
            obj[0] = maxValue * (double)value/100.0;
            return obj;
        }
    }

    public class EndAngleConver : IMultiValueConverter
    {
        private double maxValue { get; set; }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            maxValue = (double)values[1];
            return (double)((double)values[0] / (double)values[1] * 360.0);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var obj = new object[2];
            obj[1] = maxValue;
            obj[0] = maxValue / 360.0 * (double)value;
            return obj;
        }
    }
}
