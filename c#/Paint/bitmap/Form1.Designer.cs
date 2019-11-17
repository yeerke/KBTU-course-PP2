namespace bitmap
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Color_Button = new System.Windows.Forms.Button();
            this.Ellipse_button = new System.Windows.Forms.Button();
            this.Eraser = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Pen_button = new System.Windows.Forms.Button();
            this.Rectangle_button = new System.Windows.Forms.Button();
            this.Line_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Star = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Fill1 = new System.Windows.Forms.Button();
            this.Fill2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(466, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Thickness : 0";
            // 
            // Color_Button
            // 
            this.Color_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color_Button.Location = new System.Drawing.Point(733, 12);
            this.Color_Button.Name = "Color_Button";
            this.Color_Button.Size = new System.Drawing.Size(57, 29);
            this.Color_Button.TabIndex = 12;
            this.Color_Button.Text = "Color";
            this.Color_Button.UseVisualStyleBackColor = true;
            this.Color_Button.Click += new System.EventHandler(this.Color_Button_Click);
            // 
            // Ellipse_button
            // 
            this.Ellipse_button.Location = new System.Drawing.Point(445, 47);
            this.Ellipse_button.Name = "Ellipse_button";
            this.Ellipse_button.Size = new System.Drawing.Size(69, 30);
            this.Ellipse_button.TabIndex = 20;
            this.Ellipse_button.Text = "Ellipse";
            this.Ellipse_button.UseVisualStyleBackColor = true;
            this.Ellipse_button.Click += new System.EventHandler(this.Ellipse_button_Click);
            // 
            // Eraser
            // 
            this.Eraser.Location = new System.Drawing.Point(733, 47);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(57, 30);
            this.Eraser.TabIndex = 14;
            this.Eraser.Text = "Eraser";
            this.Eraser.UseVisualStyleBackColor = true;
            this.Eraser.Click += new System.EventHandler(this.Button_Eraser);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(601, 12);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(126, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // Pen_button
            // 
            this.Pen_button.Location = new System.Drawing.Point(670, 47);
            this.Pen_button.Name = "Pen_button";
            this.Pen_button.Size = new System.Drawing.Size(57, 30);
            this.Pen_button.TabIndex = 16;
            this.Pen_button.Text = "Pen";
            this.Pen_button.UseVisualStyleBackColor = true;
            this.Pen_button.Click += new System.EventHandler(this.Pen_button_Click);
            // 
            // Rectangle_button
            // 
            this.Rectangle_button.Location = new System.Drawing.Point(595, 47);
            this.Rectangle_button.Name = "Rectangle_button";
            this.Rectangle_button.Size = new System.Drawing.Size(69, 30);
            this.Rectangle_button.TabIndex = 17;
            this.Rectangle_button.Text = "Rectangle";
            this.Rectangle_button.UseVisualStyleBackColor = true;
            this.Rectangle_button.Click += new System.EventHandler(this.Rectangle_button_Click);
            // 
            // Line_button
            // 
            this.Line_button.Location = new System.Drawing.Point(520, 47);
            this.Line_button.Name = "Line_button";
            this.Line_button.Size = new System.Drawing.Size(69, 30);
            this.Line_button.TabIndex = 19;
            this.Line_button.Text = "Line";
            this.Line_button.UseVisualStyleBackColor = true;
            this.Line_button.Click += new System.EventHandler(this.Line_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 327);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // Star
            // 
            this.Star.Location = new System.Drawing.Point(370, 47);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(69, 30);
            this.Star.TabIndex = 22;
            this.Star.Text = "Star";
            this.Star.UseVisualStyleBackColor = true;
            this.Star.Click += new System.EventHandler(this.Button_Star);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "FIle";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem2.Text = "Open";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Open_File);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem3.Text = "Save";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Save_File);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Fill1
            // 
            this.Fill1.Location = new System.Drawing.Point(295, 47);
            this.Fill1.Name = "Fill1";
            this.Fill1.Size = new System.Drawing.Size(69, 30);
            this.Fill1.TabIndex = 24;
            this.Fill1.Text = "Fill1";
            this.Fill1.UseVisualStyleBackColor = true;
            this.Fill1.Click += new System.EventHandler(this.Fill1_Click);
            // 
            // Fill2
            // 
            this.Fill2.Location = new System.Drawing.Point(220, 47);
            this.Fill2.Name = "Fill2";
            this.Fill2.Size = new System.Drawing.Size(69, 30);
            this.Fill2.TabIndex = 25;
            this.Fill2.Text = "Fill2";
            this.Fill2.UseVisualStyleBackColor = true;
            this.Fill2.Click += new System.EventHandler(this.Fill2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fill2);
            this.Controls.Add(this.Fill1);
            this.Controls.Add(this.Star);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ellipse_button);
            this.Controls.Add(this.Line_button);
            this.Controls.Add(this.Rectangle_button);
            this.Controls.Add(this.Pen_button);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Eraser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Color_Button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Color_Button;
        private System.Windows.Forms.Button Ellipse_button;
        private System.Windows.Forms.Button Eraser;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Pen_button;
        private System.Windows.Forms.Button Rectangle_button;
        private System.Windows.Forms.Button Line_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Star;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Fill1;
        private System.Windows.Forms.Button Fill2;
    }
}

