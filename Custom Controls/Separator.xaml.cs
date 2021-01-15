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
    /// Logique d'interaction pour Separator.xaml
    /// </summary>
    public partial class Separator : UserControl
    {
        #region Constructors

        public Separator()
        {
            InitializeComponent();
        }

        #endregion //Constructors

        #region DependencyProperties

        /// <summary>
        /// Bold Text is the first text from left
        /// </summary>
        public string BoldText
        {
            get { return (string)GetValue(BoldTextProperty); }
            set { SetValue(BoldTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BoldText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BoldTextProperty =
            DependencyProperty.Register("BoldText", typeof(string), typeof(Separator));

        /// <summary>
        /// Light Text is the second text from left
        /// </summary>
        public string LightText
        {
            get { return (string)GetValue(LightTextProperty); }
            set { SetValue(LightTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LightText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LightTextProperty =
            DependencyProperty.Register("LightText", typeof(string), typeof(Separator));

        #endregion //DepdencyProperties

    }

}
