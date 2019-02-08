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

namespace WPFUserControlsRaf
{
    /// <summary>
    /// Logika interakcji dla klasy TekstBoxRaf.xaml
    /// </summary>
    public partial class TekstBoxRaf : UserControl
    {
        public TekstBoxRaf()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string tekstRaf
        {
            get { return (string)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("tekstRaf", typeof(string), typeof(TekstBoxRaf));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tekstRaf = string.Empty;
        }
    }
}
