using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gods2x2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string cubestate;
        public static List<string> moves = new List<string>();
        public static string temp;
        public static string[] possiblemoves = new string[12] { "R", "R'", "L", "L'", "U", "U'", "D", "D'", "F", "F'", "B", "B'"};
        Random random = new Random();
        public List<string> mov = new List<string>();
        public static string backup;

        private void button1_Click(object sender, EventArgs e)
        {
            moves.Add("N/A");
            update.cs = statebox.Text;
            con("");
            con("Cubestate is: " + statebox.Text);
            console.Refresh();


            //begin preparatory work (checking pieces)

            if (solved())
            {
                done();
                return;
            }

            //Stage 1
            if (update.cs.Substring(18, 3) != update.corner.Substring(18, 3) || update.cs.Substring(21, 3) != update.corner.Substring(21, 3))
            {
                while (update.cs.Substring(18, 3) != update.corner.Substring(18, 3) || update.cs.Substring(21, 3) != update.corner.Substring(21, 3))
                {
                    backup = update.cs;
                    gen(4);
                    foreach (var turn in mov)
                    {
                        update.manipulate(turn);
                    }

                    if (update.cs.Substring(18, 3) != update.corner.Substring(18, 3) || update.cs.Substring(21, 3) != update.corner.Substring(21, 3))
                    {
                        update.cs = backup; //restore original state and try again
                        mov.Clear();
                    }
                }
                con(Environment.NewLine + "Stage 1 solved using moves: ");
                foreach (var VARIABLE in mov)
                {
                    con(VARIABLE);
                }
                console.Refresh();
            }

            //Stage 2
            if (update.cs.Substring(15, 3) != update.corner.Substring(15, 3))
            {
                while (update.cs.Substring(15, 3) != update.corner.Substring(15, 3) || update.cs.Substring(18, 3) != update.corner.Substring(18, 3) || update.cs.Substring(21, 3) != update.corner.Substring(21, 3))
                {
                    backup = update.cs;
                    gen(4);
                    foreach (var turn in mov)
                    {
                        update.manipulate(turn);
                    }

                    if (update.cs.Substring(15, 3) != update.corner.Substring(15, 3) || update.cs.Substring(18, 3) != update.corner.Substring(18, 3) || update.cs.Substring(21, 3) != update.corner.Substring(21, 3))
                    {
                        update.cs = backup; //restore original state and try again
                        mov.Clear();
                    }
                }
                con(Environment.NewLine + "Stage 2 solved using moves: ");
                foreach (var VARIABLE in mov)
                {
                    con(VARIABLE);
                }
            }
            else
            {
                con(Environment.NewLine + "Stage 2 is already completed.");
            }
            console.Refresh();

            //Stage 3
            if (update.cs.Substring(12, 3) != update.corner.Substring(12, 3))
            {
                while (update.cs.Substring(12, 3) != update.corner.Substring(12, 3) || update.cs.Substring(15, 3) != update.corner.Substring(15, 3) || update.cs.Substring(18, 3) != update.corner.Substring(18, 3) || update.cs.Substring(21, 3) != update.corner.Substring(21, 3))
                {
                    backup = update.cs;
                    gen(8);
                    foreach (var turn in mov)
                    {
                        update.manipulate(turn);
                    }

                    if (update.cs.Substring(12, 3) != update.corner.Substring(12, 3) || update.cs.Substring(15, 3) != update.corner.Substring(15, 3) || update.cs.Substring(18, 3) != update.corner.Substring(18, 3) || update.cs.Substring(21, 3) != update.corner.Substring(21, 3))
                    {
                        update.cs = backup; //restore original state and try again
                        mov.Clear();
                    }
                }
                con(Environment.NewLine + "Stage 3 solved using moves: ");
                foreach (var VARIABLE in mov)
                {
                    con(VARIABLE);
                }
            }
            else
            {
                con(Environment.NewLine + "Stage 3 is already completed.");
            }
            console.Refresh();

            //Stage 4- Get TFR permuted
            mov.Clear();
            if (!update.cs.Substring(6, 3).Contains("W") || !update.cs.Substring(6, 3).Contains("R") ||
                !update.cs.Substring(6, 3).Contains("G"))
            {
                while (!update.cs.Substring(6, 3).Contains("W") || !update.cs.Substring(6, 3).Contains("R") ||
                       !update.cs.Substring(6, 3).Contains("G")) //if TFR is not permuted
                {
                    update.manipulate("U");
                    mov.Add(possiblemoves[4]);
                }

                con(Environment.NewLine + "TFR Permuted using moves: ");

                foreach (var VARIABLE in mov)
                {
                    con(VARIABLE);
                }
            }
            else
            {
                con(Environment.NewLine + "TFR is permuted already");
            }
            console.Refresh();

            //stage 5- permute other corners
            mov.Clear();
            if (!permuted(0) || !permuted(3) || !permuted(9)) //if anything is not permuted
            {
                while (!permuted(0) || !permuted(3) || !permuted(9))
                {
                    update.manipulate("U"); update.manipulate("R"); update.manipulate("U'"); update.manipulate("L'"); update.manipulate("U"); update.manipulate("R'"); update.manipulate("U'"); update.manipulate("L");
                    mov.Add("U R U' L' U R' U' L ");

                    if (permuted(6) && permuted(9))
                    {
                        break;
                    }
                }

                con(Environment.NewLine + "Corners are permuted using moves:");
                foreach (var move in mov)
                {
                    con(move);
                }
            }
            else
            {
                con(Environment.NewLine + "Corners are already permuted");
            }

            mov.Clear();
            //if back two still aren't permuted
            if (!permuted(0))
            {
                mov.Add("U R U R' U' R' F R2 U' R' U' R U R' F' U'");
                string[] spl = "U R U R' U' R' F R2 U' R' U' R U R' F' U'".Split(' ');
                foreach (var move in spl)
                {
                    update.manipulate(move);
                }
                con("Back corners fixed with:  U R U R' U' R' F R2 U' R' U' R U R' F' U'");
            }

            mov.Clear();

            for (int i = 0; i < 4; i++)
            {
                while (update.cs.Substring(6, 1) != "W")
                {
                    mov.Add("R' D' R D ");
                    update.manipulate("R'"); update.manipulate("D'"); update.manipulate("R"); update.manipulate("D");
                }
                con("Next corner solved using moves:");
                foreach (var item in mov)
                {
                    con(item);
                }
                con("U");
                update.manipulate("U");
                mov.Clear();
            }

            con(" "); con(" ");
            con("Your cube has been solved!");
        }

        public bool permuted(int sticker)
        {
            if (update.cs.Substring(sticker, 3).Contains(update.corner[sticker]) &&
                update.cs.Substring(sticker, 3).Contains(update.corner[sticker + 1]) &&
                update.cs.Substring(sticker, 3).Contains(update.corner[sticker + 2]))
            {
                return true;
            }
            else return false;
        }

        public bool solved()
        {
            if (update.cs == update.corner)
            {
                return true;
            }

            return false;
        }

        public void gen(int number_of_moves)
        {
            for (int i = 0; i < number_of_moves; i++)
            {
                mov.Add(possiblemoves[random.Next(0, 11)]);
            }
        }
        public void done()
        {
            con("");
            con("Cube is solved using moves: ");
            foreach (var item in moves)
            {
                temp += item + " ";
            }
            con(temp);
        }

        public void con(string text)
        {
            console.AppendText(Environment.NewLine + "  " + text);
            console.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
