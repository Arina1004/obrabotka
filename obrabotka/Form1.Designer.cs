﻿namespace obrabotka
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BasicImage = new System.Windows.Forms.PictureBox();
            this.newImage = new System.Windows.Forms.PictureBox();
            this.Upload = new System.Windows.Forms.Button();
            this.PixelBar = new System.Windows.Forms.TrackBar();
            this.PixelBar_value = new System.Windows.Forms.Label();
            this.Binarization = new System.Windows.Forms.Button();
            this.Gamma = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.adaptive_binarization = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rotation = new System.Windows.Forms.Button();
            this.Scalling = new System.Windows.Forms.Button();
            this.axis = new System.Windows.Forms.ComboBox();
            this.ScailingConst = new System.Windows.Forms.TextBox();
            this.Circle = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textfordisplay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BasicImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // BasicImage
            // 
            this.BasicImage.Location = new System.Drawing.Point(240, 17);
            this.BasicImage.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BasicImage.Name = "BasicImage";
            this.BasicImage.Size = new System.Drawing.Size(639, 440);
            this.BasicImage.TabIndex = 0;
            this.BasicImage.TabStop = false;
            this.BasicImage.Click += new System.EventHandler(this.BasicImage_Click);
            this.BasicImage.Paint += new System.Windows.Forms.PaintEventHandler(this.BasicImage_Paint);
            this.BasicImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BasicImage_MouseDown);
            this.BasicImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BasicImage_MouseMove);
            this.BasicImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BasicImage_MouseUp);
            // 
            // newImage
            // 
            this.newImage.Location = new System.Drawing.Point(905, 17);
            this.newImage.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.newImage.Name = "newImage";
            this.newImage.Size = new System.Drawing.Size(640, 440);
            this.newImage.TabIndex = 1;
            this.newImage.TabStop = false;
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.LavenderBlush;
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Upload.Location = new System.Drawing.Point(23, 17);
            this.Upload.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(171, 40);
            this.Upload.TabIndex = 2;
            this.Upload.Text = "Загрузить";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // PixelBar
            // 
            this.PixelBar.LargeChange = 10;
            this.PixelBar.Location = new System.Drawing.Point(244, 520);
            this.PixelBar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.PixelBar.Maximum = 255;
            this.PixelBar.Minimum = -255;
            this.PixelBar.Name = "PixelBar";
            this.PixelBar.Size = new System.Drawing.Size(1008, 56);
            this.PixelBar.TabIndex = 4;
            this.PixelBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.PixelBar.Value = -30;
            this.PixelBar.Scroll += new System.EventHandler(this.PixelBar_Scroll);
            // 
            // PixelBar_value
            // 
            this.PixelBar_value.AutoSize = true;
            this.PixelBar_value.Location = new System.Drawing.Point(638, 499);
            this.PixelBar_value.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PixelBar_value.Name = "PixelBar_value";
            this.PixelBar_value.Size = new System.Drawing.Size(169, 17);
            this.PixelBar_value.TabIndex = 5;
            this.PixelBar_value.Text = "Текущее значение: 0";
            this.PixelBar_value.Click += new System.EventHandler(this.PixelBar_value_Click);
            // 
            // Binarization
            // 
            this.Binarization.BackColor = System.Drawing.Color.LavenderBlush;
            this.Binarization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Binarization.Location = new System.Drawing.Point(15, 65);
            this.Binarization.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Binarization.Name = "Binarization";
            this.Binarization.Size = new System.Drawing.Size(210, 40);
            this.Binarization.TabIndex = 7;
            this.Binarization.Text = "Бинаризация";
            this.Binarization.UseVisualStyleBackColor = false;
            this.Binarization.Click += new System.EventHandler(this.Binarization_Click);
            // 
            // Gamma
            // 
            this.Gamma.BackColor = System.Drawing.Color.LavenderBlush;
            this.Gamma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gamma.Location = new System.Drawing.Point(15, 113);
            this.Gamma.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Gamma.Name = "Gamma";
            this.Gamma.Size = new System.Drawing.Size(210, 40);
            this.Gamma.TabIndex = 10;
            this.Gamma.Text = "Гамма-преобразование";
            this.Gamma.UseVisualStyleBackColor = false;
            this.Gamma.Click += new System.EventHandler(this.Gamma_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 610);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "0-0.16";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 610);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "0.17-0.33";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(599, 610);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "0.34-0.49";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(774, 610);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 40);
            this.button4.TabIndex = 15;
            this.button4.Text = "0.5-0.66";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(946, 610);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 40);
            this.button5.TabIndex = 16;
            this.button5.Text = "0.67-0.82";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1120, 610);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 40);
            this.button6.TabIndex = 17;
            this.button6.Text = "0.83-1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(12, 598);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 64);
            this.button7.TabIndex = 19;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // adaptive_binarization
            // 
            this.adaptive_binarization.Location = new System.Drawing.Point(15, 162);
            this.adaptive_binarization.Name = "adaptive_binarization";
            this.adaptive_binarization.Size = new System.Drawing.Size(210, 44);
            this.adaptive_binarization.TabIndex = 20;
            this.adaptive_binarization.Text = "Оператор Кирша";
            this.adaptive_binarization.UseVisualStyleBackColor = true;
            this.adaptive_binarization.Click += new System.EventHandler(this.button8_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(15, 212);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(210, 46);
            this.button8.TabIndex = 21;
            this.button8.Text = "Бинаризация адаптивная";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(23, 307);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 23);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(97, 307);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown2.TabIndex = 23;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "mat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "порог";
            // 
            // Rotation
            // 
            this.Rotation.Location = new System.Drawing.Point(15, 421);
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(202, 52);
            this.Rotation.TabIndex = 31;
            this.Rotation.Text = "Поворот";
            this.Rotation.Click += new System.EventHandler(this.Rotation_Click);
            // 
            // Scalling
            // 
            this.Scalling.Location = new System.Drawing.Point(12, 348);
            this.Scalling.Name = "Scalling";
            this.Scalling.Size = new System.Drawing.Size(202, 55);
            this.Scalling.TabIndex = 27;
            this.Scalling.Text = "Масштабирование";
            this.Scalling.UseVisualStyleBackColor = true;
            this.Scalling.Click += new System.EventHandler(this.Scalling_Click);
            // 
            // axis
            // 
            this.axis.FormattingEnabled = true;
            this.axis.Items.AddRange(new object[] {
            "Центр",
            "Произвольная точка"});
            this.axis.Location = new System.Drawing.Point(284, 473);
            this.axis.Name = "axis";
            this.axis.Size = new System.Drawing.Size(121, 24);
            this.axis.TabIndex = 30;
            this.axis.SelectedIndexChanged += new System.EventHandler(this.axis_SelectedIndexChanged);
            // 
            // ScailingConst
            // 
            this.ScailingConst.Location = new System.Drawing.Point(440, 473);
            this.ScailingConst.Margin = new System.Windows.Forms.Padding(4);
            this.ScailingConst.Name = "ScailingConst";
            this.ScailingConst.Size = new System.Drawing.Size(132, 23);
            this.ScailingConst.TabIndex = 29;
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(15, 499);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(198, 55);
            this.Circle.TabIndex = 32;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.button9_Click);
            // 
            // textfordisplay
            // 
            this.textfordisplay.Location = new System.Drawing.Point(620, 471);
            this.textfordisplay.Name = "textfordisplay";
            this.textfordisplay.Size = new System.Drawing.Size(125, 23);
            this.textfordisplay.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1571, 676);
            this.Controls.Add(this.textfordisplay);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.ScailingConst);
            this.Controls.Add(this.axis);
            this.Controls.Add(this.Scalling);
            this.Controls.Add(this.Rotation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.adaptive_binarization);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gamma);
            this.Controls.Add(this.Binarization);
            this.Controls.Add(this.PixelBar_value);
            this.Controls.Add(this.PixelBar);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.newImage);
            this.Controls.Add(this.BasicImage);
            this.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BasicImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BasicImage;
        private System.Windows.Forms.PictureBox newImage;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.TrackBar PixelBar;
        private System.Windows.Forms.Label PixelBar_value;
        private System.Windows.Forms.Button Binarization;
        private System.Windows.Forms.Button Gamma;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button adaptive_binarization;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Rotation;
        private System.Windows.Forms.Button Scalling;
        private System.Windows.Forms.ComboBox axis;
        private System.Windows.Forms.TextBox ScailingConst;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textfordisplay;
    }
}

