namespace Assessment_2
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblAddingNewCustomer = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAmountOwed = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAmountOwed = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.lblFindCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtFindingName = new System.Windows.Forms.TextBox();
            this.btnFindingName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.treeView1.Location = new System.Drawing.Point(444, 41);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(327, 539);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lblAddingNewCustomer
            // 
            this.lblAddingNewCustomer.AutoSize = true;
            this.lblAddingNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingNewCustomer.Location = new System.Drawing.Point(124, 41);
            this.lblAddingNewCustomer.Name = "lblAddingNewCustomer";
            this.lblAddingNewCustomer.Size = new System.Drawing.Size(167, 16);
            this.lblAddingNewCustomer.TabIndex = 1;
            this.lblAddingNewCustomer.Text = "ADD NEW CUSTOMER";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(51, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(51, 128);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 15);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(51, 167);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 15);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblAmountOwed
            // 
            this.lblAmountOwed.AutoSize = true;
            this.lblAmountOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOwed.Location = new System.Drawing.Point(51, 207);
            this.lblAmountOwed.Name = "lblAmountOwed";
            this.lblAmountOwed.Size = new System.Drawing.Size(95, 15);
            this.lblAmountOwed.TabIndex = 5;
            this.lblAmountOwed.Text = "Amount Owed";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(166, 123);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(166, 162);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtAmountOwed
            // 
            this.txtAmountOwed.Location = new System.Drawing.Point(166, 206);
            this.txtAmountOwed.Name = "txtAmountOwed";
            this.txtAmountOwed.Size = new System.Drawing.Size(100, 20);
            this.txtAmountOwed.TabIndex = 9;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(166, 261);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumber.Location = new System.Drawing.Point(81, 543);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(254, 16);
            this.lblTotalNumber.TabIndex = 12;
            this.lblTotalNumber.Text = "TOTAL NUMBER OF CUSTOMER: 0";
            this.lblTotalNumber.UseMnemonic = false;
            this.lblTotalNumber.Click += new System.EventHandler(this.lblTotalNumber_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreOrder.Location = new System.Drawing.Point(54, 302);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(84, 23);
            this.btnPreOrder.TabIndex = 13;
            this.btnPreOrder.Text = "PreOrder";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnInOrder
            // 
            this.btnInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInOrder.Location = new System.Drawing.Point(166, 302);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(83, 23);
            this.btnInOrder.TabIndex = 14;
            this.btnInOrder.Text = "InOrder";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostOrder.Location = new System.Drawing.Point(276, 302);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(81, 23);
            this.btnPostOrder.TabIndex = 15;
            this.btnPostOrder.Text = "PostOrder";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // lblFindCustomer
            // 
            this.lblFindCustomer.AutoSize = true;
            this.lblFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindCustomer.Location = new System.Drawing.Point(105, 370);
            this.lblFindCustomer.Name = "lblFindCustomer";
            this.lblFindCustomer.Size = new System.Drawing.Size(221, 16);
            this.lblFindCustomer.TabIndex = 16;
            this.lblFindCustomer.Text = "FIND CUSTOMER WITH NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--";
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(132, 410);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(169, 16);
            this.lblEnterName.TabIndex = 19;
            this.lblEnterName.Text = "Enter Customer\'s Name";
            // 
            // txtFindingName
            // 
            this.txtFindingName.Location = new System.Drawing.Point(163, 447);
            this.txtFindingName.Name = "txtFindingName";
            this.txtFindingName.Size = new System.Drawing.Size(100, 20);
            this.txtFindingName.TabIndex = 20;
            // 
            // btnFindingName
            // 
            this.btnFindingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindingName.Location = new System.Drawing.Point(174, 490);
            this.btnFindingName.Name = "btnFindingName";
            this.btnFindingName.Size = new System.Drawing.Size(75, 23);
            this.btnFindingName.TabIndex = 21;
            this.btnFindingName.Text = "Find";
            this.btnFindingName.UseVisualStyleBackColor = true;
            this.btnFindingName.Click += new System.EventHandler(this.btnFindingName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.btnFindingName);
            this.Controls.Add(this.txtFindingName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFindCustomer);
            this.Controls.Add(this.btnPostOrder);
            this.Controls.Add(this.btnInOrder);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.lblTotalNumber);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtAmountOwed);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAmountOwed);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddingNewCustomer);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblAddingNewCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAmountOwed;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAmountOwed;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.Label lblFindCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtFindingName;
        private System.Windows.Forms.Button btnFindingName;
    }
}

