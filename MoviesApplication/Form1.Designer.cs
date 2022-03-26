namespace MoviesApplication
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.getMovieButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.movieNameTextBox = new System.Windows.Forms.TextBox();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.AcceptsReturn = true;
            this.resultTextBox.Location = new System.Drawing.Point(17, 86);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(771, 344);
            this.resultTextBox.TabIndex = 8;
            // 
            // getMovieButton
            // 
            this.getMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMovieButton.Location = new System.Drawing.Point(544, 20);
            this.getMovieButton.Name = "getMovieButton";
            this.getMovieButton.Size = new System.Drawing.Size(144, 44);
            this.getMovieButton.TabIndex = 7;
            this.getMovieButton.Text = "GetMovie";
            this.getMovieButton.UseVisualStyleBackColor = true;
            this.getMovieButton.Click += new System.EventHandler(this.getMovieButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Movie Name:";
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameTextBox.Location = new System.Drawing.Point(167, 27);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(350, 30);
            this.movieNameTextBox.TabIndex = 5;
            // 
            // sendMailButton
            // 
            this.sendMailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMailButton.Location = new System.Drawing.Point(17, 453);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(144, 44);
            this.sendMailButton.TabIndex = 9;
            this.sendMailButton.Text = "Send Mail";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.sendMailButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.getMovieButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button getMovieButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movieNameTextBox;
        private System.Windows.Forms.Button sendMailButton;
    }
}

