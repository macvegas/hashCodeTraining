using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaHashCode
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string inputFile = "3 5 1 6\nTTTTT\nTMMMT\nTTTTT";
            

            //stockage des données dans les différents variables
            string[] lines = inputFile.Split('\n');
            string[] vars = lines[0].Split(' ');

            string one = vars[0];
            int rows = int.Parse(one);

            string two = vars[1];
            int columns = int.Parse(two);

            string three = vars[2];
            int minIngr = int.Parse(three);

            string four = vars[3];
            int maxCells = int.Parse(four);

            //boucles de mise en place de la pizza dans un tableau
            char[,] pizza = new char[rows, columns];
            int Mnb=0, Tnb=0;
            for (int i = 0; i <rows ; i++)
            {
                var ligne = lines[i + 1].ToCharArray();
                for (int j = 0; j <columns ; j++)
                {
                    if (ligne[j] == 'T') Tnb++;
                    else Mnb++;
                    pizza[i, j] = ligne[j];
                }
            }
            Console.Write("Tomatoes: "+ Tnb.ToString() +" Mushrooms: "+ Mnb);

        

            Console.ReadKey();
        }
    }
}
