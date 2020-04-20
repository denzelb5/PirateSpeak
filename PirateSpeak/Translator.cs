using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PirateSpeak
{
    public class Translator
    {
        public List<string> Translate(List<char> letters, List<string> pirateWords)
        {
            var possiblePirateWords = new List<string>();
            foreach (string word in pirateWords)
            {
                var characters = word.ToCharArray();
                var difference = letters.Except(characters);
                if (!difference.Any())
                {
                    possiblePirateWords.Add(word);
                }
            }
            return possiblePirateWords;
        }
       
    }
}
