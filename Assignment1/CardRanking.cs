namespace Assignment1 {
    public class CardRanking {
        //private static void Display(int[] arr) {
        //    foreach(int item in arr) {
        //        Console.Write(item);
        //    }
        //    Console.WriteLine();
        //}
        //private static void Display(List<List<int>> lists) {
        //    foreach (var list in lists) {
        //        foreach (var item in list) {
        //            Console.Write(item);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //private static bool CheckRoyalFlush(string[] ranks) {
        //    bool ans = true;
        //    foreach(string rank in ranks) {
        //        if(int.TryParse(rank, out _) && rank != "10") {
        //            ans = false; break;
        //        }
        //    }
        //    return ans;
        //}

        private static bool CheckFlush(string[] suits) {
            bool ans = true;
            for (int i = 1; i < suits.Length; i++) {
                if (suits[i - 1] != suits[i]) {
                    ans = false; break;
                }
            }
            return ans;
        }

        private static int ConvertRank(string rank) {
            if (rank == "J") return int.Parse("11");
            if (rank == "Q") return int.Parse("12");
            if (rank == "K") return int.Parse("13");
            if (rank == "A") return int.Parse("14");

            return int.Parse(rank);
        }

        private static bool CheckStraight(int[] ranks) {
            bool ans = true;

            for(int i = 1; i < ranks.Length; i++) {
                if (ranks[i] - ranks[i - 1] != 1) {
                    ans = false;
                    break;
                }
            }

            return ans;
        }

        private static List<List<int>> RankSegments(int[] ranks) {
            List<List<int>> segments = new List<List<int>>();

            List<int> segment = new List<int>();
            segment.Add(ranks[0]);

            for(int i = 1; i < ranks.Length; i++) {
                if (ranks[i] != ranks[i - 1]) {
                    segments.Add(segment);
                    segment = new List<int>();
                }
                segment.Add(ranks[i]);
            }
            segments.Add(segment);

            return segments;
        }

        public static string PokerHandRanking(string[] hand) {
            string[] ranksStr = hand.Select(h => h.Substring(0, h.Length - 1)).ToArray();
            string[] suits = hand.Select(h => h.Substring(h.Length - 1)).ToArray();

            int[] ranks = ranksStr.Select(rank => ConvertRank(rank)).ToArray();
            Array.Sort(ranks);
            bool is_straight = CheckStraight(ranks);

            if (CheckFlush(suits)) {
                if (is_straight && ranks[0] == 10) return "Royal Flush";
                if (is_straight) return "Straight Flush";

                return "Flush";
            }
            else {
                List<List<int>> segments = RankSegments(ranks);

                if(segments.Count == 2) {
                    if (segments[0].Count == 4 || segments[1].Count == 4)
                        return "Four of a Kind";

                    if ((segments[0].Count == 2 && segments[1].Count == 3) ||
                       (segments[0].Count == 3 && segments[1].Count == 2))
                        return "Full House";
                }

                if (is_straight) return "Straight";

                if(segments.Count == 3) {
                    if (segments[0].Count == 3 || segments[1].Count == 3 || segments[2].Count == 3)
                        return "Three of a Kind";

                    if (segments[0].Count == 1 || segments[1].Count == 1 || segments[2].Count == 1)
                        return "Two Pair";
                }

                if (segments.Count == 4) return "Pair";

                return "High Card";
            }
        }
    }
}
