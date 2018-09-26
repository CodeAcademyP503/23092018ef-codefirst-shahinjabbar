namespace Bankapp.Forms
{
    partial class TakeCreditForm
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
            this.btb_addcredit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_amount = new System.Windows.Forms.TextBox();
            this.Tarix = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btb_addcredit
            // 
            this.btb_addcredit.Location = new System.Drawing.Point(163, 337);
            this.btb_addcredit.Name = "btb_addcredit";
            this.btb_addcredit.Size = new System.Drawing.Size(109, 56);
            this.btb_addcredit.TabIndex = 12;
            this.btb_addcredit.Text = "Take Credit";
            this.btb_addcredit.UseVisualStyleBackColor = true;
            this.btb_addcredit.Click += new System.EventHandler(this.btb_addcredit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mebleg";
            // 
            // txbx_amount
            // 
            this.txbx_amount.Location = new System.Drawing.Point(163, 274);
            this.txbx_amount.Name = "txbx_amount";
            this.txbx_amount.Size = new System.Drawing.Size(147, 22);
            this.txbx_amount.TabIndex = 10;
            // 
            // Tarix
            // 
            this.Tarix.AutoSize = true;
            this.Tarix.Location = new System.Drawing.Point(160, 161);
            this.Tarix.Name = "Tarix";
            this.Tarix.Size = new System.Drawing.Size(93, 17);
            this.Tarix.TabIndex = 9;
            this.Tarix.Text = "Verilme Tarixi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // TakeCreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btb_addcredit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_amount);
            this.Controls.Add(this.Tarix);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Name = "TakeCreditForm";
            this.Text = "TakeCreditForm";
            this.Load += new System.EventHandler(this.TakeCreditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btb_addcredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_amount;
        private System.Windows.Forms.Label Tarix;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}