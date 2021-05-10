using System;
using System.Collections.Generic;
using System.IO;

namespace FriendConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] temp;
            string[] index = File.ReadAllLines(@"H:\H-temp\chegg\index.txt");

            List<string> friendIndex = new List<string>();

            for (i= 1; i < index.Length; i++)
            {
                temp = index[i].Split(' ');
                friendIndex.Add(temp[1]);
            }

            int t1,t2;
            string[] frd = File.ReadAllLines(@"H:\H-temp\chegg\friends.txt");

            List<List<int>> frdIndex = new List<List<int>>();

            //initialise list empty
            for (i = 1; i <= frd.Length; i++)
            {
                frdIndex.Add(new List<int>());
            }


            for (i = 1; i < frd.Length; i++)
            {
                temp = frd[i].Split(' ');
                t1 = Convert.ToInt32(temp[0]);
                t2 = Convert.ToInt32(temp[1]);
                frdIndex[t1].Add(t2);
            }

            while (true)
            {
                Console.WriteLine("\n------------------------\n" +
                "Select one option :" +
                "\n1. friends " +
                "\n2. friends number " +
                "\n3. Exit" +
                "\n-----------");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    int k = 0;
                    foreach (var person in frdIndex)
                    {
                        foreach (var f in person)
                        {
                            Console.WriteLine("{0} is friends with {1}", friendIndex[k], friendIndex[f]);
                        }
                        k++;
                    }
                }
                else if (input == 2)
                {
                    for(i = 0; i < index.Length-1; i++)
                    {
                        Console.WriteLine("{0} has {1} friends", friendIndex[i], frdIndex[i].Count);
                    }

                }
                else
                {
                    break;
                }
            }

        }
    }
}
