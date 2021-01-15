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

namespace EducationWPF.Custom_Controls
{
    /// <summary>
    /// Logique d'interaction pour Premium.xaml
    /// </summary>
    public partial class Premium : UserControl
    {
        #region Construtors

        public Premium()
        {
            InitializeComponent();
        }

        #endregion //Constructors

        public string Days
        {
            get { return (string)GetValue(DaysProperty); }
            set { SetValue(DaysProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DaysProperty =
            DependencyProperty.Register("Days", typeof(string), typeof(Premium));

        public string GetIt
        {
            get { return (string)GetValue(GetItProperty); }
            set { SetValue(GetItProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GetItProperty =
            DependencyProperty.Register("GetIt", typeof(string), typeof(Premium));

        public string TextButton
        {
            get { return (string)GetValue(TextButtonProperty); }
            set { SetValue(TextButtonProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextButton.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextButtonProperty =
            DependencyProperty.Register("TextButton", typeof(string), typeof(Premium));

        public Uri PremiumSource
        {
            get { return (Uri)GetValue(PremiumSourceProperty); }
            set { SetValue(PremiumSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PremiumSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PremiumSourceProperty =
            DependencyProperty.Register("PremiumSource", typeof(Uri), typeof(Premium));
    }

}
