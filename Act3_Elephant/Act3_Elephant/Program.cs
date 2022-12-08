using System;

namespace Act3_Elephant 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans cet échange d'éléphants");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("1 : Afficher les informations de Zazou.");
            Console.WriteLine("2 : Afficher les informations de Titi.");
            Console.WriteLine("3 : échanger les informations de Zazou et Titi");
            Console.WriteLine("4 : Voir le transfert d'un message de Zazou à Titi");
            Console.WriteLine("5 : Réviser la notion de tableaux et l'appliquer à des objets");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            Elephant elephant1 = new Elephant("Zazou", 67);
            Elephant elephant2 = new Elephant("Titi", 96);

            string message = " hallo!!! il y a quelqu'un ??";

            int reload = 5;
            while(reload == 5)
            {
                Console.WriteLine("Entrer un nombre !! (1 à 5)");
                int nbrInstruction = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (nbrInstruction == 1){
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    Console.WriteLine(elephant1.WhoIAm());
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (nbrInstruction == 2){
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    Console.WriteLine(elephant2.WhoIAm());
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if(nbrInstruction == 3){
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    Console.WriteLine(elephant1.Nom + " :");
                    Elephant echange = elephant1;
                    elephant1 = elephant2;
                    Console.WriteLine(elephant1.WhoIAm());

                    Console.WriteLine();

                    Console.WriteLine(elephant2.Nom + " :");
                    elephant2 = echange;
                    Console.WriteLine(elephant2.WhoIAm());

                    //terminer
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (nbrInstruction == 4){
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    elephant1.EnvoieMessage(message, elephant1);

                    Console.WriteLine();

                    elephant2.EnvoieMessage(message, elephant2);
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }
                else if (nbrInstruction == 5){
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    TableauElephant();
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();

            static void TableauElephant(){

                Elephant[] NewElephants = new Elephant[10];
                NewElephants[0] = new Elephant("fred",67);
                NewElephants[1] = new Elephant("tony",37);
                NewElephants[2] = new Elephant("mike",27);
                NewElephants[3] = new Elephant("kim",90);
                NewElephants[4] = new Elephant("tom",37);
                NewElephants[5] = new Elephant("gianluca",62);
                NewElephants[6] = new Elephant("alain",29);
                NewElephants[7] = new Elephant("christelle",12);
                NewElephants[8] = new Elephant("clemence",2);
                NewElephants[9] = new Elephant("lea",4);

                NewElephants[0].PlusGrandeOreille(NewElephants, out string grandOreille);
                Console.WriteLine(grandOreille);
            }
        }
    }
}