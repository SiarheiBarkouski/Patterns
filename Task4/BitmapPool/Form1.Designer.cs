namespace BitmapPool
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
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbNegative = new System.Windows.Forms.PictureBox();
            this.btnGetPictures = new System.Windows.Forms.Button();
            this.pbRotatedLeft = new System.Windows.Forms.PictureBox();
            this.pbRotatedRight = new System.Windows.Forms.PictureBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNegative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotatedLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotatedRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOriginal
            // 
            this.pbOriginal.Location = new System.Drawing.Point(23, 12);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(450, 420);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOriginal.TabIndex = 0;
            this.pbOriginal.TabStop = false;
            this.pbOriginal.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbNegative
            // 
            this.pbNegative.Location = new System.Drawing.Point(618, 12);
            this.pbNegative.Name = "pbNegative";
            this.pbNegative.Size = new System.Drawing.Size(450, 420);
            this.pbNegative.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNegative.TabIndex = 1;
            this.pbNegative.TabStop = false;
            this.pbNegative.Click += new System.EventHandler(this.pb_Click);
            // 
            // btnGetPictures
            // 
            this.btnGetPictures.Location = new System.Drawing.Point(505, 411);
            this.btnGetPictures.Name = "btnGetPictures";
            this.btnGetPictures.Size = new System.Drawing.Size(90, 67);
            this.btnGetPictures.TabIndex = 2;
            this.btnGetPictures.Text = "Get Pictures";
            this.btnGetPictures.UseVisualStyleBackColor = true;
            this.btnGetPictures.Click += new System.EventHandler(this.btnGetImages_Click);
            // 
            // pbRotatedLeft
            // 
            this.pbRotatedLeft.Location = new System.Drawing.Point(23, 450);
            this.pbRotatedLeft.Name = "pbRotatedLeft";
            this.pbRotatedLeft.Size = new System.Drawing.Size(450, 420);
            this.pbRotatedLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRotatedLeft.TabIndex = 3;
            this.pbRotatedLeft.TabStop = false;
            this.pbRotatedLeft.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbRotatedRight
            // 
            this.pbRotatedRight.Location = new System.Drawing.Point(618, 450);
            this.pbRotatedRight.Name = "pbRotatedRight";
            this.pbRotatedRight.Size = new System.Drawing.Size(450, 420);
            this.pbRotatedRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRotatedRight.TabIndex = 4;
            this.pbRotatedRight.TabStop = false;
            this.pbRotatedRight.Click += new System.EventHandler(this.pb_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(505, 313);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(90, 67);
            this.btnOpenImage.TabIndex = 5;
            this.btnOpenImage.Text = "Open image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 882);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.pbRotatedRight);
            this.Controls.Add(this.pbRotatedLeft);
            this.Controls.Add(this.btnGetPictures);
            this.Controls.Add(this.pbNegative);
            this.Controls.Add(this.pbOriginal);
            this.Name = "Form1";
            this.Text = "BitmapPool";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNegative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotatedLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotatedRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbNegative;
        private System.Windows.Forms.Button btnGetPictures;
        private System.Windows.Forms.PictureBox pbRotatedLeft;
        private System.Windows.Forms.PictureBox pbRotatedRight;
        private System.Windows.Forms.Button btnOpenImage;
    }
}

