using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Math;
//var temp = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\hmm.png");
//var ee = e as MouseEventArgs;
//var temp = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\hmm.png");
//pictureBoxCanvas.Refresh();
//pictureBoxCanvas.Focus();//ПОЧЕМУ ТЫ НЕ РАБОТАЕШЬ?!

//pictureBoxCanvas.Focus();
//buttonStartStopWriting.TabStop = false;
//buttonDraw.TabStop = false;
//buttonClearCommands.TabStop = false;

//file = System.IO.File.Create(path);
//file.Close();
//var sr = new StreamReader(path);

//var bbbbb = pictureBoxClear.Image;
//bbbbb.Save("bbbbb.png", ImageFormat.Png);
//Bitmap bmpSave = (Bitmap)pictureBoxCanvas.Image;
//SaveFileDialog sfd = new SaveFileDialog
//{
//    DefaultExt = "bmp",
//    Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*",
//};
//if (sfd.ShowDialog() == DialogResult.OK)

//    bmpSave.Save(sfd.FileName, ImageFormat.Bmp);
//GraphicsState a = graphics.Save();
//pictureBoxCanvas.Image.Save(path2 + "hmm.jpg", ImageFormat.Jpeg);
//graphics.Clear(BackColor);
//var aaaa= pictureBoxCanvas.Image;
//aaaa.Save("hmm.png", ImageFormat.Png);
//Bitmap bitmap = new Bitmap ( pictureBoxCanvas.Width, pictureBoxCanvas.Height, graphics );
//bitmap.Save(path2 + "qqq.bmp");
//Bitmap bm = new Bitmap(this.Width, this.Height);
//pictureBoxCanvas.DrawToBitmap(bm, new Rectangle(0, 0, this.Width, this.Height));
//this.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));

//Graphics g = Graphics.FromImage(image);
//Font font = SystemFonts.MessageBoxFont;
//g.FillRectangle(Brushes.Thistle, new Rectangle(0, 0, image.Width, image.Height));
//g.DrawString("LANA", font, brush, new Point(10, 10));

//image.Save(path2 + "hmm.png");
//pictureBoxCanvas.Image = image;
//pictureBoxCanvas.Image.Save(path2 + "opopop.png");

//SaveFileDialog sfd = new SaveFileDialog();


namespace ColoringBook
{

    public partial class FormColoringBook : Form
    {
        int widthCell = 36;
        int heightCell = 32;
        int radiusCell = 20;
        static int size = 10;
        bool modeMouse = false;
        //Color[] usedColors = { Color.Red, Color.Yellow, Color.Purple };
        string[] usedColors = { "Red", "Yellow", "Purple", "Blue" };

        public Dictionary<string, string> dictColors = new Dictionary<string, string>
            {
                { "R", "Red" },
                { "Oem1", "Yellow" },// ";"
                { "A", "Purple" },
                { "C", "Blue" },
            { "J", "Orange"}
            };

        Image image = Image.FromFile("right.png");

        Color[][] fieldColors = new Color[size][];
        int[][][] fieldCoords = new int[size][][];
        int[] curPoint = new int[] { 0, 0 }; // col row

        Graphics graphics;
        Pen pen = new Pen(Color.Black, width: 6);
        SolidBrush brush = new SolidBrush(Color.Orange);
        Color baseColor = Color.Orange;

        //Запись в файл
        string path = System.IO.Directory.GetCurrentDirectory() + "Commands";
        string path2 = System.IO.Directory.GetCurrentDirectory();
        //System.IO.FileStream file;
        //

        public FormColoringBook()
        {
            InitializeComponent();
            //graphics = pictureBoxCanvas.CreateGraphics();
            Bitmap bitmap = new Bitmap(image, pictureBoxCanvas.Width, pictureBoxCanvas.Height);
            image = bitmap;
            graphics = Graphics.FromImage(image);
            KeyPreview = true;
            StartPosition = FormStartPosition.CenterScreen;
            graphics.Clear(Color.FromArgb(255, 255, 192));
        }
        private void FormColoringBook_Load(object sender, EventArgs e)
        { }
        private void InitializeField()
        {

            for (int i = 0; i < size; i++)
            {
                var tempSize = size + Convert.ToInt32(i % 2 == 0);
                fieldCoords[i] = new int[tempSize][];
                fieldColors[i] = new Color[tempSize];
                for (int r = 0; r < tempSize; r++)
                {
                    var x = widthCell * (r + 1) + (Convert.ToInt32(i % 2 != 0) * (widthCell / 2 + 2)) + 4 * r;
                    var y = (heightCell + 3) * i + 30;
                    DrawHoneyComb(radiusCell, x, y, baseColor);
                    fieldColors[i][r] = baseColor;
                    fieldCoords[i][r] = new int[] { x, y };
                }
            }
            UpdateFocusHoneyComb();
        }

        private void DrawHoneyComb(int r, int x, int y, Color color)
        {


            var hexagon = new PointF[6];
            for (int a = 0; a < 6; a++)
            {
                //shape[a] = new PointF(
                //    x + r * (float)Math.Cos(a * 45 * Math.PI / 180f),
                //    y + r * (float)Math.Sin(a * 45 * Math.PI / 180f));
                var angle_deg = 60 * a + 30;
                var angle_rad = Math.PI / 180 * angle_deg;
                hexagon[a] = new PointF(
                    x + r * (float)Math.Cos(angle_rad),
                    y + r * (float)Math.Sin(angle_rad));
            }
            pen.Color = Color.FromArgb(51, 35, 27);
            graphics.DrawPolygon(pen, hexagon);
            using (PathGradientBrush br = new PathGradientBrush(hexagon))
            {
                br.CenterPoint = new PointF(x, y);
                br.CenterColor = Color.Bisque;
                br.SurroundColors = new Color[] {
                 baseColor};

                // Fill the star.
                graphics.FillPolygon(br, hexagon);
            }

            // Outline the star.
            //e.Graphics.DrawPolygon(Pens.Black, pts)

            
            //brush.Color = color;
            //graphics.FillPolygon(brush, hexagon);
            UpdateCanvas();
        }

        int[] GetCoordsFromPosition(int row, int column)
        {
            return fieldCoords[row][column];
        }
        void UnfocusHoneyComb()
        {
            var temp = GetCoordsFromPosition(curPoint[1], curPoint[0]);
            DrawHoneyComb(radiusCell, temp[0], temp[1], fieldColors[curPoint[1]][curPoint[0]]);
        }
        private void UpdateFocusHoneyComb()
        {
            var w = radiusCell * 2;
            var k = 0.75f;
            var temp = GetCoordsFromPosition(curPoint[1], curPoint[0]);
            var x = temp[1];
            var y = temp[0];
            RectangleF rect = new RectangleF(y - radiusCell + 5, x - radiusCell + 5, w * k, w * k);
            graphics.DrawEllipse(pen, rect);
            UpdateCanvas();
        }

        bool IsLongRow()
        {
            return fieldCoords[curPoint[1]].GetLength(0) == size + 1;
        }
        bool IsShortRow()
        {
            return fieldCoords[curPoint[1]].GetLength(0) == size;
        }
        void MoveRight()
        {
            if (curPoint[0] + 1 < fieldCoords[curPoint[1]].GetLength(0))
            {
                curPoint[0]++;
            }
        }

        void MoveLeft()
        {
            if (curPoint[0] - 1 >= 0)
            {
                curPoint[0]--;
            }
        }

        void MoveUp()
        {
            if (IsLongRow() && curPoint[0] != 0 && curPoint[1] != 0)
            {
                curPoint[0]--;
                curPoint[1]--;
            }
            else if (IsShortRow() && curPoint[1] - 1 >= 0)
            {
                curPoint[1]--;
            }
        }

        void MoveDown()
        {
            if (IsLongRow() && curPoint[0] != size)
            {
                curPoint[1]++;
            }
            else if (IsShortRow() && curPoint[1] != size - 1)
            {
                curPoint[0] = Min(curPoint[0] + 1, size);
                curPoint[1] = Min(curPoint[1] + 1, size - 1);
            }
        }


        private void FormColoringBook_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            if (modeMouse)
            {
                return;
            }
            UnfocusHoneyComb();
            switch (e.KeyCode)
            {
                case Keys.Right:
                    MoveRight();
                    break;

                case Keys.Up:
                    MoveUp();
                    break;

                case Keys.Down:
                    MoveDown();
                    break;

                case Keys.Left:
                    MoveLeft();
                    break;

                case Keys.R:
                case Keys.A:
                case Keys.C:
                case Keys.J:
                case Keys.OemSemicolon://";"
                    //var tempPen = new Pen(Color.FromName(dictColors[e.KeyCode.ToString()]));
                    PaintCell(e.KeyCode.ToString());
                    break;

                default:
                    break;
            }
            UpdateFocusHoneyComb();
        }
        void PaintCell(string color)
        {
            var temp = GetCoordsFromPosition(curPoint[1], curPoint[0]);
            DrawHoneyComb(radiusCell, temp[0], temp[1], Color.FromName(dictColors[color]));
            fieldColors[curPoint[1]][curPoint[0]] = Color.FromName(dictColors[color]);
        }
        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            if (!modeMouse)
            {
                return;
            }
            //var a = sender as PictureBox;
            PictureBox pb = (PictureBox)sender;
            var colorName = pb.Name.Split('_')[1];
            if (Array.IndexOf(usedColors, colorName) != -1)
            {
                var temp = GetCoordsFromPosition(curPoint[1], curPoint[0]);
                int x = temp[0], y = temp[1];
                DrawHoneyComb(radiusCell, x, y, Color.FromName(colorName));
                fieldColors[curPoint[1]][curPoint[0]] = Color.FromName(colorName);
            }
        }

        bool IsClickedOnHoneyComb(int x, int y, int x2, int y2)
        {
            var apoth = Sqrt(3) / 2 * radiusCell;
            return Sqrt((x - x2) * (x - x2) + (y - y2) * (y - y2)) <= apoth;
        }
        private void pictureBoxHolst_MouseDown(object sender, MouseEventArgs e)
        {
            if (modeMouse)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int r = 0; r < size; r++)
                    {
                        if (IsClickedOnHoneyComb(e.X, e.Y, fieldCoords[i][r][0], fieldCoords[i][r][1]))
                        {
                            UnfocusHoneyComb();
                            curPoint[0] = r;
                            curPoint[1] = i;
                            UpdateFocusHoneyComb();
                        }
                    }
                }
            }
        }


        private void FormColoringBook_LocationChanged(object sender, EventArgs e)
        {
            Size size = SystemInformation.PrimaryMonitorSize;
            if (this.Location.X < 0)
            {
                this.Location = new Point(0, this.Location.Y);
            }
            if (this.Location.Y < 0)
            {
                this.Location = new Point(this.Location.X, 0);
            }
            if (this.Location.X + this.Size.Width > size.Width)
            {
                this.Location = new Point(size.Width - this.Size.Width, this.Location.Y);
            }
            if (this.Location.Y + this.Size.Height > size.Height)
            {
                this.Location = new Point(this.Location.X, size.Height - this.Size.Height);
            }
        }

        private void редакторКодаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hmm = new FormTextEditor(this);
            hmm.Show();
            hmm.Refresh();
        }

        private void labelSave_Click(object sender, EventArgs e)
        {

            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    bm.Save(sfd.FileName);
            //}
            pictureBoxCanvas.Image.Save("please.png");
        }

        private void клавиатураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeMouse = false;
        }

        private void mouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeMouse = true;
        }

        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            var temp = GetCoordsFromPosition(curPoint[0], curPoint[1]);
            DrawHoneyComb(radiusCell, temp[0], temp[1], baseColor);
        }
        private void FormColoringBook_Shown(object sender, EventArgs e)
        {
            InitializeField();

            UpdateCanvas();
        }

        public void DrawFromCommands()
        {
            foreach (var command in Commands.commands)
            {
                var temp = command.Split();
                try
                {
                    UnfocusHoneyComb();
                    switch (temp[1])
                    {

                        case "Right": MoveRight(); break;
                        case "Left": MoveLeft(); break;
                        case "Down": MoveDown(); break;
                        case "Up": MoveUp(); break;
                        default:
                            //MessageBox.Show(temp[1]);
                            PaintCell(temp[1]);
                            break;

                    }

                    UpdateFocusHoneyComb();
                    //UpdateCanvas();

                }
                catch (Exception)
                {
                    MessageBox.Show("Ты сломал матрицу!");
                }

            }
        }
        void UpdateCanvas()
        {
            pictureBoxCanvas.Image = image;
        }

    }
}
