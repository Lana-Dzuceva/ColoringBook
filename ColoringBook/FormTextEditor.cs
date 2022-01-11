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
        public FormTextEditor()
        {
            InitializeComponent();
            graphics = pictureBoxTextEditor.CreateGraphics();
        }

        private void FormTextEditor_Load(object sender, EventArgs e)
        {
            graphics.DrawString("qqq", font, brush, new Point(0, 0));// задалбало, опять не работает
        }

        private void pictureBoxTextEditor_Click(object sender, EventArgs e)
        {
            graphics.DrawString("qqq", font, brush, new Point(0, 0));
        }
    }
}
