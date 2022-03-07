using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.nom = "Yuouness";
            p1.prenom = "EL MODAHHAB";
            p1.age = 22;
            p1.ville = "casa";

            Personne p2 = new Personne();
            Console.Write("donner le nom: ");
            p2.nom = Console.ReadLine();
            Console.Write("donner le prenom: ");
            p2.prenom = Console.ReadLine();
            Console.Write("donner l'age: ");
            p2.age = int.Parse(Console.ReadLine());
            Console.Write("donner la ville: ");
            p2.ville = Console.ReadLine();

            Console.WriteLine(p1.Affichage1());
            
            p2.Affichage2();


            Personne p3 = new Personne("YNS","ELMO",30, "fes");
            p3.Affichage2();




            Console.ReadKey();
        }

    }
}
