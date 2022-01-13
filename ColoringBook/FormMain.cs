using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Math;
//var temp = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\hmm.png");
//var ee = e as MouseEventArgs;
//var temp = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\hmm.png");
namespace ColoringBook
{
    public partial class FormColoringBook : Form
    {
        int widthCell = 36;
        int heightCell = 32;
        int radiusCell = 20;
        bool f = false;
        static int size = 10;
        //static int size = 12;
        bool modeMouse = false;
        //Color[] usedColors = { Color.Red, Color.Yellow, Color.Purple };
        string[] usedColors = { "Red", "Yellow", "Purple", "Blue" };
        
        Dictionary<string, string> dictColors = new Dictionary<string, string>
            {
                { "R", "Red" },
                { "Oem1", "Yellow" },// ";"
                { "A", "Purple" },
                { "C", "Blue" },
            { "J", "Orange"}
            };


        Color[][] fieldColors = new Color[size][];
        int[][][] fieldCoords = new int[size][][];
        int[] curPoint = new int[] { 0, 0 }; // col row

        Graphics graphics;
        Pen pen = new Pen(Color.Black, width: 6);
        SolidBrush brush = new SolidBrush(Color.Orange);
        Color baseColor = Color.Orange;

        //____всё что касается рисования на втором холсте______
        Graphics graphics2;
        Image right = Image.FromFile("right.png"),
        left = Image.FromFile("left.png"),
        down = Image.FromFile("down.png"),
        up = Image.FromFile("up.png");

        int[] coordsCommands = { 0, 0 };
        bool IsWriting = false;
        int sizeCommand = 50;
        List<string> commandSequence = new List<string>();
        //__________________________________________

        //Запись в файл
        string path = System.IO.Directory.GetCurrentDirectory() + "Commands";
        System.IO.FileStream file;
        //

        public FormColoringBook()
        {
            InitializeComponent();
            graphics = pictureBoxHolst.CreateGraphics();
            KeyPreview = true;
            graphics2 = pictureBoxCommands.CreateGraphics();

        }
        private void FormColoringBook_Load(object sender, EventArgs e)
        {
            InitializeField();//Гадины
            pictureBoxHolst.Refresh();
            //pictureBoxHolst.Focus();//ПОЧЕМУ ТЫ НЕ РАБОТАЕШЬ?!

            pictureBoxHolst.Focus();
            //buttonStartStopWriting.TabStop = false;
            //buttonDraw.TabStop = false;
            //buttonClearCommands.TabStop = false;
            StartPosition = FormStartPosition.CenterScreen;
            file = System.IO.File.Create(path);
            file.Close();
            //var sr = new StreamReader(path);
            
        }
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
            graphics.DrawPolygon(pen, hexagon);
            brush.Color = color;
            graphics.FillPolygon(brush, hexagon);


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
        }

        bool IsLongRow()
        {
            return fieldCoords[curPoint[1]].GetLength(0) == size + 1;
        }
        bool IsShortRow()
        {
            return fieldCoords[curPoint[1]].GetLength(0) == size;
        }
        void MoveRight(Rectangle rect)
        {
            if (curPoint[0] + 1 < fieldCoords[curPoint[1]].GetLength(0))
            {
                if (IsWriting)
                {
                    DrawArrow(right, rect);
                }
                else
                {
                    curPoint[0]++;
                }
            }
        }

        void MoveLeft(Rectangle rect)
        {
            if (curPoint[0] - 1 >= 0)
            {
                if (IsWriting)
                {
                    DrawArrow(left, rect);
                }
                else
                {
                    curPoint[0]--;
                }
            }
        }

        void MoveUp(Rectangle rect)
        {
            if (IsLongRow() && curPoint[0] != 0 && curPoint[1] != 0)
            {
                if (IsWriting)
                {
                    DrawArrow(up, rect);
                }
                else
                {
                    //curPoint[0] = Max(curPoint[0] - 1, 0);
                    //curPoint[1] = Max(curPoint[1] - 1, 0);
                    curPoint[0]--;
                    curPoint[1]--;
                }
            }
            else if (IsShortRow() && curPoint[1] - 1 >= 0)
            {
                if (IsWriting)
                {
                    DrawArrow(up, rect);
                }
                else
                {
                    curPoint[1]--;
                }
            }
        }

        void MoveDown(Rectangle rect)
        {

            if (IsLongRow() && curPoint[0] != size)
            {
                if (IsWriting)
                {
                    DrawArrow(down, rect);
                    return;
                }
                else
                {
                    curPoint[1]++;
                }
            }
            else if (IsShortRow())
            {
                if (IsWriting)
                {
                    DrawArrow(down, rect);
                    return;
                }
                else
                {
                    curPoint[0] = Min(curPoint[0] + 1, size);
                    curPoint[1] = Min(curPoint[1] + 1, size - 1);
                }
            }

        }
        void UpdateCoordsOfCommands()
        {
            coordsCommands[0] += (sizeCommand + 10) * Convert.ToInt32((coordsCommands[1] + 50) >= (pictureBoxCommands.Height + sizeCommand));
            coordsCommands[1] = (coordsCommands[1] + sizeCommand) % (pictureBoxCommands.Height + sizeCommand);

        }
        void DrawArrow(Image arrow, Rectangle rect)
        {
            graphics2.DrawImage(arrow, rect);
            UpdateCoordsOfCommands();
            var sw = new StreamWriter(path);
            sw.WriteLine();
            sw.Close();
        }
        private void FormColoringBook_KeyDown(object sender, KeyEventArgs e)
        {
            var rect = new Rectangle(coordsCommands[0], coordsCommands[1], 50, 50);
            //MessageBox.Show(e.KeyCode.ToString());
            if (modeMouse)
            {
                return;
            }
            UnfocusHoneyComb();
            switch (e.KeyCode)
            {
                case Keys.Right:
                    MoveRight(rect);
                    break;

                case Keys.Up:
                    MoveUp(rect);
                    break;

                case Keys.Down:
                    MoveDown(rect);
                    break;

                case Keys.Left:
                    MoveLeft(rect);
                    break;

                case Keys.R:
                case Keys.A:
                case Keys.C:
                case Keys.J:
                case Keys.OemSemicolon://";"
                    var temp = GetCoordsFromPosition(curPoint[1], curPoint[0]);
                    DrawHoneyComb(radiusCell, temp[0], temp[1], Color.FromName(dictColors[e.KeyCode.ToString()]));
                    fieldColors[curPoint[1]][curPoint[0]] = Color.FromName(dictColors[e.KeyCode.ToString()]);
                    //var tempPen = new Pen(Color.FromName(dictColors[e.KeyCode.ToString()]));
                    graphics2.DrawRectangle(pen, rect);
                    graphics2.FillRectangle(new SolidBrush(Color.FromName(dictColors[e.KeyCode.ToString()])), rect);
                    UpdateCoordsOfCommands(); break;

                default:
                    break;
            }
            UpdateFocusHoneyComb();
        }

        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            if (!modeMouse)
            {
                return;
            }
            var a = sender as PictureBox;
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
            if (!f)
            {
                InitializeField();
                f = true;
            }

            else if (modeMouse)
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


        private void labelStartStopWriting_Click(object sender, EventArgs e)
        {
            if (IsWriting)
            {
                labelStartStopWriting.Text = "Начать запись";
            }
            else
            {
                labelStartStopWriting.Text = "Остановить запись";
            }
            IsWriting = !IsWriting;
        }

        private void labelDraw_Click(object sender, EventArgs e)
        {

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
            var hmm = new FormTextEditor();
            hmm.Show();
            hmm.Refresh();
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
    }
}
