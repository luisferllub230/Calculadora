﻿namespace Calculadora
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.LBLtitle = new System.Windows.Forms.Label();
            this.BTNminimize = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBLnumero2 = new System.Windows.Forms.Label();
            this.BTNclean = new System.Windows.Forms.Button();
            this.LBLnumber = new System.Windows.Forms.Label();
            this.FLTkeyboar = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.FLTkeyboar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SandyBrown;
            this.panelHeader.Controls.Add(this.logo);
            this.panelHeader.Controls.Add(this.LBLtitle);
            this.panelHeader.Controls.Add(this.BTNminimize);
            this.panelHeader.Controls.Add(this.BTNClose);
            this.panelHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelHeader.Location = new System.Drawing.Point(0, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(430, 43);
            this.panelHeader.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Salmon;
            this.logo.Location = new System.Drawing.Point(3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(46, 34);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // LBLtitle
            // 
            this.LBLtitle.AutoSize = true;
            this.LBLtitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtitle.Location = new System.Drawing.Point(51, 10);
            this.LBLtitle.Name = "LBLtitle";
            this.LBLtitle.Size = new System.Drawing.Size(114, 28);
            this.LBLtitle.TabIndex = 3;
            this.LBLtitle.Text = "Calculator";
            this.LBLtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNminimize
            // 
            this.BTNminimize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNminimize.Location = new System.Drawing.Point(332, 3);
            this.BTNminimize.Name = "BTNminimize";
            this.BTNminimize.Size = new System.Drawing.Size(42, 35);
            this.BTNminimize.TabIndex = 1;
            this.BTNminimize.UseVisualStyleBackColor = false;
            this.BTNminimize.Click += new System.EventHandler(this.BTNminimize_Click);
            // 
            // BTNClose
            // 
            this.BTNClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNClose.Location = new System.Drawing.Point(380, 3);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(42, 35);
            this.BTNClose.TabIndex = 0;
            this.BTNClose.UseVisualStyleBackColor = false;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.LBLnumero2);
            this.panel1.Controls.Add(this.BTNclean);
            this.panel1.Controls.Add(this.LBLnumber);
            this.panel1.Location = new System.Drawing.Point(4, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 117);
            this.panel1.TabIndex = 1;
            // 
            // LBLnumero2
            // 
            this.LBLnumero2.AutoSize = true;
            this.LBLnumero2.Location = new System.Drawing.Point(14, 16);
            this.LBLnumero2.Name = "LBLnumero2";
            this.LBLnumero2.Size = new System.Drawing.Size(0, 13);
            this.LBLnumero2.TabIndex = 2;
            // 
            // BTNclean
            // 
            this.BTNclean.Location = new System.Drawing.Point(334, 3);
            this.BTNclean.Name = "BTNclean";
            this.BTNclean.Size = new System.Drawing.Size(89, 23);
            this.BTNclean.TabIndex = 1;
            this.BTNclean.UseVisualStyleBackColor = true;
            this.BTNclean.Click += new System.EventHandler(this.BTNclean_Click);
            // 
            // LBLnumber
            // 
            this.LBLnumber.AutoSize = true;
            this.LBLnumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLnumber.Location = new System.Drawing.Point(8, 52);
            this.LBLnumber.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.LBLnumber.Name = "LBLnumber";
            this.LBLnumber.Size = new System.Drawing.Size(53, 55);
            this.LBLnumber.TabIndex = 0;
            this.LBLnumber.Text = "0";
            this.LBLnumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FLTkeyboar
            // 
            this.FLTkeyboar.Controls.Add(this.button1);
            this.FLTkeyboar.Controls.Add(this.button2);
            this.FLTkeyboar.Controls.Add(this.button3);
            this.FLTkeyboar.Controls.Add(this.button4);
            this.FLTkeyboar.Controls.Add(this.button5);
            this.FLTkeyboar.Controls.Add(this.button6);
            this.FLTkeyboar.Controls.Add(this.button7);
            this.FLTkeyboar.Controls.Add(this.button8);
            this.FLTkeyboar.Controls.Add(this.button9);
            this.FLTkeyboar.Controls.Add(this.button10);
            this.FLTkeyboar.Controls.Add(this.button11);
            this.FLTkeyboar.Controls.Add(this.button12);
            this.FLTkeyboar.Location = new System.Drawing.Point(6, 177);
            this.FLTkeyboar.Name = "FLTkeyboar";
            this.FLTkeyboar.Size = new System.Drawing.Size(250, 333);
            this.FLTkeyboar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 74);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(84, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 74);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(165, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 74);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 163);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 74);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(84, 163);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 74);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(165, 163);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 74);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(3, 243);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 74);
            this.button10.TabIndex = 9;
            this.button10.Text = "+/-";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(84, 243);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 74);
            this.button11.TabIndex = 10;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(165, 243);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 74);
            this.button12.TabIndex = 11;
            this.button12.Text = ".";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button13);
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.Controls.Add(this.button15);
            this.flowLayoutPanel1.Controls.Add(this.button16);
            this.flowLayoutPanel1.Controls.Add(this.button17);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(262, 177);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 332);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(3, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(157, 56);
            this.button13.TabIndex = 0;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(3, 65);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(157, 50);
            this.button14.TabIndex = 1;
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(3, 121);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(157, 54);
            this.button15.TabIndex = 2;
            this.button15.Text = "*";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(3, 181);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(157, 46);
            this.button16.TabIndex = 3;
            this.button16.Text = "/";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(3, 233);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(157, 84);
            this.button17.TabIndex = 4;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 522);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.FLTkeyboar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FLTkeyboar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label LBLtitle;
        private System.Windows.Forms.Button BTNminimize;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNclean;
        private System.Windows.Forms.Label LBLnumber;
        private System.Windows.Forms.FlowLayoutPanel FLTkeyboar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label LBLnumero2;
    }
}

