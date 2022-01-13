using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoringBook
{
    public partial class FormTextEditor : Form
    {
        SolidBrush brush = new SolidBrush(Color.Black);
        Font font = new System.Drawing.Font("Comic Sans MS", 25F);
        Graphics graphics;
        List<string> commands = new List<string>();
        public FormTextEditor()
        {
            InitializeComponent();
            graphics = pictureBoxTextEditor.CreateGraphics();
        }

        private void FormTextEditor_Load(object sender, EventArgs e)
        {
            //graphics.DrawString("qqq", font, brush, new Point(0, 0));// задалбало, опять не работает
        }

        private void pictureBoxTextEditor_Click(object sender, EventArgs e)
        {
            //graphics.DrawString("qqq", font, brush, new Point(0, 0));
            Draw();
        }

        private void FormTextEditor_Shown(object sender, EventArgs e)
        {

        }

        private void FormTextEditor_Paint(object sender, PaintEventArgs e)
        {
            //graphics.DrawString("qqq", font, brush, new Point(0, 0)); 
        }
        private void FormTextEditor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    commands.Add(e.KeyCode.ToString());
                    break;

                case Keys.Up:
                    break;

                case Keys.Down:
                    break;

                case Keys.Left:
                    break;

                case Keys.R:
                case Keys.A:
                case Keys.C:
                case Keys.J:
                case Keys.OemSemicolon://";"
                    break;

                default:
                    break;
            }
            Draw();
        }
        void Draw()
        {
            for (int i = 0; i < commands.Count; i++)
            {
                graphics.DrawString($"{i + 1}. " + commands[i], font, brush, new Point(10, i * 50));
            }
            graphics.DrawString($"{commands.Count + 1}. ", font, brush, new Point(10, commands.Count * 50));

        }
    }
}

