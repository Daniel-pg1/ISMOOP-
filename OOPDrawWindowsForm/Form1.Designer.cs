namespace OOPDrawWindowsForm
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarElNumber = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(769, 26);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(141, 71);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Промалювати";
            this.buttonDraw.UseVisualStyleBackColor = false;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(769, 133);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(141, 71);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDraw.BackColor = System.Drawing.Color.White;
            this.pictureBoxDraw.Location = new System.Drawing.Point(27, 26);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBoxDraw.Size = new System.Drawing.Size(691, 476);
            this.pictureBoxDraw.TabIndex = 2;
            this.pictureBoxDraw.TabStop = false;
            this.pictureBoxDraw.Click += new System.EventHandler(this.pictureBoxDraw_Click);
            this.pictureBoxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDraw_Paint_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(848, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Клименко Д. О.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBarElNumber
            // 
            this.trackBarElNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarElNumber.BackColor = System.Drawing.Color.White;
            this.trackBarElNumber.Location = new System.Drawing.Point(27, 531);
            this.trackBarElNumber.Maximum = 100;
            this.trackBarElNumber.Minimum = 1;
            this.trackBarElNumber.Name = "trackBarElNumber";
            this.trackBarElNumber.Size = new System.Drawing.Size(691, 45);
            this.trackBarElNumber.TabIndex = 4;
            this.trackBarElNumber.Value = 1;
            this.trackBarElNumber.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.trackBarElNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDraw);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDraw);
            this.MaximumSize = new System.Drawing.Size(1500, 870);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form1";
            this.Text = "Практична робота № 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarElNumber;
    }
}

