using System;
using System.Collections;
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
    /// Logika interakcji dla klasy ComboBoxRaf.xaml
    /// </summary>
    public partial class ComboBoxRaf : UserControl
    {
        public ComboBoxRaf()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string tekstComboRaf
        {
            get { return (string)GetValue(tekstComboRafProperty); }
            set { SetValue(tekstComboRafProperty, value); }
        }
        
        public static readonly DependencyProperty tekstComboRafProperty =
            DependencyProperty.Register("tekstComboRaf", typeof(string), typeof(ComboBoxRaf));
        
        public IEnumerable listSource
        {
            get { return (IEnumerable)GetValue(listSourceProperty); }
            set { SetValue(listSourceProperty, value); }
        }

        public static readonly DependencyProperty listSourceProperty =
            DependencyProperty.Register("listSource", typeof(IEnumerable), typeof(ComboBoxRaf));

    }
}
