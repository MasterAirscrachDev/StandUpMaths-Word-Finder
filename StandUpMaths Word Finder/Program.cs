using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace StandUpMaths_Word_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //file
            //"C:\Users\Airsc\Downloads\words_alpha.txt"
            //find 5, 5 letter words with no matching letters
            //
            //run the task
            Yes();
        }

        static async Task Yes(){
            //not the time before starting
            var start = DateTime.Now;
            var file = File.ReadAllLines("\\StandUpMaths Word Finder\\words_alpha.txt");
            var words = file.Where(x => x.Length == 5).ToList();
            List<string> results = new List<string>();
            List<char> chars = new List<char>();
            for(int i = 0; i < words.Count; i++){
                Console.WriteLine(words[i]);
                if(words[i].Length != 5){ continue; }
                Char[] letters = words[i].ToCharArray();
                //check if the letters are in the word
                //check if chars inclueds any letters
                //if it does, then skip
                //if it doesn't, then add to results
                if(chars.Contains(letters[0]) || chars.Contains(letters[1]) || chars.Contains(letters[2]) || chars.Contains(letters[3]) || chars.Contains(letters[4])){
                    continue;
                }
                else{
                    chars.Add(letters[0]);
                    chars.Add(letters[1]);
                    chars.Add(letters[2]);
                    chars.Add(letters[3]);
                    chars.Add(letters[4]);
                    results.Add(words[i]);
                }
                if(results.Count > 4) { break; }
            }
            //print the words
            Console.WriteLine("");
            Console.WriteLine("Words:");
            for(int i = 0; i < results.Count; i++){
                Console.WriteLine(results[i]);
            }
            //print the time it took
            Console.WriteLine(DateTime.Now - start);
            //await File.WriteAllTextAsync("C:\\Users\\Airsc\\Downloads\\words_alpha.txt", sb.ToString());
        }
    }
}
