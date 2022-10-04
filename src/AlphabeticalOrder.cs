using System.Text;

namespace CSharp.Assignment.Part1 {
    public class AlphabeticalOrder {
        private static bool AppendHelper(int[] freq, ref int i, char ch, StringBuilder res) {
            if (freq[i] <= 0) {
                i++;
                return false;
            }

            res.Append((char)(ch + i));
            freq[i]--;
            return true;
        }
        public static string TrueAlphabetic(string str) {
            int[] freqLower = new int[26];
            int[] freqUpper = new int[26];

            // Initializing the freq arrays
            for (int i = 0; i < str.Length; i++) {
                if (str[i] >= 97 && str[i] <= 122) {
                    freqLower[str[i] - 'a']++;
                }
                else if (str[i] >= 65 && str[i] <= 90) {
                    freqUpper[str[i] - 'A']++;
                }
            }

            int p1 = 0, p2 = 0;
            bool pointerOnLower = true;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length;) {
                bool appended = true;
                if (str[i] == ' ') {
                    sb.Append(' ');
                }
                else {
                    if(pointerOnLower) {
                        appended = AppendHelper(freqLower, ref p1, 'a', sb);
                    }
                    else {
                        appended = AppendHelper(freqUpper, ref p2, 'A', sb);
                    }
                }

                if (appended) {
                    i++;
                }
                else {
                    pointerOnLower = !pointerOnLower;
                }
            }
            return sb.ToString();
        }
    }
}
