using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD1console.Data;


namespace TD1console.Data
{
    public partial class Avi
    {
        public static void Exo2qNote()
        {
            using (var ctx = new FilmDbContext())
            {
                Console.WriteLine(ctx.Avis.Min(q => q.note));
            }
        }




        public override string ToString()
        {
            return this.film + "  " + this.utilisateur + "  Avi : " + this.avis ;
        }
    }
}
