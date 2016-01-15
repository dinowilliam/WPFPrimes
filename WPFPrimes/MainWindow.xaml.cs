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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFPrimes.Business;
using WPFPrimes.Properties;

namespace WPFPrimes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }              

        private void SetCulture(CultureInfo culture)
        {
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            ReloadResourceText();

            this.FlowDirection = culture.TextInfo.IsRightToLeft ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
        }

        private void ReloadResourceText()
        {
            this.Title = Properties.Resources.WindowTitle;
            this.LblTitle.Content = Properties.Resources.WindowDescription;
            this.LblLstTitle.Content = Properties.Resources.ListBoxTitle;

            this.BtnGeneratePrimes.Content = Properties.Resources.ButtonGeneratePrimes;
            this.BtnClearListPrimes.Content = Properties.Resources.ButtonClearListPrimes;
        }

        private void BtnLanguageEnglish_Click(object sender, RoutedEventArgs e) {
            SetCulture(new CultureInfo("en-US"));            
        }

        private void BtnLanguageFrench_Click(object sender, RoutedEventArgs e) {
            SetCulture(new CultureInfo("fr-FR"));
        }

        private void BtnLanguagePortuguese_Click(object sender, RoutedEventArgs e) {
            SetCulture(new CultureInfo("pt-BR"));
        }

        private void BtnLanguageGerman_Click(object sender, RoutedEventArgs e) {
            SetCulture(new CultureInfo("de-DE"));
        }

        private void BtnLanguageJapanese_Click(object sender, RoutedEventArgs e) {
            SetCulture(new CultureInfo("ja-JP"));            
        }

        private void BtnLanguageSpanish_Click(object sender, RoutedEventArgs e) {
            SetCulture(new CultureInfo("es-ES"));
        }

        private void BtnLanguageItalian_Click(object sender, RoutedEventArgs e) {
            SetCulture(new CultureInfo("it-IT"));
        }

        private void BtnClearListPrimes_Click(object sender, RoutedEventArgs e) {
            this.LstPrimes.Items.Clear();
        }

        private void BtnGeneratePrimes_Click(object sender, RoutedEventArgs e) {
            Primes primes = new Primes();
            
            var listPrimes = primes.GetListPrimeNumbers();

            foreach (String item in listPrimes){
                
                this.LstPrimes.Items.Add(item);

            }
        }   
    }
}
