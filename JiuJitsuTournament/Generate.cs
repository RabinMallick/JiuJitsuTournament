using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuJitsuTournament
{
    class Generate
    {
        public static void generate(Categories categories,string tmtName)
        {
            if (categories.MenzFinBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFinBlackBelt, "Mens_Straw_Weight_Black_Belt",tmtName);
            }
            if (categories.MenzFinWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFinWhiteBelt, "Mens_Straw_Weight_White_Belt",tmtName);
            }
            if (categories.MenzFinPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFinPurpleBelt, "Mens_Straw_Weight_Purple_Belt", tmtName);
            }
            if (categories.MenzFinBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFinBlueBelt, "Mens_Straw_Weight_Blue_Belt", tmtName);
            }
            if (categories.MenzFinBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFinBrownBelt, "Mens_Straw_Weight_Brown_Belt", tmtName);
            }

            if (categories.MenzFlyBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFlyBlackBelt, "Mens_Fly_Black_Belt", tmtName);
            }
            if (categories.MenzFlyWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFlyWhiteBelt, "Mens_Fly_White_Belt", tmtName);
            }
            if (categories.MenzFlyPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFlyPurpleBelt, "Mens_Fly_Purple_Belt", tmtName);
            }
            if (categories.MenzFlyBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFlyBlueBelt, "Mens_Fly_Blue_Belt", tmtName);
            }
            if (categories.MenzFlyBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFlyBrownBelt, "Mens_Fly_Brown_Belt", tmtName);
            }

            if (categories.MenzBantamBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzBantamBlackBelt, "Mens_Bantam_Black_Belt", tmtName);
            }
            if (categories.MenzBantamWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzBantamWhiteBelt, "Mens_Bantam_White_Belt", tmtName);
            }
            if (categories.MenzBantamPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzBantamPurpleBelt, "Mens_Bantam_Purple_Belt", tmtName);
            }
            if (categories.MenzBantamBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzBantamBlueBelt, "Mens_Bantam_Blue_Belt", tmtName);
            }
            if (categories.MenzBantamBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzBantamBrownBelt, "Mens_Bantam_Brown_Belt", tmtName);
            }

            if (categories.MenzFeatherBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFeatherBlackBelt, "Mens_Feather_Black_Belt", tmtName);
            }
            if (categories.MenzFeatherWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFeatherWhiteBelt, "Mens_Feather_White_Belt", tmtName);
            }
            if (categories.MenzFeatherPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFeatherPurpleBelt, "Mens_Feather_Purple_Belt", tmtName);
            }
            if (categories.MenzFeatherBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFeatherBlueBelt, "Mens_Feather_Blue_Belt", tmtName);
            }
            if (categories.MenzFeatherBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzFeatherBrownBelt, "Mens_Feather_Brown_Belt", tmtName);
            }

            if (categories.MenzLightBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzLightBlackBelt, "Mens_Light_Black_Belt", tmtName);
            }
            if (categories.MenzLightWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzLightWhiteBelt, "Mens_Light_White_Belt", tmtName);
            }
            if (categories.MenzLightPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzLightPurpleBelt, "Mens_Light_Purple_Belt", tmtName);
            }
            if (categories.MenzLightBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzLightBlueBelt, "Mens_Light_Blue_Belt", tmtName);
            }
            if (categories.MenzLightBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzLightBrownBelt, "Mens_Light_Brown_Belt", tmtName);
            }

            if (categories.MenzWelterBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzWelterBlackBelt, "Mens_Welter_Black_Belt", tmtName);
            }
            if (categories.MenzWelterWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzWelterWhiteBelt, "Mens_Welter_White_Belt", tmtName);
            }
            if (categories.MenzWelterPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzWelterPurpleBelt, "Mens_Welter_Purple_Belt", tmtName);
            }
            if (categories.MenzWelterBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzWelterBlueBelt, "Mens_Welter_Blue_Belt", tmtName);
            }
            if (categories.MenzWelterBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzWelterBrownBelt, "Mens_Weltert_Brown_Belt", tmtName);
            }

            if (categories.MenzMiddleBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzMiddleBlackBelt, "Mens_Middle_Black_Belt", tmtName);
            }
            if (categories.MenzMiddleWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzMiddleWhiteBelt, "Mens_Middle_White_Belt", tmtName);
            }
            if (categories.MenzMiddlePurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzMiddlePurpleBelt, "Mens_Middle_Purple_Belt", tmtName);
            }
            if (categories.MenzMiddleBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzMiddleBlueBelt, "Mens_Middle_Blue_Belt", tmtName);
            }
            if (categories.MenzMiddleBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzMiddleBrownBelt, "Mens_Middle_Brown_Belt", tmtName);
            }

            if (categories.MenzHeavyBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzHeavyBlackBelt, "Mens_Heavy_Black_Belt", tmtName);
            }
            if (categories.MenzHeavyWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzHeavyWhiteBelt, "Mens_Heavy_White_Belt", tmtName);
            }
            if (categories.MenzHeavyPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzHeavyPurpleBelt, "Mens_Heavy_Purple_Belt", tmtName);
            }
            if (categories.MenzHeavyBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzHeavyBlueBelt, "Mens_Heavy_Blue_Belt", tmtName);
            }
            if (categories.MenzHeavyBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.MenzHeavyBrownBelt, "Mens_Heavy_Brown_Belt", tmtName);
            }

            //Women Brackets 

            if (categories.WomenzFinBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFinBlackBelt, "Womens_Straw_Weight_Black_Belt", tmtName);
            }
            if (categories.WomenzFinWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFinWhiteBelt, "Womens_Straw_Weight_White_Belt", tmtName);
            }
            if (categories.WomenzFinPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFinPurpleBelt, "Womens_Straw_Weight_Purple_Belt", tmtName);
            }
            if (categories.WomenzFinBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFinBlueBelt, "Womens_Straw_Weight_Blue_Belt", tmtName);
            }
            if (categories.WomenzFinBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFinBrownBelt, "Womens_Straw_Weight_Brown_Belt", tmtName);
            }

            if (categories.WomenzFlyBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFlyBlackBelt, "Womens_Fly_Black_Belt", tmtName);
            }
            if (categories.WomenzFlyWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFlyWhiteBelt, "Womens_Fly_White_Belt", tmtName);
            }
            if (categories.WomenzFlyPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFlyPurpleBelt, "Womens_Fly_Purple_Belt", tmtName);
            }
            if (categories.WomenzFlyBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFlyBlueBelt, "Womens_Fly_Blue_Belt", tmtName);
            }
            if (categories.WomenzFlyBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFlyBrownBelt, "Womens_Fly_Brown_Belt", tmtName);
            }

            if (categories.WomenzBantamBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzBantamBlackBelt, "Womens_Bantam_Black_Belt", tmtName);
            }
            if (categories.WomenzBantamWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzBantamWhiteBelt, "Womens_Bantam_White_Belt", tmtName);
            }
            if (categories.WomenzBantamPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzBantamPurpleBelt, "Womens_Bantam_Purple_Belt", tmtName);
            }
            if (categories.WomenzBantamBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzBantamBlueBelt, "Womens_Bantam_Blue_Belt", tmtName);
            }
            if (categories.WomenzBantamBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzBantamBrownBelt, "Womens_Bantam_Brown_Belt", tmtName);
            }

            if (categories.WomenzFeatherBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFeatherBlackBelt, "Womens_Feather_Black_Belt", tmtName);
            }
            if (categories.WomenzFeatherWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFeatherWhiteBelt, "Womens_Feather_White_Belt", tmtName);
            }
            if (categories.WomenzFeatherPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFeatherPurpleBelt, "Womens_Feather_Purple_Belt", tmtName);
            }
            if (categories.WomenzFeatherBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFeatherBlueBelt, "Womens_Feather_Blue_Belt", tmtName);
            }
            if (categories.WomenzFeatherBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzFeatherBrownBelt, "Womens_Feather_Brown_Belt", tmtName);
            }

            if (categories.WomenzLightBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzLightBlackBelt, "Womens_Light_Black_Belt", tmtName);
            }
            if (categories.WomenzLightWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzLightWhiteBelt, "Womens_Light_White_Belt", tmtName);
            }
            if (categories.WomenzLightPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzLightPurpleBelt, "Womens_Light_Purple_Belt", tmtName);
            }
            if (categories.WomenzLightBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzLightBlueBelt, "Womens_Light_Blue_Belt", tmtName);
            }
            if (categories.WomenzLightBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzLightBrownBelt, "Womens_Light_Brown_Belt", tmtName);
            }

            if (categories.WomenzWelterBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzWelterBlackBelt, "Womens_Welter_Black_Belt", tmtName);
            }
            if (categories.WomenzWelterWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzWelterWhiteBelt, "Womens_Welter_White_Belt", tmtName);
            }
            if (categories.WomenzWelterPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzWelterPurpleBelt, "Womens_Welter_Purple_Belt", tmtName);
            }
            if (categories.WomenzWelterBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzWelterBlueBelt, "Womens_Welter_Blue_Belt", tmtName);
            }
            if (categories.WomenzWelterBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzWelterBrownBelt, "Womens_Weltert_Brown_Belt", tmtName);
            }

            if (categories.WomenzMiddleBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzMiddleBlackBelt, "Womens_Middle_Black_Belt", tmtName);
            }
            if (categories.WomenzMiddleWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzMiddleWhiteBelt, "Womens_Middle_White_Belt", tmtName);
            }
            if (categories.WomenzMiddlePurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzMiddlePurpleBelt, "Womens_Middle_Purple_Belt", tmtName);
            }
            if (categories.WomenzMiddleBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzMiddleBlueBelt, "Womens_Middle_Blue_Belt", tmtName);
            }
            if (categories.WomenzMiddleBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzMiddleBrownBelt, "Womens_Middle_Brown_Belt", tmtName);
            }

            if (categories.WomenzHeavyBlackBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzHeavyBlackBelt, "Womens_Heavy_Black_Belt", tmtName);
            }
            if (categories.WomenzHeavyWhiteBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzHeavyWhiteBelt, "Womens_Heavy_White_Belt", tmtName);
            }
            if (categories.WomenzHeavyPurpleBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzHeavyPurpleBelt, "Womens_Heavy_Purple_Belt", tmtName);
            }
            if (categories.WomenzHeavyBlueBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzHeavyBlueBelt, "Womens_Heavy_Blue_Belt", tmtName);
            }
            if (categories.WomenzHeavyBrownBelt.Count > 1)
            {
                generate_pdf.generate_bracket(categories.WomenzHeavyBrownBelt, "Womens_Heavy_Brown_Belt", tmtName);
            }

            // Kids

            if(categories.KidsNovice.Count > 1)
            {
                generate_pdf.generate_bracket(categories.KidsNovice, "Kids_Novice", tmtName);
            }
            if (categories.KidsBeginner.Count > 1)
            {
                generate_pdf.generate_bracket(categories.KidsBeginner, "Kids_Beginner", tmtName);
            }
            if (categories.KidsIntermediate.Count > 1)
            {
                generate_pdf.generate_bracket(categories.KidsIntermediate, "Kids_Intermediate", tmtName);
            }
            if(categories.KidsAdvanced.Count > 1)
            {
                generate_pdf.generate_bracket(categories.KidsAdvanced, "Kids_Advanced", tmtName);
            }

        }
    }
}
