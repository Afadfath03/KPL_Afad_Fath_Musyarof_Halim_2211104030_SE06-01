namespace Aljabar
{
    public class Class1
    {
    public static double[] AkarKuadrat(double[] psm)
        {
            double a = psm[0];
            double b = psm[1];
            double c = psm[2];

            double disc = b * b - 4 * a * c;

            if (disc < 0)
                return new double[] { };

            double square = Math.Sqrt(disc);
            double x1 = (-b + square) / (2 * a);
            double x2 = (-b - square) / (2 * a);

            return new double[] { x1, x2 };
        }

        public static double[] HasilKuadrat(double[] psm)
        {
            double a = psm[0];
            double b = psm[1];

            double x2 = a * a;
            double x = 2 * a * b;
            double kons = b * b;

            return new double[] { x2, x * -1, kons };
        }
    }
}