namespace JavaAccessBridge {
    partial class mainForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSelectedItem = new System.Windows.Forms.Button();
            this.buttonGetList = new System.Windows.Forms.Button();
            this.textBoxGetList = new System.Windows.Forms.TextBox();
            this.buttonGetItems = new System.Windows.Forms.Button();
            this.textBoxHandle = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearchWindow = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSelectedItem);
            this.panel1.Controls.Add(this.buttonGetList);
            this.panel1.Controls.Add(this.textBoxGetList);
            this.panel1.Controls.Add(this.buttonGetItems);
            this.panel1.Controls.Add(this.textBoxHandle);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonSearchWindow);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 167);
            this.panel1.TabIndex = 5;
            // 
            // buttonSelectedItem
            // 
            this.buttonSelectedItem.Location = new System.Drawing.Point(12, 99);
            this.buttonSelectedItem.Name = "buttonSelectedItem";
            this.buttonSelectedItem.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectedItem.TabIndex = 12;
            this.buttonSelectedItem.Text = "SelectedItem";
            this.buttonSelectedItem.UseVisualStyleBackColor = true;
            this.buttonSelectedItem.Click += new System.EventHandler(this.buttonSelectedItem_Click);
            // 
            // buttonGetList
            // 
            this.buttonGetList.Location = new System.Drawing.Point(12, 70);
            this.buttonGetList.Name = "buttonGetList";
            this.buttonGetList.Size = new System.Drawing.Size(75, 23);
            this.buttonGetList.TabIndex = 11;
            this.buttonGetList.Text = "GetList";
            this.buttonGetList.UseVisualStyleBackColor = true;
            this.buttonGetList.Click += new System.EventHandler(this.buttonGetList_Click);
            // 
            // textBoxGetList
            // 
            this.textBoxGetList.Location = new System.Drawing.Point(90, 70);
            this.textBoxGetList.Name = "textBoxGetList";
            this.textBoxGetList.Size = new System.Drawing.Size(147, 19);
            this.textBoxGetList.TabIndex = 10;
            // 
            // buttonGetItems
            // 
            this.buttonGetItems.Location = new System.Drawing.Point(12, 41);
            this.buttonGetItems.Name = "buttonGetItems";
            this.buttonGetItems.Size = new System.Drawing.Size(75, 23);
            this.buttonGetItems.TabIndex = 9;
            this.buttonGetItems.Text = "GetItems";
            this.buttonGetItems.UseVisualStyleBackColor = true;
            this.buttonGetItems.Click += new System.EventHandler(this.buttonGetItems_Click);
            // 
            // textBoxHandle
            // 
            this.textBoxHandle.Location = new System.Drawing.Point(93, 14);
            this.textBoxHandle.Name = "textBoxHandle";
            this.textBoxHandle.Size = new System.Drawing.Size(71, 19);
            this.textBoxHandle.TabIndex = 8;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 138);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearchWindow
            // 
            this.buttonSearchWindow.Location = new System.Drawing.Point(12, 12);
            this.buttonSearchWindow.Name = "buttonSearchWindow";
            this.buttonSearchWindow.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchWindow.TabIndex = 5;
            this.buttonSearchWindow.Text = "SearchWindow";
            this.buttonSearchWindow.UseVisualStyleBackColor = true;
            this.buttonSearchWindow.Click += new System.EventHandler(this.buttonSearchWindow_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(0, 167);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(599, 284);
            this.textBoxLog.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 451);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "JavaAccessBridge";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public mainForm() {
            InitializeComponent();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxHandle;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearchWindow;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonGetItems;
        private System.Windows.Forms.Button buttonGetList;
        private System.Windows.Forms.TextBox textBoxGetList;
        private System.Windows.Forms.Button buttonSelectedItem;
    }
}

