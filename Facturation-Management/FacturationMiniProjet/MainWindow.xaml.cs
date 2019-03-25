using System.Windows;
using System.Windows.Navigation;
using FacturationMiniProjet.Article;
using FacturationMiniProjet.Client;
using FacturationMiniProjet.Controllers;
using FacturationMiniProjet.Facture;

namespace FacturationMiniProjet
{
  /// <summary>
  ///   Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    HelperMySQL hms = new HelperMySQL();

    public MainWindow()
    {
      InitializeComponent();
      /*  hms.ExecuteQuery(
            @"CREATE TABLE `Article` (
            `N_Article` int(50) NOT NULL AUTO_INCREMENT,
            `Libelle` varchar(50) DEFAULT NULL,
            `Prix_unit` varchar(50) DEFAULT NULL,
            `TVA` varchar(50) DEFAULT NULL,
            PRIMARY KEY (`N_Article`)
          ) ENGINE=InnoDB DEFAULT CHARSET=utf8;"
         );
          hms.ExecuteQuery(
           @"CREATE TABLE `Client` (
            `N_Client` int(50) NOT NULL AUTO_INCREMENT,
            `Nom` varchar(50) DEFAULT NULL,
            `Adresse` varchar(50) DEFAULT NULL,
            `RC` varchar(50) DEFAULT NULL,
            `Mat_Fiscal` varchar(50) DEFAULT NULL,
             PRIMARY KEY (`N_Client`)
          ) ENGINE=InnoDB DEFAULT CHARSET=utf8;"
        );
          hms.ExecuteQuery(
          @"CREATE TABLE `Facture` (
            `N_Fact` int(50) NOT NULL AUTO_INCREMENT,
            `N_client` int,
            `date_facture` date DEFAULT NULL,
            `TTC_global` varchar(50) DEFAULT NULL,
             PRIMARY KEY (`N_Fact`),
             FOREIGN KEY (`N_client`) REFERENCES Client(`N_client`)
             ON DELETE CASCADE
          ) ENGINE=InnoDB DEFAULT CHARSET=utf8;"
       );
          hms.ExecuteQuery(
         @"CREATE TABLE `Details` (
            `N_Fact` int,
            `N_Article` int,
            `Qte_vente` varchar(50) DEFAULT NULL,
            `HT` varchar(50) DEFAULT NULL,
            `TVA` varchar(50) DEFAULT NULL,
            `TTC` varchar(50) DEFAULT NULL,
             PRIMARY KEY (`N_Fact`,`N_Article`),
             FOREIGN KEY (`N_Fact`) REFERENCES Facture(`N_Fact`)
             ON DELETE CASCADE,
             FOREIGN KEY (`N_Article`) REFERENCES Article(`N_Article`)
             ON DELETE CASCADE
          ) ENGINE=InnoDB DEFAULT CHARSET=utf8;"
      );*/
      Frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
      Frame.Navigate(new ArticlePage());
    }

    private void Facture_Click(object sender, RoutedEventArgs e)
    {
      Frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
      Frame.Navigate(new FacturePage(""));
    }

    private void Client_Click(object sender, RoutedEventArgs e)
    {
      Frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
      Frame.Navigate(new ClientPage());
    }

    private void Article_Click(object sender, RoutedEventArgs e)
    {
      Frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
      Frame.Navigate(new ArticlePage());
    }
  }
}