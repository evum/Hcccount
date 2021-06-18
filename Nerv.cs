using System;



class Nerv
   {
    private int Run = 4;
    private int Eat = 4;
    private int Think = 4;

    public int NewOpss(String name)
    {
        int value = 0;
        if (name == "Opss1")
        {
            value = 6 - Run;
        }
        else if (name == "Opss2")
        {
            value = 6 - Eat;
        }
        else if (name == "Opss3")
        {
            value = 6 - Think;
        }
        return value;
    }

    public void setNums(String name, int value)
    {
        if (name == "Run")
        {
            Run = value;
        }
        else if (name == "Eat")
        {
            Eat = value;
        }
        else if (name == "Think")
        {
            Think = value;
        }
    }

    public double[] compensation(int hcc, int opss1, int opss2, int opss3, int ock)
    {
        double[] res = new double[4];
        double x;
        x = (-opss1 - opss2 - opss3 - 4 * ock + Math.Sqrt(Math.Pow(opss1 + opss2 + opss3 + 4 * ock, 2) - 16 * ((-5000 / (3 * hcc)) + ock * (opss1 + opss2 + opss3)))) / 8;
        res[0] = Math.Abs(opss1 + 2 * x);
        res[1] = Math.Abs(opss2 + 2 * x);
        res[2] = Math.Abs(ock + x);
        res[3] = x;
        return res;
    }
    public Nerv() 
    {
    }
}