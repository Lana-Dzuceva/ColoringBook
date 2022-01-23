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

        string path = System.IO.Directory.GetCurrentDirectory();
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
            formMain = f_;
        }


        private void FormTextEditor_Shown(object sender, EventArgs e)
        {
            ReDrawCommands();
        }

        private void нарисоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMain.DrawFromCommands();
            formMain.Focus();
        }

        // обрабатываем команды с клавиатуры, которые отрисовываются в виде последовательности ходов 
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
                            rect = new Rectangle(cellSize + (Commands.commands.Count - 1) / 8 * (cellSize * 3 + 10), (Commands.commands.Count - 1) % 8 * cellSize, cellSize, cellSize);
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
        // Тут у меня закончилась фантазия на названия функций, так как эта функция делает два совершенно разных дела,
        // но привязанных к схожим процессам. Так как мне лень писать дважды одно и тоже я объединила их в мини функцию.
        void someActions(string kc)
        {
            Commands.commands.Add("move " + kc);
            graphics.DrawString($"{ Commands.commands.Count + 1}. ", font, brush, new Point(10 + (Commands.commands.Count / 8) * cellSize * 3, (Commands.commands.Count % 8) * cellSize));
        }
        // Перерисовка команд при закрытии и повторном открытии.
        // Пока что эта функция работает неправильно, поэтому я ее не использую там где она действительно нужна.
        void ReDrawCommands()
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
        }
        // Отрисовка стрелы
        void DrawArrow(Image arrow, Rectangle rect)
        {
            graphics.DrawImage(arrow, rect);
        }
        // Отрисовка буквы(команды закрашивания)
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
        // На закрытие формы я полностью очищаю список команд, так как функция перерисовки ( ReDrawCommands ), пока не работает
        private void FormTextEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Commands.commands.Clear();
        }

    }


}

