namespace Food_Assement
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
            this.lblnamefood1 = new System.Windows.Forms.Label();
            this.pricefood1 = new System.Windows.Forms.Label();
            this.lblnamefood2 = new System.Windows.Forms.Label();
            this.lblpricefood2 = new System.Windows.Forms.Label();
            this.txtnamefood1 = new System.Windows.Forms.TextBox();
            this.txtenamefood2 = new System.Windows.Forms.TextBox();
            this.txtpricefood1 = new System.Windows.Forms.TextBox();
            this.txtpricefood2 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.outputlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnamefood1
            // 
            this.lblnamefood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamefood1.Location = new System.Drawing.Point(61, 12);
            this.lblnamefood1.Name = "lblnamefood1";
            this.lblnamefood1.Size = new System.Drawing.Size(246, 31);
            this.lblnamefood1.TabIndex = 0;
            this.lblnamefood1.Text = "Enter  Name Food 1 :";
            // 
            // pricefood1
            // 
            this.pricefood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricefood1.Location = new System.Drawing.Point(61, 79);
            this.pricefood1.Name = "pricefood1";
            this.pricefood1.Size = new System.Drawing.Size(237, 31);
            this.pricefood1.TabIndex = 1;
            this.pricefood1.Text = "Enter Price Food 1:";
            this.pricefood1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblnamefood2
            // 
            this.lblnamefood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamefood2.Location = new System.Drawing.Point(52, 131);
            this.lblnamefood2.Name = "lblnamefood2";
            this.lblnamefood2.Size = new System.Drawing.Size(220, 39);
            this.lblnamefood2.TabIndex = 2;
            this.lblnamefood2.Text = "Enter Name Food 2:";
            // 
            // lblpricefood2
            // 
            this.lblpricefood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpricefood2.Location = new System.Drawing.Point(52, 192);
            this.lblpricefood2.Name = "lblpricefood2";
            this.lblpricefood2.Size = new System.Drawing.Size(231, 39);
            this.lblpricefood2.TabIndex = 3;
            this.lblpricefood2.Text = "Enter Price  Food 2:";
            // 
            // txtnamefood1
            // 
            this.txtnamefood1.Location = new System.Drawing.Point(395, 12);
            this.txtnamefood1.Multiline = true;
            this.txtnamefood1.Name = "txtnamefood1";
            this.txtnamefood1.Size = new System.Drawing.Size(180, 31);
            this.txtnamefood1.TabIndex = 4;
            this.txtnamefood1.TextChanged += new System.EventHandler(this.txtnamefood1_TextChanged);
            // 
            // txtenamefood2
            // 
            this.txtenamefood2.Location = new System.Drawing.Point(395, 121);
            this.txtenamefood2.Multiline = true;
            this.txtenamefood2.Name = "txtenamefood2";
            this.txtenamefood2.Size = new System.Drawing.Size(176, 39);
            this.txtenamefood2.TabIndex = 5;
            // 
            // txtpricefood1
            // 
            this.txtpricefood1.Location = new System.Drawing.Point(395, 61);
            this.txtpricefood1.Multiline = true;
            this.txtpricefood1.Name = "txtpricefood1";
            this.txtpricefood1.Size = new System.Drawing.Size(176, 35);
            this.txtpricefood1.TabIndex = 6;
            // 
            // txtpricefood2
            // 
            this.txtpricefood2.Location = new System.Drawing.Point(382, 181);
            this.txtpricefood2.Multiline = true;
            this.txtpricefood2.Name = "txtpricefood2";
            this.txtpricefood2.Size = new System.Drawing.Size(193, 35);
            this.txtpricefood2.TabIndex = 7;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(317, 355);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(202, 58);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "Calculate The Price";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // outputlbl
            // 
            this.outputlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputlbl.Location = new System.Drawing.Point(222, 249);
            this.outputlbl.Name = "outputlbl";
            this.outputlbl.Size = new System.Drawing.Size(431, 57);
            this.outputlbl.TabIndex = 9;
            this.outputlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 524);
            this.Controls.Add(this.outputlbl);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtpricefood2);
            this.Controls.Add(this.txtpricefood1);
            this.Controls.Add(this.txtenamefood2);
            this.Controls.Add(this.txtnamefood1);
            this.Controls.Add(this.lblpricefood2);
            this.Controls.Add(this.lblnamefood2);
            this.Controls.Add(this.pricefood1);
            this.Controls.Add(this.lblnamefood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnamefood1;
        private System.Windows.Forms.Label pricefood1;
        private System.Windows.Forms.Label lblnamefood2;
        private System.Windows.Forms.Label lblpricefood2;
        private System.Windows.Forms.TextBox txtnamefood1;
        private System.Windows.Forms.TextBox txtenamefood2;
        private System.Windows.Forms.TextBox txtpricefood1;
        private System.Windows.Forms.TextBox txtpricefood2;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label outputlbl;
    }
}

