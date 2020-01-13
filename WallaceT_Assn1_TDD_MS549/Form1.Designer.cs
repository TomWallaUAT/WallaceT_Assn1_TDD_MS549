namespace WallaceT_Assn1_TDD_MS549
{
    partial class frmPushPop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPop = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbItemList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPeak = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.tbHistory = new System.Windows.Forms.TextBox();
            this.gbInfo.SuspendLayout();
            this.gbHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(160, 206);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(44, 30);
            this.btnPop.TabIndex = 0;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.Location = new System.Drawing.Point(76, 12);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(63, 21);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNumber_KeyUp);
            // 
            // tbItemList
            // 
            this.tbItemList.AcceptsReturn = true;
            this.tbItemList.AcceptsTab = true;
            this.tbItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbItemList.Location = new System.Drawing.Point(12, 38);
            this.tbItemList.Multiline = true;
            this.tbItemList.Name = "tbItemList";
            this.tbItemList.ReadOnly = true;
            this.tbItemList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbItemList.Size = new System.Drawing.Size(192, 153);
            this.tbItemList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number";
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(145, 12);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(59, 21);
            this.btnPush.TabIndex = 4;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPeak
            // 
            this.btnPeak.Location = new System.Drawing.Point(111, 206);
            this.btnPeak.Name = "btnPeak";
            this.btnPeak.Size = new System.Drawing.Size(43, 30);
            this.btnPeak.TabIndex = 5;
            this.btnPeak.Text = "Peak";
            this.btnPeak.UseVisualStyleBackColor = true;
            this.btnPeak.Click += new System.EventHandler(this.btnPeak_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblItemCount);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(12, 197);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(93, 44);
            this.gbInfo.TabIndex = 6;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Item Count";
            // 
            // lblItemCount
            // 
            this.lblItemCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblItemCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblItemCount.Location = new System.Drawing.Point(6, 16);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(81, 23);
            this.lblItemCount.TabIndex = 7;
            this.lblItemCount.Text = "0";
            this.lblItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbHistory
            // 
            this.gbHistory.Controls.Add(this.tbHistory);
            this.gbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHistory.Location = new System.Drawing.Point(218, 12);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(264, 229);
            this.gbHistory.TabIndex = 7;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "Action History";
            // 
            // tbHistory
            // 
            this.tbHistory.AcceptsReturn = true;
            this.tbHistory.AcceptsTab = true;
            this.tbHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHistory.ForeColor = System.Drawing.Color.Yellow;
            this.tbHistory.Location = new System.Drawing.Point(6, 18);
            this.tbHistory.Multiline = true;
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.ReadOnly = true;
            this.tbHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHistory.Size = new System.Drawing.Size(252, 205);
            this.tbHistory.TabIndex = 3;
            // 
            // frmPushPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 246);
            this.Controls.Add(this.gbHistory);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnPeak);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbItemList);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.btnPop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPushPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PushPop Demo";
            this.Load += new System.EventHandler(this.frmPushPop_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbItemList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPeak;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.GroupBox gbHistory;
        private System.Windows.Forms.TextBox tbHistory;
    }
}

