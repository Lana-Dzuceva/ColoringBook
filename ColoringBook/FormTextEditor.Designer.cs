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
            this.pictureBoxTextEditor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTextEditor
            // 
            this.pictureBoxTextEditor.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxTextEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTextEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxTextEditor.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTextEditor.Name = "pictureBoxTextEditor";
            this.pictureBoxTextEditor.Size = new System.Drawing.Size(546, 450);
            this.pictureBoxTextEditor.TabIndex = 0;
            this.pictureBoxTextEditor.TabStop = false;
            this.pictureBoxTextEditor.Click += new System.EventHandler(this.pictureBoxTextEditor_Click);
            // 
            // FormTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxTextEditor);
            this.Name = "FormTextEditor";
            this.Text = "Редактор кода";
            this.Load += new System.EventHandler(this.FormTextEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTextEditor;
    }
}