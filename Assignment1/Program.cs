namespace Assignment1
{
    internal class Program
    {
        static void AlphabeticalOrderTest() {
            string[] inputs = { "hello world", "edabit is awesome", "have a nice day",
                                "Hello World", "Hii how are you doing" };
            string[] outputs = { "dehll loorw", "aabdee ei imosstw", "aaac d eehi nvy",
                                 "deHll loorW", "ade ghH iii noo oruwy"};

            for (int i = 0; i < inputs.Length; i++) {
                string output = AlphabeticalOrder.TrueAlphabetic(inputs[i]);
                Console.WriteLine($"{inputs[i]}\t{output}\t{output == outputs[i]}");
            }

            //foreach(string input in inputs) {
            //    Console.WriteLine(AlphabeticalOrder.TrueAlphabetic(input));
            //}
        }

        static void BinaryClockTest() {
            string[] inputs = { "10:37:49", "18:57:31", "10:50:22" };
            for(int i = 0; i < inputs.Length; i++) {
                string[] output = BinaryClock.TimeToBinaryClock(inputs[i]);

                foreach(var o in output) {
                    Console.WriteLine(o);
                }
                Console.WriteLine();
            }
        }

        static void AreaCalculatorTest() {
            int[] radii = { 0, 4, 25 };

            foreach (int r in radii) {
                Console.Write(AreaCalculator.RedArea(r));
                Console.Write('\t');
                Console.WriteLine(AreaCalculator.RedAreaOneLiner(r));
            }
        }

        static void CardRankingTest() {
            string[][] hands = {
                                 new string[]{ "10h", "Jh", "Qh", "Ah", "Kh" },
                                 new string[]{ "3h", "5h", "Qs", "9h", "Ad" },
                                 new string[]{ "10s", "10c", "8d", "10d", "10h" },
                                 new string[]{ "5h", "8h", "6h", "7h", "9h" },
                                 new string[]{ "10c", "9c", "9s", "10s", "9h" }
                               };

            foreach (var h in hands) {
                Console.WriteLine(CardRanking.PokerHandRanking(h));
            }
        }
        static void Main(string[] args)
        {
            // AlphabeticalOrderTest();
            // BinaryClockTest();
            // AreaCalculatorTest();
            CardRankingTest();
        }
    }
}