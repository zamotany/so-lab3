namespace solab3
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
            this.frameNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RequestsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randpe = new System.Windows.Forms.Label();
            this.alrupe = new System.Windows.Forms.Label();
            this.lrupe = new System.Windows.Forms.Label();
            this.optpe = new System.Windows.Forms.Label();
            this.fifope = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxFrameValNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FramesListView = new System.Windows.Forms.ListView();
            this.RequestsListView = new System.Windows.Forms.ListView();
            this.labl9 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frameNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrameValNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // frameNumericUpDown
            // 
            this.frameNumericUpDown.Location = new System.Drawing.Point(117, 7);
            this.frameNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameNumericUpDown.Name = "frameNumericUpDown";
            this.frameNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.frameNumericUpDown.TabIndex = 0;
            this.frameNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RequestsNumericUpDown
            // 
            this.RequestsNumericUpDown.Location = new System.Drawing.Point(117, 34);
            this.RequestsNumericUpDown.Name = "RequestsNumericUpDown";
            this.RequestsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.RequestsNumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of frames";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of requests";
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(348, 218);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(75, 23);
            this.beginButton.TabIndex = 4;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.randpe);
            this.groupBox1.Controls.Add(this.alrupe);
            this.groupBox1.Controls.Add(this.lrupe);
            this.groupBox1.Controls.Add(this.optpe);
            this.groupBox1.Controls.Add(this.fifope);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 144);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pages errors";
            // 
            // randpe
            // 
            this.randpe.AutoSize = true;
            this.randpe.Location = new System.Drawing.Point(52, 106);
            this.randpe.Name = "randpe";
            this.randpe.Size = new System.Drawing.Size(13, 13);
            this.randpe.TabIndex = 9;
            this.randpe.Text = "0";
            // 
            // alrupe
            // 
            this.alrupe.AutoSize = true;
            this.alrupe.Location = new System.Drawing.Point(52, 83);
            this.alrupe.Name = "alrupe";
            this.alrupe.Size = new System.Drawing.Size(13, 13);
            this.alrupe.TabIndex = 8;
            this.alrupe.Text = "0";
            // 
            // lrupe
            // 
            this.lrupe.AutoSize = true;
            this.lrupe.Location = new System.Drawing.Point(52, 60);
            this.lrupe.Name = "lrupe";
            this.lrupe.Size = new System.Drawing.Size(13, 13);
            this.lrupe.TabIndex = 7;
            this.lrupe.Text = "0";
            // 
            // optpe
            // 
            this.optpe.AutoSize = true;
            this.optpe.Location = new System.Drawing.Point(52, 38);
            this.optpe.Name = "optpe";
            this.optpe.Size = new System.Drawing.Size(13, 13);
            this.optpe.TabIndex = 6;
            this.optpe.Text = "0";
            // 
            // fifope
            // 
            this.fifope.AutoSize = true;
            this.fifope.Location = new System.Drawing.Point(52, 16);
            this.fifope.Name = "fifope";
            this.fifope.Size = new System.Drawing.Size(13, 13);
            this.fifope.TabIndex = 5;
            this.fifope.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "RAND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "A-LRU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "LRU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "OPT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "FIFO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Max frame value";
            // 
            // MaxFrameValNumericUpDown
            // 
            this.MaxFrameValNumericUpDown.Location = new System.Drawing.Point(336, 11);
            this.MaxFrameValNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxFrameValNumericUpDown.Name = "MaxFrameValNumericUpDown";
            this.MaxFrameValNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.MaxFrameValNumericUpDown.TabIndex = 12;
            this.MaxFrameValNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FramesListView
            // 
            this.FramesListView.Location = new System.Drawing.Point(247, 66);
            this.FramesListView.Name = "FramesListView";
            this.FramesListView.Size = new System.Drawing.Size(82, 144);
            this.FramesListView.TabIndex = 13;
            this.FramesListView.UseCompatibleStateImageBehavior = false;
            // 
            // RequestsListView
            // 
            this.RequestsListView.Location = new System.Drawing.Point(335, 66);
            this.RequestsListView.Name = "RequestsListView";
            this.RequestsListView.Size = new System.Drawing.Size(82, 144);
            this.RequestsListView.TabIndex = 14;
            this.RequestsListView.UseCompatibleStateImageBehavior = false;
            this.RequestsListView.View = System.Windows.Forms.View.List;
            // 
            // labl9
            // 
            this.labl9.AutoSize = true;
            this.labl9.Location = new System.Drawing.Point(247, 47);
            this.labl9.Name = "labl9";
            this.labl9.Size = new System.Drawing.Size(41, 13);
            this.labl9.TabIndex = 15;
            this.labl9.Text = "Frames";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Requests";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 253);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labl9);
            this.Controls.Add(this.RequestsListView);
            this.Controls.Add(this.FramesListView);
            this.Controls.Add(this.MaxFrameValNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequestsNumericUpDown);
            this.Controls.Add(this.frameNumericUpDown);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SO-Lab3";
            ((System.ComponentModel.ISupportInitialize)(this.frameNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrameValNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown frameNumericUpDown;
        private System.Windows.Forms.NumericUpDown RequestsNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label randpe;
        private System.Windows.Forms.Label alrupe;
        private System.Windows.Forms.Label lrupe;
        private System.Windows.Forms.Label optpe;
        private System.Windows.Forms.Label fifope;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown MaxFrameValNumericUpDown;
        private System.Windows.Forms.ListView FramesListView;
        private System.Windows.Forms.ListView RequestsListView;
        private System.Windows.Forms.Label labl9;
        private System.Windows.Forms.Label label9;
    }
}

