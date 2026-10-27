namespace Lab3
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
            picHelp = new PictureBox();
            groupBox1 = new GroupBox();
            btnExit = new Button();
            btnReset = new Button();
            btnCalculate = new Button();
            txtYears = new TextBox();
            txtFutureValue = new TextBox();
            lblRatePerYear = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpSolution = new GroupBox();
            lblStartOver = new Label();
            lblPayment = new Label();
            lblMPResult = new Label();
            lblPaymentCaption = new Label();
            lblSolution = new Label();
            ((System.ComponentModel.ISupportInitialize)picHelp).BeginInit();
            groupBox1.SuspendLayout();
            grpSolution.SuspendLayout();
            SuspendLayout();
            // 
            // picHelp
            // 
            picHelp.BorderStyle = BorderStyle.FixedSingle;
            picHelp.Image = (Image)resources.GetObject("picHelp.Image");
            picHelp.Location = new Point(259, 0);
            picHelp.Name = "picHelp";
            picHelp.Size = new Size(156, 110);
            picHelp.SizeMode = PictureBoxSizeMode.Zoom;
            picHelp.TabIndex = 0;
            picHelp.TabStop = false;
            picHelp.Click += picHelp_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(txtYears);
            groupBox1.Controls.Add(txtFutureValue);
            groupBox1.Controls.Add(lblRatePerYear);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(picHelp);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 214);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Required";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(303, 154);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(106, 45);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(154, 154);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(106, 45);
            btnReset.TabIndex = 8;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(7, 154);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(106, 45);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtYears
            // 
            txtYears.Location = new Point(134, 103);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(119, 24);
            txtYears.TabIndex = 6;
            txtYears.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFutureValue
            // 
            txtFutureValue.Location = new Point(134, 31);
            txtFutureValue.Name = "txtFutureValue";
            txtFutureValue.Size = new Size(119, 24);
            txtFutureValue.TabIndex = 5;
            txtFutureValue.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRatePerYear
            // 
            lblRatePerYear.BackColor = Color.FromArgb(255, 192, 192);
            lblRatePerYear.BorderStyle = BorderStyle.FixedSingle;
            lblRatePerYear.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRatePerYear.Location = new Point(134, 67);
            lblRatePerYear.Name = "lblRatePerYear";
            lblRatePerYear.Size = new Size(119, 24);
            lblRatePerYear.TabIndex = 4;
            lblRatePerYear.Text = "7.5";
            lblRatePerYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 106);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 3;
            label3.Text = "Years:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 70);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 2;
            label2.Text = "Rate per Year:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 34);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 1;
            label1.Text = "Future Value:";
            // 
            // grpSolution
            // 
            grpSolution.BackColor = SystemColors.Info;
            grpSolution.Controls.Add(lblStartOver);
            grpSolution.Controls.Add(lblPayment);
            grpSolution.Controls.Add(lblMPResult);
            grpSolution.Controls.Add(lblPaymentCaption);
            grpSolution.Controls.Add(lblSolution);
            grpSolution.Location = new Point(434, 14);
            grpSolution.Name = "grpSolution";
            grpSolution.Size = new Size(237, 212);
            grpSolution.TabIndex = 2;
            grpSolution.TabStop = false;
            // 
            // lblStartOver
            // 
            lblStartOver.BackColor = Color.FromArgb(255, 192, 192);
            lblStartOver.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartOver.Location = new Point(6, 152);
            lblStartOver.Name = "lblStartOver";
            lblStartOver.Size = new Size(225, 57);
            lblStartOver.TabIndex = 4;
            lblStartOver.Text = "Payments are totalled. Reset to start over.";
            // 
            // lblPayment
            // 
            lblPayment.BackColor = SystemColors.GradientActiveCaption;
            lblPayment.BorderStyle = BorderStyle.FixedSingle;
            lblPayment.Location = new Point(28, 75);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(160, 26);
            lblPayment.TabIndex = 3;
            // 
            // lblMPResult
            // 
            lblMPResult.AutoSize = true;
            lblMPResult.BackColor = SystemColors.ActiveCaption;
            lblMPResult.Location = new Point(68, 108);
            lblMPResult.Name = "lblMPResult";
            lblMPResult.Size = new Size(0, 17);
            lblMPResult.TabIndex = 2;
            // 
            // lblPaymentCaption
            // 
            lblPaymentCaption.AutoSize = true;
            lblPaymentCaption.Location = new Point(28, 49);
            lblPaymentCaption.Name = "lblPaymentCaption";
            lblPaymentCaption.Size = new Size(131, 17);
            lblPaymentCaption.TabIndex = 1;
            lblPaymentCaption.Text = "Monthly Payments:";
            // 
            // lblSolution
            // 
            lblSolution.AutoSize = true;
            lblSolution.Location = new Point(0, 0);
            lblSolution.Name = "lblSolution";
            lblSolution.Size = new Size(60, 17);
            lblSolution.TabIndex = 0;
            lblSolution.Text = "Solution";
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReset;
            ClientSize = new Size(680, 235);
            Controls.Add(grpSolution);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Annuity Payment by Sam Shaw";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picHelp).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpSolution.ResumeLayout(false);
            grpSolution.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picHelp;
        private GroupBox groupBox1;
        private Label lblRatePerYear;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtYears;
        private TextBox txtFutureValue;
        private Button btnExit;
        private Button btnReset;
        private Button btnCalculate;
        private GroupBox grpSolution;
        private Label lblMPResult;
        private Label lblPaymentCaption;
        private Label lblSolution;
        private Label lblPayment;
        private Label lblStartOver;
    }
}
