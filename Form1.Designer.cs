namespace Dieren2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbKoe = new System.Windows.Forms.CheckBox();
            this.cbVarken = new System.Windows.Forms.CheckBox();
            this.cbSlang = new System.Windows.Forms.CheckBox();
            this.btHoren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKoe
            // 
            this.cbKoe.AutoSize = true;
            this.cbKoe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbKoe.Location = new System.Drawing.Point(172, 87);
            this.cbKoe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKoe.Name = "cbKoe";
            this.cbKoe.Size = new System.Drawing.Size(55, 25);
            this.cbKoe.TabIndex = 0;
            this.cbKoe.Text = "Koe";
            this.cbKoe.UseVisualStyleBackColor = true;
            // 
            // cbVarken
            // 
            this.cbVarken.AutoSize = true;
            this.cbVarken.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbVarken.Location = new System.Drawing.Point(371, 87);
            this.cbVarken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVarken.Name = "cbVarken";
            this.cbVarken.Size = new System.Drawing.Size(77, 25);
            this.cbVarken.TabIndex = 1;
            this.cbVarken.Text = "Varken";
            this.cbVarken.UseVisualStyleBackColor = true;
            // 
            // cbSlang
            // 
            this.cbSlang.AutoSize = true;
            this.cbSlang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSlang.Location = new System.Drawing.Point(272, 87);
            this.cbSlang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSlang.Name = "cbSlang";
            this.cbSlang.Size = new System.Drawing.Size(68, 25);
            this.cbSlang.TabIndex = 2;
            this.cbSlang.Text = "Slang";
            this.cbSlang.UseVisualStyleBackColor = true;
            // 
            // btHoren
            // 
            this.btHoren.Location = new System.Drawing.Point(172, 116);
            this.btHoren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHoren.Name = "btHoren";
            this.btHoren.Size = new System.Drawing.Size(276, 22);
            this.btHoren.TabIndex = 3;
            this.btHoren.Text = "Laat Horen";
            this.btHoren.UseVisualStyleBackColor = true;
            this.btHoren.Click += new System.EventHandler(this.btHoren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.btHoren);
            this.Controls.Add(this.cbSlang);
            this.Controls.Add(this.cbVarken);
            this.Controls.Add(this.cbKoe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbKoe;
        private System.Windows.Forms.CheckBox cbVarken;
        private System.Windows.Forms.CheckBox cbSlang;
        private System.Windows.Forms.Button btHoren;
    }
}

