namespace ColoringBook
{
    partial class FormColoringBook
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColoringBook));
            this.pictureBox_Blue = new System.Windows.Forms.PictureBox();
            this.pictureBox_Purple = new System.Windows.Forms.PictureBox();
            this.pictureBox_Yellow = new System.Windows.Forms.PictureBox();
            this.pictureBox_Red = new System.Windows.Forms.PictureBox();
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редакторКодаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.режимToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.клавиатураToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.мышьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox_Green = new System.Windows.Forms.PictureBox();
            this.pictureBox_White = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Purple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_White)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Blue
            // 
            this.pictureBox_Blue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Blue.BackColor = System.Drawing.Color.Blue;
            this.pictureBox_Blue.Location = new System.Drawing.Point(622, 228);
            this.pictureBox_Blue.Name = "pictureBox_Blue";
            this.pictureBox_Blue.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_Blue.TabIndex = 4;
            this.pictureBox_Blue.TabStop = false;
            this.pictureBox_Blue.Click += new System.EventHandler(this.pictureBoxColor_Click);
            // 
            // pictureBox_Purple
            // 
            this.pictureBox_Purple.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Purple.BackColor = System.Drawing.Color.Purple;
            this.pictureBox_Purple.Location = new System.Drawing.Point(622, 284);
            this.pictureBox_Purple.Name = "pictureBox_Purple";
            this.pictureBox_Purple.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_Purple.TabIndex = 3;
            this.pictureBox_Purple.TabStop = false;
            this.pictureBox_Purple.Click += new System.EventHandler(this.pictureBoxColor_Click);
            // 
            // pictureBox_Yellow
            // 
            this.pictureBox_Yellow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox_Yellow.Location = new System.Drawing.Point(622, 116);
            this.pictureBox_Yellow.Name = "pictureBox_Yellow";
            this.pictureBox_Yellow.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_Yellow.TabIndex = 2;
            this.pictureBox_Yellow.TabStop = false;
            this.pictureBox_Yellow.Click += new System.EventHandler(this.pictureBoxColor_Click);
            // 
            // pictureBox_Red
            // 
            this.pictureBox_Red.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Red.BackColor = System.Drawing.Color.Red;
            this.pictureBox_Red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Red.Location = new System.Drawing.Point(622, 60);
            this.pictureBox_Red.Name = "pictureBox_Red";
            this.pictureBox_Red.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_Red.TabIndex = 1;
            this.pictureBox_Red.TabStop = false;
            this.pictureBox_Red.Click += new System.EventHandler(this.pictureBoxColor_Click);
            // 
            // pictureBoxClear
            // 
            this.pictureBoxClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxClear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClear.Image")));
            this.pictureBoxClear.Location = new System.Drawing.Point(622, 439);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(100, 69);
            this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClear.TabIndex = 0;
            this.pictureBoxClear.TabStop = false;
            this.pictureBoxClear.Click += new System.EventHandler(this.pictureBoxClear_Click);
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxCanvas.Location = new System.Drawing.Point(25, 39);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(481, 400);
            this.pictureBoxCanvas.TabIndex = 6;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHolst_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редакторКодаToolStripMenuItem1,
            this.режимToolStripMenuItem1,
            this.сохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редакторКодаToolStripMenuItem1
            // 
            this.редакторКодаToolStripMenuItem1.Name = "редакторКодаToolStripMenuItem1";
            this.редакторКодаToolStripMenuItem1.Size = new System.Drawing.Size(97, 20);
            this.редакторКодаToolStripMenuItem1.Text = "редактор кода";
            this.редакторКодаToolStripMenuItem1.Click += new System.EventHandler(this.редакторКодаToolStripMenuItem_Click);
            // 
            // режимToolStripMenuItem1
            // 
            this.режимToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клавиатураToolStripMenuItem1,
            this.мышьToolStripMenuItem});
            this.режимToolStripMenuItem1.Name = "режимToolStripMenuItem1";
            this.режимToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.режимToolStripMenuItem1.Text = "режим";
            // 
            // клавиатураToolStripMenuItem1
            // 
            this.клавиатураToolStripMenuItem1.Name = "клавиатураToolStripMenuItem1";
            this.клавиатураToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.клавиатураToolStripMenuItem1.Text = "клавиатура";
            this.клавиатураToolStripMenuItem1.Click += new System.EventHandler(this.клавиатураToolStripMenuItem_Click);
            // 
            // мышьToolStripMenuItem
            // 
            this.мышьToolStripMenuItem.Name = "мышьToolStripMenuItem";
            this.мышьToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.мышьToolStripMenuItem.Text = "мышь";
            this.мышьToolStripMenuItem.Click += new System.EventHandler(this.mouseToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.labelSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25F);
            this.label1.Location = new System.Drawing.Point(577, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "К";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 25F);
            this.label2.Location = new System.Drawing.Point(570, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 47);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ж";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 25F);
            this.label3.Location = new System.Drawing.Point(575, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 47);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ф";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 25F);
            this.label4.Location = new System.Drawing.Point(577, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 47);
            this.label4.TabIndex = 14;
            this.label4.Text = "С";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(607, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Очистить";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 25F);
            this.label6.Location = new System.Drawing.Point(570, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 47);
            this.label6.TabIndex = 19;
            this.label6.Text = "З";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 25F);
            this.label7.Location = new System.Drawing.Point(577, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 47);
            this.label7.TabIndex = 18;
            this.label7.Text = "Б";
            // 
            // pictureBox_Green
            // 
            this.pictureBox_Green.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Green.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox_Green.Location = new System.Drawing.Point(622, 172);
            this.pictureBox_Green.Name = "pictureBox_Green";
            this.pictureBox_Green.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_Green.TabIndex = 17;
            this.pictureBox_Green.TabStop = false;
            this.pictureBox_Green.Click += new System.EventHandler(this.pictureBoxColor_Click);
            // 
            // pictureBox_White
            // 
            this.pictureBox_White.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_White.BackColor = System.Drawing.Color.White;
            this.pictureBox_White.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_White.Location = new System.Drawing.Point(622, 340);
            this.pictureBox_White.Name = "pictureBox_White";
            this.pictureBox_White.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_White.TabIndex = 16;
            this.pictureBox_White.TabStop = false;
            this.pictureBox_White.Click += new System.EventHandler(this.pictureBoxColor_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormColoringBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(799, 573);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox_Green);
            this.Controls.Add(this.pictureBox_White);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.pictureBox_Blue);
            this.Controls.Add(this.pictureBox_Purple);
            this.Controls.Add(this.pictureBox_Yellow);
            this.Controls.Add(this.pictureBox_Red);
            this.Controls.Add(this.pictureBoxClear);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormColoringBook";
            this.Text = "Раскрашка";
            this.Load += new System.EventHandler(this.FormColoringBook_Load);
            this.Shown += new System.EventHandler(this.FormColoringBook_Shown);
            this.LocationChanged += new System.EventHandler(this.FormColoringBook_LocationChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormColoringBook_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Purple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_White)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClear;
        private System.Windows.Forms.PictureBox pictureBox_Red;
        private System.Windows.Forms.PictureBox pictureBox_Yellow;
        private System.Windows.Forms.PictureBox pictureBox_Purple;
        private System.Windows.Forms.PictureBox pictureBox_Blue;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem редакторКодаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem клавиатураToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem мышьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox_Green;
        private System.Windows.Forms.PictureBox pictureBox_White;
        private System.Windows.Forms.Timer timer;
    }
}

