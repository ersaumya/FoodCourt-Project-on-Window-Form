namespace foodcourt
{
    partial class updatestock
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtstockid = new System.Windows.Forms.TextBox();
            this.btnupdstock = new System.Windows.Forms.Button();
            this.cbitemtype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbitemname = new System.Windows.Forms.ComboBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Update";
            // 
            // txtstockid
            // 
            this.txtstockid.Location = new System.Drawing.Point(195, 68);
            this.txtstockid.Name = "txtstockid";
            this.txtstockid.Size = new System.Drawing.Size(121, 20);
            this.txtstockid.TabIndex = 1;
            // 
            // btnupdstock
            // 
            this.btnupdstock.Location = new System.Drawing.Point(209, 306);
            this.btnupdstock.Name = "btnupdstock";
            this.btnupdstock.Size = new System.Drawing.Size(82, 23);
            this.btnupdstock.TabIndex = 2;
            this.btnupdstock.Text = "Update Stock";
            this.btnupdstock.UseVisualStyleBackColor = true;
            this.btnupdstock.Click += new System.EventHandler(this.btnupdstock_Click);
            // 
            // cbitemtype
            // 
            this.cbitemtype.FormattingEnabled = true;
            this.cbitemtype.Location = new System.Drawing.Point(195, 114);
            this.cbitemtype.Name = "cbitemtype";
            this.cbitemtype.Size = new System.Drawing.Size(121, 21);
            this.cbitemtype.TabIndex = 3;
            this.cbitemtype.SelectedIndexChanged += new System.EventHandler(this.cbitemtype_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(88, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "StockID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(88, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(77, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(88, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "QTY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(88, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Amount";
            // 
            // cbitemname
            // 
            this.cbitemname.FormattingEnabled = true;
            this.cbitemname.Location = new System.Drawing.Point(195, 163);
            this.cbitemname.Name = "cbitemname";
            this.cbitemname.Size = new System.Drawing.Size(121, 21);
            this.cbitemname.TabIndex = 9;
            this.cbitemname.SelectedIndexChanged += new System.EventHandler(this.cbitemname_SelectedIndexChanged);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(195, 215);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(121, 20);
            this.txtqty.TabIndex = 10;
            this.txtqty.Leave += new System.EventHandler(this.txtqty_Leave);
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(195, 258);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(121, 20);
            this.txtamount.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Copyright © 2017   Designed By :Soumya";
            // 
            // updatestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(426, 386);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.cbitemname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbitemtype);
            this.Controls.Add(this.btnupdstock);
            this.Controls.Add(this.txtstockid);
            this.Controls.Add(this.label1);
            this.Name = "updatestock";
            this.Text = "updatestock";
            this.Load += new System.EventHandler(this.updatestock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstockid;
        private System.Windows.Forms.Button btnupdstock;
        private System.Windows.Forms.ComboBox cbitemtype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbitemname;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label8;
    }
}