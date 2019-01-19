namespace obrabotka
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
            this.graph = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.BasicImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // BasicImage
            // 
            this.BasicImage.Location = new System.Drawing.Point(240, 17);
            this.BasicImage.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BasicImage.Name = "BasicImage";
            this.BasicImage.Size = new System.Drawing.Size(375, 308);
            this.BasicImage.TabIndex = 0;
            this.BasicImage.TabStop = false;
            // 
            // newImage
            // 
            this.newImage.Location = new System.Drawing.Point(641, 17);
            this.newImage.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.newImage.Name = "newImage";
            this.newImage.Size = new System.Drawing.Size(375, 308);
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
            this.PixelBar.Location = new System.Drawing.Point(224, 352);
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
            this.PixelBar_value.Location = new System.Drawing.Point(649, 331);
            this.PixelBar_value.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PixelBar_value.Name = "PixelBar_value";
            this.PixelBar_value.Size = new System.Drawing.Size(169, 17);
            this.PixelBar_value.TabIndex = 5;
            this.PixelBar_value.Text = "Текущее значение: 0";
            this.PixelBar_value.Click += new System.EventHandler(this.PixelBar_value_Click);
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(1046, 17);
            this.graph.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(384, 310);
            this.graph.TabIndex = 6;
            this.graph.TabStop = false;
            this.graph.Click += new System.EventHandler(this.graph_Click);
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
            this.button1.Location = new System.Drawing.Point(261, 444);
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
            this.button2.Location = new System.Drawing.Point(423, 444);
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
            this.button3.Location = new System.Drawing.Point(588, 444);
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
            this.button4.Location = new System.Drawing.Point(759, 444);
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
            this.button5.Location = new System.Drawing.Point(921, 444);
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
            this.button6.Location = new System.Drawing.Point(1082, 444);
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
            this.button7.Location = new System.Drawing.Point(23, 420);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 64);
            this.button7.TabIndex = 19;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // adaptive_binarization
            // 
            this.adaptive_binarization.Location = new System.Drawing.Point(15, 161);
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
            this.button8.Text = "Бинаризация адавптивная";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1485, 524);
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
            this.Controls.Add(this.graph);
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
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BasicImage;
        private System.Windows.Forms.PictureBox newImage;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.TrackBar PixelBar;
        private System.Windows.Forms.Label PixelBar_value;
        private System.Windows.Forms.PictureBox graph;
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
    }
}

