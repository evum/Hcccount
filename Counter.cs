using System;
/// <summary>
/// Класс для реализации приближённых вычислений
/// </summary>
public class Counter
{
	public Counter()
	{
	}
    private const int IDEALDIASTOL = 120000;
    private const double EPS = 0.000000001; 
	private double a;
	private double b;

    /// <summary>
    /// Поиск корней
    /// </summary>
    public double FindRoots(double Hcc, int opss1, int opss2, int opss3, int ock, double t)
    {
        a = 0;
        b = 100;
        double x = 0;
        while (Math.Abs(b - a) > EPS)
        {
            x = (a + b) / 2;
            double fX = function(x, Hcc, opss1, opss2, opss3, ock, t);
            double fA = function(a, Hcc, opss1, opss2, opss3, ock, t);
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
    private double function(double x, double Hcc, int opss1, int opss2, int opss3, int ock, double t)
    {
		double f = t * ((Hcc + 3 * x) % Hcc) * 3 * (Math.Abs(opss1 + 3 * x) % 6 + Math.Abs(opss2 + 3 * x) % 6 + opss3) * 4 * (Math.Abs(ock + x) % 7) - IDEALDIASTOL;
		return f;
	}
}
