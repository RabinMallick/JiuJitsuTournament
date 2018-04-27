using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace JiuJitsuTournament
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        String filepath = "";
        Constraints constraints = new Constraints();
        private static string message = "Brackets created successfully!!! \nCheck folder C:/ Tournament_Bracket /";

        public static string Message { get => message; set => message = value; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox29_Click(object sender, EventArgs e)
        {

        }

        private bool isDouble(string number)
        {
            double price;
            bool isDouble = Double.TryParse(number, out price);
            return isDouble;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (filepath == "")
            {
                MessageBox.Show("Please select a text file containing participants list first !");
            }
            else if ( menzFin.Text == ""
                || menzFlyLow.Text == "" || menzFlyHigh.Text == "" || menzBantamLow.Text == "" || menzBantamHigh.Text == ""
                || menzFeatherLow.Text == "" || menzFeatherHigh.Text == "" || menzLightLow.Text == "" || menzLightHigh.Text == ""
                || menzMiddleLow.Text == "" || menzMiddleHigh.Text == "" || menzWelterLow.Text == "" || menzWelterHigh.Text == ""
                || menzHeavy.Text == ""
                || womenzFin.Text == ""
                || womenzFlyLow.Text == "" || womenzFlyHigh.Text == "" || womenzBantamLow.Text == "" || womenzBantamHigh.Text == ""
                || womenzFeatherLow.Text == "" || womenzFeatherHigh.Text == "" || womenzLightLow.Text == "" || womenzLightHigh.Text == ""
                || womenzMiddleLow.Text == "" || womenzMiddleHigh.Text == "" || womenzWelterLow.Text == "" || womenzWelterHigh.Text == ""
                || womenzHeavy.Text == ""
            )
            {
                MessageBox.Show("Text fields can not be empty!");
            }
            else if (!isDouble(menzFin.Text) 
                || !isDouble(menzFlyLow.Text) || !isDouble(menzFlyHigh.Text) || !isDouble(menzBantamLow.Text) || !isDouble(menzBantamHigh.Text)
                || !isDouble(menzFeatherLow.Text) || !isDouble(menzFeatherHigh.Text) || !isDouble(menzLightLow.Text) || !isDouble(menzLightHigh.Text)
                || !isDouble(menzMiddleLow.Text) || !isDouble(menzMiddleHigh.Text) || !isDouble(menzWelterLow.Text) || !isDouble(menzWelterHigh.Text) 
                || !isDouble(menzHeavy.Text)
                || !isDouble(womenzFin.Text)
                || !isDouble(womenzFlyLow.Text) || !isDouble(womenzFlyHigh.Text) || !isDouble(womenzBantamLow.Text) || !isDouble(womenzBantamHigh.Text)
                || !isDouble(womenzFeatherLow.Text) || !isDouble(womenzFeatherHigh.Text) || !isDouble(womenzLightLow.Text) || !isDouble(womenzLightHigh.Text)
                || !isDouble(womenzMiddleLow.Text) || !isDouble(womenzMiddleHigh.Text) || !isDouble(womenzWelterLow.Text) || !isDouble(womenzWelterHigh.Text)
                || !isDouble(womenzHeavy.Text))
            {
                MessageBox.Show("Weight divisions must be numbers !");
            }
            else
            {
                constraints.MenzFin = Double.Parse(menzFin.Text);
                constraints.MenzFlyLow = Double.Parse(menzFlyLow.Text);
                constraints.MenzFlyHigh = Double.Parse(menzFlyHigh.Text);
                constraints.MenzBantamLow = Double.Parse(menzBantamLow.Text);
                constraints.MenzBantamHigh = Double.Parse(menzBantamHigh.Text);
                constraints.MenzFeatherLow = Double.Parse(menzFeatherLow.Text);
                constraints.MenzFeatherHigh = Double.Parse(menzFeatherHigh.Text);
                constraints.MenzLightLow = Double.Parse(menzLightLow.Text);
                constraints.MenzLightHigh = Double.Parse(menzLightHigh.Text);
                constraints.MenzMiddleLow = Double.Parse(menzMiddleLow.Text);
                constraints.MenzMiddleHigh = Double.Parse(menzMiddleHigh.Text);
                constraints.MenzWelterLow = Double.Parse(menzWelterLow.Text);
                constraints.MenzWelterHigh = Double.Parse(menzWelterHigh.Text);
                constraints.MenzHeavy = Double.Parse(menzHeavy.Text);

                constraints.WomenzFin = Double.Parse(womenzFin.Text);
                constraints.WomenzFlyLow = Double.Parse(womenzFlyLow.Text);
                constraints.WomenzFlyHigh = Double.Parse(womenzFlyHigh.Text);
                constraints.WomenzBantamLow = Double.Parse(womenzBantamLow.Text);
                constraints.WomenzBantamHigh = Double.Parse(womenzBantamHigh.Text);
                constraints.WomenzFeatherLow = Double.Parse(womenzFeatherLow.Text);
                constraints.WomenzFeatherHigh = Double.Parse(womenzFeatherHigh.Text);
                constraints.WomenzLightLow = Double.Parse(womenzLightLow.Text);
                constraints.WomenzLightHigh = Double.Parse(womenzLightHigh.Text);
                constraints.WomenzMiddleLow = Double.Parse(womenzMiddleLow.Text);
                constraints.WomenzMiddleHigh = Double.Parse(womenzMiddleHigh.Text);
                constraints.WomenzWelterLow = Double.Parse(womenzWelterLow.Text);
                constraints.WomenzWelterHigh = Double.Parse(womenzWelterHigh.Text);
                constraints.WomenzHeavy = Double.Parse(womenzHeavy.Text);

                //read_from_excel.getExcelFile(filepath,constraints);
                //read_from_text.getTextData(filepath, constraints);
                Message = "Brackets created successfully!!! \nCheck folder C:/ Tournament_Bracket /";
                read_from_raw_text.getTextData(filepath, constraints);
                MessageBox.Show(Message);
            }
        }

    }
}
