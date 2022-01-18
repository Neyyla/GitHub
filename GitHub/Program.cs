using System;

namespace GitHub
{
    class Program
    {
        static void Main(string[] args)

        {
            int choix = 0;
            int val1 = 0;
            int val2 = 0;
            int reponse;
            int solution;
        
            


            if (choix != 0)

                if (choix == 1)
                {
                    val1 = Random.Next(1, 10);
                    val2 = Random.Next(1, 10);

                    Console.WriteLine(val1 + " + " + val2 + " = ");
                    reponse = int.Parse(Console.ReadLine());

                    solution = val1 + val2;
                    if (reponse == solution)
                    {
                        Console.WriteLine("Bravo !");
                    }
                    else
                    {
                        Console.WriteLine("Faux : " + val1 + " + ");
                    }

                }
                else
                {
                    val1 = Random.Next(1, 10);
                    val2 = Random.Next(1, 10);

                    Console.Write(val1 + " x " + val2 + " = ");
                    reponse = int.Parse(Console.ReadLine());
                }
                
        
    

