namespace Paint
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Color_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Pen_button = new System.Windows.Forms.Button();
            this.Rectangle_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Line_button = new System.Windows.Forms.Button();
            this.Ellipse_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(703, 334);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // Color_Button
            // 
            this.Color_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color_Button.Location = new System.Drawing.Point(731, 7);
            this.Color_Button.Name = "Color_Button";
            this.Color_Button.Size = new System.Drawing.Size(57, 29);
            this.Color_Button.TabIndex = 1;
            this.Color_Button.Text = "Color";
            this.Color_Button.UseVisualStyleBackColor = true;
            this.Color_Button.Click += new System.EventHandler(this.Color_Changing);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(464, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Thickness : 0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Eraser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Eraser);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(599, 7);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(126, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // Pen_button
            // 
            this.Pen_button.Location = new System.Drawing.Point(668, 42);
            this.Pen_button.Name = "Pen_button";
            this.Pen_button.Size = new System.Drawing.Size(57, 30);
            this.Pen_button.TabIndex = 7;
            this.Pen_button.Text = "Pen";
            this.Pen_button.UseVisualStyleBackColor = true;
            this.Pen_button.Click += new System.EventHandler(this.Button_Pen);
            // 
            // Rectangle_button
            // 
            this.Rectangle_button.Location = new System.Drawing.Point(593, 42);
            this.Rectangle_button.Name = "Rectangle_button";
            this.Rectangle_button.Size = new System.Drawing.Size(69, 30);
            this.Rectangle_button.TabIndex = 8;
            this.Rectangle_button.Text = "Rectangle";
            this.Rectangle_button.UseVisualStyleBackColor = true;
            this.Rectangle_button.Click += new System.EventHandler(this.Button_Rect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Line_button
            // 
            this.Line_button.Location = new System.Drawing.Point(518, 42);
            this.Line_button.Name = "Line_button";
            this.Line_button.Size = new System.Drawing.Size(69, 30);
            this.Line_button.TabIndex = 10;
            this.Line_button.Text = "Line";
            this.Line_button.UseVisualStyleBackColor = true;
            this.Line_button.Click += new System.EventHandler(this.Button_Line);
            // 
            // Ellipse_button
            // 
            this.Ellipse_button.Location = new System.Drawing.Point(443, 42);
            this.Ellipse_button.Name = "Ellipse_button";
            this.Ellipse_button.Size = new System.Drawing.Size(69, 30);
            this.Ellipse_button.TabIndex = 11;
            this.Ellipse_button.Text = "Ellipse";
            this.Ellipse_button.UseVisualStyleBackColor = true;
            this.Ellipse_button.Click += new System.EventHandler(this.Button_Ellipse);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ellipse_button);
            this.Controls.Add(this.Line_button);
            this.Controls.Add(this.Rectangle_button);
            this.Controls.Add(this.Pen_button);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Color_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Color_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Pen_button;
        private System.Windows.Forms.Button Rectangle_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Line_button;
        private System.Windows.Forms.Button Ellipse_button;
    }
}

