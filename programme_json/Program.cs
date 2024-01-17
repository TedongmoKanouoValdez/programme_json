using Newtonsoft.Json;
using System;
using System.Net.Mail;
using System.Threading.Channels;

namespace programme_json
{
    class Personne
    {
        public string nom;
        //public string nom { get; private set; }

        public int age;
        /* public int age { get; private set; }*/

        public bool majeur;
        //public bool majeur { get; private set; }

        /* public Personne(string nom, int age, bool majeur)
         {
             this.nom = nom;
             this.age = age;
             this.majeur = majeur;
         }*/

        public void Afficher()
        {
            Console.WriteLine("Nom : " +nom+ " - age : " +age+ "ans");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var personne1 = new Personne();
            personne1.Afficher();
            personne1.nom = "Val";
            personne1.age = 22;
            personne1.majeur = true;
            personne1.Afficher();
            Console.WriteLine();

            //serialiser les données
            string json = JsonConvert.SerializeObject(personne1);
            Console.WriteLine(json);

            List<string> noms = new List<string>() { "val", "leila", "kim", "billie" };
            string jsonListe = JsonConvert.SerializeObject(noms);
            Console.WriteLine(jsonListe);

            //deserialiser les données
            string jsonVal = "{\"nom\":\"Val\",\"age\":22,\"majeur\":false}";
            Personne val = JsonConvert.DeserializeObject<Personne>(jsonVal);
            val.Afficher();

           /* var personnes = new List<Personne>()
             {
                 new Personne ("val",22,true),
                 new Personne ("leila",21,true),
                 new Personne ("kim",23,true),
                 new Personne ("billie",20,false),
             };

            string json = JsonConvert.SerializeObject(personnes);
            Console.WriteLine(json);*/

            //ecrire le json dans un fichier
            File.WriteAllText("personne.txt", json);

            // lire le json à partir du fichier
            // Creer vos personnes à partir du json (deserialise)
            // Afficher les personnes

            /*string json = File.ReadAllText("personne.txt");
            var personne = JsonConvert.DeserializeObject<List<Personne>>(json);
            foreach(var personnes in personne)
            {
                personnes.Afficher();
            }*/

        } 

    }
}
