using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    class Program
    {

        private static string getBlankedWord(string word)
        {
            //return string.Join(" ", new string('-', word.Length).ToCharArray());   
            return new string('-', word.Length);
        }

        private static string getSpacedBlankedWord(string blankedWord)
        {
            return string.Join(" ", blankedWord.ToCharArray());
        }

        private static string getRandomWord()
        {
            return "pizza";
        }

        private static bool processLetter(char letter, string word, ref string blankedWord, out string spacedBlankedWord)
        {
            bool found = word.Any(item => item == letter);
            if (found)
                {
                    for (int i = 0; i < blankedWord.Length; i++)
                    {
                        if (word[i] == letter)
                        {
                            char[] blankedWordArray = blankedWord.ToCharArray();
                            blankedWordArray[i] = letter;
                            blankedWord = string.Join(string.Empty, blankedWordArray);
                        }
                    }
                }
            spacedBlankedWord = getSpacedBlankedWord(blankedWord);   
            return found;
        }

        private static void Deneme(object[] args)
        { 
        
        }

        private static bool checkFinished(string blankedWord)
        {
            bool finished = blankedWord.Any(item => item == '-');
            return finished;
        }

        private static void writeX(int strikes)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("X ", strikes)));
        }

        public static void playGame()
        {
            bool playing = true;
            int strikes = 0;
            int maxStrikes = 3;

            string word = getRandomWord();
            string blankedWord = getBlankedWord(word);
            string spacedBlankedWord = getSpacedBlankedWord(blankedWord);

            while (playing)
            {
                Console.WriteLine("{0}\nPick a letter!", spacedBlankedWord);
                char letter = Console.ReadLine()[0];

                bool found = processLetter(letter, word, ref blankedWord, out spacedBlankedWord);
             
                playing = checkFinished(blankedWord);

                if (!found)
                {
                    strikes++;
                    writeX(strikes);
                }

                if (strikes >= maxStrikes)
                {
                    playing = false;
                }
            }

            if (strikes >= maxStrikes)
            {
                Console.WriteLine("Loser!");
            }
            else if (strikes < maxStrikes)
            {
                Console.WriteLine("{0}\nWinner!!!", spacedBlankedWord);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Game Started");
            playGame();
            Console.WriteLine("Game Over");
            Console.ReadLine();
        }
    }
}
