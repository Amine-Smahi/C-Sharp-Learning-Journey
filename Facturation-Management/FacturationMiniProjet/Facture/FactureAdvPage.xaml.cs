using System;
using System.Windows;
using System.Windows.Controls;
using FacturationMiniProjet.Controllers;

namespace FacturationMiniProjet.Facture
{
  /// <summary>
  ///   Interaction logic for ArticlePage.xaml
  /// </summary>
  public partial class FactureAdvPage : Page
  {
    HelperMySQL msh = new HelperMySQL();
    int primary = 0;

    public FactureAdvPage(string client)
    {
      InitializeComponent();
      date_debut.SelectedDate = DateTime.Today.AddDays(-1);
      date_fin.SelectedDate = DateTime.Today.AddDays(-1);
      if (client == "")
      {
        msh.LoadData(
          "SELECT * FROM `facture`, `article`,`details`,`Client` Where facture.N_Fact = details.N_Fact and article.N_Article = details.N_Article and facture.N_Client = client.N_Client",
          dataGridView3);
      }
      else
      {
        msh.LoadData(
          "SELECT * FROM `facture`, `article`,`details`,`Client` Where facture.N_Fact = details.N_Fact and article.N_Article = details.N_Article and facture.N_Client = client.N_Client and Client.N_Client='" +
          client + "'", dataGridView3);
      }

      msh.FillDropDownList("select Nom from client", Nom_client, "Nom");
      msh.FillDropDownList2("select Libelle from `article`", libelle, "Libelle");
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

        DataGridCellInfo cell4 = dataGridView3.SelectedCells[3];
        TTC_global.Text = ((TextBlock) cell4.Column.GetCellContent(cell4.Item)).Text;

        DataGridCellInfo cell5 = dataGridView3.SelectedCells[4];
        libelle.Text = ((TextBlock) cell5.Column.GetCellContent(cell5.Item)).Text;

        DataGridCellInfo cell6 = dataGridView3.SelectedCells[5];
        prixUnit.Text = ((TextBlock) cell6.Column.GetCellContent(cell6.Item)).Text;

        DataGridCellInfo cell7 = dataGridView3.SelectedCells[6];
        TVA.Text = ((TextBlock) cell7.Column.GetCellContent(cell7.Item)).Text;

        DataGridCellInfo cell8 = dataGridView3.SelectedCells[7];
        QteVente.Text = ((TextBlock) cell8.Column.GetCellContent(cell8.Item)).Text;
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
      string result2 = msh.getValue("select N_Article from Article where Libelle = '" + libelle.SelectedValue + "'",
        "N_Article");
      string fact_id =
        msh.getValue(
          "INSERT INTO `facture` (`N_Fact`, `N_client`, `date_facture`) VALUES (NULL, '" + result + "', '" +
          date_facture.SelectedDate.Value.ToString("yyyy-MM-dd") + "');SELECT LAST_INSERT_ID();", "LAST_INSERT_ID()");
      msh.ExecuteQuery("INSERT INTO `details`(`N_Fact`, `N_Article`, `Qte_vente`,`HT`, `TVA`, `TTC`) VALUES ('" +
                       fact_id + "','" + result2 + "','" + QteVente.Text + "','" + calculateHT() + "','" + TVA.Text +
                       "','" + calculateTTC() + "')");
      msh.LoadData(
        "SELECT * FROM `facture`, `article`,`details`,`Client` Where facture.N_Fact = details.N_Fact and article.N_Article = details.N_Article and facture.N_Client = client.N_Client",
        dataGridView3);
    }

    private void Modifier_Click(object sender, RoutedEventArgs e)
    {
      string result = msh.getValue("select N_Client from client where Nom = '" + Nom_client.SelectedValue + "'",
        "N_Client");
      msh.ExecuteQuery("UPDATE `facture` SET `N_client`=" + result + ",`date_facture`=" +
                       date_facture.SelectedDate.Value.ToString("yyyy-MM-dd") + " WHERE `N_Fact`='" + primary + "'");
      msh.ExecuteQuery("UPDATE `details` SET `N_Article`='" + result + "',`Qte_vente`='" + QteVente.Text + "' `HT`='" +
                       calculateHT() + "',`TVA`='" + TVA.Text + "',`TTC`='" + calculateTTC() + "' WHERE `N_Fact`='" +
                       primary + "'");
      msh.LoadData(
        "SELECT * FROM `facture`, `article`,`details`,`Client` Where facture.N_Fact = details.N_Fact and article.N_Article = details.N_Article and facture.N_Client = client.N_Client",
        dataGridView3);
    }

    private void Supprimer_Click(object sender, RoutedEventArgs e)
    {
      msh.ExecuteQuery(@"DELETE FROM `facture` WHERE `N_Fact`='" + primary + "'");
      msh.ExecuteQuery(@"DELETE FROM `details` WHERE `N_Fact`='" + primary + "'");
      msh.LoadData(
        "SELECT * FROM `facture`, `article`,`details`,`Client` Where facture.N_Fact = details.N_Fact and article.N_Article = details.N_Article and facture.N_Client = client.N_Client",
        dataGridView3);
    }

    private void Rechercher_Click(object sender, RoutedEventArgs e)
    {
      if (rechrecheNom.Text == "")
      {
        msh.LoadData(
          "SELECT * FROM `facture`, `article`,`details`,`Client` Where facture.N_Fact = details.N_Fact and article.N_Article = details.N_Article and facture.N_Client = client.N_Client and facture.date_facture between '" +
          date_debut.SelectedDate.Value.ToString("yyyy-MM-dd") + "' and '" +
          date_fin.SelectedDate.Value.ToString("yyyy-MM-dd") + "'",
          dataGridView3);
      }
      else
      {
        msh.LoadData(
          "SELECT * FROM `facture`, `article`,`details`,`Client` Where facture.N_Fact = details.N_Fact and article.N_Article = details.N_Article and facture.N_Client = client.N_Client and facture.date_facture between '" +
          date_debut.SelectedDate.Value.ToString("yyyy-MM-dd") + "' and '" +
          date_fin.SelectedDate.Value.ToString("yyyy-MM-dd") + "' and  client.nom like '%" + rechrecheNom.Text + "%'",
          dataGridView3);
        montant_totale.Content = msh.getValue(
          "SELECT SUM(details.HT) FROM `facture`, `article`,`details`,`Client` Where facture.N_Fact = details.N_Fact and article.N_Article = details.N_Article and facture.N_Client = client.N_Client and facture.date_facture between '" +
          date_debut.SelectedDate.Value.ToString("yyyy-MM-dd") + "' and '" +
          date_fin.SelectedDate.Value.ToString("yyyy-MM-dd") + "' and  client.nom like '%" + rechrecheNom.Text + "%'",
          "SUM(details.HT)");
      }
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
      return (ht + (ht * decimal.Parse(TVA.Text))).ToString();
    }
  }
}