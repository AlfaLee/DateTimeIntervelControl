namespace DateTimeIntervelControl
{
    partial class DateTimeIntervelPicker
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxDisplay = new System.Windows.Forms.TextBox();
            this.btnPopup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxDisplay
            // 
            this.txtBoxDisplay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxDisplay.Location = new System.Drawing.Point(3, 3);
            this.txtBoxDisplay.Name = "txtBoxDisplay";
            this.txtBoxDisplay.Size = new System.Drawing.Size(206, 26);
            this.txtBoxDisplay.TabIndex = 2;
            // 
            // btnPopup
            // 
            this.btnPopup.Location = new System.Drawing.Point(187, 5);
            this.btnPopup.Name = "btnPopup";
            this.btnPopup.Size = new System.Drawing.Size(22, 22);
            this.btnPopup.TabIndex = 3;
            this.btnPopup.UseVisualStyleBackColor = true;
            this.btnPopup.Click += new System.EventHandler(this.btnPopup_Click);
            // 
            // DateTimeIntervelPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPopup);
            this.Controls.Add(this.txtBoxDisplay);
            this.Name = "DateTimeIntervelPicker";
            this.Size = new System.Drawing.Size(212, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDisplay;
        private System.Windows.Forms.Button btnPopup;

    }
}
