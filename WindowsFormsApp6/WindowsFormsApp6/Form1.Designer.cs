namespace WindowsFormsApp6
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
            this.lblinput = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnreverse = new System.Windows.Forms.Button();
            this.btnurutkan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput.Location = new System.Drawing.Point(39, 52);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(65, 29);
            this.lblinput.TabIndex = 0;
            this.lblinput.Text = "Input";
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(39, 340);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(84, 29);
            this.lbloutput.TabIndex = 1;
            this.lbloutput.Text = "Output";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(44, 99);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(274, 26);
            this.txtinput.TabIndex = 2;
            // 
            // btnreverse
            // 
            this.btnreverse.Location = new System.Drawing.Point(44, 168);
            this.btnreverse.Name = "btnreverse";
            this.btnreverse.Size = new System.Drawing.Size(108, 44);
            this.btnreverse.TabIndex = 3;
            this.btnreverse.Text = "REVERSE";
            this.btnreverse.UseVisualStyleBackColor = true;
            this.btnreverse.Click += new System.EventHandler(this.btnreverse_Click);
            // 
            // btnurutkan
            // 
            this.btnurutkan.Location = new System.Drawing.Point(210, 168);
            this.btnurutkan.Name = "btnurutkan";
            this.btnurutkan.Size = new System.Drawing.Size(108, 44);
            this.btnurutkan.TabIndex = 4;
            this.btnurutkan.Text = "URUTKAN";
            this.btnurutkan.UseVisualStyleBackColor = true;
            this.btnurutkan.Click += new System.EventHandler(this.btnurutkan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnurutkan);
            this.Controls.Add(this.btnreverse);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnreverse;
        private System.Windows.Forms.Button btnurutkan;
    }
}

