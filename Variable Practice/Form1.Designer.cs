
namespace Variable_Practice
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
            this.Hockey = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Button();
            this.Carpet = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hockey
            // 
            this.Hockey.Location = new System.Drawing.Point(12, 12);
            this.Hockey.Name = "Hockey";
            this.Hockey.Size = new System.Drawing.Size(106, 47);
            this.Hockey.TabIndex = 0;
            this.Hockey.Text = "Hockey";
            this.Hockey.UseVisualStyleBackColor = true;
            this.Hockey.Click += new System.EventHandler(this.Hockey_Click);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(12, 100);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(106, 47);
            this.Area.TabIndex = 1;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.Click += new System.EventHandler(this.Area_Click);
            // 
            // Carpet
            // 
            this.Carpet.Location = new System.Drawing.Point(12, 189);
            this.Carpet.Name = "Carpet";
            this.Carpet.Size = new System.Drawing.Size(106, 47);
            this.Carpet.TabIndex = 2;
            this.Carpet.Text = "Carpet";
            this.Carpet.UseVisualStyleBackColor = true;
            this.Carpet.Click += new System.EventHandler(this.Carpet_Click);
            // 
            // Bill
            // 
            this.Bill.Location = new System.Drawing.Point(12, 274);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(106, 47);
            this.Bill.TabIndex = 3;
            this.Bill.Text = "Bill";
            this.Bill.UseVisualStyleBackColor = true;
            this.Bill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(138, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(230, 309);
            this.textBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 333);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Bill);
            this.Controls.Add(this.Carpet);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Hockey);
            this.Name = "Form1";
            this.Text = "Variable Practice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Hockey;
        private System.Windows.Forms.Button Area;
        private System.Windows.Forms.Button Carpet;
        private System.Windows.Forms.Button Bill;
        private System.Windows.Forms.Label textBox;
    }
}

