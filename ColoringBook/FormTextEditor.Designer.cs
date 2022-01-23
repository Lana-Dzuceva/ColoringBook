namespace ColoringBook
{
    partial class FormTextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextEditor));
            this.pictureBoxTextEditor = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.нарисоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextEditor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTextEditor
            // 
            this.pictureBoxTextEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxTextEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTextEditor.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxTextEditor.Name = "pictureBoxTextEditor";
            this.pictureBoxTextEditor.Size = new System.Drawing.Size(784, 426);
            this.pictureBoxTextEditor.TabIndex = 0;
            this.pictureBoxTextEditor.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нарисоватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // нарисоватьToolStripMenuItem
            // 
            this.нарисоватьToolStripMenuItem.Name = "нарисоватьToolStripMenuItem";
            this.нарисоватьToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.нарисоватьToolStripMenuItem.Text = "Нарисовать";
            this.нарисоватьToolStripMenuItem.Click += new System.EventHandler(this.нарисоватьToolStripMenuItem_Click);
            // 
            // FormTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.pictureBoxTextEditor);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTextEditor";
            this.Text = "Редактор кода";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTextEditor_FormClosed);
            this.Shown += new System.EventHandler(this.FormTextEditor_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTextEditor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextEditor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTextEditor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem нарисоватьToolStripMenuItem;
    }
}