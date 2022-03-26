namespace WeatherApplication
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
            this.countryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetWeatherButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.getWholeWeekCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // countryNameTextBox
            // 
            this.countryNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryNameTextBox.Location = new System.Drawing.Point(200, 35);
            this.countryNameTextBox.Name = "countryNameTextBox";
            this.countryNameTextBox.Size = new System.Drawing.Size(240, 30);
            this.countryNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country Name:";
            // 
            // GetWeatherButton
            // 
            this.GetWeatherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetWeatherButton.Location = new System.Drawing.Point(491, 28);
            this.GetWeatherButton.Name = "GetWeatherButton";
            this.GetWeatherButton.Size = new System.Drawing.Size(178, 44);
            this.GetWeatherButton.TabIndex = 2;
            this.GetWeatherButton.Text = "GetWeather";
            this.GetWeatherButton.UseVisualStyleBackColor = true;
            this.GetWeatherButton.Click += new System.EventHandler(this.GetWeatherButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.AcceptsReturn = true;
            this.resultTextBox.Location = new System.Drawing.Point(17, 138);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(771, 300);
            this.resultTextBox.TabIndex = 3;
            // 
            // getWholeWeekCheckBox
            // 
            this.getWholeWeekCheckBox.AutoSize = true;
            this.getWholeWeekCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getWholeWeekCheckBox.Location = new System.Drawing.Point(17, 84);
            this.getWholeWeekCheckBox.Name = "getWholeWeekCheckBox";
            this.getWholeWeekCheckBox.Size = new System.Drawing.Size(176, 29);
            this.getWholeWeekCheckBox.TabIndex = 4;
            this.getWholeWeekCheckBox.Text = "Get whole week";
            this.getWholeWeekCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getWholeWeekCheckBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.GetWeatherButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox countryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetWeatherButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.CheckBox getWholeWeekCheckBox;
    }
}

