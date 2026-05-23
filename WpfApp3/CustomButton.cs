using System.Windows;
using System.Windows.Controls;

namespace WpfApp3
{
    public class CustomButton : Button
    {
        static CustomButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomButton),
                new FrameworkPropertyMetadata(typeof(CustomButton)));
        }

        // 只加这一段！！！
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(
                "CornerRadius",
                typeof(CornerRadius),
                typeof(CustomButton),
                new PropertyMetadata(new CornerRadius(0)));
    }
}