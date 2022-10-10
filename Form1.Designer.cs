namespace Project2
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelWeightInPounds = new System.Windows.Forms.Label();
            this.labelWeightInKilograms = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelOutputResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(462, 167);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxInput.TabIndex = 0;
            // 
            // labelWeightInPounds
            // 
            this.labelWeightInPounds.AutoSize = true;
            this.labelWeightInPounds.Location = new System.Drawing.Point(286, 175);
            this.labelWeightInPounds.Name = "labelWeightInPounds";
            this.labelWeightInPounds.Size = new System.Drawing.Size(139, 15);
            this.labelWeightInPounds.TabIndex = 1;
            this.labelWeightInPounds.Text = "Enter Your Weight in Lbs:";
            // 
            // labelWeightInKilograms
            // 
            this.labelWeightInKilograms.AutoSize = true;
            this.labelWeightInKilograms.Location = new System.Drawing.Point(308, 239);
            this.labelWeightInKilograms.Name = "labelWeightInKilograms";
            this.labelWeightInKilograms.Size = new System.Drawing.Size(117, 15);
            this.labelWeightInKilograms.TabIndex = 3;
            this.labelWeightInKilograms.Text = "Weight in Kilograms:";
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.Lime;
            this.buttonConvert.Location = new System.Drawing.Point(462, 299);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(100, 45);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // labelOutputResult
            // 
            this.labelOutputResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutputResult.Location = new System.Drawing.Point(462, 239);
            this.labelOutputResult.Name = "labelOutputResult";
            this.labelOutputResult.Size = new System.Drawing.Size(100, 23);
            this.labelOutputResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutputResult);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelWeightInKilograms);
            this.Controls.Add(this.labelWeightInPounds);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxInput;
        private Label labelWeightInPounds;
        private Label labelWeightInKilograms;
        private Button buttonConvert;
        private Label labelOutputResult;
    }
}