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
    /// Logique d'interaction pour Tutorial.xaml
    /// </summary>
    public partial class Tutorial : UserControl
    {
        #region Constructors

        public Tutorial()
        {
            InitializeComponent();
        }

        #endregion //Constructors

        public Uri BackgroundSource
        {
            get { return (Uri)GetValue(BackgroundSourceProperty); }
            set { SetValue(BackgroundSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundSourceProperty =
            DependencyProperty.Register("BackgroundSource", typeof(Uri), typeof(Tutorial));



        public Uri UserSource
        {
            get { return (Uri)GetValue(UserSourceProperty); }
            set { SetValue(UserSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserSourceProperty =
            DependencyProperty.Register("UserSource", typeof(Uri), typeof(Tutorial));

        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Username.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(Tutorial));

        public string NickName
        {
            get { return (string)GetValue(NickNameProperty); }
            set { SetValue(NickNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NickNameProperty =
            DependencyProperty.Register("NickName", typeof(string), typeof(Tutorial));

        public string Time
        {
            get { return (string)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Time.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TimeProperty =
            DependencyProperty.Register("Time", typeof(string), typeof(Tutorial));

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Description.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(Tutorial));

    }

}
