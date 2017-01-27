using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1console.Data
{
     public partial class Utilisateur
    {
        public override string ToString()
        {
            return this.id + " login : " + this.login  ;
        }

        public static void Exo2qEmail()
        {
            using (var ctx = new FilmDbContext())
            {
                foreach (var u in ctx.Utilisateurs)
                {
                    foreach(var a in u.email)
                    {
                        Console.Write(a);
                    }
                    Console.WriteLine("");
                }
            }
        }
    
        public static void Exo2qAllog()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            using (var ctx = new FilmDbContext())
            {

                foreach (var u in ctx.Utilisateurs.OrderBy(q => q.login))
                {
                    utilisateurs.Add(u);
                }
            }

            foreach (var u in utilisateurs)
            {
                Console.WriteLine(u.ToString());
            }
        }
        public static void Exo2qMax()
        {
            Console.WriteLine("\n=== Q9. USER WHO SET THE MINIMAL NOTE ===\n");
            using (var ctx = new FilmDbContext())
            {
                double note = 0;
                int userId = 0;
                Utilisateur utilisateur = new Utilisateur();

                foreach (var a in ctx.Avis)
                {
                    if (a.note > note)
                    {
                        note = a.note;
                        userId = a.utilisateur;
                    }
                }
                foreach (var u in ctx.Utilisateurs)
                {
                    if (u.id == userId)
                    {
                        utilisateur = u;
                        break;
                    }
                }

                Console.WriteLine("Best note: {0}\nSet by: {1}", note, utilisateur.ToString());
            }
        }
    }
}
