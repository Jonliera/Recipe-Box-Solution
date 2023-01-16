using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public int RecipeId { get; set; }
    public string RecipeName { get; set; }
    public string Ingredients { get; set; }
    public string Instructions { get; set; }
    public double Rating { get; set; }
    public List<RecipeTag> JoinEntities { get; set; }
    public ApplicationUser User { get; set; }
  }
}