namespace Merafile.Reader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.detailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.stopProcessButton = new System.Windows.Forms.Button();
            this.startProcessButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.detailsRichTextBox);
            this.panel1.Controls.Add(this.stopProcessButton);
            this.panel1.Controls.Add(this.startProcessButton);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 314);
            this.panel1.TabIndex = 1;
            // 
            // detailsRichTextBox
            // 
            this.detailsRichTextBox.Location = new System.Drawing.Point(3, 77);
            this.detailsRichTextBox.Name = "detailsRichTextBox";
            this.detailsRichTextBox.Size = new System.Drawing.Size(290, 230);
            this.detailsRichTextBox.TabIndex = 2;
            this.detailsRichTextBox.Text = "";
            // 
            // stopProcessButton
            // 
            this.stopProcessButton.Location = new System.Drawing.Point(3, 40);
            this.stopProcessButton.Name = "stopProcessButton";
            this.stopProcessButton.Size = new System.Drawing.Size(290, 31);
            this.stopProcessButton.TabIndex = 1;
            this.stopProcessButton.Text = "Stop process";
            this.stopProcessButton.UseVisualStyleBackColor = true;
            this.stopProcessButton.Click += new System.EventHandler(this.stopProcessButton_Click);
            // 
            // startProcessButton
            // 
            this.startProcessButton.Location = new System.Drawing.Point(3, 3);
            this.startProcessButton.Name = "startProcessButton";
            this.startProcessButton.Size = new System.Drawing.Size(290, 31);
            this.startProcessButton.TabIndex = 0;
            this.startProcessButton.Text = "Load image";
            this.startProcessButton.UseVisualStyleBackColor = true;
            this.startProcessButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button startProcessButton;
        private Button stopProcessButton;
        private RichTextBox detailsRichTextBox;
    }
}