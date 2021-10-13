using System;
using System.Collections.Generic;
/// <summary>
/// Класс для реализации приближённых вычислений
/// </summary>
public class Counter
{
	public Counter()
	{
	}
    private const int IDEALDIASTOL = 80000;
    private const double EPS = 0.000000001; 
	private double a;
	private double b;

    /// <summary>
    /// Поиск корней
    /// </summary>
    public double FindRoots(double Hcc, int opss1, int opss2, int opss3, int ock, double t, Dictionary<String, bool> WhatIsBlocked)
    {
        double x = 0;
        a = 0;
        b = 100;

        while (Math.Abs(b - a) > EPS)
        {
            x = (a + b) / 2;
            double fX = function(x, Hcc, opss1, opss2, opss3, ock, t, WhatIsBlocked);
            double fA = function(a, Hcc, opss1, opss2, opss3, ock, t, WhatIsBlocked);
            if ((fA >= 0 && fX >= 0) || (fA <= 0 && fX <= 0))
            {
                a = x;
            }
            else
            {
                b = x;
            }
        }
        return x;
    }

    /// <summary>
    /// Функция, по которой ищется х
    /// </summary>
    private double function(double x, double Hcc, int opss1, int opss2, int opss3, int ock, double t, Dictionary<String, bool> WhatIsBlocked)
    {
        double m;
        double l;
        double n;
        double k;
        double g;
        if (WhatIsBlocked["Opss1"] == false)
        {
            m = (opss1 + 3 * x) % 6;
        }
        else
        {
            m = opss1;
        }

        if (WhatIsBlocked["Opss2"] == false)
        {
            l = (opss2 + 3 * x) % 6;
        }
        else
        {
            l = opss2;
        }
        if (WhatIsBlocked["Opss3"] == false)
        {
            n = (opss3 + 3 * x) % 6;
        }
        else
        {
            n = opss3;
        }
        if (WhatIsBlocked["Ock"] == false)
        {
            k = (ock + x) % 7;
        }
        else
        {
            k = ock;
        }

        if (WhatIsBlocked["Hcc"] == false)
        {
            g = (Hcc + 3 * x) % Hcc;
        }
        else
        {
            g = Hcc;
        }

        double f = t * g * 6 * (m + l + n) * 4 * k - IDEALDIASTOL;
		return f;
	}
}
