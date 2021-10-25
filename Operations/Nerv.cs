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
    public Dictionary<String, double> Сompensation(int hcc, int opss1, int opss2, int opss3, int ock, double t, Dictionary<string, bool> WhatIsBlocked)
    {
        var res = new Dictionary<String, double>();
        double x;
        x = mathematics.FindRoots(hcc, opss1, opss2, opss3, ock, t, WhatIsBlocked);

        if (WhatIsBlocked["Opss1"] == false)
        {
            res["Opss1"] = Math.Abs(opss1 + 3 * x) % 6;
        }
        else
        {
            res["Opss1"] = opss1;
        }

        if (WhatIsBlocked["Opss2"] == false)
        {
            res["Opss2"] = Math.Abs(opss2 + 3 * x) % 6;
        }
        else
        {
            res["Opss2"] = opss2;
        }
        if (WhatIsBlocked["Opss3"] == false)
        {
            res["Opss3"] = Math.Abs(opss3 + 3 * x) % 6;
        }
        else
        {
            res["Opss3"] = opss3;
        }
        if (WhatIsBlocked["Ock"] == false)
        {
            res["Ock"] = Math.Abs(ock + x) % 7;
        }
        else
        {
            res["Ock"] = ock;
        }

        if (WhatIsBlocked["Hcc"] == false)
        {
            res["Hcc"] = (hcc + 3 * x) % hcc;
        }
        else
        {
            res["Hcc"] = hcc;
        }

        return res;
    }
}