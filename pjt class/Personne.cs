using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjt_class
{
    public class Personne
    {
        public Personne(string n, string p, int a, string v)
        {
            nom = n;
            prenom = p;
            age = a;
            ville = v;
        }
        public Personne() { }//constructeur par defeau

        public string nom;
        public string prenom;
        public int age;
        public string ville;

        public String Affichage1()
        {
            String s = "   Je m’appelle    " + nom + "      " + prenom + "   J’ai  " + age + " ans   J’habite à   " + ville;
            return s;

        }
        public void Affichage2()
        {
            String s = "   Je m’appelle    " + nom + "      " + prenom + "   J’ai  " + age + " ans   J’habite à   " + ville;
            Console.WriteLine(s);
           
        }
    }
}
