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
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.lblusage = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtusage = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname1.Location = new System.Drawing.Point(133, 40);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(186, 20);
            this.lblname1.TabIndex = 0;
            this.lblname1.Text = "Enter customer name:";
            // 
            // lblprice1
            // 
            this.lblprice1.AutoSize = true;
            this.lblprice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice1.Location = new System.Drawing.Point(133, 78);
            this.lblprice1.Name = "lblprice1";
            this.lblprice1.Size = new System.Drawing.Size(195, 20);
            this.lblprice1.TabIndex = 1;
            this.lblprice1.Text = "Enter previous reading:";
            this.lblprice1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblname2
            // 
            this.lblname2.AutoSize = true;
            this.lblname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname2.Location = new System.Drawing.Point(133, 119);
            this.lblname2.Name = "lblname2";
            this.lblname2.Size = new System.Drawing.Size(185, 20);
            this.lblname2.TabIndex = 2;
            this.lblname2.Text = "Enter current reading:";
            // 
            // lblprice2
            // 
            this.lblprice2.AutoSize = true;
            this.lblprice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice2.Location = new System.Drawing.Point(133, 161);
            this.lblprice2.Name = "lblprice2";
            this.lblprice2.Size = new System.Drawing.Size(195, 20);
            this.lblprice2.TabIndex = 3;
            this.lblprice2.Text = "Enter price per unit ($):";
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(394, 34);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(260, 26);
            this.txtcustomer.TabIndex = 4;
            // 
            // txtprevious
            // 
            this.txtprevious.Location = new System.Drawing.Point(394, 72);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(260, 26);
            this.txtprevious.TabIndex = 5;
            // 
            // txtcurrent
            // 
            this.txtcurrent.Location = new System.Drawing.Point(394, 113);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(260, 26);
            this.txtcurrent.TabIndex = 6;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(394, 155);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(260, 26);
            this.txtunitprice.TabIndex = 7;
            // 
            // lblusage
            // 
            this.lblusage.AutoSize = true;
            this.lblusage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusage.Location = new System.Drawing.Point(49, 306);
            this.lblusage.Name = "lblusage";
            this.lblusage.Size = new System.Drawing.Size(195, 20);
            this.lblusage.TabIndex = 9;
            this.lblusage.Text = "electricity usage(units):";
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltax.Location = new System.Drawing.Point(49, 350);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(108, 20);
            this.lbltax.TabIndex = 10;
            this.lbltax.Text = "tax amount: ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(49, 393);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(291, 20);
            this.lbltotal.TabIndex = 11;
            this.lbltotal.Text = "Total bill (including $5 fixed charge:";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(265, 201);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(182, 54);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "calculate bill";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtusage
            // 
            this.txtusage.Location = new System.Drawing.Point(346, 309);
            this.txtusage.Name = "txtusage";
            this.txtusage.Size = new System.Drawing.Size(260, 26);
            this.txtusage.TabIndex = 13;
            this.txtusage.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txttax
            // 
            this.txttax.Location = new System.Drawing.Point(346, 350);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(260, 26);
            this.txttax.TabIndex = 14;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(346, 393);
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
            this.Controls.Add(this.txttax);
            this.Controls.Add(this.txtusage);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.lblusage);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtprevious);
            this.Controls.Add(this.txtcustomer);
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
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.Label lblusage;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtusage;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.TextBox txttotal;
    }
}

