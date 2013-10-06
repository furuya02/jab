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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSelectedItem = new System.Windows.Forms.Button();
            this.buttonGetList = new System.Windows.Forms.Button();
            this.textBoxGetList = new System.Windows.Forms.TextBox();
            this.buttonGetItems = new System.Windows.Forms.Button();
            this.textBoxHandle = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearchWindow = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerMousePos = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_y);
            this.panel1.Controls.Add(this.textBox_x);
            this.panel1.Controls.Add(this.textBoxY);
            this.panel1.Controls.Add(this.textBoxX);
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
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(289, 14);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(71, 19);
            this.textBoxX.TabIndex = 13;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(401, 14);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(71, 19);
            this.textBoxY.TabIndex = 14;
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(289, 41);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(71, 19);
            this.textBox_x.TabIndex = 15;
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(401, 41);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(71, 19);
            this.textBox_y.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "y";
            // 
            // timerMousePos
            // 
            this.timerMousePos.Enabled = true;
            this.timerMousePos.Tick += new System.EventHandler(this.timerMousePos_Tick);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Timer timerMousePos;
    }
}

