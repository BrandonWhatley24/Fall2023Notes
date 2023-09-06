namespace InClassCalculator
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
            groupBox1 = new GroupBox();
            Exit_Btn = new Button();
            Reset_Btn = new Button();
            Submit_Btn = new Button();
            Result_2 = new TextBox();
            Result_Lbl = new Label();
            Operator_CB = new ComboBox();
            Value2_Txt = new TextBox();
            Value1_Txt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Purple;
            groupBox1.Controls.Add(Exit_Btn);
            groupBox1.Controls.Add(Reset_Btn);
            groupBox1.Controls.Add(Submit_Btn);
            groupBox1.Controls.Add(Result_2);
            groupBox1.Controls.Add(Result_Lbl);
            groupBox1.Controls.Add(Operator_CB);
            groupBox1.Controls.Add(Value2_Txt);
            groupBox1.Controls.Add(Value1_Txt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Two Positive Values";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Exit_Btn
            // 
            Exit_Btn.ForeColor = SystemColors.ActiveCaptionText;
            Exit_Btn.Location = new Point(523, 239);
            Exit_Btn.Name = "Exit_Btn";
            Exit_Btn.Size = new Size(75, 23);
            Exit_Btn.TabIndex = 9;
            Exit_Btn.Text = "Exit";
            Exit_Btn.UseVisualStyleBackColor = true;
            Exit_Btn.Click += Exit_Btn_Click;
            // 
            // Reset_Btn
            // 
            Reset_Btn.ForeColor = SystemColors.ActiveCaptionText;
            Reset_Btn.Location = new Point(310, 239);
            Reset_Btn.Name = "Reset_Btn";
            Reset_Btn.Size = new Size(75, 23);
            Reset_Btn.TabIndex = 8;
            Reset_Btn.Text = "Clear";
            Reset_Btn.UseVisualStyleBackColor = true;
            Reset_Btn.Click += Reset_Btn_Click;
            // 
            // Submit_Btn
            // 
            Submit_Btn.ForeColor = SystemColors.ActiveCaptionText;
            Submit_Btn.Location = new Point(125, 239);
            Submit_Btn.Name = "Submit_Btn";
            Submit_Btn.Size = new Size(75, 23);
            Submit_Btn.TabIndex = 7;
            Submit_Btn.Text = "Calculate";
            Submit_Btn.UseVisualStyleBackColor = true;
            Submit_Btn.Click += Submit_Btn_Click;
            // 
            // Result_2
            // 
            Result_2.Location = new Point(125, 190);
            Result_2.Name = "Result_2";
            Result_2.Size = new Size(473, 23);
            Result_2.TabIndex = 6;
            Result_2.Text = " ";
            Result_2.Visible = false;
            // 
            // Result_Lbl
            // 
            Result_Lbl.AutoSize = true;
            Result_Lbl.Location = new Point(53, 192);
            Result_Lbl.Name = "Result_Lbl";
            Result_Lbl.Size = new Size(39, 15);
            Result_Lbl.TabIndex = 5;
            Result_Lbl.Text = "Result";
            Result_Lbl.Visible = false;
            // 
            // Operator_CB
            // 
            Operator_CB.FormattingEnabled = true;
            Operator_CB.Items.AddRange(new object[] { "Addition", "Subtraction", "Division", "Multiplication" });
            Operator_CB.Location = new Point(125, 128);
            Operator_CB.Name = "Operator_CB";
            Operator_CB.Size = new Size(473, 23);
            Operator_CB.TabIndex = 4;
            // 
            // Value2_Txt
            // 
            Value2_Txt.Location = new Point(125, 82);
            Value2_Txt.Name = "Value2_Txt";
            Value2_Txt.Size = new Size(473, 23);
            Value2_Txt.TabIndex = 3;
            Value2_Txt.Text = " ";
            // 
            // Value1_Txt
            // 
            Value1_Txt.Location = new Point(125, 39);
            Value1_Txt.Name = "Value1_Txt";
            Value1_Txt.Size = new Size(473, 23);
            Value1_Txt.TabIndex = 2;
            Value1_Txt.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 82);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Value 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 41);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Value 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 309);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Value2_Txt;
        private TextBox Value1_Txt;
        private Label label2;
        private Label label1;
        private ComboBox Operator_CB;
        private Button Exit_Btn;
        private Button Reset_Btn;
        private Button Submit_Btn;
        private TextBox Result_2;
        private Label Result_Lbl;
    }
}