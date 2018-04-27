using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace JiuJitsuTournament
{
    class read_from_excel
    {
        public static Categories categories = new Categories();

        public static void getExcelFile(String filepath,Constraints constraints)
        {

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filepath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count+1;
            int colCount = xlRange.Columns.Count;

            for (int i = 2; i <= rowCount; i++)
            {
                if (xlRange.Cells[i, 6] != null && xlRange.Cells[i, 6].Value2 != null)
                {
                    if(Convert.ToInt16(xlRange.Cells[i,5].Value2) <= Convert.ToInt16(constraints.KidsMaxAge))
                    {
                        Console.WriteLine("Kids Found !");
                        if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "NOVICE")
                        {
                            categories.KidsNovice.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                        }
                        else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BEGINNER")
                        {
                            categories.KidsBeginner.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                        }
                        else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "INTERMEDIATE")
                        {
                            categories.KidsIntermediate.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                        }
                        else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "ADVANCED")
                        {
                            categories.KidsAdvanced.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                        }
                        else
                        {
                            categories.KidzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                        }
                    }
                    else if (xlRange.Cells[i, 6].Value2.ToString() == "male")
                    {
                        if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.MenzFin))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT" )
                            {
                                categories.MenzFinBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.MenzFinWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.MenzFinPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.MenzFinBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.MenzFinBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.MenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.MenzFlyLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.MenzFlyHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.MenzFlyBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.MenzFlyWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.MenzFlyPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.MenzFlyBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.MenzFlyBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.MenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.MenzBantamLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.MenzBantamHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.MenzBantamBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.MenzBantamWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.MenzBantamPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.MenzBantamBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.MenzBantamBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.MenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.MenzFeatherLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.MenzFeatherHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.MenzFeatherBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.MenzFeatherWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.MenzFeatherPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.MenzFeatherBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.MenzFeatherBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.MenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.MenzLightLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.MenzLightHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.MenzLightBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.MenzLightWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.MenzLightPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.MenzLightBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.MenzLightBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.MenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.MenzWelterLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.MenzWelterHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.MenzWelterBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.MenzWelterWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.MenzWelterPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.MenzWelterBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.MenzWelterBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.MenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.MenzMiddleLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.MenzMiddleHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.MenzMiddleBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.MenzMiddleWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.MenzMiddlePurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.MenzMiddleBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.MenzMiddleBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.MenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.MenzHeavy))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.MenzHeavyBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.MenzHeavyWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.MenzHeavyPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.MenzHeavyBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.MenzHeavyBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.MenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        
                    }
                    else if (xlRange.Cells[i, 6].Value2.ToString() == "female")
                    {
                        if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.WomenzFin))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.WomenzFinBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.WomenzFinWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.WomenzFinPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.WomenzFinBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.WomenzFinBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.WomenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.WomenzFlyLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.WomenzFlyHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.WomenzFlyBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.WomenzFlyWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.WomenzFlyPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.WomenzFlyBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.WomenzFlyBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.WomenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.WomenzBantamLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.WomenzBantamHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.WomenzBantamBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.WomenzBantamWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.WomenzBantamPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.WomenzBantamBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.WomenzBantamBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.WomenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.WomenzFeatherLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.WomenzFeatherHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.WomenzFeatherBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.WomenzFeatherWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.WomenzFeatherPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.WomenzFeatherBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.WomenzFeatherBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.WomenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.WomenzLightLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.WomenzLightHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.WomenzLightBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.WomenzLightWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.WomenzLightPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.WomenzLightBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.WomenzLightBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.WomenzWelterLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.WomenzWelterHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.WomenzWelterBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.WomenzWelterWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.WomenzWelterPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.WomenzWelterBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.WomenzWelterBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.WomenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.WomenzMiddleLow) && Convert.ToDouble(xlRange.Cells[i, 4].Value2) <= Convert.ToDouble(constraints.WomenzMiddleHigh))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.WomenzMiddleBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.WomenzMiddleWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.WomenzMiddlePurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.WomenzMiddleBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.WomenzMiddleBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.WomenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }
                        else if (Convert.ToDouble(xlRange.Cells[i, 4].Value2) >= Convert.ToDouble(constraints.WomenzHeavy))
                        {
                            if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLACK BELT")
                            {
                                categories.WomenzHeavyBlackBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "WHITE BELT")
                            {
                                categories.WomenzHeavyWhiteBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "PURPLE BELT")
                            {
                                categories.WomenzHeavyPurpleBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BLUE BELT")
                            {
                                categories.WomenzHeavyBlueBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else if (xlRange.Cells[i, 3].Value2.ToString().ToUpper() == "BROWN BELT")
                            {
                                categories.WomenzHeavyBrownBelt.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                            else
                            {
                                categories.WomenzError.Add(Convert.ToInt16(xlRange.Cells[i, 1].Value2));
                            }
                        }

                    }
                }
                
            }

            //categories.MenzHeavyBrownBelt.ForEach(Console.WriteLine);

            GC.Collect();
            GC.WaitForPendingFinalizers();


            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
