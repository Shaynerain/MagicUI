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

namespace MagicUI
{
    /// <summary>
    /// MagicButton.xaml 的交互逻辑
    /// </summary>
    public partial class MagicButton : Button
    {
        public MagicButton()
        {
            InitializeComponent();
        }

        public SolidColorBrush MouseOverBackground
        {
            get { return (SolidColorBrush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(SolidColorBrush), typeof(MagicButton),
                new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBEE6FD"))));


        public SolidColorBrush MouseOverBorder
        {
            get { return (SolidColorBrush)GetValue(MouseOverBorderProperty); }
            set { SetValue(MouseOverBorderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverBorder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverBorderProperty =
            DependencyProperty.Register("MouseOverBorder", typeof(SolidColorBrush), typeof(MagicButton), 
                new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3C7FB1"))));


        public SolidColorBrush PressedBackground
        {
            get { return (SolidColorBrush)GetValue(PressedBackgroundProperty); }
            set { SetValue(PressedBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PressedBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PressedBackgroundProperty =
            DependencyProperty.Register("PressedBackground", typeof(SolidColorBrush), typeof(MagicButton),
                new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC4E5F6"))));


        public SolidColorBrush PressedBorder
        {
            get { return (SolidColorBrush)GetValue(PressedBorderProperty); }
            set { SetValue(PressedBorderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PressedBorder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PressedBorderProperty =
            DependencyProperty.Register("PressedBorder", typeof(SolidColorBrush), typeof(MagicButton),
                new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2C628B"))));



        public SolidColorBrush DisabledBackground
        {
            get { return (SolidColorBrush)GetValue(DisabledBackgroundProperty); }
            set { SetValue(DisabledBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisabledBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisabledBackgroundProperty =
            DependencyProperty.Register("DisabledBackground", typeof(SolidColorBrush), typeof(MagicButton), 
                new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF4F4F4"))));



        public SolidColorBrush DisabledBorder
        {
            get { return (SolidColorBrush)GetValue(DisabledBorderProperty); }
            set { SetValue(DisabledBorderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisabledBorder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisabledBorderProperty =
            DependencyProperty.Register("DisabledBorder", typeof(SolidColorBrush), typeof(MagicButton),
                new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFADB2B5"))));



        public SolidColorBrush DisabledForeground
        {
            get { return (SolidColorBrush)GetValue(DisabledForegroundProperty); }
            set { SetValue(DisabledForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisabledForeground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisabledForegroundProperty =
            DependencyProperty.Register("DisabledForeground", typeof(SolidColorBrush), typeof(MagicButton),
                new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF838383"))));



        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(MagicButton), new PropertyMetadata(new CornerRadius(0)));



    }
}
