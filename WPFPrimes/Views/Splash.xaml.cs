using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPFPrimes.Views {
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class Splash : Window {
        
        MainWindow mainWindow = new MainWindow();
        private List<String> languageList = new List<string> { "en-US", "fr-FR", "pt-BR", "de-DE", "ja-JP", "es-ES", "it-IT" };

        public Splash() {
            InitializeComponent();
        }

       

        private void SetCulture(CultureInfo culture) {
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            ReloadResourceText();

            this.FlowDirection = culture.TextInfo.IsRightToLeft ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
        }

        private void ReloadResourceText() {
            
            this.LblTileMathematics.Content = Properties.Resources.SplashTitleMathematics;
            this.LblTile.Content = Properties.Resources.SplashTitle;
            this.LblDevelopBy.Content = Properties.Resources.SplashDevelopBy;
            
        }


        private void OnWindowLoaded(object sender, RoutedEventArgs e) {
            
            Application.Current.Dispatcher.BeginInvoke(
                DispatcherPriority.Loaded,
                 new Action(() => {
                     var currentCulture = Thread.CurrentThread.CurrentCulture;
                     var currentCultureUI = Thread.CurrentThread.CurrentUICulture;

                     foreach (var language in languageList) {
                         SetCulture(new CultureInfo(language));

                         Thread.Sleep(2000);
                     }

                     Thread.CurrentThread.CurrentCulture = currentCulture;
                     Thread.CurrentThread.CurrentUICulture = currentCultureUI;

                     this.Hide();
                     mainWindow.Show();

             }));
        }
    }
}
