namespace mouse_position
{
    partial class FormMousePosition
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
            this.distanceLabel = new System.Windows.Forms.Label();
            this.distanceCounter = new System.Windows.Forms.Label();
            this.additionalInformationStart = new System.Windows.Forms.Label();
            this.additionalInformationStop = new System.Windows.Forms.Label();
            this.additionalInformationCalStart = new System.Windows.Forms.Label();
            this.additionalInformationCalStop = new System.Windows.Forms.Label();
            this.labelInchTextBox = new System.Windows.Forms.Label();
            this.textBoxInch = new System.Windows.Forms.TextBox();
            this.labelInch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distanceLabel.Location = new System.Drawing.Point(0, 104);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(233, 72);
            this.distanceLabel.TabIndex = 1;
            this.distanceLabel.Text = "Distance";
            // 
            // distanceCounter
            // 
            this.distanceCounter.AutoSize = true;
            this.distanceCounter.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distanceCounter.Location = new System.Drawing.Point(239, 104);
            this.distanceCounter.Name = "distanceCounter";
            this.distanceCounter.Size = new System.Drawing.Size(59, 72);
            this.distanceCounter.TabIndex = 2;
            this.distanceCounter.Text = "0";
            // 
            // additionalInformationStart
            // 
            this.additionalInformationStart.AutoSize = true;
            this.additionalInformationStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.additionalInformationStart.Location = new System.Drawing.Point(0, 0);
            this.additionalInformationStart.Name = "additionalInformationStart";
            this.additionalInformationStart.Size = new System.Drawing.Size(81, 15);
            this.additionalInformationStart.TabIndex = 3;
            this.additionalInformationStart.Text = "Start - Shift+S";
            // 
            // additionalInformationStop
            // 
            this.additionalInformationStop.AutoSize = true;
            this.additionalInformationStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.additionalInformationStop.Location = new System.Drawing.Point(0, 15);
            this.additionalInformationStop.Name = "additionalInformationStop";
            this.additionalInformationStop.Size = new System.Drawing.Size(79, 15);
            this.additionalInformationStop.TabIndex = 3;
            this.additionalInformationStop.Text = "Stop - Shift+F";
            // 
            // additionalInformationCalStart
            // 
            this.additionalInformationCalStart.AutoSize = true;
            this.additionalInformationCalStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.additionalInformationCalStart.Location = new System.Drawing.Point(0, 30);
            this.additionalInformationCalStart.Name = "additionalInformationCalStart";
            this.additionalInformationCalStart.Size = new System.Drawing.Size(144, 15);
            this.additionalInformationCalStart.TabIndex = 3;
            this.additionalInformationCalStart.Text = "Calibration start - Shift+C";
            // 
            // additionalInformationCalStop
            // 
            this.additionalInformationCalStop.AutoSize = true;
            this.additionalInformationCalStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.additionalInformationCalStop.Location = new System.Drawing.Point(0, 45);
            this.additionalInformationCalStop.Name = "additionalInformationCalStop";
            this.additionalInformationCalStop.Size = new System.Drawing.Size(141, 15);
            this.additionalInformationCalStop.TabIndex = 3;
            this.additionalInformationCalStop.Text = "Calibration stop - Shift+X";
            // 
            // labelInchTextBox
            // 
            this.labelInchTextBox.AutoSize = true;
            this.labelInchTextBox.Location = new System.Drawing.Point(0, 75);
            this.labelInchTextBox.Name = "labelInchTextBox";
            this.labelInchTextBox.Size = new System.Drawing.Size(115, 15);
            this.labelInchTextBox.TabIndex = 4;
            this.labelInchTextBox.Text = "Calibration distance:";
            // 
            // textBoxInch
            // 
            this.textBoxInch.Location = new System.Drawing.Point(121, 72);
            this.textBoxInch.Name = "textBoxInch";
            this.textBoxInch.Size = new System.Drawing.Size(100, 23);
            this.textBoxInch.TabIndex = 5;
            // 
            // labelInch
            // 
            this.labelInch.AutoSize = true;
            this.labelInch.Location = new System.Drawing.Point(227, 75);
            this.labelInch.Name = "labelInch";
            this.labelInch.Size = new System.Drawing.Size(30, 15);
            this.labelInch.TabIndex = 6;
            this.labelInch.Text = "inch";
            // 
            // FormMousePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInch);
            this.Controls.Add(this.textBoxInch);
            this.Controls.Add(this.labelInchTextBox);
            this.Controls.Add(this.additionalInformationCalStop);
            this.Controls.Add(this.additionalInformationCalStart);
            this.Controls.Add(this.additionalInformationStop);
            this.Controls.Add(this.additionalInformationStart);
            this.Controls.Add(this.distanceCounter);
            this.Controls.Add(this.distanceLabel);
            this.Name = "FormMousePosition";
            this.Text = "Mouse distance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label distanceLabel;
        private Label distanceCounter;
        private Label additionalInformationStart;
        private Label additionalInformationStop;
        private Label additionalInformationCalStart;
        private Label additionalInformationCalStop;
        private Label labelInchTextBox;
        private TextBox textBoxInch;
        private Label labelInch;
    }
}