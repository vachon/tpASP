using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD1console.Data;

namespace TD1console
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Film.Exo2qAllMovie();
            Utilisateur.Exo2qEmail();
            Utilisateur.Exo2qAllog();
            Film.Exo2qIdAction();
            Categorie.Exo2qCount();
            Avi.Exo2qNote();
            Film.Exo2qRecherche();
            Film.Exo2qPulp("Pulp Fiction");
            Utilisateur.Exo2qMax();

            stopwatch.Stop();

            Console.WriteLine("temps"+stopwatch.Elapsed);
            Console.ReadKey();
        }
    }
}
