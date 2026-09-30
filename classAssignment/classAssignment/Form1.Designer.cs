namespace classAssignment
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
            this.lblname1 = new System.Windows.Forms.Label();
            this.lblprice1 = new System.Windows.Forms.Label();
            this.lblname2 = new System.Windows.Forms.Label();
            this.lblprice2 = new System.Windows.Forms.Label();
            this.txtname1 = new System.Windows.Forms.TextBox();
            this.txtprice1 = new System.Windows.Forms.TextBox();
            this.txtname2 = new System.Windows.Forms.TextBox();
            this.txtprice2 = new System.Windows.Forms.TextBox();
            this.lblsaletax = new System.Windows.Forms.Label();
            this.lbltips = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtsales = new System.Windows.Forms.TextBox();
            this.txttips = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname1.Location = new System.Drawing.Point(133, 40);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(163, 20);
            this.lblname1.TabIndex = 0;
            this.lblname1.Text = "Enter name food 1:";
            // 
            // lblprice1
            // 
            this.lblprice1.AutoSize = true;
            this.lblprice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice1.Location = new System.Drawing.Point(133, 78);
            this.lblprice1.Name = "lblprice1";
            this.lblprice1.Size = new System.Drawing.Size(158, 20);
            this.lblprice1.TabIndex = 1;
            this.lblprice1.Text = "Enter price food 1:";
            this.lblprice1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblname2
            // 
            this.lblname2.AutoSize = true;
            this.lblname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname2.Location = new System.Drawing.Point(133, 119);
            this.lblname2.Name = "lblname2";
            this.lblname2.Size = new System.Drawing.Size(163, 20);
            this.lblname2.TabIndex = 2;
            this.lblname2.Text = "Enter name food 2:";
            // 
            // lblprice2
            // 
            this.lblprice2.AutoSize = true;
            this.lblprice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice2.Location = new System.Drawing.Point(133, 161);
            this.lblprice2.Name = "lblprice2";
            this.lblprice2.Size = new System.Drawing.Size(158, 20);
            this.lblprice2.TabIndex = 3;
            this.lblprice2.Text = "Enter price food 2:";
            // 
            // txtname1
            // 
            this.txtname1.Location = new System.Drawing.Point(394, 34);
            this.txtname1.Name = "txtname1";
            this.txtname1.Size = new System.Drawing.Size(260, 26);
            this.txtname1.TabIndex = 4;
            // 
            // txtprice1
            // 
            this.txtprice1.Location = new System.Drawing.Point(394, 72);
            this.txtprice1.Name = "txtprice1";
            this.txtprice1.Size = new System.Drawing.Size(260, 26);
            this.txtprice1.TabIndex = 5;
            // 
            // txtname2
            // 
            this.txtname2.Location = new System.Drawing.Point(394, 113);
            this.txtname2.Name = "txtname2";
            this.txtname2.Size = new System.Drawing.Size(260, 26);
            this.txtname2.TabIndex = 6;
            // 
            // txtprice2
            // 
            this.txtprice2.Location = new System.Drawing.Point(394, 155);
            this.txtprice2.Name = "txtprice2";
            this.txtprice2.Size = new System.Drawing.Size(260, 26);
            this.txtprice2.TabIndex = 7;
            // 
            // lblsaletax
            // 
            this.lblsaletax.AutoSize = true;
            this.lblsaletax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaletax.Location = new System.Drawing.Point(133, 309);
            this.lblsaletax.Name = "lblsaletax";
            this.lblsaletax.Size = new System.Drawing.Size(106, 20);
            this.lblsaletax.TabIndex = 9;
            this.lblsaletax.Text = "Sales tax is:";
            // 
            // lbltips
            // 
            this.lbltips.AutoSize = true;
            this.lbltips.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltips.Location = new System.Drawing.Point(133, 353);
            this.lbltips.Name = "lbltips";
            this.lbltips.Size = new System.Drawing.Size(117, 20);
            this.lbltips.TabIndex = 10;
            this.lbltips.Text = "Tips amount: ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(133, 396);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(119, 20);
            this.lbltotal.TabIndex = 11;
            this.lbltotal.Text = "Total amount:";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(265, 201);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(182, 54);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "calculate the price";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtsales
            // 
            this.txtsales.Location = new System.Drawing.Point(277, 306);
            this.txtsales.Name = "txtsales";
            this.txtsales.Size = new System.Drawing.Size(260, 26);
            this.txtsales.TabIndex = 13;
            this.txtsales.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txttips
            // 
            this.txttips.Location = new System.Drawing.Point(277, 347);
            this.txttips.Name = "txttips";
            this.txttips.Size = new System.Drawing.Size(260, 26);
            this.txttips.TabIndex = 14;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(277, 390);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(260, 26);
            this.txttotal.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txttips);
            this.Controls.Add(this.txtsales);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbltips);
            this.Controls.Add(this.lblsaletax);
            this.Controls.Add(this.txtprice2);
            this.Controls.Add(this.txtname2);
            this.Controls.Add(this.txtprice1);
            this.Controls.Add(this.txtname1);
            this.Controls.Add(this.lblprice2);
            this.Controls.Add(this.lblname2);
            this.Controls.Add(this.lblprice1);
            this.Controls.Add(this.lblname1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname1;
        private System.Windows.Forms.Label lblprice1;
        private System.Windows.Forms.Label lblname2;
        private System.Windows.Forms.Label lblprice2;
        private System.Windows.Forms.TextBox txtname1;
        private System.Windows.Forms.TextBox txtprice1;
        private System.Windows.Forms.TextBox txtname2;
        private System.Windows.Forms.TextBox txtprice2;
        private System.Windows.Forms.Label lblsaletax;
        private System.Windows.Forms.Label lbltips;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtsales;
        private System.Windows.Forms.TextBox txttips;
        private System.Windows.Forms.TextBox txttotal;
    }
}

