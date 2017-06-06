namespace CustomerSystem
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
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.custNoTextBox = new System.Windows.Forms.TextBox();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.totalPurchasesTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(67, 295);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(84, 23);
            this.addCustomerButton.TabIndex = 0;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mailing List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Purchases";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(197, 78);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(165, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(197, 109);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(165, 20);
            this.addressTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(197, 135);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(165, 20);
            this.phoneTextBox.TabIndex = 10;
            // 
            // custNoTextBox
            // 
            this.custNoTextBox.Location = new System.Drawing.Point(197, 163);
            this.custNoTextBox.Name = "custNoTextBox";
            this.custNoTextBox.Size = new System.Drawing.Size(165, 20);
            this.custNoTextBox.TabIndex = 11;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(259, 193);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.yesRadioButton.TabIndex = 12;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // totalPurchasesTextBox
            // 
            this.totalPurchasesTextBox.Location = new System.Drawing.Point(197, 219);
            this.totalPurchasesTextBox.Name = "totalPurchasesTextBox";
            this.totalPurchasesTextBox.Size = new System.Drawing.Size(165, 20);
            this.totalPurchasesTextBox.TabIndex = 13;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(218, 295);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Add New Customer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 356);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalPurchasesTextBox);
            this.Controls.Add(this.yesRadioButton);
            this.Controls.Add(this.custNoTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCustomerButton);
            this.Name = "Form1";
            this.Text = "Add Preffered Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox custNoTextBox;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.TextBox totalPurchasesTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

