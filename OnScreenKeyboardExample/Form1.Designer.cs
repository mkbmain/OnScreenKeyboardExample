namespace OnScreenKeyboardExample
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
            this.AButton = new System.Windows.Forms.Button();
            this.SButton = new System.Windows.Forms.Button();
            this.DButton = new System.Windows.Forms.Button();
            this.WButton = new System.Windows.Forms.Button();
            this.QButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AButton
            // 
            this.AButton.Location = new System.Drawing.Point(12, 232);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(64, 44);
            this.AButton.TabIndex = 0;
            this.AButton.Text = "A";
            this.AButton.UseVisualStyleBackColor = true;
            // 
            // SButton
            // 
            this.SButton.Location = new System.Drawing.Point(82, 232);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(64, 44);
            this.SButton.TabIndex = 1;
            this.SButton.Text = "S";
            this.SButton.UseVisualStyleBackColor = true;
            // 
            // DButton
            // 
            this.DButton.Location = new System.Drawing.Point(152, 232);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(64, 44);
            this.DButton.TabIndex = 2;
            this.DButton.Text = "D";
            this.DButton.UseVisualStyleBackColor = true;
            // 
            // WButton
            // 
            this.WButton.Location = new System.Drawing.Point(82, 182);
            this.WButton.Name = "WButton";
            this.WButton.Size = new System.Drawing.Size(64, 44);
            this.WButton.TabIndex = 3;
            this.WButton.Text = "W";
            this.WButton.UseVisualStyleBackColor = true;
            // 
            // QButton
            // 
            this.QButton.Location = new System.Drawing.Point(12, 182);
            this.QButton.Name = "QButton";
            this.QButton.Size = new System.Drawing.Size(64, 44);
            this.QButton.TabIndex = 4;
            this.QButton.Text = "Q";
            this.QButton.UseVisualStyleBackColor = true;
            this.QButton.Click += new System.EventHandler(this.StandardKeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QButton);
            this.Controls.Add(this.WButton);
            this.Controls.Add(this.DButton);
            this.Controls.Add(this.SButton);
            this.Controls.Add(this.AButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button AButton;
        private System.Windows.Forms.Button DButton;
        private System.Windows.Forms.Button QButton;
        private System.Windows.Forms.Button SButton;
        private System.Windows.Forms.Button WButton;

        #endregion
    }
}