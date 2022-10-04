namespace CSharp.Assignment.Part1 {
    public class BinaryClock {
        private static void Helper(int digit, int lights, string[] result) {
            string binary = Convert.ToString(digit, 2);

            while(binary.Length < lights)
                binary = "0" + binary;
            while(binary.Length < 4)
                binary = " " + binary;

            for(int i = 0; i < 4; i++) {
                result[i] += binary[i];
            }
        }

        public static string[] TimeToBinaryClock(string time) {
            string[] result = new string[4];
            var digits = time.Where(char.IsDigit).Select(d => d - '0').ToArray();

            int lights = 2;
            Helper(digits[0], lights, result);
            for(int i = 1; i < digits.Length; i++) {
                if (i % 2 != 0) lights = 4;
                else lights = 3;

                Helper(digits[i], lights, result);
            }
            return result;
        }
    }
}
