namespace WindowsFormsApplication38
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.captureImageBox = new Emgu.CV.UI.ImageBox();
            this.captureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captureImageBox
            // 
            this.captureImageBox.Location = new System.Drawing.Point(43, 28);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(300, 300);
            this.captureImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.captureImageBox.TabIndex = 2;
            this.captureImageBox.TabStop = false;
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(422, 113);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(148, 76);
            this.captureButton.TabIndex = 6;
            this.captureButton.Text = "button1";
            this.captureButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 324);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.captureImageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox captureImageBox;
        private System.Windows.Forms.Button captureButton;
    }
}

