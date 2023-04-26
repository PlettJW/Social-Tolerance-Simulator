namespace SocialTolerance
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
            this.components = new System.ComponentModel.Container();
            this.enterPeoples = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterEmpty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.enterTolerance = new System.Windows.Forms.NumericUpDown();
            this.enterWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.enterRed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.enterBlue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.enterGreen = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.enterYellow = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.enterGray = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.butStep = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enterPeoples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterGray)).BeginInit();
            this.SuspendLayout();
            // 
            // enterPeoples
            // 
            this.enterPeoples.Location = new System.Drawing.Point(124, 34);
            this.enterPeoples.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.enterPeoples.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.enterPeoples.Name = "enterPeoples";
            this.enterPeoples.Size = new System.Drawing.Size(32, 20);
            this.enterPeoples.TabIndex = 0;
            this.enterPeoples.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.enterPeoples.ValueChanged += new System.EventHandler(this.enterWidth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "People Groups";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empty Cells (Percentage)";
            // 
            // enterEmpty
            // 
            this.enterEmpty.Location = new System.Drawing.Point(58, 183);
            this.enterEmpty.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.enterEmpty.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.enterEmpty.Name = "enterEmpty";
            this.enterEmpty.Size = new System.Drawing.Size(32, 20);
            this.enterEmpty.TabIndex = 0;
            this.enterEmpty.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.enterEmpty.ValueChanged += new System.EventHandler(this.enterWidth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tolerance (Percentage)";
            // 
            // enterTolerance
            // 
            this.enterTolerance.Location = new System.Drawing.Point(58, 114);
            this.enterTolerance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enterTolerance.Name = "enterTolerance";
            this.enterTolerance.Size = new System.Drawing.Size(32, 20);
            this.enterTolerance.TabIndex = 0;
            this.enterTolerance.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.enterTolerance.ValueChanged += new System.EventHandler(this.enterWidth_ValueChanged);
            // 
            // enterWidth
            // 
            this.enterWidth.Location = new System.Drawing.Point(16, 34);
            this.enterWidth.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.enterWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.enterWidth.Name = "enterWidth";
            this.enterWidth.Size = new System.Drawing.Size(46, 20);
            this.enterWidth.TabIndex = 0;
            this.enterWidth.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.enterWidth.ValueChanged += new System.EventHandler(this.enterWidth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Grid Size";
            // 
            // enterRed
            // 
            this.enterRed.Location = new System.Drawing.Point(16, 249);
            this.enterRed.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.enterRed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enterRed.Name = "enterRed";
            this.enterRed.Size = new System.Drawing.Size(32, 20);
            this.enterRed.TabIndex = 0;
            this.enterRed.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.enterRed.ValueChanged += new System.EventHandler(this.enterWidth_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Red (Weight)";
            // 
            // enterBlue
            // 
            this.enterBlue.Location = new System.Drawing.Point(124, 249);
            this.enterBlue.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.enterBlue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enterBlue.Name = "enterBlue";
            this.enterBlue.Size = new System.Drawing.Size(32, 20);
            this.enterBlue.TabIndex = 0;
            this.enterBlue.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.enterBlue.ValueChanged += new System.EventHandler(this.enterWidth_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Blue (Weight)";
            // 
            // enterGreen
            // 
            this.enterGreen.Location = new System.Drawing.Point(16, 317);
            this.enterGreen.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.enterGreen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enterGreen.Name = "enterGreen";
            this.enterGreen.Size = new System.Drawing.Size(32, 20);
            this.enterGreen.TabIndex = 0;
            this.enterGreen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enterGreen.ValueChanged += new System.EventHandler(this.enterWidth_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Green (Weight)";
            // 
            // enterYellow
            // 
            this.enterYellow.Location = new System.Drawing.Point(124, 318);
            this.enterYellow.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.enterYellow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enterYellow.Name = "enterYellow";
            this.enterYellow.Size = new System.Drawing.Size(32, 20);
            this.enterYellow.TabIndex = 0;
            this.enterYellow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enterYellow.ValueChanged += new System.EventHandler(this.enterWidth_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Yellow (Weight)";
            // 
            // enterGray
            // 
            this.enterGray.Location = new System.Drawing.Point(16, 385);
            this.enterGray.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.enterGray.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enterGray.Name = "enterGray";
            this.enterGray.Size = new System.Drawing.Size(32, 20);
            this.enterGray.TabIndex = 0;
            this.enterGray.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enterGray.ValueChanged += new System.EventHandler(this.enterWidth_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Gray (Weight)";
            // 
            // butStart
            // 
            this.butStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butStart.ForeColor = System.Drawing.Color.Black;
            this.butStart.Location = new System.Drawing.Point(16, 429);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(90, 41);
            this.butStart.TabIndex = 2;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = false;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butStop
            // 
            this.butStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butStop.ForeColor = System.Drawing.Color.Black;
            this.butStop.Location = new System.Drawing.Point(112, 429);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(90, 41);
            this.butStop.TabIndex = 2;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = false;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butStep
            // 
            this.butStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butStep.ForeColor = System.Drawing.Color.Black;
            this.butStep.Location = new System.Drawing.Point(16, 476);
            this.butStep.Name = "butStep";
            this.butStep.Size = new System.Drawing.Size(90, 29);
            this.butStep.TabIndex = 2;
            this.butStep.Text = "Step";
            this.butStep.UseVisualStyleBackColor = false;
            this.butStep.Click += new System.EventHandler(this.butStep_Click);
            // 
            // butReset
            // 
            this.butReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butReset.ForeColor = System.Drawing.Color.Black;
            this.butReset.Location = new System.Drawing.Point(112, 476);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(90, 29);
            this.butReset.TabIndex = 2;
            this.butReset.Text = "Reset";
            this.butReset.UseVisualStyleBackColor = false;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1099, 650);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butStep);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enterYellow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterGray);
            this.Controls.Add(this.enterBlue);
            this.Controls.Add(this.enterGreen);
            this.Controls.Add(this.enterRed);
            this.Controls.Add(this.enterTolerance);
            this.Controls.Add(this.enterWidth);
            this.Controls.Add(this.enterEmpty);
            this.Controls.Add(this.enterPeoples);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Social Tolerance Simulator 2020";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.enterPeoples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterGray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown enterPeoples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown enterEmpty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown enterTolerance;
        private System.Windows.Forms.NumericUpDown enterWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown enterRed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown enterBlue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown enterGreen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown enterYellow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown enterGray;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butStep;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Timer timer1;
    }
}

