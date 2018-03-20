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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Plary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
             * To start off on the profile page, comment out:
             *        this.Headers.Visibility = Visibility.Hidden;
             *        this.ProfileScreen.Visibility = Visibility.Hidden;
             * And uncomment
             *        this.LoginScreen.Visibility = Visibility.Hidden;
             * */

            //Hide the other screens
            //this.LoginScreen.Visibility = Visibility.Hidden;
            this.CreateAccountScreen.Visibility = Visibility.Hidden;
            this.EmailCodeScreen.Visibility = Visibility.Hidden;
            this.AccountCreatedScreen.Visibility = Visibility.Hidden;
            this.BadgeInfoScreen.Visibility = Visibility.Hidden;
            this.Headers.Visibility = Visibility.Hidden;
            this.ProfileScreen.Visibility = Visibility.Hidden;

            //Login and create account screen button functionality
            this.LoginButton.Click += OnLogin;
            this.CreateNewAccountButton.Click += OnCreateNewAccount;
            this.CancleAccountButton.Click += OnCancleAccount;
            this.CreateAccountButton.Click += OnCreateAccount;
            this.EmailCodeBackButton.Click += OnCodeBack;
            this.EmailCodeContinueButton.Click += OnCodeContinue;
            this.CreatedContinueButton.Click += OnCreatedContinue;

            //Profile Screen (And badge info) functionality
            FullBadge1.MouseLeftButtonDown += OnFullBadgeClick;
            BadgeInfoScreen.MouseLeftButtonDown += OnFullBadgeScreenClick;
        }

        #region Login/Create account screen button functionality

        private void OnLogin(object sender, RoutedEventArgs e)
        {
            this.LoginScreen.Visibility = Visibility.Hidden;
            this.Headers.Visibility = Visibility.Visible;
            this.ProfileScreen.Visibility = Visibility.Visible;
        }

        private void OnCreateNewAccount(object sender, RoutedEventArgs e)
        {
            this.LoginScreen.Visibility = Visibility.Hidden;
            this.CreateAccountScreen.Visibility = Visibility.Visible;
        }

        private void OnCancleAccount(object sender, RoutedEventArgs e)
        {
            this.CreateAccountScreen.Visibility = Visibility.Hidden;
            this.LoginScreen.Visibility = Visibility.Visible;
        }

        private void OnCreateAccount(object sender, RoutedEventArgs e)
        {
            this.CreateAccountScreen.Visibility = Visibility.Hidden;
            this.EmailCodeScreen.Visibility = Visibility.Visible;
        }

        private void OnCodeBack(object sender, RoutedEventArgs e)
        {
            this.EmailCodeScreen.Visibility = Visibility.Hidden;
            this.CreateAccountScreen.Visibility = Visibility.Visible;
        }

        private void OnCodeContinue(object sender, RoutedEventArgs e)
        {
            this.EmailCodeScreen.Visibility = Visibility.Hidden;
            this.AccountCreatedScreen.Visibility = Visibility.Visible;
        }

        private void OnCreatedContinue(object sender, RoutedEventArgs e)
        {
            this.AccountCreatedScreen.Visibility = Visibility.Hidden;
            this.Headers.Visibility = Visibility.Visible;
            this.ProfileScreen.Visibility = Visibility.Visible;
        }

        #endregion

        #region Profile Screen (And badge info) functionality

        private void OnFullBadgeClick(object sender, MouseButtonEventArgs e)
        {
            this.BadgeInfoScreen.Visibility = Visibility.Visible;
        }

        private void OnFullBadgeScreenClick(object sender, MouseButtonEventArgs e)
        {
            this.BadgeInfoScreen.Visibility = Visibility.Hidden;
        }

        #endregion
    }
}
