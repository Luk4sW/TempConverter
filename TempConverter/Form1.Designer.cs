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
            this.components = new System.ComponentModel.Container();
            this.Temperature_1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Temperature_2 = new System.Windows.Forms.TextBox();
            this.C_to_F = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Temperature_1
            // 
            this.Temperature_1.Location = new System.Drawing.Point(23, 24);
            this.Temperature_1.Name = "Temperature_1";
            this.Temperature_1.Size = new System.Drawing.Size(142, 22);
            this.Temperature_1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "<- F to C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Temperature_2;
        private System.Windows.Forms.Button C_to_F;
        private System.Windows.Forms.Button button1;
    }
}

