using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HorasExtrasX
{
    class ExcelProcess
    {


        private static int INDEX_CELL_EVENTOS = 10;

        public Dictionary<string, string> process(string filepath)
        {
            Dictionary<string, string> mapa = new Dictionary<string, string>();

            using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                XSSFWorkbook wb = new XSSFWorkbook(fs);

                //primeira planilha
                XSSFSheet sh = (XSSFSheet)wb.GetSheetAt(0);

                IEnumerator enumerator = sh.GetRowEnumerator();
                while (enumerator.MoveNext())
                {
                    if (enumerator.Current != null)
                    {
                        IRow row = (IRow)enumerator.Current;

                        if (row.GetCell(INDEX_CELL_EVENTOS) != null)
                        {
                            string evento = row.GetCell(INDEX_CELL_EVENTOS).ToString();

                            if (Char.IsNumber(evento, 0))
                            {
                                string horas = evento.Substring(0, 5);
                                string data = row.GetCell(0).ToString();

                                if (evento.Contains("Débito Banco Horas"))
                                {
                                    mapa.Add(data, "-" + horas);
                                }
                                else if (evento.Contains("Crédito Banco Horas"))
                                {
                                    mapa.Add(data, horas);
                                }
                            }
                        }
                    }

                }
            }

            return mapa;
        }

    }
}
