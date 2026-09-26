namespace assigment1
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
            this.txtdayoftheWeek = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.txtdayofthenumeric = new System.Windows.Forms.TextBox();
            this.LBL = new System.Windows.Forms.Label();
            this.LBLL = new System.Windows.Forms.Label();
            this.LBLLL = new System.Windows.Forms.Label();
            this.LBLLLL = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbldatoutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdayoftheWeek
            // 
            this.txtdayoftheWeek.Location = new System.Drawing.Point(395, 31);
            this.txtdayoftheWeek.Name = "txtdayoftheWeek";
            this.txtdayoftheWeek.Size = new System.Drawing.Size(253, 26);
            this.txtdayoftheWeek.TabIndex = 0;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(395, 167);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(253, 26);
            this.txtyear.TabIndex = 1;
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.Location = new System.Drawing.Point(395, 124);
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(253, 26);
            this.txtdayofthemonth.TabIndex = 2;
            // 
            // txtdayofthenumeric
            // 
            this.txtdayofthenumeric.Location = new System.Drawing.Point(395, 80);
            this.txtdayofthenumeric.Name = "txtdayofthenumeric";
            this.txtdayofthenumeric.Size = new System.Drawing.Size(253, 26);
            this.txtdayofthenumeric.TabIndex = 3;
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL.Location = new System.Drawing.Point(133, 34);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(240, 20);
            this.LBL.TabIndex = 4;
            this.LBL.Text = "ENTER DAY OF THE WEEK:";
            // 
            // LBLL
            // 
            this.LBLL.AutoSize = true;
            this.LBLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLL.Location = new System.Drawing.Point(37, 83);
            this.LBLL.Name = "LBLL";
            this.LBLL.Size = new System.Drawing.Size(336, 20);
            this.LBLL.TabIndex = 5;
            this.LBLL.Text = "ENTER THE NUMERIC OF THE MONTH:";
            // 
            // LBLLL
            // 
            this.LBLLL.AutoSize = true;
            this.LBLLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLL.Location = new System.Drawing.Point(178, 130);
            this.LBLLL.Name = "LBLLL";
            this.LBLLL.Size = new System.Drawing.Size(195, 20);
            this.LBLLL.TabIndex = 6;
            this.LBLLL.Text = "ENTER MONTH NAME:";
            // 
            // LBLLLL
            // 
            this.LBLLLL.AutoSize = true;
            this.LBLLLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLLL.Location = new System.Drawing.Point(246, 176);
            this.LBLLLL.Name = "LBLLLL";
            this.LBLLLL.Size = new System.Drawing.Size(127, 20);
            this.LBLLLL.TabIndex = 7;
            this.LBLLLL.Text = "ENTER YEAR:";
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(175, 343);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(104, 60);
            this.btnshow.TabIndex = 8;
            this.btnshow.Text = "SHOW";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(291, 343);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 60);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(422, 343);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(104, 60);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbldatoutput
            // 
            this.lbldatoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldatoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatoutput.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbldatoutput.Location = new System.Drawing.Point(175, 264);
            this.lbldatoutput.Name = "lbldatoutput";
            this.lbldatoutput.Size = new System.Drawing.Size(365, 40);
            this.lbldatoutput.TabIndex = 11;
            this.lbldatoutput.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldatoutput);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.LBLLLL);
            this.Controls.Add(this.LBLLL);
            this.Controls.Add(this.LBLL);
            this.Controls.Add(this.LBL);
            this.Controls.Add(this.txtdayofthenumeric);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayoftheWeek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdayoftheWeek;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.TextBox txtdayofthenumeric;
        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.Label LBLL;
        private System.Windows.Forms.Label LBLLL;
        private System.Windows.Forms.Label LBLLLL;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lbldatoutput;
    }
}

