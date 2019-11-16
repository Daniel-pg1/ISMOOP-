namespace GraphicRedactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxShapes = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxShapes
            // 
            resources.ApplyResources(this.listBoxShapes, "listBoxShapes");
            this.listBoxShapes.AllowDrop = true;
            this.listBoxShapes.FormattingEnabled = true;
            this.listBoxShapes.Name = "listBoxShapes";
            this.listBoxShapes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.BackColor = System.Drawing.Color.MintCream;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonColor
            // 
            resources.ApplyResources(this.buttonColor, "buttonColor");
            this.buttonColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // textBoxWidth
            // 
            resources.ApplyResources(this.textBoxWidth, "textBoxWidth");
            this.textBoxWidth.Name = "textBoxWidth";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // buttonRectangle
            // 
            resources.ApplyResources(this.buttonRectangle, "buttonRectangle");
            this.buttonRectangle.BackColor = System.Drawing.Color.White;
            this.buttonRectangle.BackgroundImage = global::GraphicRedactor.Properties.Resources._3;
            this.buttonRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonCircle
            // 
            resources.ApplyResources(this.buttonCircle, "buttonCircle");
            this.buttonCircle.BackColor = System.Drawing.Color.White;
            this.buttonCircle.BackgroundImage = global::GraphicRedactor.Properties.Resources._2;
            this.buttonCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxDraw
            // 
            resources.ApplyResources(this.pictureBoxDraw, "pictureBoxDraw");
            this.pictureBoxDraw.BackColor = System.Drawing.Color.White;
            this.pictureBoxDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.TabStop = false;
            this.pictureBoxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDraw_Paint);
            this.pictureBoxDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDraw_MouseDown);
            this.pictureBoxDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDraw_MouseMove);
            this.pictureBoxDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDraw_MouseUp);
            // 
            // buttonLine
            // 
            resources.ApplyResources(this.buttonLine, "buttonLine");
            this.buttonLine.BackColor = System.Drawing.Color.White;
            this.buttonLine.BackgroundImage = global::GraphicRedactor.Properties.Resources._1;
            this.buttonLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonEllipse
            // 
            resources.ApplyResources(this.buttonEllipse, "buttonEllipse");
            this.buttonEllipse.BackgroundImage = global::GraphicRedactor.Properties.Resources.Безымянный;
            this.buttonEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // ButtonPoint
            // 
            resources.ApplyResources(this.ButtonPoint, "ButtonPoint");
            this.ButtonPoint.BackColor = System.Drawing.Color.White;
            this.ButtonPoint.BackgroundImage = global::GraphicRedactor.Properties.Resources.to4ka;
            this.ButtonPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.UseVisualStyleBackColor = false;
            this.ButtonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.pictureBoxDraw);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEllipse);
            this.Controls.Add(this.ButtonPoint);
            this.Controls.Add(this.listBoxShapes);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShapes;
        private System.Windows.Forms.Button ButtonPoint;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

