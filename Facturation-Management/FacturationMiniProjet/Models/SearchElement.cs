namespace FacturationMiniProjet.Models
{
  public class SearchElement
  {
    public string filter = "";
    public string value = "";

    public SearchElement(string filter, string value)
    {
      this.filter = filter;
      this.value = value;
    }
  }
}