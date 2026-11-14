namespace payroll_Time
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblgross = new System.Windows.Forms.Label();
            this.lblgrosspay = new System.Windows.Forms.Label();
            this.txthours = new System.Windows.Forms.TextBox();
            this.txtpayrate = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter hours work:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "enter pay rate:";
            // 
            // lblgross
            // 
            this.lblgross.AutoSize = true;
            this.lblgross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgross.Location = new System.Drawing.Point(144, 135);
            this.lblgross.Name = "lblgross";
            this.lblgross.Size = new System.Drawing.Size(140, 29);
            this.lblgross.TabIndex = 2;
            this.lblgross.Text = "gross pay: ";
            // 
            // lblgrosspay
            // 
            this.lblgrosspay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgrosspay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosspay.Location = new System.Drawing.Point(297, 135);
            this.lblgrosspay.Name = "lblgrosspay";
            this.lblgrosspay.Size = new System.Drawing.Size(301, 50);
            this.lblgrosspay.TabIndex = 3;
            // 
            // txthours
            // 
            this.txthours.Location = new System.Drawing.Point(346, 62);
            this.txthours.Name = "txthours";
            this.txthours.Size = new System.Drawing.Size(240, 26);
            this.txthours.TabIndex = 4;
            this.txthours.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpayrate
            // 
            this.txtpayrate.Location = new System.Drawing.Point(346, 98);
            this.txtpayrate.Name = "txtpayrate";
            this.txtpayrate.Size = new System.Drawing.Size(240, 26);
            this.txtpayrate.TabIndex = 5;
            this.txtpayrate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(188, 269);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(130, 69);
            this.btn.TabIndex = 6;
            this.btn.Text = "calculate &gross pay";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 69);
            this.button2.TabIndex = 7;
            this.button2.Text = "&clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtpayrate);
            this.Controls.Add(this.txthours);
            this.Controls.Add(this.lblgrosspay);
            this.Controls.Add(this.lblgross);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgross;
        private System.Windows.Forms.Label lblgrosspay;
        private System.Windows.Forms.TextBox txthours;
        private System.Windows.Forms.TextBox txtpayrate;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button2;
    }
}

