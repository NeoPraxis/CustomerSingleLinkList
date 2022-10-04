namespace CustomerSingleLinkList {
    partial class FormCustomerSingleLinkList {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelCustomer = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.buttonAddBegin = new System.Windows.Forms.Button();
            this.buttonAddEnd = new System.Windows.Forms.Button();
            this.labelCustomerList = new System.Windows.Forms.Label();
            this.listBoxCustomerList = new System.Windows.Forms.ListBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.buttonAddPosition = new System.Windows.Forms.Button();
            this.buttonDeleteFirst = new System.Windows.Forms.Button();
            this.buttonDeleteLast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDeleteByName = new System.Windows.Forms.TextBox();
            this.buttonDeleteByName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(13, 22);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(54, 13);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Customer:";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(73, 19);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomer.TabIndex = 1;
            // 
            // buttonAddBegin
            // 
            this.buttonAddBegin.Location = new System.Drawing.Point(179, 17);
            this.buttonAddBegin.Name = "buttonAddBegin";
            this.buttonAddBegin.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBegin.TabIndex = 2;
            this.buttonAddBegin.Text = "Add Begin";
            this.buttonAddBegin.UseVisualStyleBackColor = true;
            this.buttonAddBegin.Click += new System.EventHandler(this.buttonAddBegin_Click);
            // 
            // buttonAddEnd
            // 
            this.buttonAddEnd.Location = new System.Drawing.Point(260, 17);
            this.buttonAddEnd.Name = "buttonAddEnd";
            this.buttonAddEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEnd.TabIndex = 3;
            this.buttonAddEnd.Text = "Add End";
            this.buttonAddEnd.UseVisualStyleBackColor = true;
            this.buttonAddEnd.Click += new System.EventHandler(this.buttonAddEnd_Click);
            // 
            // labelCustomerList
            // 
            this.labelCustomerList.AutoSize = true;
            this.labelCustomerList.Location = new System.Drawing.Point(13, 96);
            this.labelCustomerList.Name = "labelCustomerList";
            this.labelCustomerList.Size = new System.Drawing.Size(73, 13);
            this.labelCustomerList.TabIndex = 4;
            this.labelCustomerList.Text = "Customer List:";
            // 
            // listBoxCustomerList
            // 
            this.listBoxCustomerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCustomerList.FormattingEnabled = true;
            this.listBoxCustomerList.Location = new System.Drawing.Point(13, 112);
            this.listBoxCustomerList.Name = "listBoxCustomerList";
            this.listBoxCustomerList.Size = new System.Drawing.Size(775, 329);
            this.listBoxCustomerList.TabIndex = 5;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(379, 22);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(47, 13);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "Position:";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(432, 19);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosition.TabIndex = 7;
            // 
            // buttonAddPosition
            // 
            this.buttonAddPosition.Location = new System.Drawing.Point(538, 17);
            this.buttonAddPosition.Name = "buttonAddPosition";
            this.buttonAddPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPosition.TabIndex = 8;
            this.buttonAddPosition.Text = "Add Position";
            this.buttonAddPosition.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFirst
            // 
            this.buttonDeleteFirst.Location = new System.Drawing.Point(179, 45);
            this.buttonDeleteFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteFirst.Name = "buttonDeleteFirst";
            this.buttonDeleteFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteFirst.TabIndex = 9;
            this.buttonDeleteFirst.Text = "Delete First";
            this.buttonDeleteFirst.UseVisualStyleBackColor = true;
            this.buttonDeleteFirst.Click += new System.EventHandler(this.buttonDeleteFirst_Click);
            // 
            // buttonDeleteLast
            // 
            this.buttonDeleteLast.Location = new System.Drawing.Point(260, 45);
            this.buttonDeleteLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteLast.Name = "buttonDeleteLast";
            this.buttonDeleteLast.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteLast.TabIndex = 10;
            this.buttonDeleteLast.Text = "Delete Last";
            this.buttonDeleteLast.UseVisualStyleBackColor = true;
            this.buttonDeleteLast.Click += new System.EventHandler(this.buttonDeleteLast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Delete by Name:";
            // 
            // textBoxDeleteByName
            // 
            this.textBoxDeleteByName.Location = new System.Drawing.Point(432, 49);
            this.textBoxDeleteByName.Name = "textBoxDeleteByName";
            this.textBoxDeleteByName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeleteByName.TabIndex = 12;
            // 
            // buttonDeleteByName
            // 
            this.buttonDeleteByName.Location = new System.Drawing.Point(538, 46);
            this.buttonDeleteByName.Name = "buttonDeleteByName";
            this.buttonDeleteByName.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteByName.TabIndex = 13;
            this.buttonDeleteByName.Text = "Delete";
            this.buttonDeleteByName.UseVisualStyleBackColor = true;
            this.buttonDeleteByName.Click += new System.EventHandler(this.buttonDeleteByName_Click);
            // 
            // FormCustomerSingleLinkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteByName);
            this.Controls.Add(this.textBoxDeleteByName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteLast);
            this.Controls.Add(this.buttonDeleteFirst);
            this.Controls.Add(this.buttonAddPosition);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.listBoxCustomerList);
            this.Controls.Add(this.labelCustomerList);
            this.Controls.Add(this.buttonAddEnd);
            this.Controls.Add(this.buttonAddBegin);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.labelCustomer);
            this.Name = "FormCustomerSingleLinkList";
            this.Text = "Customer Single Link List Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Button buttonAddBegin;
        private System.Windows.Forms.Button buttonAddEnd;
        private System.Windows.Forms.Label labelCustomerList;
        private System.Windows.Forms.ListBox listBoxCustomerList;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Button buttonAddPosition;
        private System.Windows.Forms.Button buttonDeleteFirst;
        private System.Windows.Forms.Button buttonDeleteLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDeleteByName;
        private System.Windows.Forms.Button buttonDeleteByName;
    }
}

