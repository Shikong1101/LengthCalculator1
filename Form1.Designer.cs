namespace LengthCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.clear = new System.Windows.Forms.Button();
            this.cm1 = new System.Windows.Forms.Label();
            this.m1 = new System.Windows.Forms.Label();
            this.km1 = new System.Windows.Forms.Label();
            this.inch1 = new System.Windows.Forms.Label();
            this.ft1 = new System.Windows.Forms.Label();
            this.yard1 = new System.Windows.Forms.Label();
            this.cm = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.TextBox();
            this.km = new System.Windows.Forms.TextBox();
            this.inch = new System.Windows.Forms.TextBox();
            this.ft = new System.Windows.Forms.TextBox();
            this.yard = new System.Windows.Forms.TextBox();
            this.www = new System.Windows.Forms.Label();
            this.explanationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(56, 44);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(96, 29);
            this.clear.TabIndex = 0;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // cm1
            // 
            this.cm1.AutoSize = true;
            this.cm1.Location = new System.Drawing.Point(55, 99);
            this.cm1.Name = "cm1";
            this.cm1.Size = new System.Drawing.Size(37, 15);
            this.cm1.TabIndex = 1;
            this.cm1.Text = "公分";
            // 
            // m1
            // 
            this.m1.AutoSize = true;
            this.m1.Location = new System.Drawing.Point(144, 99);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(37, 15);
            this.m1.TabIndex = 2;
            this.m1.Text = "公尺";
            // 
            // km1
            // 
            this.km1.AutoSize = true;
            this.km1.Location = new System.Drawing.Point(241, 99);
            this.km1.Name = "km1";
            this.km1.Size = new System.Drawing.Size(37, 15);
            this.km1.TabIndex = 3;
            this.km1.Text = "公里";
            // 
            // inch1
            // 
            this.inch1.AutoSize = true;
            this.inch1.Location = new System.Drawing.Point(55, 170);
            this.inch1.Name = "inch1";
            this.inch1.Size = new System.Drawing.Size(37, 15);
            this.inch1.TabIndex = 4;
            this.inch1.Text = "英吋";
            // 
            // ft1
            // 
            this.ft1.AutoSize = true;
            this.ft1.Location = new System.Drawing.Point(144, 170);
            this.ft1.Name = "ft1";
            this.ft1.Size = new System.Drawing.Size(37, 15);
            this.ft1.TabIndex = 5;
            this.ft1.Text = "英尺";
            // 
            // yard1
            // 
            this.yard1.AutoSize = true;
            this.yard1.Location = new System.Drawing.Point(241, 170);
            this.yard1.Name = "yard1";
            this.yard1.Size = new System.Drawing.Size(37, 15);
            this.yard1.TabIndex = 6;
            this.yard1.Text = "英碼";
            // 
            // cm
            // 
            this.cm.Location = new System.Drawing.Point(56, 117);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(76, 25);
            this.cm.TabIndex = 7;
            this.cm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Cm_KeyUp);
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(147, 117);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(76, 25);
            this.m.TabIndex = 8;
            this.m.KeyUp += new System.Windows.Forms.KeyEventHandler(this.W_KeyUp);
            // 
            // km
            // 
            this.km.Location = new System.Drawing.Point(244, 117);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(76, 25);
            this.km.TabIndex = 9;
            this.km.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Km_KeyUp);
            // 
            // inch
            // 
            this.inch.Location = new System.Drawing.Point(56, 188);
            this.inch.Name = "inch";
            this.inch.Size = new System.Drawing.Size(76, 25);
            this.inch.TabIndex = 10;
            this.inch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Inch_KeyUp);
            // 
            // ft
            // 
            this.ft.Location = new System.Drawing.Point(147, 188);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(76, 25);
            this.ft.TabIndex = 11;
            this.ft.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Ft_KeyUp);
            // 
            // yard
            // 
            this.yard.Location = new System.Drawing.Point(244, 188);
            this.yard.Name = "yard";
            this.yard.Size = new System.Drawing.Size(76, 25);
            this.yard.TabIndex = 12;
            this.yard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Yard_KeyUp);
            // 
            // www
            // 
            this.www.AutoSize = true;
            this.www.Location = new System.Drawing.Point(55, 247);
            this.www.Name = "www";
            this.www.Size = new System.Drawing.Size(67, 15);
            this.www.TabIndex = 13;
            this.www.Text = "說明文字";
            // 
            // explanationTextBox
            // 
            this.explanationTextBox.Location = new System.Drawing.Point(56, 265);
            this.explanationTextBox.Name = "explanationTextBox";
            this.explanationTextBox.Size = new System.Drawing.Size(164, 25);
            this.explanationTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.explanationTextBox);
            this.Controls.Add(this.www);
            this.Controls.Add(this.yard);
            this.Controls.Add(this.ft);
            this.Controls.Add(this.inch);
            this.Controls.Add(this.km);
            this.Controls.Add(this.m);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.yard1);
            this.Controls.Add(this.ft1);
            this.Controls.Add(this.inch1);
            this.Controls.Add(this.km1);
            this.Controls.Add(this.m1);
            this.Controls.Add(this.cm1);
            this.Controls.Add(this.clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label cm1;
        private System.Windows.Forms.Label m1;
        private System.Windows.Forms.Label km1;
        private System.Windows.Forms.Label inch1;
        private System.Windows.Forms.Label ft1;
        private System.Windows.Forms.Label yard1;
        private System.Windows.Forms.TextBox cm;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.TextBox km;
        private System.Windows.Forms.TextBox inch;
        private System.Windows.Forms.TextBox ft;
        private System.Windows.Forms.TextBox yard;
        private System.Windows.Forms.Label www;
        private System.Windows.Forms.TextBox explanationTextBox;
        private System.Windows.Forms.TextBox sourceTextBox;

    }
}

