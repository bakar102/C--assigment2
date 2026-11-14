namespace calories
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
            this.txtcolories = new System.Windows.Forms.TextBox();
            this.txtfat = new System.Windows.Forms.TextBox();
            this.checkBoxlowfat = new System.Windows.Forms.CheckBox();
            this.lblfatgram = new System.Windows.Forms.Label();
            this.lblprecentagegram = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter colories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "enter fat:";
            // 
            // txtcolories
            // 
            this.txtcolories.Location = new System.Drawing.Point(303, 67);
            this.txtcolories.Multiline = true;
            this.txtcolories.Name = "txtcolories";
            this.txtcolories.Size = new System.Drawing.Size(204, 26);
            this.txtcolories.TabIndex = 2;
            // 
            // txtfat
            // 
            this.txtfat.Location = new System.Drawing.Point(303, 119);
            this.txtfat.Multiline = true;
            this.txtfat.Name = "txtfat";
            this.txtfat.Size = new System.Drawing.Size(204, 26);
            this.txtfat.TabIndex = 3;
            // 
            // checkBoxlowfat
            // 
            this.checkBoxlowfat.AutoSize = true;
            this.checkBoxlowfat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxlowfat.Location = new System.Drawing.Point(199, 184);
            this.checkBoxlowfat.Name = "checkBoxlowfat";
            this.checkBoxlowfat.Size = new System.Drawing.Size(114, 29);
            this.checkBoxlowfat.TabIndex = 4;
            this.checkBoxlowfat.Text = "Low Fat";
            this.checkBoxlowfat.UseVisualStyleBackColor = true;
            // 
            // lblfatgram
            // 
            this.lblfatgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfatgram.Location = new System.Drawing.Point(411, 429);
            this.lblfatgram.Name = "lblfatgram";
            this.lblfatgram.Size = new System.Drawing.Size(253, 46);
            this.lblfatgram.TabIndex = 5;
            this.lblfatgram.Click += new System.EventHandler(this.lblfatgram_Click);
            // 
            // lblprecentagegram
            // 
            this.lblprecentagegram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblprecentagegram.Location = new System.Drawing.Point(411, 497);
            this.lblprecentagegram.Name = "lblprecentagegram";
            this.lblprecentagegram.Size = new System.Drawing.Size(253, 45);
            this.lblprecentagegram.TabIndex = 6;
            this.lblprecentagegram.Click += new System.EventHandler(this.lblprecentagegram_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(199, 252);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(114, 74);
            this.btncalculate.TabIndex = 7;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "numer of colories:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "precentages:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 566);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblprecentagegram);
            this.Controls.Add(this.lblfatgram);
            this.Controls.Add(this.checkBoxlowfat);
            this.Controls.Add(this.txtfat);
            this.Controls.Add(this.txtcolories);
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
        private System.Windows.Forms.TextBox txtcolories;
        private System.Windows.Forms.TextBox txtfat;
        private System.Windows.Forms.CheckBox checkBoxlowfat;
        private System.Windows.Forms.Label lblfatgram;
        private System.Windows.Forms.Label lblprecentagegram;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

