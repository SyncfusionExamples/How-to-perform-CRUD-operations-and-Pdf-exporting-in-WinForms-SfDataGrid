namespace SfDataGridDemo
{
    partial class InlineForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.shipCountryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(368, 253);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(101, 41);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(503, 253);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 41);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(36, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unit Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(313, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Customer ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(327, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(313, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 37);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ship Country";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Location = new System.Drawing.Point(154, 68);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(144, 28);
            this.orderIdTextBox.TabIndex = 9;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(154, 122);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(144, 28);
            this.productNameTextBox.TabIndex = 10;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(154, 174);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(144, 28);
            this.unitPriceTextBox.TabIndex = 11;
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(447, 74);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(153, 28);
            this.customerIdTextBox.TabIndex = 12;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(447, 122);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(153, 28);
            this.quantityTextBox.TabIndex = 13;
            // 
            // shipCountryTextBox
            // 
            this.shipCountryTextBox.Location = new System.Drawing.Point(447, 174);
            this.shipCountryTextBox.Name = "shipCountryTextBox";
            this.shipCountryTextBox.Size = new System.Drawing.Size(153, 28);
            this.shipCountryTextBox.TabIndex = 14;
            // 
            // InlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 316);
            this.Controls.Add(this.shipCountryTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InlineForm";
            this.Text = "InlineForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox shipCountryTextBox;
    }
}