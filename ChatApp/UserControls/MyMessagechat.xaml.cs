using System.Windows;
using System.Windows.Controls;

namespace ChatApp.UserControls
{
    /// <summary>
    /// MyMessagechat.xaml 的交互逻辑
    /// </summary>
    public partial class MyMessagechat : UserControl
    {
        public MyMessagechat()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(MyMessagechat));
    }
}
