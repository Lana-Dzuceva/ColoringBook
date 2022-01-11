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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColoringBook));
            this.pictureBox_Blue = new System.Windows.Forms.PictureBox();
            this.pictureBox_Purple = new System.Windows.Forms.PictureBox();
            this.pictureBox_Yellow = new System.Windows.Forms.PictureBox();
            this.pictureBox_Red = new System.Windows.Forms.PictureBox();
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.pictureBoxHolst = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клавиатураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxCommands = new System.Windows.Forms.PictureBox();
            this.labelStartStopWriting = new System.Windows.Forms.Label();
            this.labelDraw = new System.Windows.Forms.Label();
            this.labelClear = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.редакторКодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Purple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHolst)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommands)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Blue
            // 
            this.pictureBox_Blue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Blue.BackColor = System.Drawing.Color.Blue;
            this.pictureBox_Blue.Location = new System.Drawing.Point(667, 165);
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
            this.pictureBox_Purple.Location = new System.Drawing.Point(667, 221);
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
            this.pictureBox_Yellow.Location = new System.Drawing.Point(667, 109);
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
            this.pictureBox_Red.Location = new System.Drawing.Point(667, 53);
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
            this.pictureBoxClear.Location = new System.Drawing.Point(667, 357);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClear.TabIndex = 0;
            this.pictureBoxClear.TabStop = false;
            this.pictureBoxClear.Click += new System.EventHandler(this.pictureBoxClear_Click);
            // 
            // pictureBoxHolst
            // 
            this.pictureBoxHolst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxHolst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxHolst.Location = new System.Drawing.Point(31, 32);
            this.pictureBoxHolst.Name = "pictureBoxHolst";
            this.pictureBoxHolst.Size = new System.Drawing.Size(552, 400);
            this.pictureBoxHolst.TabIndex = 6;
            this.pictureBoxHolst.TabStop = false;
            this.pictureBoxHolst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHolst_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимToolStripMenuItem,
            this.редакторКодаToolStripMenuItem});
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.helloToolStripMenuItem.Text = "Свойства";
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клавиатураToolStripMenuItem,
            this.mouseToolStripMenuItem});
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.режимToolStripMenuItem.Text = "Режим";
            // 
            // клавиатураToolStripMenuItem
            // 
            this.клавиатураToolStripMenuItem.Name = "клавиатураToolStripMenuItem";
            this.клавиатураToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.клавиатураToolStripMenuItem.Text = "Клавиатура";
            this.клавиатураToolStripMenuItem.Click += new System.EventHandler(this.клавиатураToolStripMenuItem_Click);
            // 
            // mouseToolStripMenuItem
            // 
            this.mouseToolStripMenuItem.Name = "mouseToolStripMenuItem";
            this.mouseToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mouseToolStripMenuItem.Text = "Мышь";
            this.mouseToolStripMenuItem.Click += new System.EventHandler(this.mouseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25F);
            this.label1.Location = new System.Drawing.Point(622, 56);
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
            this.label2.Location = new System.Drawing.Point(615, 112);
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
            this.label3.Location = new System.Drawing.Point(620, 221);
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
            this.label4.Location = new System.Drawing.Point(622, 168);
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
            this.label5.Location = new System.Drawing.Point(652, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Очистить";
            // 
            // pictureBoxCommands
            // 
            this.pictureBoxCommands.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxCommands.Location = new System.Drawing.Point(803, 32);
            this.pictureBoxCommands.Name = "pictureBoxCommands";
            this.pictureBoxCommands.Size = new System.Drawing.Size(310, 400);
            this.pictureBoxCommands.TabIndex = 16;
            this.pictureBoxCommands.TabStop = false;
            // 
            // labelStartStopWriting
            // 
            this.labelStartStopWriting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStartStopWriting.AutoSize = true;
            this.labelStartStopWriting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStartStopWriting.Location = new System.Drawing.Point(800, 495);
            this.labelStartStopWriting.Name = "labelStartStopWriting";
            this.labelStartStopWriting.Size = new System.Drawing.Size(84, 15);
            this.labelStartStopWriting.TabIndex = 20;
            this.labelStartStopWriting.Text = "Начать запись";
            this.labelStartStopWriting.Click += new System.EventHandler(this.labelStartStopWriting_Click);
            // 
            // labelDraw
            // 
            this.labelDraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDraw.AutoSize = true;
            this.labelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDraw.Location = new System.Drawing.Point(927, 495);
            this.labelDraw.Name = "labelDraw";
            this.labelDraw.Size = new System.Drawing.Size(70, 15);
            this.labelDraw.TabIndex = 21;
            this.labelDraw.Text = "Нарисовать";
            this.labelDraw.Click += new System.EventHandler(this.labelDraw_Click);
            // 
            // labelClear
            // 
            this.labelClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClear.AutoSize = true;
            this.labelClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClear.Location = new System.Drawing.Point(1047, 493);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(50, 15);
            this.labelClear.TabIndex = 22;
            this.labelClear.Text = "Стереть";
            // 
            // labelSave
            // 
            this.labelSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSave.AutoSize = true;
            this.labelSave.Location = new System.Drawing.Point(935, 529);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(60, 13);
            this.labelSave.TabIndex = 23;
            this.labelSave.Text = "Сохранить";
            // 
            // редакторКодаToolStripMenuItem
            // 
            this.редакторКодаToolStripMenuItem.Name = "редакторКодаToolStripMenuItem";
            this.редакторКодаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.редакторКодаToolStripMenuItem.Text = "редактор кода";
            this.редакторКодаToolStripMenuItem.Click += new System.EventHandler(this.редакторКодаToolStripMenuItem_Click);
            // 
            // FormColoringBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1140, 598);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.labelDraw);
            this.Controls.Add(this.labelStartStopWriting);
            this.Controls.Add(this.pictureBoxCommands);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxHolst);
            this.Controls.Add(this.pictureBox_Blue);
            this.Controls.Add(this.pictureBox_Purple);
            this.Controls.Add(this.pictureBox_Yellow);
            this.Controls.Add(this.pictureBox_Red);
            this.Controls.Add(this.pictureBoxClear);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1156, 637);
            this.Name = "FormColoringBook";
            this.Text = "Coloring Book";
            this.Load += new System.EventHandler(this.FormColoringBook_Load);
            this.LocationChanged += new System.EventHandler(this.FormColoringBook_LocationChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormColoringBook_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Purple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHolst)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClear;
        private System.Windows.Forms.PictureBox pictureBox_Red;
        private System.Windows.Forms.PictureBox pictureBox_Yellow;
        private System.Windows.Forms.PictureBox pictureBox_Purple;
        private System.Windows.Forms.PictureBox pictureBox_Blue;
        private System.Windows.Forms.PictureBox pictureBoxHolst;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клавиатураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxCommands;
        private System.Windows.Forms.Label labelStartStopWriting;
        private System.Windows.Forms.Label labelDraw;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.ToolStripMenuItem редакторКодаToolStripMenuItem;
    }
}

