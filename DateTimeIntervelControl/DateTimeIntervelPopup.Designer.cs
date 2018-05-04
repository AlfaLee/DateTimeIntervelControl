namespace DateTimeIntervelControl
{
    partial class DateTimeIntervelPopup
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
            this.calendarStart = new System.Windows.Forms.MonthCalendar();
            this.calendarEnd = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSure = new System.Windows.Forms.Button();
            this.timeEnd = new DateTimeIntervelControl.TimeSetting();
            this.timeStart = new DateTimeIntervelControl.TimeSetting();
            this.SuspendLayout();
            // 
            // calendarStart
            // 
            this.calendarStart.Location = new System.Drawing.Point(9, 32);
            this.calendarStart.Name = "calendarStart";
            this.calendarStart.TabIndex = 0;
            // 
            // calendarEnd
            // 
            this.calendarEnd.BackColor = System.Drawing.SystemColors.Window;
            this.calendarEnd.Location = new System.Drawing.Point(236, 32);
            this.calendarEnd.Name = "calendarEnd";
            this.calendarEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(102, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "开始";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "结束";
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(381, 261);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 5;
            this.btnSure.Text = "确定";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // timeEnd
            // 
            this.timeEnd.BackColor = System.Drawing.SystemColors.Window;
            this.timeEnd.Location = new System.Drawing.Point(256, 221);
            this.timeEnd.Margin = new System.Windows.Forms.Padding(0);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(189, 21);
            this.timeEnd.TabIndex = 9;
            // 
            // timeStart
            // 
            this.timeStart.BackColor = System.Drawing.SystemColors.Window;
            this.timeStart.Location = new System.Drawing.Point(31, 221);
            this.timeStart.Margin = new System.Windows.Forms.Padding(0);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(189, 21);
            this.timeStart.TabIndex = 8;
            // 
            // DateTimeIntervelPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendarEnd);
            this.Controls.Add(this.calendarStart);
            this.Name = "DateTimeIntervelPopup";
            this.Size = new System.Drawing.Size(465, 296);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarStart;
        private System.Windows.Forms.MonthCalendar calendarEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSure;
        private TimeSetting timeStart;
        private TimeSetting timeEnd;
    }
}
