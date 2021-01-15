using System;
using System.Windows;
using System.Windows.Controls;

namespace EducationWPF.Custom_Controls
{
    /// <summary>
    /// Logique d'interaction pour SmallButtons.xaml
    /// </summary>
    public partial class SmallButton : UserControl
    {

        #region Constructors

        public SmallButton()
        {
            InitializeComponent();
        }

        #endregion //Constructors

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(SmallButton));

        public Uri ImageSource
        {
            get { return (Uri)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(Uri), typeof(SmallButton), new PropertyMetadata(0));

    }

}
