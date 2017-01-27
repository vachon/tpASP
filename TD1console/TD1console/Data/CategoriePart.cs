using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TD1console.Data

{
    public partial class Categorie
    {
        public static void Exo2qCount()
        {
            using (var ctx = new FilmDbContext())
            {
                Console.WriteLine(ctx.Categories.Count()); 
            }
        }
        public override string ToString()
        {
            return this.id + " titre :" + this.nom;
        }
    }
}
