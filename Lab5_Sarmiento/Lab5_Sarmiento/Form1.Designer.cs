namespace Lab5_Sarmiento
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
            this.getMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getMessage
            // 
            this.getMessage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.getMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMessage.Location = new System.Drawing.Point(12, 30);
            this.getMessage.Name = "getMessage";
            this.getMessage.Size = new System.Drawing.Size(200, 108);
            this.getMessage.TabIndex = 0;
            this.getMessage.Text = "Message";
            this.getMessage.UseVisualStyleBackColor = false;
            this.getMessage.Click += new System.EventHandler(this.getMessage_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(224, 285);
            this.Controls.Add(this.getMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getMessage;
    }
}