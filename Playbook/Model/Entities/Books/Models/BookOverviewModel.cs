using System.Data;
using Model.Entities.Sections.RuleSections;
using Model.Entities.Sections.StorySections;

namespace Model.Entities.Books.Models; 

public class BookOverviewModel {
    public Book Book { get; set; } = new();
    public List<RuleSection> RuleSections { get; set; } = new();
    public List<StorySection> StorySections { get; set; } = new();
}