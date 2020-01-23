using System;
using System.Collections.Generic;

namespace HorasExtrasX
{
    class CalcProcess
    {
        //"c:\\temp", "*.xlsx"

        public string executeCalc(string dirpath)
        {

            ExcelProcess excel = new ExcelProcess();
            TimeSpan total = TimeSpan.Parse("00:00");

            string[] files = System.IO.Directory.GetFiles(dirpath, "*.xlsx");
            foreach (var filepath in files)
            {
                Dictionary<string, string> mapa = excel.process(filepath);

                total = calcular(total, mapa);
            }

            Console.WriteLine("Horas Extras: " + total);

            return total.ToString();
        }

        private TimeSpan calcular(TimeSpan total, Dictionary<string, string> mapa)
        {
            foreach (var k in mapa.Keys)
            {
                string hora = mapa[k];

                total = total.Add(TimeSpan.Parse(hora));
            }
            return total;
        }
    }
}
