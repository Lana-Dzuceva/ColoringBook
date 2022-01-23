using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//var sw = new StreamWriter(commandsPath);
//for (int i = 0; i < commands.Count; i++)
//{
//    sw.WriteLine(commands[i]);
//}
//sw.Close();
//var sr = new StreamReader(commandsPath);
//while (!sr.EndOfStream)
//{
//    MessageBox.Show(sr.ReadLine());
//}
//sr.Close();

//Image right = Image.FromFile("right.png"),
//   left = Image.FromFile("left.png"),
//   down = Image.FromFile("down.png"),
//   up = Image.FromFile("up.png");

namespace ColoringBook
{
    public partial class FormTextEditor : Form
    {
        FormColoringBook formMain;
        SolidBrush brush = new SolidBrush(Color.Black);
        Font font = new System.Drawing.Font("Comic Sans MS", 25F);
        Graphics graphics;
        //List<string> commands = new List<string>();

        string path = System.IO.Directory.GetCurrentDirectory();
        //string commandsPath;
        //System.IO.FileStream file;

        int cellSize = 50;

        Dictionary<string, Image> arrows = new Dictionary<string, Image>
        {
            {"Right" , Image.FromFile("right.png") },
            {"Left" , Image.FromFile("left.png") },
            {"Up", Image.FromFile("up.png") },
            {"Down", Image.FromFile("down.png") }
        };

        Dictionary<string, string> dictColors = new Dictionary<string, string>
        {
             { "R", "К" },
                { "Oem1", "Ж" },// ";"
                { "A", "Ф" },
                { "C", "С" },
            { "J", "О"}
        };

        public FormTextEditor(FormColoringBook f_)
        {
            InitializeComponent();
            graphics = pictureBoxTextEditor.CreateGraphics();
            //commandsPath = System.IO.Path.Combine(path, "Commands.txt");
            formMain = f_;
        }




        private void FormTextEditor_Shown(object sender, EventArgs e)
        {
            //graphics.DrawString($"{1}. ", font, brush, new Point(10, 0));
            Draw();
        }

        private void FormTextEditor_Paint(object sender, PaintEventArgs e)
        {
            //graphics.DrawString("qqq", font, brush, new Point(0, 0)); 
        }

        private void нарисоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formMain.Show();
            formMain.DrawFromCommands();
            formMain.Focus();
        }

        private void FormTextEditor_KeyDown(object sender, KeyEventArgs e)
        {
            var rect = new Rectangle(cellSize + (Commands.commands.Count / 8) * (cellSize * 3 + 10), Commands.commands.Count % 8 * cellSize, cellSize, cellSize);
            switch (e.KeyCode)
            {
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                    someActions(e.KeyCode.ToString());
                    DrawArrow(arrows[e.KeyCode.ToString()], rect);
                    break;

                case Keys.R:
                case Keys.A:
                case Keys.C:
                case Keys.J:
                case Keys.OemSemicolon://";"
                    someActions(e.KeyCode.ToString());
                    DrawLetter();
                    break;

                case Keys.Back:
                    try
                    {
                        if (Commands.commands.Count % 8 != 0)
                        {
                            rect.Y -= 50;
                        }
                        else
                        {
                            //MessageBox.Show(rect.X.ToString() + " " + rect.Y.ToString());
                            rect = new Rectangle(cellSize + (Commands.commands.Count- 1) / 8 * (cellSize * 3 + 10), (Commands.commands.Count - 1) % 8 * cellSize, cellSize, cellSize);

                        }
                        Commands.commands.RemoveAt(Commands.commands.Count - 1);
                        
                        graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 192)), rect);
                    }
                    catch { }

                    break;
                default:
                    break;
            }
        }
        void someActions(string kc)
        {
            Commands.commands.Add("move " + kc);
            graphics.DrawString($"{ Commands.commands.Count + 1}. ", font, brush, new Point(10 + (Commands.commands.Count / 8) * cellSize * 3, (Commands.commands.Count % 8) * cellSize));
        }
        void Draw()
        {
            graphics.DrawString($"{1}. ", font, brush, new Point(10, 0));
            for (int i = 0; i < Commands.commands.Count; i++)
            {
                var cmd = Commands.commands[i].Split();
                if (cmd[0] == "move")
                {
                    var rect = new Rectangle(cellSize, (i + 1) * cellSize, cellSize, cellSize);
                    graphics.DrawImage(arrows[cmd[1]], rect);
                }
                else
                {

                }
                graphics.DrawString($"{i + 1}. " + Commands.commands[i], font, brush, new Point(10, i * cellSize));
            }
            //graphics.DrawString($"{ Commands.commands.Count + 1}. ", font, brush, new Point(10, Commands.commands.Count * cellSize));
        }
        //-----------------------------------------------
        void DrawArrow(Image arrow, Rectangle rect)
        {
            graphics.DrawImage(arrow, rect);
        }
        void DrawLetter()
        {
            if (Commands.commands.Count % 8 != 0)
            {
                graphics.DrawString($"{dictColors[Commands.commands[Commands.commands.Count - 1].Split()[1]]}", font, brush, new Point(cellSize + Commands.commands.Count / 8 * (cellSize * 3 + 10), Commands.commands.Count % 8 * cellSize - cellSize));

            }
            else
            {
                graphics.DrawString($"{dictColors[Commands.commands[Commands.commands.Count - 1].Split()[1]]}", font, brush, new Point(cellSize + (Commands.commands.Count - 1) / 8 * (cellSize * 3 + 10), (Commands.commands.Count - 1) % 8 * cellSize));
            }
        }

        private void FormTextEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Commands.commands.Clear();
        }


        //-------------------------------------------------
    }


}

