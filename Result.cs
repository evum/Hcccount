using System;
using System.Collections.Generic;

public class Result
{
    private const int MAXSISTOL = 300;
    private const int MAXDIASTOL = 250;

    private double t;
    private double t_d;
    private int Hcc = 80;
    private int Opss1 = 2;
    private int Opss2 = 2;
    private int Opss3 = 2;
    private int Ock = 4;

    private double s;
    private double d;
    private double a;
    private double v;
    private double k;
    private double k_1;
    private double k_2;
    private double k_3;

    private Nerv nerv;
    public Dictionary<String, double> GetNums()
    {
        var nums = new Dictionary<String, double>();
        nums["Hcc"] = Hcc;
        nums["Opss1"] = Opss1;
        nums["Opss2"] = Opss2;
        nums["Opss3"] = Opss3;
        nums["Ock"] = Ock;
        nums["Sistol"] = s;
        nums["Diastol"] = d;
        nums["Arter"] = a;
        nums["Venul"] = v;
        nums["Kapil"] = k;
        nums["Krov1"] = k_1;
        nums["Krov2"] = k_2;
        nums["Krov3"] = k_3;
        return nums;
    }

    public Boolean HighPressure()
    {
        if (s > MAXSISTOL || d > MAXDIASTOL)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public Boolean LowPressure()
    {
        if (s == 0 && d == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void SetNums(String num, int n)
    {
        switch (num)
        {
            case "Hcc":
                Hcc = n;
                break;
            case "Opss1":
                Opss1 = n;
                break;
            case "Opss2":
                Opss2 = n;
                break;
            case "Opss3":
                Opss3 = n;
                break;
            case "Ock":
                Ock = n;
                break;
        }
    }
    public void shet()
    {
        koaficents();
        res_s();
        res_d();
        res_a();
        res_v();
        res_k();
        res_krov();
    }
    private void koaficents()
    {
        if (Hcc < 68)
        {
            t = 6;
            t_d = 2;
        }
        else if (Hcc < 157)
        {
            t = 51.8549 * (Math.Pow(Hcc, -0.5088));
            t_d = -0.000002 * (Math.Pow(Hcc, 3)) + 0.0008 * (Math.Pow(Hcc, 2)) - 0.1086 * Hcc + 6.3073;
        }
        else
        {
            t = 51.8549 * (Math.Pow(Hcc, -0.5088));
            t_d = 41.9377 * Math.Pow(Hcc, -0.6904);
        }


    }
    private void res_s()
    {
        s = Math.Round((t * Hcc * 3 * (Opss1 + Opss2 + Opss3) * 4 * Ock) / 1000);
    }
    
    private void res_s(double hcc, double opss1, double opss2, double opss3, double ock)
    {
        s = Math.Round((t * hcc * 3 * (opss1 + opss2 + opss3) * 4 * ock) / 1000);
    }
    private void res_d()
    {
        d = Math.Round((t_d * Hcc * 6 * (Opss1 + Opss2 + Opss3) * 4 * Ock) / 1000);
    }
    private void res_d(double hcc, double opss1, double opss2, double opss3, double ock)
    {
        d = Math.Round((t_d * hcc * 6 * (opss1 + opss2 + opss3) * 4 * ock) / 1000);
    }
    private void res_a()
    {
        a = Math.Round(s / (963.4720 * (Math.Pow(s, -1.1458))));
    }
    private void res_v()
    {
        v = Math.Round(s / (0.0001 * (Math.Pow(s, 2) - 0.0725 * s + 19.62)));
    }
    private void res_k()
    {
        k = Math.Round((a + v) / 2);
    }
    private void res_krov()
    {
        k_1 = Math.Round(k / 3 + (k / 3 * (6 - Opss1)));
        k_2 = Math.Round(k / 3 + (k / 3 * (6 - Opss2)));
        k_3 = Math.Round(k / 3 + (k / 3 * (6 - Opss3)));
    }

    public Result()
    {
        nerv = new Nerv();
    }

    public double[][] NervRegulation()
    {
        double[][] res = new double[2][];
        res[0] = nerv.compensationDiastol(Hcc, Opss1, Opss2, Opss3, Ock, t_d, d);
        res[1] = nerv.compensationSistol(Hcc, Opss1, Opss2, Opss3, Ock, t, s);

        res_s(Hcc, res[1][0], res[1][1], Opss3, res[1][2]);
        res_d(Hcc, res[0][0], res[0][1], Opss3, res[0][2]);
        return res;
    }
}