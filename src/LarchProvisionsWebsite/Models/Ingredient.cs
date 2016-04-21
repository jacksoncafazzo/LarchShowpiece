using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LarchProvisionsWebsite.Models
{
    [Table("Ingredients")]
    public class Ingredient
    {
        //private LarchProvisionsDbContext db = new LarchProvisionsDbContext();

        [Key]
        public int IngredientId { get; set; }

        public string Name { get; set; }

        public string Source { get; set; }

        public double Amount { get; set; }

        public string Unit { get; set; }

        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }

        [NotMapped]
        public virtual Recipe Recipe { get; set; }

        public double SingleServing()
        {
            if (RecipeId != 0)
            {
                //Recipe recipe = db.Recipe.Find(RecipeId);

                double singleServing = this.Amount / Recipe.Servings;
                return singleServing;
            }
            else
            {
                return 0;
            }
        }

        /*Truncate the ingredient return amounts */

        public string ChopNumbers(double n)
        {
            return n.ToString("0.##");
        }
    }
}