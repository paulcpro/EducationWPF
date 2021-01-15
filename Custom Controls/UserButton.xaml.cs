using System;
using System.Windows;
using System.Windows.Controls;

namespace EducationWPF.Custom_Controls
{
    /// <summary>
    /// Logique d'interaction pour UserButton.xaml
    /// </summary>
    public partial class UserButton : UserControl
    {

        #region Constructors

        public UserButton()
        {
            InitializeComponent();
        }

        #endregion //Constructors


        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(UserButton));

        public string NickName
        {
            get { return (string)GetValue(NickNameProperty); }
            set { SetValue(NickNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NickNameProperty =
            DependencyProperty.Register("NickName", typeof(string), typeof(UserButton));

        public Uri UserSource
        {
            get { return (Uri)GetValue(UserSourceProperty); }
            set { SetValue(UserSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserSourceProperty =
            DependencyProperty.Register("UserSource", typeof(Uri), typeof(UserButton), new PropertyMetadata(0));

        public Uri OptionsSource
        {
            get { return (Uri)GetValue(OptionsSourceProperty); }
            set { SetValue(OptionsSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OptionsSourceProperty =
            DependencyProperty.Register("OptionsSource", typeof(Uri), typeof(UserButton), new PropertyMetadata(0));
    }

}
