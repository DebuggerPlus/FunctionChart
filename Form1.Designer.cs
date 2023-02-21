
namespace FunctionChart
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartButton = new System.Windows.Forms.Button();
            this.AtextBox = new System.Windows.Forms.TextBox();
            this.BtextBox = new System.Windows.Forms.TextBox();
            this.CtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(927, 568);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chartButton
            // 
            this.chartButton.Location = new System.Drawing.Point(978, 448);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(75, 23);
            this.chartButton.TabIndex = 1;
            this.chartButton.Text = "Show Chart";
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // AtextBox
            // 
            this.AtextBox.Location = new System.Drawing.Point(1009, 52);
            this.AtextBox.Name = "AtextBox";
            this.AtextBox.Size = new System.Drawing.Size(41, 20);
            this.AtextBox.TabIndex = 3;
            this.AtextBox.Text = "1";
            // 
            // BtextBox
            // 
            this.BtextBox.Location = new System.Drawing.Point(1009, 125);
            this.BtextBox.Name = "BtextBox";
            this.BtextBox.Size = new System.Drawing.Size(41, 20);
            this.BtextBox.TabIndex = 4;
            this.BtextBox.Text = "2";
            // 
            // CtextBox
            // 
            this.CtextBox.Location = new System.Drawing.Point(1012, 194);
            this.CtextBox.Name = "CtextBox";
            this.CtextBox.Size = new System.Drawing.Size(41, 20);
            this.CtextBox.TabIndex = 5;
            this.CtextBox.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1015, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1015, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1018, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "c";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(978, 504);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear Chart";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 570);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CtextBox);
            this.Controls.Add(this.BtextBox);
            this.Controls.Add(this.AtextBox);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.TextBox AtextBox;
        private System.Windows.Forms.TextBox BtextBox;
        private System.Windows.Forms.TextBox CtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearButton;
    }
}

