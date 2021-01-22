using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace AntonPaarTask
{
    class Program
    {
      
        static void Main(string[] args)
        {
            

            //loading File 
          string filePath = @"../../Data/Sample.txt";
          string filePathWrite = @"../../Data/Ergebnis.txt";

        //List<string> lines = File.ReadAllLines(filePath).ToList();
        StreamReader sr = new StreamReader(filePath);  
            string text = System.IO.File.ReadAllText(filePath);

            //Regex to Remove all non char 
            Regex reg_exp = new Regex("[^a-zA-Z]");
            text = reg_exp.Replace(text, " ");

            // Split by Space 
            string[] words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            

            //select Uniqe words LINQ 
            var word_query = (from string word in words orderby word select word).Distinct();   
            
            string[] result = word_query.ToArray();  
            int counter = 0;  
            string delim = " ,.";  
            string[] fields = null;  
            string line = null;  
        while (!sr.EndOfStream) {  
            line = sr.ReadLine(); //each time you read a line you should split it into the words  
            line.Trim();  
           fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);  
            counter += fields.Length; //and just add how many of them there is  
             
        }

        //Write into Console to verify
            Console.WriteLine("Wort || Anzal");
            Console.WriteLine("=========================");
        
            //write into another file 
            using (StreamWriter outputFile = new StreamWriter(filePathWrite, true))
            {
                outputFile.WriteLine("Wort                  Anzal");
                outputFile.WriteLine("============================");
                outputFile.Close();
            }

            foreach (string word in result)
            {

                CountString(text, word);
            }
            sr.Close();  


        }

        //Count the frequency of each unique word.  
        public static void CountString(string text, string word)
        {
            string filePathWrite = @"../../Data/Ergebnis.txt";
            // StreamWriter outputFile = new StreamWriter(filePathWrite);

            // File.WriteAllLines(filePathWrite, lines);
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(word, i)) != -1)
            {
                i += word.Length;
                count++;
            }
            Console.WriteLine("{0}                  {1}", word, count);

            using (StreamWriter outputFile = new StreamWriter(filePathWrite,true))
            {
                outputFile.WriteLine("{0}                   {1}", word, count);
            }
          

        }
    }
}
