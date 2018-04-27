using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Reflection;

namespace JiuJitsuTournament
{
    class generate_pdf
    {
        public static void generate_bracket(List<string> category, string name,string tmtName)
        {
            string path = "C:/Tournament_Bracket/";
            System.IO.Directory.CreateDirectory(path);

            try
            {
                FileStream fs = new FileStream(path + name + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                BaseFont f_cn = BaseFont.CreateFont("c:\\windows\\fonts\\calibri.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                int maxNum = category.Count / 2;
                int matchCount = 0;

                int width = 25;
                int margin = 150;
                int distance = 15;
                int separation = 20;
                int initialHeight;
                int height = initialHeight = 680;
                int x1, x2, x3, x4, y1, y2, y3, y4;

                int newMax = maxNum / 2;

                doc.Open();

                PdfContentByte cb = writer.DirectContent;
                int counter = 0;

                while (maxNum >= 1)
                {
                    for (int i = 0; i < maxNum; i++)
                    {

                        int textMargin = margin - 15;

                        x1 = margin;
                        y1 = height;
                        x2 = x1 + width;
                        y2 = y1;

                        // player 1
                        cb.MoveTo(x1, y1);
                        cb.LineTo(x2, y2);

                        x3 = x1;
                        x4 = x2;
                        y3 = y1 - distance;
                        y4 = y3;

                        // player 2
                        cb.MoveTo(x3, y3);
                        cb.LineTo(x4, y4);

                        //join
                        cb.MoveTo(x2, y1);
                        cb.LineTo(x2, y3);

                        int matchNoMargin = x2 - 15;
                        matchCount++;

                        cb.BeginText();
                        cb.SetFontAndSize(f_cn, 6);
                        cb.SetTextMatrix(matchNoMargin, y4 + distance / 2);
                        cb.ShowText(matchCount + ")");
                        cb.EndText();

                        height = height - separation;
                    }

                    counter++;
                    maxNum = maxNum / 2;
                    margin = margin + 25;
                    distance = distance + (5 * counter * counter);
                    height = initialHeight - distance / 2;
                    separation = separation * 2;

                }

                height = initialHeight;
                int count = category.Count;
                int nameDistance = 15;
                if (category.Count > 64)
                {
                    count = 64;
                }
                for (int i = 0; i < count; i++)
                {
                    cb.BeginText();
                    cb.SetFontAndSize(f_cn, 6);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, category.ElementAt(i), 145, height, 0);
                    cb.EndText();

                    if (i % 2 == 0)
                    {
                        height = height - nameDistance;
                        nameDistance = 5;
                    }
                    else
                    {
                        height = height - nameDistance;
                        nameDistance = 15;
                    }
                }

                PdfContentByte Canvas = writer.DirectContent;
                Canvas.SetColorStroke(BaseColor.CYAN);
                Canvas.Stroke();



                cb.Stroke();

                cb.BeginText();
                cb.SetFontAndSize(f_cn, 14);
                cb.SetTextMatrix(236, 790);
                cb.SetColorFill(BaseColor.GRAY);
                cb.ShowText("Tournament Bracket ");
                cb.EndText();

                cb.BeginText();
                cb.SetFontAndSize(f_cn, 8);
                cb.SetTextMatrix(258, 780);
                cb.ShowText("Created at : " + DateTime.Now.ToShortDateString());
                cb.EndText();

                cb.BeginText();
                cb.SetFontAndSize(f_cn, 8);
                cb.SetTextMatrix(270, 770);
                cb.ShowText("Time : " + DateTime.Now.ToShortTimeString());
                cb.EndText();

                cb.BeginText();
                cb.SetFontAndSize(f_cn, 11);
                cb.SetTextMatrix(70, 745);
                cb.ShowText("# Tournament : " + tmtName);
                cb.EndText();

                cb.BeginText();
                cb.SetFontAndSize(f_cn, 11);
                cb.SetTextMatrix(70, 730);
                cb.ShowText("# Division : "+name);
                cb.EndText();

                cb.BeginText();
                cb.SetFontAndSize(f_cn, 11);
                cb.SetTextMatrix(70, 715);
                cb.ShowText("# Total No. of Participants : " + category.Count);
                cb.EndText();

                PdfContentByte line = writer.DirectContent;
                line.SetColorStroke(BaseColor.LIGHT_GRAY);

                line.MoveTo(35, doc.Top - 45f);
                line.LineTo(560, doc.Top - 45f);
                line.Stroke();

                cb.MoveTo(35, doc.Top - 100f);
                cb.LineTo(560, doc.Top - 100f);
                cb.Stroke();


                doc.Close();
                writer.Close();
                fs.Close();
            }catch(Exception E)
            {
                Form1.Message = E.Message;
            }
        }


    }
}
