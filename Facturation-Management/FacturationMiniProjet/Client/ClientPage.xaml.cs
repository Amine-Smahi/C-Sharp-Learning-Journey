using System;
using System.Windows;
using System.Windows.Controls;
using FacturationMiniProjet.Controllers;
using FacturationMiniProjet.Facture;

namespace FacturationMiniProjet.Client
{
  /// <summary>
  ///   Interaction logic for ArticlePage.xaml
  /// </summary>
  public partial class ClientPage : Page
  {
    HelperMySQL msh = new HelperMySQL();
    int primary = 0;

    public ClientPage()
    {
      InitializeComponent();
      msh.LoadData("select * from client", dataGridView3);
    }

    private void dataGridView3_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      try
      {
        DataGridCellInfo cell0 = dataGridView3.SelectedCells[0];
        primary = Convert.ToInt32(((TextBlock) cell0.Column.GetCellContent(cell0.Item)).Text);

        DataGridCellInfo cell2 = dataGridView3.SelectedCells[1];
        Nom.Text = ((TextBlock) cell2.Column.GetCellContent(cell2.Item)).Text;

        DataGridCellInfo cell3 = dataGridView3.SelectedCells[2];
        Adresse.Text = ((TextBlock) cell3.Column.GetCellContent(cell3.Item)).Text;

        DataGridCellInfo cell4 = dataGridView3.SelectedCells[3];
        RC.Text = ((TextBlock) cell4.Column.GetCellContent(cell4.Item)).Text;

        DataGridCellInfo cell5 = dataGridView3.SelectedCells[4];
        Mat_Fiscals.Text = ((TextBlock) cell5.Column.GetCellContent(cell5.Item)).Text;
      }
      catch (Exception)
      {
      }
    }

    private void Ajouter_Click(object sender, RoutedEventArgs e)
    {
      msh.ExecuteQuery(@"INSERT INTO `client` (`Nom`, `Adresse`, `RC`, `Mat_Fiscal`) VALUES ('" + Nom.Text + "', '" +
                       Adresse.Text + "', '" + RC.Text + "', '" + Mat_Fiscals.Text + "');");
      msh.LoadData("select * from client", dataGridView3);
    }

    private void Modifier_Click(object sender, RoutedEventArgs e)
    {
      msh.ExecuteQuery(@"UPDATE `client` SET `Nom`='" + Nom.Text + "',`Adresse`='" + Adresse.Text + "',`RC`='" +
                       Adresse.Text + "',`Mat_Fiscal`='" + Mat_Fiscals.Text + "' WHERE `N_Client`='" + primary + "'");
      msh.LoadData("select * from client", dataGridView3);
    }

    private void Supprimer_Click(object sender, RoutedEventArgs e)
    {
      msh.ExecuteQuery(@"DELETE FROM `article` WHERE `N_Article`= " + primary + "");
      msh.LoadData("select * from client", dataGridView3);
    }

    private void Rechercher_Click(object sender, RoutedEventArgs e)
    {
      msh.LoadData("select * from client where nom like '%" + inputRecherche.Text + "%'", dataGridView3);
    }

    private void Facture_Click(object sender, RoutedEventArgs e)
    {
      FacturePage af = new FacturePage(primary.ToString());
      this.NavigationService.Navigate(af);
    }
  }
}