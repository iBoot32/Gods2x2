namespace Gods2x2
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
            this.heading = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statebox = new System.Windows.Forms.TextBox();
            this.console = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(9, 11);
            this.heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(432, 98);
            this.heading.TabIndex = 0;
            this.heading.Text = "God\'s 2x2";
            this.heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(79, 711);
            this.author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(299, 27);
            this.author.TabIndex = 1;
            this.author.Text = "By: Tom O\'Donnell";
            this.author.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "A program to brute-force a solution to a 2x2 Rubik\'s Cube";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 646);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(425, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statebox
            // 
            this.statebox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.statebox.Location = new System.Drawing.Point(16, 602);
            this.statebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statebox.Name = "statebox";
            this.statebox.Size = new System.Drawing.Size(424, 22);
            this.statebox.TabIndex = 5;
            this.statebox.Text = "Enter Cubestate Here";
            this.statebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // console
            // 
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.console.Location = new System.Drawing.Point(16, 113);
            this.console.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.console.Size = new System.Drawing.Size(424, 468);
            this.console.TabIndex = 6;
            this.console.Text = "Console Window";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 738);
            this.Controls.Add(this.console);
            this.Controls.Add(this.statebox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.author);
            this.Controls.Add(this.heading);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "God\'s 2x2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox statebox;
        private System.Windows.Forms.RichTextBox console;
    }
}

