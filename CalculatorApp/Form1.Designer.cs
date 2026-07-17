namespace CalculatorApp
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
            txtDisplay = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMul = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnClear = new Button();
            btnDiv = new Button();
            btnEqual = new Button();
            lblHistory = new Label();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.GrayText;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.Window;
            txtDisplay.Location = new Point(237, 59);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(294, 78);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlDark;
            btn1.Location = new Point(237, 143);
            btn1.Name = "btn1";
            btn1.Size = new Size(61, 54);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlDark;
            btn2.Location = new Point(313, 143);
            btn2.Name = "btn2";
            btn2.Size = new Size(61, 54);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += button_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlDark;
            btn3.Location = new Point(392, 143);
            btn3.Name = "btn3";
            btn3.Size = new Size(61, 54);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += button_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlDarkDark;
            btnAdd.Location = new Point(470, 143);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 54);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += operator_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDark;
            btn4.Location = new Point(237, 212);
            btn4.Name = "btn4";
            btn4.Size = new Size(61, 54);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += button_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlDark;
            btn5.Location = new Point(313, 212);
            btn5.Name = "btn5";
            btn5.Size = new Size(61, 54);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += button_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlDark;
            btn6.Location = new Point(392, 212);
            btn6.Name = "btn6";
            btn6.Size = new Size(61, 54);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.MouseCaptureChanged += button_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = SystemColors.ControlDarkDark;
            btnSub.Location = new Point(470, 212);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(61, 54);
            btnSub.TabIndex = 8;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += operator_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlDark;
            btn7.Location = new Point(237, 286);
            btn7.Name = "btn7";
            btn7.Size = new Size(61, 54);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += button_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlDark;
            btn8.Location = new Point(313, 286);
            btn8.Name = "btn8";
            btn8.Size = new Size(61, 54);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += button_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlDark;
            btn9.Location = new Point(392, 286);
            btn9.Name = "btn9";
            btn9.Size = new Size(61, 54);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += button_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = SystemColors.ControlDarkDark;
            btnMul.Location = new Point(470, 286);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(61, 54);
            btnMul.TabIndex = 12;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += operator_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.WindowFrame;
            btnDot.Location = new Point(237, 362);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(61, 54);
            btnDot.TabIndex = 13;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlDark;
            btn0.Location = new Point(313, 362);
            btn0.Name = "btn0";
            btn0.Size = new Size(61, 54);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += button_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.WindowFrame;
            btnClear.Location = new Point(392, 362);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 54);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.ControlDarkDark;
            btnDiv.Location = new Point(470, 362);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(61, 54);
            btnDiv.TabIndex = 16;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += operator_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.WindowFrame;
            btnEqual.Location = new Point(237, 433);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(294, 48);
            btnEqual.TabIndex = 17;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistory.Location = new Point(470, 44);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(0, 25);
            lblHistory.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(810, 556);
            Controls.Add(lblHistory);
            Controls.Add(btnEqual);
            Controls.Add(btnDiv);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btnDot);
            Controls.Add(btnMul);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnSub);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnAdd);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            ForeColor = SystemColors.Window;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSub;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMul;
        private Button btnDot;
        private Button btn0;
        private Button btnClear;
        private Button btnDiv;
        private Button btnEqual;
        private Label lblHistory;
    }
}
