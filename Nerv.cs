using System;
using System.Collections.Generic;

/// <summary>
/// Класс, реализующий логику работы нерва-депрессора
/// </summary>
class Nerv
   {
    private Counter mathematics;
    public Nerv()
    {
        mathematics = new Counter();
    }

    /// <summary>
    /// Функция вычисления всех параметров
    /// </summary>
    /// <returns>Коллекция новых значений для Чсс, опсс 1, 2, 3 и оцк</returns>
    public Dictionary<String, double> Сompensation(int hcc, int opss1, int opss2, int opss3, int ock, double t)
    {
        var res = new Dictionary<String, double>();
        double x;
        x = mathematics.FindRoots(hcc, opss1, opss2, opss3, ock, t);
        res["Opss1"] = Math.Abs(opss1 + 3 * x) % 6;
        res["Opss2"] = Math.Abs(opss2 + 3 * x) % 6;
        res["Opss3"] = opss3;
        res["Ock"] = Math.Abs(ock + x) % 7;
        res["Hcc"] = (hcc + 3 * x) % hcc;
        return res;
    }
}