

namespace Tas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = System.Text.Encoding.UTF8;

            /*
            string topLeft = "┌";
            string topRight = "┐";
            string bottomLeft = "└";
            string bottomRight = "┘";
            string horizontal = "─";
            string vertical = "│";
            string dot = "●";
            */

            string[] Tass1 = 
                {
                    "┌───────────────────┐",
                    "│                   │",
                    "│                   │",
                    "│                   │",
                    "│         ●         │",
                    "│                   │",
                    "│                   │",
                    "│                   │",
                    "└───────────────────┘"
                };
            string[] Tass2 =
                {
                    "┌───────────────────┐",
                    "│                   │",
                    "│              ●    │",
                    "│                   │",
                    "│                   │",
                    "│                   │",
                    "│    ●              │",
                    "│                   │",
                    "└───────────────────┘"
                };
            string[] Tass3 =
                {
                    "┌───────────────────┐",
                    "│                   │",
                    "│              ●    │",
                    "│                   │",
                    "│         ●         │",
                    "│                   │",
                    "│    ●              │",
                    "│                   │",
                    "└───────────────────┘"
                };
            string[] Tass4 =
                {
                    "┌───────────────────┐",
                    "│                   │",
                    "│    ●         ●    │",
                    "│                   │",
                    "│         ●         │",
                    "│                   │",
                    "│    ●         ●    │",
                    "│                   │",
                    "└───────────────────┘"
                };
            string[] Tass5 =
                {
                    "┌───────────────────┐",
                    "│                   │",
                    "│    ●         ●    │",
                    "│                   │",
                    "│         ●         │",
                    "│                   │",
                    "│    ●         ●    │",
                    "│                   │",
                    "└───────────────────┘"
                };
            string[] Tass6 =
                {
                    "┌───────────────────┐",
                    "│                   │",
                    "│    ●         ●    │",
                    "│                   │",
                    "│    ●         ●    │",
                    "│                   │",
                    "│    ●         ●    │",
                    "│                   │",
                    "└───────────────────┘"
                };

            
            Random random = new Random();
            int end = 2;
            while (end > 0)
            {
                int[] dices = new int[end];
                string[][] dicesS = new string[end][];
                for (int i = 0; i < end; i++)
                {
                    switch (random.Next(1 , 7))
                    {
                        case 1:
                            dicesS[i] = Tass1;
                            break;
                        case 2:
                            dicesS[i] = Tass2;
                            break;
                        case 3:
                            dicesS[i] = Tass3;
                            break;
                        case 4:
                            dicesS[i] = Tass4;
                            break;
                        case 5:
                            dicesS[i] = Tass5;
                            break;
                        case 6:
                            dicesS[i] = Tass6;
                            break;
                    }
                }
                writeDice(dicesS);
                
                Write("how many times do you want to dice:");
                string x = ReadLine();
                end = int.Parse(x);
                Console.Clear();
            }
            
        }
        static void writeDice(string[][] dices)
        {
            for (int i = 0;i < 9; i++)
            {
                for (int j = 0; j < dices.Length; j++)
                {
                    Write(dices[j][i]);
                }
                WriteLine();
            }
        }
    }
}
