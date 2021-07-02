using System;



class Nerv
   {
    public Nerv()
    {
    }

    public double[] compensationDiastol(int hcc, int opss1, int opss2, int opss3, int ock, double t_d, double d)
    {
        double[] res = new double[5];
        double x;
        double deltaD = d - 80;
        double newHcc;
        newHcc = hcc + (0.4 * deltaD + t_d * hcc - 2 * hcc) / 2;
        x = (-opss1 - opss2 - opss3 - 4 * ock + Math.Sqrt(Math.Pow(opss1 + opss2 + opss3 + 4 * ock, 2) - 16 * ((-10000 / (3 * t_d * newHcc)) + ock * (opss1 + opss2 + opss3)))) / 8;
        res[0] = Math.Abs(opss1 + 2 * x);
        res[1] = Math.Abs(opss2 + 2 * x);
        res[2] = Math.Abs(ock + x);
        res[3] = x;
        res[4] = newHcc;
        return res;
    }

    public double[] compensationSistol(int hcc, int opss1, int opss2, int opss3, int ock, double t, double s)
    {
        double[] res = new double[4];
        double x;
        double deltaS = s - 80;
        double newHcc;
        newHcc = hcc + (0.4 * deltaS + t * hcc - 6 * hcc) / 6;
        x = (-opss1 - opss2 - opss3 - 4 * ock + Math.Sqrt(Math.Pow(opss1 + opss2 + opss3 + 4 * ock, 2) - 16 * ((-10000 / (t * hcc)) + ock * (opss1 + opss2 + opss3)))) / 8;
        res[0] = Math.Abs(opss1 + 2 * x);
        res[1] = Math.Abs(opss2 + 2 * x);
        res[2] = Math.Abs(ock + x);
        res[3] = x;
        res[4] = newHcc;
        return res;
    }

}