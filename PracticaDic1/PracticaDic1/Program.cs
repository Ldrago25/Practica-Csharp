using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PracticaDic1
{
    class Program
    {
      
        static int result(string word,string comp)
        {
            bool flag = false;
           // Console.WriteLine(comp.Length);
           // Console.ReadKey();
            if(word.Length==comp.Length)
            {
                for(int i=0; i<word.Length; i++)
                {
                    for(int j=0; j<word.Length; j++)
                    {
                        if(word[i]==comp[j])
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }
                if (flag) return 1;
            }
            return 0;
        }
        static string correct(string word,string[] orde)
        {
            int sizedic = orde.Length;
            int sizedeso = word.Length;
            int con = 0;
            
            foreach (string comp in orde)
            {
                if(result(word,comp)==1)
                {
                    return comp;
                }
                
            }
            return word;
        }
        static void read(string file)
        {
            int idx = 1;
            int con = 0;
            string[] lines = File.ReadAllLines(file);
            int Cases = Int16.Parse(lines[0]);

            while(true)
            {
                string[] dic = lines[idx].Split(' ');
                idx++;
                string[] desor = lines[idx].Split(' ');
                idx++;
                con++;
                foreach(string word in desor)
                {
                    Console.Write(correct(word,dic)+" " );
                   // Console.WriteLine("Linea: " + word);
                }
                Console.WriteLine();
                if (Cases == con) break;
            }

        }
        static void Main(string[] args)
        {
            string file = "file.txt";
            read(file);
            Console.ReadKey();


        }
    }
}
