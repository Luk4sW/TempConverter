namespace TempConverter
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
            this.Temperature_1 = new System.Windows.Forms.TextBox();
            this.Temperature_2 = new System.Windows.Forms.TextBox();
            this.C_to_F = new System.Windows.Forms.Button();
            this.F_to_C = new System.Windows.Forms.Button();
            this.K_to_C = new System.Windows.Forms.Button();
            this.C_to_K = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Temperature_1
            // 
            this.Temperature_1.Location = new System.Drawing.Point(23, 24);
            this.Temperature_1.Name = "Temperature_1";
            this.Temperature_1.Size = new System.Drawing.Size(142, 22);
            this.Temperature_1.TabIndex = 0;
            // 
            // Temperature_2
            // 
            this.Temperature_2.Location = new System.Drawing.Point(287, 23);
            this.Temperature_2.Name = "Temperature_2";
            this.Temperature_2.Size = new System.Drawing.Size(174, 22);
            this.Temperature_2.TabIndex = 2;
            // 
            // C_to_F
            // 
            this.C_to_F.Location = new System.Drawing.Point(174, 62);
            this.C_to_F.Name = "C_to_F";
            this.C_to_F.Size = new System.Drawing.Size(113, 39);
            this.C_to_F.TabIndex = 3;
            this.C_to_F.Text = "C to F ->";
            this.C_to_F.UseVisualStyleBackColor = true;
            this.C_to_F.Click += new System.EventHandler(this.C_to_F_Click);
            // 
            // F_to_C
            // 
            this.F_to_C.Location = new System.Drawing.Point(174, 107);
            this.F_to_C.Name = "F_to_C";
            this.F_to_C.Size = new System.Drawing.Size(113, 39);
            this.F_to_C.TabIndex = 4;
            this.F_to_C.Text = "<- F to C";
            this.F_to_C.UseVisualStyleBackColor = true;
            this.F_to_C.Click += new System.EventHandler(this.button1_Click);
            // 
            // K_to_C
            // 
            this.K_to_C.Location = new System.Drawing.Point(174, 213);
            this.K_to_C.Name = "K_to_C";
            this.K_to_C.Size = new System.Drawing.Size(113, 39);
            this.K_to_C.TabIndex = 5;
            this.K_to_C.Text = "<- K to C";
            this.K_to_C.UseVisualStyleBackColor = true;
            this.K_to_C.Click += new System.EventHandler(this.K_to_C_Click);
            // 
            // C_to_K
            // 
            this.C_to_K.Location = new System.Drawing.Point(174, 168);
            this.C_to_K.Name = "C_to_K";
            this.C_to_K.Size = new System.Drawing.Size(113, 39);
            this.C_to_K.TabIndex = 6;
            this.C_to_K.Text = "C to K ->";
            this.C_to_K.UseVisualStyleBackColor = true;
            this.C_to_K.Click += new System.EventHandler(this.C_to_K_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.C_to_K);
            this.Controls.Add(this.K_to_C);
            this.Controls.Add(this.F_to_C);
            this.Controls.Add(this.C_to_F);
            this.Controls.Add(this.Temperature_2);
            this.Controls.Add(this.Temperature_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Temperature_1;
        private System.Windows.Forms.TextBox Temperature_2;
        private System.Windows.Forms.Button C_to_F;
        private System.Windows.Forms.Button F_to_C;
        private System.Windows.Forms.Button K_to_C;
        private System.Windows.Forms.Button C_to_K;
    }
}

