namespace testoperator
{
    partial class frmassignmentoperator
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
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndisplay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // txta
            // 
            this.txta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta.Location = new System.Drawing.Point(95, 75);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(167, 26);
            this.txta.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb.Location = new System.Drawing.Point(95, 116);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(167, 26);
            this.txtb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(95, 194);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(167, 26);
            this.txtresult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // btndisplay
            // 
            this.btndisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Location = new System.Drawing.Point(97, 152);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(75, 33);
            this.btndisplay.TabIndex = 6;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 48);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Assignment Operators";
            // 
            // frmassignmentoperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 273);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label1);
            this.Name = "frmassignmentoperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmassignmentoperator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}