namespace Basic_Calculator
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
            this.NumericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.radioButtonDivide = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiply = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtract = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownB)).BeginInit();
            this.groupBoxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumericUpDownA
            // 
            this.NumericUpDownA.Location = new System.Drawing.Point(33, 10);
            this.NumericUpDownA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericUpDownA.Name = "NumericUpDownA";
            this.NumericUpDownA.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownA.TabIndex = 0;
            this.NumericUpDownA.ValueChanged += new System.EventHandler(this.MathInputs_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // NumericUpDownB
            // 
            this.NumericUpDownB.Location = new System.Drawing.Point(33, 36);
            this.NumericUpDownB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericUpDownB.Name = "NumericUpDownB";
            this.NumericUpDownB.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownB.TabIndex = 2;
            this.NumericUpDownB.ValueChanged += new System.EventHandler(this.MathInputs_Changed);
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.radioButtonDivide);
            this.groupBoxOperations.Controls.Add(this.radioButtonMultiply);
            this.groupBoxOperations.Controls.Add(this.radioButtonSubtract);
            this.groupBoxOperations.Controls.Add(this.radioButtonAdd);
            this.groupBoxOperations.Location = new System.Drawing.Point(16, 62);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(137, 102);
            this.groupBoxOperations.TabIndex = 4;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "groupBoxOperations";
            // 
            // radioButtonDivide
            // 
            this.radioButtonDivide.AutoSize = true;
            this.radioButtonDivide.Location = new System.Drawing.Point(81, 63);
            this.radioButtonDivide.Name = "radioButtonDivide";
            this.radioButtonDivide.Size = new System.Drawing.Size(30, 17);
            this.radioButtonDivide.TabIndex = 3;
            this.radioButtonDivide.TabStop = true;
            this.radioButtonDivide.Text = "/";
            this.radioButtonDivide.UseVisualStyleBackColor = true;
            this.radioButtonDivide.CheckedChanged += new System.EventHandler(this.MathInputs_Changed);
            // 
            // radioButtonMultiply
            // 
            this.radioButtonMultiply.AutoSize = true;
            this.radioButtonMultiply.Location = new System.Drawing.Point(26, 63);
            this.radioButtonMultiply.Name = "radioButtonMultiply";
            this.radioButtonMultiply.Size = new System.Drawing.Size(29, 17);
            this.radioButtonMultiply.TabIndex = 2;
            this.radioButtonMultiply.TabStop = true;
            this.radioButtonMultiply.Text = "*";
            this.radioButtonMultiply.UseVisualStyleBackColor = true;
            this.radioButtonMultiply.CheckedChanged += new System.EventHandler(this.MathInputs_Changed);
            // 
            // radioButtonSubtract
            // 
            this.radioButtonSubtract.AutoSize = true;
            this.radioButtonSubtract.Location = new System.Drawing.Point(81, 27);
            this.radioButtonSubtract.Name = "radioButtonSubtract";
            this.radioButtonSubtract.Size = new System.Drawing.Size(28, 17);
            this.radioButtonSubtract.TabIndex = 1;
            this.radioButtonSubtract.TabStop = true;
            this.radioButtonSubtract.Text = "-";
            this.radioButtonSubtract.UseVisualStyleBackColor = true;
            this.radioButtonSubtract.CheckedChanged += new System.EventHandler(this.MathInputs_Changed);
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(26, 27);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(31, 17);
            this.radioButtonAdd.TabIndex = 0;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "+";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            this.radioButtonAdd.CheckedChanged += new System.EventHandler(this.MathInputs_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(225, 111);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(16, 13);
            this.LabelResult.TabIndex = 6;
            this.LabelResult.Text = "- -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericUpDownB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUpDownA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownB)).EndInit();
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericUpDownA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericUpDownB;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.RadioButton radioButtonDivide;
        private System.Windows.Forms.RadioButton radioButtonMultiply;
        private System.Windows.Forms.RadioButton radioButtonSubtract;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelResult;
    }
}

