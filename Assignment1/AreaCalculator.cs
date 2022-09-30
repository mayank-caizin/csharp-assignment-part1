namespace Assignment1 {
    public class AreaCalculator {
        private static double AreaOfTriangle(double b, double h) {
            return (b * h) / 2;
        }
        public static double RedArea(int radius) {
            if (radius == 0) return 0;

            double r = radius;

            double small_triangle_area = AreaOfTriangle(r / 4, r / 5);
            double large_triangle_area = AreaOfTriangle(3 * r / 4, r);
            double sector_area = (r * r) / 2 * Math.Atan((double)3 / 4);

            double redArea = small_triangle_area + large_triangle_area - sector_area;
            return Math.Round(redArea, 3);
        }
        public static double RedAreaOneLiner(int r) {
            return Math.Round(r * r * 0.07824945, 3);
        }
    }
}
