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
    /// Logique d'interaction pour SmallStats.xaml
    /// </summary>
    public partial class SmallStats : UserControl
    {
        #region Constructors

        public SmallStats()
        {
            InitializeComponent();
        }

        #endregion //Constructors


        public Uri ImageSource
        {
            get { return (Uri)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(Uri), typeof(SmallStats), new PropertyMetadata(0));

        public string Stats
        {
            get { return (string)GetValue(StatsProperty); }
            set { SetValue(StatsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Stats.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StatsProperty =
            DependencyProperty.Register("Stats", typeof(int), typeof(SmallStats));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(int), typeof(SmallStats));
    }

}
