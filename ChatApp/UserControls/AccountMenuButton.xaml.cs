using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace ChatApp.UserControls
{
    /// <summary>
    /// AccountMenuButton.xaml 的交互逻辑
    /// </summary>
    public partial class AccountMenuButton : UserControl
    {
        public AccountMenuButton()
        {
            InitializeComponent();
        }



        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(AccountMenuButton));



        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsActive.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(AccountMenuButton));



        public Color GradientColor1
        {
            get { return (Color)GetValue(GradientColor1Property); }
            set { SetValue(GradientColor1Property, value); }
        }

        // Using a DependencyProperty as the backing store for GradientColor1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GradientColor1Property =
            DependencyProperty.Register("GradientColor1", typeof(Color), typeof(AccountMenuButton));



        public Color GradientColor2
        {
            get { return (Color)GetValue(GradientColor2Property); }
            set { SetValue(GradientColor2Property, value); }
        }

        // Using a DependencyProperty as the backing store for GradientColor2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GradientColor2Property =
            DependencyProperty.Register("GradientColor2", typeof(Color), typeof(AccountMenuButton));



    }
}
