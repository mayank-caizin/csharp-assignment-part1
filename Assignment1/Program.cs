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
        static void Main(string[] args)
        {
            // AlphabeticalOrderTest();
            // BinaryClockTest();
            AreaCalculatorTest();
        }
    }
}