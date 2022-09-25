public class PTB2
{
    public double A { set; get; }

    public double B { set; get; }

    public double C { get; set; }

    public PTB2(double A, double B, double C)
    {
        this.A = A;
        this.B = B;
        this.C = C;
    }

    public double[]? GiaiPT()
    {
        double[]? result;
        double delta = B * B - 4 * A * C;
        if (delta < 0)
        {
            return null;
        }
        else if (delta == 0)
        {
            result = new double[1];
            result[0] = -B / 2 / A;
        }
        else
        {
            result = new double[2];
            result[0] = (-B - Math.Sqrt(delta)) / 2 / A;
            result[1] = (-B + Math.Sqrt(delta)) / 2 / A;

        }

        return result;
    }

}