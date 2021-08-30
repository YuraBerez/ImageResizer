
namespace ImageResizer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectInputFolder = new System.Windows.Forms.Button();
            this.txtOutputFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectOutputFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input folder";
            // 
            // txtInputFolderPath
            // 
            this.txtInputFolderPath.Location = new System.Drawing.Point(168, 8);
            this.txtInputFolderPath.Name = "txtInputFolderPath";
            this.txtInputFolderPath.ReadOnly = true;
            this.txtInputFolderPath.Size = new System.Drawing.Size(336, 23);
            this.txtInputFolderPath.TabIndex = 2;
            // 
            // btnSelectInputFolder
            // 
            this.btnSelectInputFolder.Location = new System.Drawing.Point(87, 8);
            this.btnSelectInputFolder.Name = "btnSelectInputFolder";
            this.btnSelectInputFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectInputFolder.TabIndex = 1;
            this.btnSelectInputFolder.Text = "...";
            this.btnSelectInputFolder.UseVisualStyleBackColor = true;
            this.btnSelectInputFolder.Click += new System.EventHandler(this.btnSelectInputFolder_Click);
            // 
            // txtOutputFolderPath
            // 
            this.txtOutputFolderPath.Location = new System.Drawing.Point(178, 42);
            this.txtOutputFolderPath.Name = "txtOutputFolderPath";
            this.txtOutputFolderPath.ReadOnly = true;
            this.txtOutputFolderPath.Size = new System.Drawing.Size(326, 23);
            this.txtOutputFolderPath.TabIndex = 5;
            // 
            // btnSelectOutputFolder
            // 
            this.btnSelectOutputFolder.Location = new System.Drawing.Point(97, 42);
            this.btnSelectOutputFolder.Name = "btnSelectOutputFolder";
            this.btnSelectOutputFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectOutputFolder.TabIndex = 4;
            this.btnSelectOutputFolder.Text = "...";
            this.btnSelectOutputFolder.UseVisualStyleBackColor = true;
            this.btnSelectOutputFolder.Click += new System.EventHandler(this.btnSelectOutputFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width (px)";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(81, 76);
            this.numWidth.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(95, 23);
            this.numWidth.TabIndex = 7;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(255, 76);
            this.numHeight.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(95, 23);
            this.numHeight.TabIndex = 9;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(182, 80);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(67, 15);
            this.Height.TabIndex = 8;
            this.Height.Text = "Height (px)";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(429, 113);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 151);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutputFolderPath);
            this.Controls.Add(this.btnSelectOutputFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInputFolderPath);
            this.Controls.Add(this.btnSelectInputFolder);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ImageResizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputFolderPath;
        private System.Windows.Forms.Button btnSelectInputFolder;
        private System.Windows.Forms.TextBox txtOutputFolderPath;
        private System.Windows.Forms.Button btnSelectOutputFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Button btnConvert;
    }
}

