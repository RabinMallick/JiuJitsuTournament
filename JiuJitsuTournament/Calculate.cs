using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace JiuJitsuTournament
{
    class Calculate
    {
        int[] Fin, Fly, Bantam, Feather, Welter, Middle, Heavy,
              Men, Women, Kids,
              BlackBelt, WhiteBelt, PurpleBelt, BlueBelt, BrownBelt,
              Novice, Beginner, Intermediate, Advanced;

        Constraints[] constrains;

        public static void SeparateGroups(Excel.Range xlRange)
        {
            int rowCount = xlRange.Rows.Count + 1;
            int colCount = xlRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (j == 1)
                        Console.Write("\r\n");

                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");
                }
            }
        }

    }
}
