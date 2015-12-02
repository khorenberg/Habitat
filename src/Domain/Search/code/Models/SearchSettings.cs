namespace Sitecore.Feature.Search.Models
{
  using Sitecore.Data.Items;
  using Sitecore.Framework.Indexing.Models;

  public class SearchSettings : ISearchSettings
  {
    public Item ConfigurationItem { get; set; }
    public string Query { get; set; }
    public string SearchBoxTitle { get; set; }
    public string SearchResultsUrl { get; set; }
    public Item Root { get; set; }
  }
}