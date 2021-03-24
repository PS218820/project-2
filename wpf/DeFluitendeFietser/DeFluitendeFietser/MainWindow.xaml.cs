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

namespace DeFluitendeFietser
{
    

    public partial class MainWindow : Window
    {

        double TotaalPrijs = 0;

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void btToevoegen_Click(object sender, RoutedEventArgs e)
        {
            Listbox();
            TotaalPrijs = 0;
            tbTotaal.Text = "Totaal prijs: €" + TotaalPrijs.ToString();
        }

        private void uitvoeren()
        {
            try
            {
                TotaalPrijs = 0;
                ComboBoxItem cbFiets = (ComboBoxItem)cbFietsen.SelectedItem;
                string GekozenFiets = cbFiets.Content.ToString();

                ComboBoxItem cbVerzekering = (ComboBoxItem)cbVerzekeringen.SelectedItem;
                string GekozenVerzekering = cbVerzekering.Content.ToString();

                ComboBoxItem cbService = (ComboBoxItem)cbServices.SelectedItem;
                string GekozenService = cbService.Content.ToString();

                string AantalDagen = tbDagen.Text;
                int GekozenDagen = int.Parse(AantalDagen);

                switch (GekozenFiets)
                {
                    case "Aanhangfiets € 20,00 / dag":
                        TotaalPrijs = TotaalPrijs + 20 * GekozenDagen;
                        break;
                    case "Bakfiets € 35,00 / dag":
                        TotaalPrijs = TotaalPrijs + 35 * GekozenDagen; 
                        break;
                    case "Driewielfiets € 30,00 / dag":
                        TotaalPrijs = TotaalPrijs + 30 * GekozenDagen;
                        break;
                    case "Elektrische fiets € 30,00 / dag":
                        TotaalPrijs = TotaalPrijs + 30 * GekozenDagen;
                        break;
                    case "Kinderfiets € 15,00 / dag":
                        TotaalPrijs = TotaalPrijs + 15 * GekozenDagen;
                        break;
                    case "Ligfiets € 45,00 / dag":
                        TotaalPrijs = TotaalPrijs + 45 * GekozenDagen;
                        break;
                    case "Oma fiets € 12,50 / dag":
                        TotaalPrijs = TotaalPrijs + 12.50 * GekozenDagen;
                        break;
                    case "Racefiets € 15,00 / dag":
                        TotaalPrijs = TotaalPrijs + 15 * GekozenDagen;
                        break;
                    case "Speed pedelec € 15,00 / dag":
                        TotaalPrijs = TotaalPrijs + 15 * GekozenDagen;
                        break;
                    case "Stadsfiets € 12,50 / dag":
                        TotaalPrijs = TotaalPrijs + 12.50 * GekozenDagen;
                        break;
                    case "Vouwfiets € 10,00 / dag":
                        TotaalPrijs = TotaalPrijs + 10 * GekozenDagen;
                        break;
                    case "Zitfiets € 15,00 / dag":
                        TotaalPrijs = TotaalPrijs + 15 * GekozenDagen;
                        break;
                    case "Niet gekozen":
                        break;
                    default:
                        break;                    
                }

                switch (GekozenVerzekering)
                {
                    case "Beschadigingen € 5,00 / dag":
                        TotaalPrijs = TotaalPrijs + 5 * GekozenDagen;
                        break;
                    case "Diefstal € 10,00 / dag, eigen risico":
                        TotaalPrijs = TotaalPrijs + 10 * GekozenDagen;
                        break;
                    case "Rechtsbijstand € 5,00 / dag":
                        TotaalPrijs = TotaalPrijs + 5 * GekozenDagen;
                        break;
                    case "Ongevallen € 2,50 / dag":
                        TotaalPrijs = TotaalPrijs + 2.50 * GekozenDagen;
                        break;
                    case "Niet gekozen":
                        break;
                    default:
                        break;
                }

                switch (GekozenService)
                {
                    case "Ophaalservice € 15,00 / dag":
                        TotaalPrijs = TotaalPrijs + 15 * GekozenDagen;
                        break;
                    case "Regenpak € 10,00 / dag":
                        TotaalPrijs = TotaalPrijs + 10 * GekozenDagen;
                        break;
                    case "Lunchpakket basis € 12,50 / dag":
                        TotaalPrijs = TotaalPrijs + 12.50 * GekozenDagen;
                        break;
                    case "Lunchpakket uitgebreid € 20,00 / dag":
                        TotaalPrijs = TotaalPrijs + 20 * GekozenDagen;
                        break;
                    case "Niet gekozen":
                        break;
                    default:
                        break;
                }
                tbTotaal.Text = "Totaal prijs: €" + TotaalPrijs.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Fout");
            }
        }

        private void Listbox()
        {
            try
            {
                ComboBoxItem cbFiets = (ComboBoxItem)cbFietsen.SelectedItem;
                string GekozenFiets = cbFiets.Content.ToString();

                string AantalDagen = tbDagen.Text;

                lbOverzicht.Items.Add(GekozenFiets + " - " + AantalDagen + " Dag/Dagen - €" + TotaalPrijs);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cbFietsen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            uitvoeren();
        }

        private void cbVerzekeringen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            uitvoeren();
        }

        private void cbServices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            uitvoeren();
        }

        private void tbDagen_MouseLeave(object sender, MouseEventArgs e)
        {
            uitvoeren();
        }

        private void lbOverzicht_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lbOverzicht.Items.RemoveAt(lbOverzicht.Items.IndexOf(lbOverzicht.SelectedItem));
        }
    }
}
