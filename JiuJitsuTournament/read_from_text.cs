using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JiuJitsuTournament
{
    class read_from_text
    {
        /*public static Categories categories = null;

        public static void getTextData(String filepath, Constraints constraints)
        {
            categories = new Categories();
            string[] lines = System.IO.File.ReadAllLines(filepath);

            foreach (string line in lines)
            {
                Char delimiter= '*';
                String[] substrings = line.Split(delimiter);

                if(substrings.Length > 2)
                {
                    string name = substrings[6];

                    if (substrings[1].Contains("Adult"))
                    {
                        string resultString = Regex.Match(substrings[5], @"\d+").Value;
                        double weight = Double.Parse(resultString);
                        if (substrings[2].Contains("MEN"))
                        {
                            if (substrings[3].Contains("White"))
                            {
                                if (weight <= constraints.MenzFin)
                                {
                                    categories.MenzFinWhiteBelt.Add(name);
                                }
                                else if(weight >= constraints.MenzFlyLow && weight <= constraints.MenzFlyHigh)
                                {
                                    categories.MenzFlyWhiteBelt.Add(name);
                                }
                                else if( weight >= constraints.MenzBantamLow && weight <= constraints.MenzFeatherHigh)
                                {
                                    categories.MenzBantamWhiteBelt.Add(name);
                                }
                                else if(weight >= constraints.MenzFeatherLow && weight <= constraints.MenzFeatherHigh)
                                {
                                    categories.MenzFeatherWhiteBelt.Add(name);
                                }
                                else if(weight >= constraints.MenzLightLow && weight <= constraints.MenzLightHigh)
                                {
                                    categories.MenzLightWhiteBelt.Add(name);
                                }
                                else if(weight >= constraints.MenzWelterLow && weight <= constraints.MenzWelterHigh)
                                {
                                    categories.MenzWelterWhiteBelt.Add(name);
                                }
                                else if(weight >= constraints.MenzMiddleLow && weight <= constraints.MenzWelterHigh)
                                {
                                    categories.MenzMiddleWhiteBelt.Add(name);
                                }
                                else if(weight >= constraints.MenzHeavy)
                                {
                                    categories.MenzHeavyWhiteBelt.Add(name);
                                }
                                else
                                {
                                    categories.MenzError.Add(name);
                                }
                            }
                            else if (substrings[3].Contains("Black"))
                            {
                                if (weight <= constraints.MenzFin)
                                {
                                    categories.MenzFinBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzFlyLow && weight <= constraints.MenzFlyHigh)
                                {
                                    categories.MenzFlyBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzBantamLow && weight <= constraints.MenzFeatherHigh)
                                {
                                    categories.MenzBantamBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzFeatherLow && weight <= constraints.MenzFeatherHigh)
                                {
                                    categories.MenzFeatherBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzLightLow && weight <= constraints.MenzLightHigh)
                                {
                                    categories.MenzLightBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzWelterLow && weight <= constraints.MenzWelterHigh)
                                {
                                    categories.MenzWelterBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzMiddleLow && weight <= constraints.MenzWelterHigh)
                                {
                                    categories.MenzMiddleBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzHeavy)
                                {
                                    categories.MenzHeavyBlackBelt.Add(name);
                                }
                                else
                                {
                                    categories.MenzError.Add(name);
                                }
                            }
                            else if (substrings[3].Contains("Blue"))
                            {
                                if (weight <= constraints.MenzFin)
                                {
                                    categories.MenzFinBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzFlyLow && weight <= constraints.MenzFlyHigh)
                                {
                                    categories.MenzFlyBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzBantamLow && weight <= constraints.MenzFeatherHigh)
                                {
                                    categories.MenzBantamBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzFeatherLow && weight <= constraints.MenzFeatherHigh)
                                {
                                    categories.MenzFeatherBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzLightLow && weight <= constraints.MenzLightHigh)
                                {
                                    categories.MenzLightBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzWelterLow && weight <= constraints.MenzWelterHigh)
                                {
                                    categories.MenzWelterBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzMiddleLow && weight <= constraints.MenzWelterHigh)
                                {
                                    categories.MenzMiddleBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzHeavy)
                                {
                                    categories.MenzHeavyBlueBelt.Add(name);
                                }
                                else
                                {
                                    categories.MenzError.Add(name);
                                }
                            }
                            else if (substrings[3].Contains("Purple"))
                            {
                                if (weight <= constraints.MenzFin)
                                {
                                    categories.MenzFinPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzFlyLow && weight <= constraints.MenzFlyHigh)
                                {
                                    categories.MenzFlyPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzBantamLow && weight <= constraints.MenzFeatherHigh)
                                {
                                    categories.MenzBantamPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzFeatherLow && weight <= constraints.MenzFeatherHigh)
                                {
                                    categories.MenzFeatherPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzLightLow && weight <= constraints.MenzLightHigh)
                                {
                                    categories.MenzLightPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzWelterLow && weight <= constraints.MenzWelterHigh)
                                {
                                    categories.MenzWelterPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzMiddleLow && weight <= constraints.MenzWelterHigh)
                                {
                                    categories.MenzMiddlePurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzHeavy)
                                {
                                    categories.MenzHeavyPurpleBelt.Add(name);
                                }
                                else
                                {
                                    categories.MenzError.Add(name);
                                }
                            }
                            else if (substrings[3].Contains("Brown"))
                            {
                                if (weight <= constraints.MenzFin)
                                {
                                    categories.MenzFinBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzFlyLow && weight <= constraints.MenzFlyHigh)
                                {
                                    categories.MenzFlyBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzBantamLow && weight <= constraints.MenzFeatherHigh)
                                {
                                    categories.MenzBantamBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzFeatherLow && weight <= constraints.MenzFeatherHigh)
                                {
                                    categories.MenzFeatherBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzLightLow && weight <= constraints.MenzLightHigh)
                                {
                                    categories.MenzLightBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzWelterLow && weight <= constraints.MenzWelterHigh)
                                {
                                    categories.MenzWelterBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzMiddleLow && weight <= constraints.MenzWelterHigh)
                                {
                                    categories.MenzMiddleBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzHeavy)
                                {
                                    categories.MenzHeavyBrownBelt.Add(name);
                                }
                                else
                                {
                                    categories.MenzError.Add(name);
                                }
                            }
                            else
                            {
                                categories.MenzError.Add(name);
                            }
                        }
                        else if (substrings[2].Contains("FEMALE"))
                        {
                            if (substrings[3].Contains("White"))
                            {
                                if (weight <= constraints.WomenzFin)
                                {
                                    categories.WomenzFinWhiteBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzFlyLow && weight <= constraints.WomenzFlyHigh)
                                {
                                    categories.WomenzFlyWhiteBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzBantamLow && weight <= constraints.WomenzFeatherHigh)
                                {
                                    categories.WomenzBantamWhiteBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzFeatherLow && weight <= constraints.WomenzFeatherHigh)
                                {
                                    categories.WomenzFeatherWhiteBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzLightLow && weight <= constraints.WomenzLightHigh)
                                {
                                    categories.WomenzLightWhiteBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzWelterLow && weight <= constraints.WomenzWelterHigh)
                                {
                                    categories.WomenzWelterWhiteBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzMiddleLow && weight <= constraints.WomenzWelterHigh)
                                {
                                    categories.WomenzMiddleWhiteBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzHeavy)
                                {
                                    categories.WomenzHeavyWhiteBelt.Add(name);
                                }
                                else
                                {
                                    categories.WomenzError.Add(name);
                                }
                            }
                            else if (substrings[3].Contains("Black"))
                            {
                                if (weight <= constraints.WomenzFin)
                                {
                                    categories.WomenzFinBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzFlyLow && weight <= constraints.WomenzFlyHigh)
                                {
                                    categories.WomenzFlyBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzBantamLow && weight <= constraints.WomenzFeatherHigh)
                                {
                                    categories.WomenzBantamBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzFeatherLow && weight <= constraints.WomenzFeatherHigh)
                                {
                                    categories.WomenzFeatherBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzLightLow && weight <= constraints.WomenzLightHigh)
                                {
                                    categories.WomenzLightBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzWelterLow && weight <= constraints.WomenzWelterHigh)
                                {
                                    categories.WomenzWelterBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzMiddleLow && weight <= constraints.WomenzWelterHigh)
                                {
                                    categories.WomenzMiddleBlackBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzHeavy)
                                {
                                    categories.WomenzHeavyBlackBelt.Add(name);
                                }
                                else
                                {
                                    categories.WomenzError.Add(name);
                                }
                            }
                            else if (substrings[3].Contains("Blue"))
                            {
                                if (weight <= constraints.MenzFin)
                                {
                                    categories.WomenzFinBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzFlyLow && weight <= constraints.WomenzFlyHigh)
                                {
                                    categories.WomenzFlyBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzBantamLow && weight <= constraints.WomenzFeatherHigh)
                                {
                                    categories.WomenzBantamBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzFeatherLow && weight <= constraints.WomenzFeatherHigh)
                                {
                                    categories.WomenzFeatherBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzLightLow && weight <= constraints.WomenzLightHigh)
                                {
                                    categories.WomenzLightBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzWelterLow && weight <= constraints.WomenzWelterHigh)
                                {
                                    categories.WomenzWelterBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzMiddleLow && weight <= constraints.WomenzWelterHigh)
                                {
                                    categories.WomenzMiddleBlueBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzHeavy)
                                {
                                    categories.WomenzHeavyBlueBelt.Add(name);
                                }
                                else
                                {
                                    categories.WomenzError.Add(name);
                                }
                            }
                            else if (substrings[3].Contains("Purple"))
                            {
                                if (weight <= constraints.WomenzFin)
                                {
                                    categories.WomenzFinPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzFlyLow && weight <= constraints.WomenzFlyHigh)
                                {
                                    categories.WomenzFlyPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzBantamLow && weight <= constraints.WomenzFeatherHigh)
                                {
                                    categories.WomenzBantamPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzFeatherLow && weight <= constraints.WomenzFeatherHigh)
                                {
                                    categories.WomenzFeatherPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzLightLow && weight <= constraints.WomenzLightHigh)
                                {
                                    categories.WomenzLightPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzWelterLow && weight <= constraints.WomenzWelterHigh)
                                {
                                    categories.WomenzWelterPurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzMiddleLow && weight <= constraints.WomenzWelterHigh)
                                {
                                    categories.WomenzMiddlePurpleBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzHeavy)
                                {
                                    categories.WomenzHeavyPurpleBelt.Add(name);
                                }
                                else
                                {
                                    categories.WomenzError.Add(name);
                                }
                            }
                            else if (substrings[3].Contains("Brown"))
                            {
                                if (weight <= constraints.WomenzFin)
                                {
                                    categories.WomenzFinBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzFlyLow && weight <= constraints.WomenzFlyHigh)
                                {
                                    categories.WomenzFlyBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzBantamLow && weight <= constraints.WomenzFeatherHigh)
                                {
                                    categories.WomenzBantamBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzFeatherLow && weight <= constraints.WomenzFeatherHigh)
                                {
                                    categories.WomenzFeatherBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzLightLow && weight <= constraints.WomenzLightHigh)
                                {
                                    categories.WomenzLightBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzWelterLow && weight <= constraints.WomenzWelterHigh)
                                {
                                    categories.WomenzWelterBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.WomenzMiddleLow && weight <= constraints.WomenzWelterHigh)
                                {
                                    categories.WomenzMiddleBrownBelt.Add(name);
                                }
                                else if (weight >= constraints.MenzHeavy)
                                {
                                    categories.WomenzHeavyBrownBelt.Add(name);
                                }
                                else
                                {
                                    categories.WomenzError.Add(name);
                                }
                            }
                            else
                            {
                                categories.WomenzError.Add(name);
                            }
                        }
                    }
                    else if (substrings[2].Contains("Kids"))
                    {
                        if (substrings[3].Contains("Novice"))
                        {
                            categories.KidsNovice.Add(name);
                        }
                        else if (substrings[3].Contains("Beginner"))
                        {
                            categories.KidsBeginner.Add(name);
                        }
                        else if (substrings[3].Contains("Intermediate"))
                        {
                            categories.KidsIntermediate.Add(name);
                        }
                        else if (substrings[3].Contains("Advanced"))
                        {
                            categories.KidsAdvanced.Add(name);
                        }
                        else
                        {
                            categories.KidzError.Add(name);
                        }
                    }
                }
            }

            Generate.generate(categories);

        }
        */
    }
}

