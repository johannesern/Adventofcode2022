using System.Diagnostics;
using System.Globalization;

namespace AdventOfCodeDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] opponentWinCombinations = new string[] { "A Z", "B X", "C Y" };
            string[] IWinCombinations = new string[] { "A Y", "B Z", "C X" };
            string[] drawCombinations = new string[] { "A X", "B Y", "C Z" };
            
            string[] rounds = Input().Trim().Split("\r\n");
            
            int score = 0;
            int counter = 0;
            foreach (string round in rounds)
            {
                //bool oppoWin = CheckForMatch(round, opponentWinCombinations);
                //bool IWin = CheckForMatch(round, IWinCombinations);
                //bool draw = CheckForMatch(round, drawCombinations);

                string cheatRound = CheatRound(round);
                bool oppoWin = CheckForMatch(cheatRound, opponentWinCombinations);
                bool IWin = CheckForMatch(cheatRound, IWinCombinations);
                bool draw = CheckForMatch(cheatRound, drawCombinations);

                if (draw)
                {
                    score += 3;
                }
                else if(IWin) 
                {
                    score += 6;
                }
                //score += ScoreCounter(round);
                score += ScoreCounter(cheatRound);
                counter++;
            }

            Console.WriteLine(score);
        }

        public static string CheatRound(string round)
        {
            if (round[2] == 'Y')
            {
                //Draw game                
                return DrawGame(round);
            }
            else if(round[2] == 'X')
            {
                //Opponent win game
                return OppoWinGame(round);
            }
            else
            {
                //I win game
                return IWinGame(round);
            }
        }

        public static string DrawGame(string round)
        {
            if (round[0] == 'A')
            {
                round = "A X";
            }
            else if (round[0] == 'B')
            {
                round = "B Y";
            }
            else
            {
                round = "C Z";
            }
            return round;
        }

        public static string OppoWinGame(string round)
        {
            if (round[0] == 'A')
            {
                round = "A Z";
            }
            else if (round[0] == 'B')
            {
                round = "B X";
            }
            else
            {
                round = "C Y";
            }
            return round;
        }

        public static string IWinGame(string round)
        {
            if (round[0] == 'A')
            {
                round = "A Y";
            }
            else if (round[0] == 'B')
            {
                round = "B Z";
            }
            else
            {
                round = "C X";
            }
            return round;
        }

        public static int ScoreCounter(string round)
        {
            char XYZ = round[2];
            if (XYZ == 'X')
            {
                return 1;
            }
            else if (XYZ == 'Y')
            {
                return 2;
            }
            else
            {
                return 3;
            }           
        }
                
        public static bool CheckForMatch(string round, string[] combinations)
        {
            bool foundMatch = false;
            foreach (var combination in combinations)
            {
                if (round == combination)
                {
                    foundMatch = true;                                      
                }
            }
            return foundMatch;
        }      

        public static string Input()
        {
            return "A Y\r\nB X\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nA Z\r\nB Y\r\nA Z\r\nB X\r\nC Z\r\nC X\r\nC X\r\nB Y\r\nC X\r\nA X\r\nB Y\r\nB Z\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nC X\r\nB Y\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA Y\r\nB X\r\nC X\r\nB X\r\nC X\r\nC X\r\nA Z\r\nC Z\r\nC X\r\nA Y\r\nB Y\r\nB Y\r\nB X\r\nC X\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nA X\r\nA Y\r\nC Y\r\nA Z\r\nC X\r\nC X\r\nA X\r\nA Z\r\nA X\r\nC X\r\nC X\r\nA X\r\nC X\r\nB Y\r\nA Z\r\nA Y\r\nA Z\r\nB X\r\nC X\r\nB X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC Z\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nA Z\r\nA Z\r\nA Y\r\nB Y\r\nA Z\r\nC X\r\nA Y\r\nA Z\r\nA Y\r\nA Z\r\nC X\r\nC X\r\nC X\r\nB X\r\nB Y\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nB X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA X\r\nA Z\r\nC Y\r\nA Z\r\nC X\r\nC X\r\nC Z\r\nC X\r\nA Z\r\nA X\r\nC Y\r\nA X\r\nC X\r\nC X\r\nC X\r\nA X\r\nA X\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Y\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nA X\r\nB X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nC X\r\nC X\r\nA Y\r\nC X\r\nC Y\r\nC Z\r\nC X\r\nC X\r\nB Y\r\nC X\r\nA Z\r\nC Z\r\nA Z\r\nC X\r\nA Y\r\nB Y\r\nC X\r\nC X\r\nC X\r\nB X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nB X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA X\r\nB Y\r\nC Y\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nB Y\r\nB X\r\nC X\r\nA Z\r\nA Y\r\nB Z\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nC Z\r\nB X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC Z\r\nA Y\r\nC X\r\nC X\r\nA Y\r\nA X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nA X\r\nA X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nB Y\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nB X\r\nC X\r\nB Y\r\nA Y\r\nA Y\r\nC Z\r\nB Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC Z\r\nA Y\r\nC X\r\nA Y\r\nC Z\r\nA Y\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nA Y\r\nC X\r\nA X\r\nA X\r\nB X\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nA Y\r\nC X\r\nB Y\r\nB X\r\nC X\r\nC X\r\nA Z\r\nB X\r\nA X\r\nC X\r\nC X\r\nB Y\r\nC Z\r\nB X\r\nC X\r\nA Z\r\nA Z\r\nA X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nA Y\r\nA Y\r\nC Z\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nB X\r\nA Z\r\nA Y\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nA X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nC X\r\nB Y\r\nB X\r\nC X\r\nB Y\r\nA Z\r\nA X\r\nC X\r\nA Y\r\nA X\r\nA Z\r\nB Y\r\nA X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nB Y\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nB X\r\nA Y\r\nA X\r\nA Y\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nB X\r\nA Y\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC Y\r\nA Z\r\nA Z\r\nA Z\r\nA Y\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nC X\r\nA Y\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nB Y\r\nB X\r\nA Z\r\nA X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nA Z\r\nC X\r\nA X\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA X\r\nA X\r\nA Y\r\nA Z\r\nA X\r\nC X\r\nA X\r\nA Z\r\nB Y\r\nA X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA X\r\nA X\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC Z\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nC X\r\nB Y\r\nC X\r\nA X\r\nA X\r\nA Y\r\nC X\r\nA Y\r\nA Z\r\nC X\r\nC X\r\nC Z\r\nC X\r\nC X\r\nC X\r\nB X\r\nC X\r\nC X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Y\r\nC X\r\nC Z\r\nC X\r\nC X\r\nB X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nB X\r\nA Z\r\nC X\r\nA Z\r\nB X\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nC Y\r\nA Z\r\nC X\r\nC X\r\nA X\r\nA X\r\nA X\r\nA X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nA Z\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nB X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nA X\r\nB Y\r\nB Y\r\nC Z\r\nC X\r\nC X\r\nB Y\r\nA X\r\nC X\r\nC X\r\nA X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nC X\r\nC X\r\nA X\r\nA X\r\nC X\r\nC Z\r\nC X\r\nA Z\r\nB X\r\nC X\r\nB Y\r\nA Y\r\nB X\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA Y\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nB X\r\nB Y\r\nA Z\r\nC X\r\nC Y\r\nA Z\r\nC X\r\nC X\r\nA X\r\nA Z\r\nA X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nA X\r\nB X\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nA X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA X\r\nA Z\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nA X\r\nC X\r\nA X\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nC X\r\nA Z\r\nC X\r\nB X\r\nB X\r\nB Y\r\nA Y\r\nA Y\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nB Z\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nB X\r\nA Y\r\nC X\r\nA X\r\nA Z\r\nB Y\r\nA X\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nC X\r\nB X\r\nC Z\r\nA X\r\nB X\r\nA Y\r\nC X\r\nA Z\r\nA Z\r\nB X\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nA X\r\nC X\r\nC X\r\nB Z\r\nB X\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC Y\r\nB X\r\nC X\r\nA X\r\nC X\r\nA X\r\nA Z\r\nC Z\r\nA Z\r\nC X\r\nA Y\r\nC X\r\nC X\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC Y\r\nC X\r\nA X\r\nA Z\r\nA X\r\nC X\r\nA Z\r\nA Z\r\nB Y\r\nB X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA X\r\nC X\r\nC Y\r\nA Z\r\nA Y\r\nC Z\r\nC X\r\nC Z\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA Y\r\nA X\r\nB Y\r\nC X\r\nA Y\r\nC X\r\nA Y\r\nC X\r\nA Z\r\nB X\r\nA Y\r\nC X\r\nB X\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nA Y\r\nA Z\r\nA X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nA Y\r\nA Y\r\nC X\r\nA Z\r\nC X\r\nC Y\r\nC X\r\nC X\r\nA X\r\nA Z\r\nA X\r\nA X\r\nC X\r\nA X\r\nA Z\r\nC X\r\nA Y\r\nA Y\r\nC X\r\nB Y\r\nA Y\r\nC X\r\nA Z\r\nA Z\r\nA X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nB Y\r\nA X\r\nA Y\r\nC X\r\nC X\r\nC X\r\nB X\r\nA Z\r\nC X\r\nC X\r\nB X\r\nA Z\r\nA X\r\nC X\r\nA X\r\nC X\r\nB Y\r\nA Z\r\nC X\r\nC X\r\nB X\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC Y\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nC X\r\nB X\r\nA X\r\nA Z\r\nC X\r\nB Z\r\nC X\r\nC X\r\nA X\r\nA Y\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nB Y\r\nA Z\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nA Y\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nC X\r\nC Z\r\nA X\r\nC X\r\nC X\r\nA X\r\nA X\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nB Z\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nB X\r\nC X\r\nA Z\r\nB Y\r\nB Y\r\nC X\r\nA X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nC Y\r\nB Y\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nC X\r\nC X\r\nA Y\r\nC X\r\nA Y\r\nB X\r\nC Z\r\nC X\r\nA Y\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC Z\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nB Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC Y\r\nC X\r\nB Y\r\nA X\r\nA Z\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nC Y\r\nC Z\r\nA X\r\nA Z\r\nA X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nA Y\r\nC X\r\nC X\r\nC X\r\nA X\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nB Z\r\nA X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Y\r\nA Z\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nA X\r\nC Y\r\nA Y\r\nA Y\r\nC X\r\nC X\r\nA X\r\nA Y\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nB X\r\nC X\r\nC X\r\nC X\r\nB Z\r\nA Y\r\nC X\r\nB Y\r\nC X\r\nA X\r\nC X\r\nC X\r\nB X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC Z\r\nB X\r\nC Z\r\nC X\r\nB X\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nC Z\r\nC X\r\nB X\r\nA X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nC Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nA Y\r\nA Y\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nB X\r\nC X\r\nB X\r\nB Y\r\nA Z\r\nC X\r\nB Y\r\nA Y\r\nC Z\r\nA Z\r\nA X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nB Y\r\nA Z\r\nB X\r\nA Z\r\nA Z\r\nB X\r\nA X\r\nA Z\r\nC X\r\nC X\r\nA Y\r\nC X\r\nA Z\r\nB Y\r\nC Y\r\nA Z\r\nC Y\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA X\r\nC X\r\nA X\r\nA Z\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nC X\r\nB Y\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA X\r\nA Z\r\nB Y\r\nA Y\r\nC X\r\nC X\r\nC Z\r\nC X\r\nA X\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nB X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Y\r\nA Y\r\nC X\r\nB X\r\nC X\r\nB X\r\nA Y\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nB X\r\nB X\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA X\r\nA X\r\nB Y\r\nA Y\r\nA X\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nB Y\r\nC X\r\nB Y\r\nA Y\r\nC X\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nC X\r\nA Z\r\nA Y\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nC Y\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nB X\r\nA X\r\nA Z\r\nA Y\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nA Y\r\nB Y\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nC Y\r\nA X\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nC X\r\nC X\r\nA Y\r\nC X\r\nA Z\r\nC X\r\nA X\r\nC X\r\nA X\r\nC X\r\nC X\r\nB X\r\nC X\r\nB X\r\nC X\r\nC X\r\nA Y\r\nA X\r\nA Z\r\nC X\r\nA X\r\nA Y\r\nA Z\r\nC X\r\nC X\r\nC X\r\nB Y\r\nA Z\r\nA Y\r\nA Z\r\nC X\r\nA Y\r\nB X\r\nC X\r\nA X\r\nA Y\r\nA Y\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nA Z\r\nC X\r\nB X\r\nA Z\r\nC X\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nB Y\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nB Y\r\nA X\r\nA Z\r\nC X\r\nB X\r\nA Z\r\nA Z\r\nA Y\r\nB Y\r\nA Y\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nC Z\r\nA Y\r\nC X\r\nA Y\r\nA Y\r\nA Y\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nB X\r\nB Y\r\nC X\r\nA Z\r\nB X\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nB X\r\nA X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nC Y\r\nC X\r\nA Z\r\nA X\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nA Y\r\nC X\r\nA X\r\nC X\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nB Y\r\nA Z\r\nA Y\r\nC X\r\nA Y\r\nA Y\r\nA Y\r\nC X\r\nB X\r\nB X\r\nC X\r\nB X\r\nC X\r\nC X\r\nA X\r\nA X\r\nA X\r\nC X\r\nC X\r\nC Y\r\nA Y\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nB X\r\nC X\r\nC Z\r\nA Z\r\nC Y\r\nB Y\r\nA Y\r\nA Z\r\nA Z\r\nA X\r\nA Y\r\nC X\r\nC Y\r\nC X\r\nC X\r\nA X\r\nA Y\r\nA Z\r\nC X\r\nB X\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nA Y\r\nA Z\r\nC Z\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nA X\r\nC X\r\nA Z\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nC X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nB Z\r\nA Z\r\nA Y\r\nC X\r\nB X\r\nC X\r\nC X\r\nC Z\r\nC X\r\nC X\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Y\r\nC X\r\nB Y\r\nA Z\r\nC X\r\nB X\r\nC X\r\nA X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nB Z\r\nC X\r\nA Z\r\nA X\r\nC X\r\nB X\r\nA X\r\nA Y\r\nB Y\r\nB Y\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nA Y\r\nA Z\r\nA Y\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nB Y\r\nA X\r\nA Z\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nB X\r\nB X\r\nA Z\r\nC X\r\nA Y\r\nA Z\r\nC X\r\nA X\r\nA X\r\nA Z\r\nA Y\r\nC X\r\nA Z\r\nB Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nC X\r\nB X\r\nA X\r\nC X\r\nA X\r\nB Y\r\nC X\r\nB Y\r\nA Z\r\nA Z\r\nA Y\r\nA Z\r\nB X\r\nA X\r\nC X\r\nB Y\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nA Z\r\nA X\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA X\r\nB Y\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nB X\r\nB X\r\nC X\r\nC X\r\nA Z\r\nB X\r\nC X\r\nA X\r\nC X\r\nB Y\r\nA Y\r\nC Z\r\nC X\r\nA Z\r\nC Z\r\nB Y\r\nB Y\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nC X\r\nA X\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nB Y\r\nA Z\r\nB X\r\nA X\r\nA Z\r\nA Z\r\nC X\r\nB X\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA X\r\nA X\r\nC X\r\nB X\r\nC X\r\nC X\r\nB Y\r\nC X\r\nC X\r\nA X\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nB Y\r\nC X\r\nC Z\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Y\r\nA X\r\nC X\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nA Y\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nB X\r\nC X\r\nC X\r\nC X\r\nC X\r\nB Y\r\nA X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nC X\r\nA Y\r\nC X\r\nA Z\r\nA Z\r\nB Y\r\nC X\r\nC Y\r\nA Y\r\nC X\r\nB Y\r\nA Z\r\nB X\r\nC X\r\nC X\r\nA X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA X\r\nA X\r\nA Z\r\nC X\r\nB Z\r\nC X\r\nA Y\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA Y\r\nA X\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nA Z\r\nC X\r\nC Z\r\nB X\r\nC X\r\nC X\r\nA Z\r\nA X\r\nB X\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nC Z\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA X\r\nC Z\r\nB Y\r\nA X\r\nA X\r\nB X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nB X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC Y\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nA Y\r\nA X\r\nA X\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nC X\r\nB X\r\nC X\r\nA Y\r\nA X\r\nC X\r\nC X\r\nC X\r\nB X\r\nB X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nA Y\r\nA X\r\nA Y\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nA Y\r\nB X\r\nA Z\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA X\r\nC X\r\nA Z\r\nA Z\r\nB X\r\nA Y\r\nC X\r\nC X\r\nC X\r\nC X\r\nB X\r\nB Y\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nB X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nA X\r\nC X\r\nC X\r\nA X\r\nA Z\r\nC X\r\nA X\r\nC X\r\nC X\r\nA X\r\nC X\r\nA X\r\nA Y\r\nA Z\r\nA Y\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nB Z\r\nA Y\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA X\r\nC X\r\nC Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nB X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC Z\r\nC X\r\nA X\r\nA Y\r\nB Y\r\nA Z\r\nA X\r\nB X\r\nC X\r\nC X\r\nC X\r\nA Y\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nC Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC Y\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nB X\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nA Y\r\nC Y\r\nA Z\r\nA Z\r\nB X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nB X\r\nA X\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nA Z\r\nC Z\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Y\r\nC X\r\nC X\r\nA Y\r\nC X\r\nB X\r\nC X\r\nC X\r\nB Y\r\nA X\r\nC X\r\nA Y\r\nB Y\r\nC X\r\nA X\r\nA Z\r\nC Z\r\nA X\r\nC X\r\nC X\r\nB X\r\nA Z\r\nB Z\r\nA Z\r\nA X\r\nA Y\r\nC X\r\nA X\r\nB X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nB X\r\nC X\r\nA Y\r\nA Z\r\nA X\r\nA X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nA Y\r\nC X\r\nB X\r\nA Z\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA X\r\nB Y\r\nA Y\r\nC X\r\nC X\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nA X\r\nC X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC Z\r\nA Y\r\nC X\r\nC X\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nA Z\r\nB X\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nB Y\r\nC X\r\nA X\r\nB X\r\nA Z\r\nA Z\r\nC X\r\nC Y\r\nA Z\r\nB Y\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nC X\r\nA Z\r\nC Z\r\nA X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nB X\r\nB Y\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nC Z\r\nC X\r\nB X\r\nA X\r\nB Z\r\nA Z\r\nC X\r\nA X\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nA X\r\nA Z\r\nC X\r\nA X\r\nC X\r\nC Y\r\nC X\r\nA Z\r\nB X\r\nA Y\r\nA Z\r\nC Y\r\nA Z\r\nC X\r\nA Y\r\nC X\r\nA X\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nA X\r\nA Z\r\nA X\r\nA Y\r\nC Z\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nC Z\r\nA X\r\nA Z\r\nB Y\r\nA Z\r\nA Z\r\nB X\r\nB Y\r\nA X\r\nA Y\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nB X\r\nB X\r\nC X\r\nC X\r\nC X\r\nA X\r\nC X\r\nA Z\r\nB X\r\nA Y\r\nB X\r\nC X\r\nA X\r\nC X\r\nA X\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nC X\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nA Y\r\nC Y\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC Z\r\nB X\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nA Y\r\nC X\r\nA X\r\n";
        }
    }
}