namespace BMI_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelBMI = new Label();
            radioButtonEnglish = new RadioButton();
            radioButtonPortugues = new RadioButton();
            labelHeight = new Label();
            labelWeight = new Label();
            labelBMIValue = new Label();
            labelClassification = new Label();
            textBoxHeight = new TextBox();
            textBoxWeight = new TextBox();
            textBoxBMIValue = new TextBox();
            textBoxClassification = new TextBox();
            labelTypeHeight = new Label();
            labelTypeWeight = new Label();
            buttonCheck = new Button();
            buttonClean = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelBMI
            // 
            labelBMI.Dock = DockStyle.Top;
            labelBMI.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBMI.Location = new Point(0, 0);
            labelBMI.Name = "labelBMI";
            labelBMI.Size = new Size(354, 51);
            labelBMI.TabIndex = 0;
            labelBMI.Text = "Body Mass Index";
            labelBMI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButtonEnglish
            // 
            radioButtonEnglish.AutoSize = true;
            radioButtonEnglish.Checked = true;
            radioButtonEnglish.Location = new Point(98, 69);
            radioButtonEnglish.Name = "radioButtonEnglish";
            radioButtonEnglish.Size = new Size(63, 19);
            radioButtonEnglish.TabIndex = 1;
            radioButtonEnglish.TabStop = true;
            radioButtonEnglish.Text = "English";
            radioButtonEnglish.UseVisualStyleBackColor = true;
            radioButtonEnglish.CheckedChanged += radioButtonEnglish_CheckedChanged;
            // 
            // radioButtonPortugues
            // 
            radioButtonPortugues.AutoSize = true;
            radioButtonPortugues.Location = new Point(192, 69);
            radioButtonPortugues.Name = "radioButtonPortugues";
            radioButtonPortugues.Size = new Size(79, 19);
            radioButtonPortugues.TabIndex = 2;
            radioButtonPortugues.Text = "Português";
            radioButtonPortugues.UseVisualStyleBackColor = true;
            radioButtonPortugues.CheckedChanged += radioButtonPortugues_CheckedChanged;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelHeight.Location = new Point(35, 127);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(86, 17);
            labelHeight.TabIndex = 3;
            labelHeight.Text = "Enter Height";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelWeight.Location = new Point(35, 154);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(89, 17);
            labelWeight.TabIndex = 4;
            labelWeight.Text = "Enter Weight";
            // 
            // labelBMIValue
            // 
            labelBMIValue.AutoSize = true;
            labelBMIValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelBMIValue.Location = new Point(35, 181);
            labelBMIValue.Name = "labelBMIValue";
            labelBMIValue.Size = new Size(70, 17);
            labelBMIValue.TabIndex = 5;
            labelBMIValue.Text = "BMI Value";
            // 
            // labelClassification
            // 
            labelClassification.AutoSize = true;
            labelClassification.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelClassification.Location = new Point(35, 208);
            labelClassification.Name = "labelClassification";
            labelClassification.Size = new Size(90, 17);
            labelClassification.TabIndex = 6;
            labelClassification.Text = "Classification";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxHeight.Location = new Point(134, 126);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(110, 20);
            textBoxHeight.TabIndex = 7;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBoxWeight.Location = new Point(134, 155);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(110, 20);
            textBoxWeight.TabIndex = 8;
            // 
            // textBoxBMIValue
            // 
            textBoxBMIValue.Enabled = false;
            textBoxBMIValue.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBoxBMIValue.Location = new Point(134, 184);
            textBoxBMIValue.Name = "textBoxBMIValue";
            textBoxBMIValue.Size = new Size(110, 20);
            textBoxBMIValue.TabIndex = 9;
            // 
            // textBoxClassification
            // 
            textBoxClassification.Enabled = false;
            textBoxClassification.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBoxClassification.Location = new Point(134, 213);
            textBoxClassification.Name = "textBoxClassification";
            textBoxClassification.Size = new Size(110, 20);
            textBoxClassification.TabIndex = 10;
            // 
            // labelTypeHeight
            // 
            labelTypeHeight.AutoSize = true;
            labelTypeHeight.Font = new Font("Segoe UI", 9F);
            labelTypeHeight.Location = new Point(249, 129);
            labelTypeHeight.Name = "labelTypeHeight";
            labelTypeHeight.Size = new Size(38, 15);
            labelTypeHeight.TabIndex = 11;
            labelTypeHeight.Text = "meter";
            // 
            // labelTypeWeight
            // 
            labelTypeWeight.AutoSize = true;
            labelTypeWeight.Font = new Font("Segoe UI", 9F);
            labelTypeWeight.Location = new Point(249, 158);
            labelTypeWeight.Name = "labelTypeWeight";
            labelTypeWeight.Size = new Size(54, 15);
            labelTypeWeight.TabIndex = 12;
            labelTypeWeight.Text = "kilogram";
            // 
            // buttonCheck
            // 
            buttonCheck.Font = new Font("Segoe UI", 9.75F);
            buttonCheck.Location = new Point(35, 272);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(85, 30);
            buttonCheck.TabIndex = 13;
            buttonCheck.Text = "Check BMI";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // buttonClean
            // 
            buttonClean.Font = new Font("Segoe UI", 9.75F);
            buttonClean.Location = new Point(134, 272);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(85, 30);
            buttonClean.TabIndex = 14;
            buttonClean.Text = "Clean";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 9.75F);
            buttonExit.Location = new Point(233, 272);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(85, 30);
            buttonExit.TabIndex = 15;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 331);
            Controls.Add(buttonExit);
            Controls.Add(buttonClean);
            Controls.Add(buttonCheck);
            Controls.Add(labelTypeWeight);
            Controls.Add(labelTypeHeight);
            Controls.Add(textBoxClassification);
            Controls.Add(textBoxBMIValue);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxHeight);
            Controls.Add(labelClassification);
            Controls.Add(labelBMIValue);
            Controls.Add(labelWeight);
            Controls.Add(labelHeight);
            Controls.Add(radioButtonPortugues);
            Controls.Add(radioButtonEnglish);
            Controls.Add(labelBMI);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMI Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBMI;
        private RadioButton radioButtonEnglish;
        private RadioButton radioButtonPortugues;
        private Label labelHeight;
        private Label labelWeight;
        private Label labelBMIValue;
        private Label labelClassification;
        private TextBox textBoxHeight;
        private TextBox textBoxWeight;
        private TextBox textBoxBMIValue;
        private TextBox textBoxClassification;
        private Label labelTypeHeight;
        private Label labelTypeWeight;
        private Button buttonCheck;
        private Button buttonClean;
        private Button buttonExit;
    }
}
