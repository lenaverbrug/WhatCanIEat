using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspIdentityServer.data
{
    public class Ingredient
    {
      public int ingredientID { get; set; }
      public string Name { get; set; }
      public string Group { get; set; }
      public string Allergen { get; set; }
      public bool isSafe { get; set; }
    }
}
