using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TD1console.Data
{
    public partial class Film
    {
        public static void Exo2qAllMovie()
        {
            using (var ctx = new FilmDbContext())
            {
                foreach (var u in ctx.Films)
                {
                    Console.WriteLine(u);
                }
            }

        }

        public static void Exo2qRecherche()
        {
            using (var ctx = new FilmDbContext())
            {
                foreach (var u in ctx.Films)
                {
                    if (u.nom.StartsWith("Ve"))
                    {
                        Console.WriteLine(u);
                    }
                }
            }

        }
        public static void Exo2qIdAction()
        {
            using (var ctx = new FilmDbContext())
            {
                foreach (var u in ctx.Films.Where(q => q.categorie == 1)){
                    Console.WriteLine(u);
                }
            }
                
        }

        public static void Exo2qPulp(String titre)
        {
            int nbAvis = 0;
            Double totalNote = 0;
            using (var ctx = new FilmDbContext())
            {
                foreach (var f in ctx.Films)
                {
                    if (titre.ToUpper() == f.nom.ToUpper())
                    {
                        foreach (var a in f.Avis)
                        {
                            nbAvis++;
                            totalNote += a.note;
                        }
                        break;
                    }
                }
            }
            Console.WriteLine(titre + "'s Avis Mean: {0}", (totalNote / nbAvis));
        }
        public override string ToString()
        {
            return this.id + " titre :" + this.nom;
        }
    }
}
