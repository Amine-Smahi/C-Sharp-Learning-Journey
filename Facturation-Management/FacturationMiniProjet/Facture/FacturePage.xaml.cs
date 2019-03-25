using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using FacturationMiniProjet.Controllers;
using FacturationMiniProjet.Models;

namespace FacturationMiniProjet.Facture
{
  /// <summary>
  ///   Interaction logic for ArticlePage.xaml
  /// </summary>
  public partial class FacturePage : Page
  {
    HelperMySQL msh = new HelperMySQL();
    string numArticle = "0";
    int primary = 0;

    public FacturePage(string client)
    {
      InitializeComponent();
      Client = client;
      msh.FillDropDownList("select Nom from client", Nom_client, "Nom");
      msh.FillDropDownList2("select Libelle from `article`", libelle, "Libelle");

      date_debut.SelectedDate = DateTime.Today.AddDays(-1);
      date_fin.SelectedDate = DateTime.Today.AddDays(-1);
    }

    public string Nom { get; set; }
    public string DateDebut { get; set; }
    public string DateFin { get; set; }
    public string Montant { get; set; }
    public string Client { get; set; }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
      if (Client == "")
      {
        msh.LoadData(
          "SELECT * FROM `facture`,`Client` Where facture.N_Client = client.N_Client",
          dataGridView3);
      }
      else
      {
        msh.LoadData(
          "SELECT * FROM `facture`,`Client` Where facture.N_Client = client.N_Client and Client.N_Client='" +
          Client + "'", dataGridView3);
      }
    }

    private void dataGridView3_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      try
      {
        DataGridCellInfo cell0 = dataGridView3.SelectedCells[0];
        primary = Convert.ToInt32(((TextBlock) cell0.Column.GetCellContent(cell0.Item)).Text);

        DataGridCellInfo cell1 = dataGridView3.SelectedCells[1];
        Nom_client.Text = ((TextBlock) cell1.Column.GetCellContent(cell1.Item)).Text;

        DataGridCellInfo cell3 = dataGridView3.SelectedCells[2];
        date_facture.Text = ((TextBlock) cell3.Column.GetCellContent(cell3.Item)).Text;

        msh.LoadData(
          "SELECT * FROM `details`, `article` Where article.N_Article = details.N_Article and details.N_Fact = '" +
          primary + "'",
          dataGridView4);
        TTC_global.Text = msh.getValue("select ttc_global from facture where N_Fact = '" + primary + "'",
        "ttc_global");
      }
      catch (Exception)
      {
        //   MessageBox.Show(ex.Message);
      }
    }

    private void Ajouter_Click(object sender, RoutedEventArgs e)
    {
      string result = msh.getValue("select N_Client from client where Nom = '" + Nom_client.SelectedValue + "'",
        "N_Client");

      primary = int.Parse(
        msh.getValue(
          "INSERT INTO `facture` (`N_Fact`, `N_client`, `date_facture`) VALUES (NULL, '" + result + "', '" +
          date_facture.SelectedDate.Value.ToString("yyyy-MM-dd") + "');SELECT LAST_INSERT_ID();", "LAST_INSERT_ID()"));

      msh.LoadData(
        "SELECT * FROM `facture`,`Client` Where facture.N_Client = client.N_Client",
        dataGridView3);
    }

    private void Modifier_Click(object sender, RoutedEventArgs e)
    {
      string result = msh.getValue("select N_Client from client where Nom = '" + Nom_client.SelectedValue + "'",
        "N_Client");
      msh.ExecuteQuery("UPDATE `facture` SET `N_client`=" + result + ",`date_facture`=" +
                       date_facture.SelectedDate.Value.ToString("yyyy-MM-dd") + " WHERE `N_Fact`='" + primary + "'");
      msh.LoadData(
        "SELECT * FROM `facture`,`Client` Where facture.N_Client = client.N_Client",
        dataGridView3);
    }

    private void Supprimer_Click(object sender, RoutedEventArgs e)
    {
      msh.ExecuteQuery(@"DELETE FROM `facture` WHERE `N_Fact`='" + primary + "'");
      msh.ExecuteQuery(@"DELETE FROM `details` WHERE `N_Fact`='" + primary + "'");
      msh.LoadData(
        "SELECT * FROM `facture`,`Client` Where facture.N_Client = client.N_Client",
        dataGridView3);
    }


    private void libelle_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      prixUnit.Text = msh.getValue("select Prix_unit from article where Libelle = '" + libelle.SelectedValue + "'",
        "Prix_unit");
    }

    private string calculateHT()
    {
      return (decimal.Parse(prixUnit.Text) * decimal.Parse(QteVente.Text)).ToString();
    }

    private string calculateTTC()
    {
      decimal ht = decimal.Parse(calculateHT());
      return (ht + (ht * decimal.Parse("19"))).ToString();
    }

    private void dataGridView4_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      DataGridCellInfo cell4 = dataGridView4.SelectedCells[0];
      numArticle = ((TextBlock) cell4.Column.GetCellContent(cell4.Item)).Text;

      DataGridCellInfo cell5 = dataGridView4.SelectedCells[1];
      libelle.Text = ((TextBlock) cell5.Column.GetCellContent(cell5.Item)).Text;

      DataGridCellInfo cell6 = dataGridView4.SelectedCells[2];
      prixUnit.Text = ((TextBlock) cell6.Column.GetCellContent(cell6.Item)).Text;

      DataGridCellInfo cell8 = dataGridView4.SelectedCells[5];
      QteVente.Text = ((TextBlock) cell8.Column.GetCellContent(cell8.Item)).Text;
    }

    private void AjouterDetails_Click(object sender, RoutedEventArgs e)
    {
      string result2 = msh.getValue("select N_Article from Article where Libelle = '" + libelle.SelectedValue + "'",
        "N_Article");
      msh.ExecuteQuery("INSERT INTO `details`(`N_Fact`, `N_Article`, `Qte_vente`,`HT`, `TTC`) VALUES ('" +
                       primary + "','" + result2 + "','" + QteVente.Text + "','" + calculateHT() + "','" +
                       calculateTTC() + "')");
      msh.LoadData(
        "SELECT * FROM `details`, `article` Where article.N_Article = details.N_Article and details.N_Fact = '" +
        primary + "'",
        dataGridView4);
    }

    private void ModifierDetails_Click(object sender, RoutedEventArgs e)
    {
      string result = msh.getValue("select N_Article from Article where Libelle = '" + libelle.SelectedValue + "'",
        "N_Article");
      msh.ExecuteQuery("UPDATE `details` SET `N_Article`='" + result + "',`Qte_vente`='" + QteVente.Text + "', `HT`='" +
                       calculateHT() + "',`TTC`='" + calculateTTC() + "' WHERE N_Fact='" + primary +
                       "' and N_Article='" + numArticle + "'");
      msh.LoadData(
        "SELECT * FROM `details`, `article` Where article.N_Article = details.N_Article and details.N_Fact = '" +
        primary + "'",
        dataGridView4);
    }

    private void SupprimerDetailss_Click(object sender, RoutedEventArgs e)
    {
      msh.ExecuteQuery(@"DELETE FROM `details` WHERE `N_Fact`='" + primary + "' and N_Article = '" + numArticle + "'");
      msh.LoadData(
        "SELECT * FROM `details`, `article` Where article.N_Article = details.N_Article and details.N_Fact = '" +
        primary + "'",
        dataGridView4);
    }


    private void searchSelectedDateChanged(object sender, SelectionChangedEventArgs e)
    {
      Search();
    }

    private void inputRecherche_TextChanged(object sender, TextChangedEventArgs e)
    {
      Search();
    }

    public void Search()
    {
      try
      {
        Nom = rechrecheNom.Text;
        DateDebut = date_debut.SelectedDate.Value.ToString("yyyy-MM-dd");
        DateFin = date_fin.SelectedDate.Value.ToString("yyyy-MM-dd");
        Montant = inputMontant.Text;

        List<SearchElement> SearchElement = new List<SearchElement>
        {
          new SearchElement(" client.nom like '%" + Nom + "%'", Nom),
          new SearchElement(" facture.date_facture between '" + DateDebut + "' and '" + DateFin + "'", DateDebut),
          new SearchElement(" facture.ttc_global > " + Montant + "", Montant),
        };
        string SearchqQuery = "SELECT * FROM `facture`, `article`,`details`,`Client` Where ";
        List<string> SearchFound = new List<string> { };
        for (int i = 0; i < SearchElement.Count; i++)
        {
          if (SearchElement[i].value != "" && SearchElement[i].value != null)
          {
            SearchqQuery += SearchElement[i].filter + " and ";
          }
        }

        SearchqQuery +=
          " facture.N_Fact = details.N_Fact and article.N_Article = details.N_Article and facture.N_Client = client.N_Client";

        msh.LoadData(SearchqQuery, dataGridView3);
      }
      catch (Exception)
      {
      }
    }
  }
}