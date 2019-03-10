using System;
using System.Windows;
using System.Windows.Controls;
using FacturationMiniProjet.Controllers;

namespace FacturationMiniProjet.Article
{
  /// <summary>
  ///   Interaction logic for ArticlePage.xaml
  /// </summary>
  public partial class ArticlePage : Page
  {
    HelperMySQL msh = new HelperMySQL();
    int primary = 0;

    public ArticlePage()
    {
      InitializeComponent();
      msh.LoadData("select * from article", dataGridView3);
    }

    private void dataGridView3_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      try
      {
        DataGridCellInfo cell0 = dataGridView3.SelectedCells[0];
        primary = Convert.ToInt32(((TextBlock) cell0.Column.GetCellContent(cell0.Item)).Text);

        DataGridCellInfo cell2 = dataGridView3.SelectedCells[1];
        Libelle.Text = ((TextBlock) cell2.Column.GetCellContent(cell2.Item)).Text;

        DataGridCellInfo cell3 = dataGridView3.SelectedCells[2];
        PrixUnit.Text = ((TextBlock) cell3.Column.GetCellContent(cell3.Item)).Text;

        DataGridCellInfo cell4 = dataGridView3.SelectedCells[3];
        TVA.Text = ((TextBlock) cell4.Column.GetCellContent(cell4.Item)).Text;
      }
      catch (Exception)
      {
      }
    }

    private void Ajouter_Click(object sender, RoutedEventArgs e)
    {
      msh.ExecuteQuery(@"INSERT INTO `article` (`Libelle`, `Prix_unit`, `TVA`) VALUES ('" + Libelle.Text + "', '" +
                       PrixUnit.Text + "', '" + TVA.Text + "');");
      msh.LoadData("select * from article", dataGridView3);
    }

    private void Modifier_Click(object sender, RoutedEventArgs e)
    {
      msh.ExecuteQuery(@"UPDATE `article` SET `Libelle`='" + Libelle.Text + "',`Prix_unit`='" + PrixUnit.Text +
                       "',`TVA`='" + TVA.Text + "' WHERE `N_Article`= " + primary + "");
      msh.LoadData("select * from article", dataGridView3);
    }

    private void Supprimer_Click(object sender, RoutedEventArgs e)
    {
      msh.ExecuteQuery(@"DELETE FROM `article` WHERE `N_Article`= " + primary + "");
      msh.LoadData("select * from article", dataGridView3);
    }

    private void Rechercher_Click(object sender, RoutedEventArgs e)
    {
      msh.LoadData("select * from Article where libelle like '%" + inputRecherche.Text + "%'", dataGridView3);
    }
  }
}