namespace Tiling_Engine
{
    partial class uxMainMenu
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
            this.uxNewM = new System.Windows.Forms.Button();
            this.uxLoadM = new System.Windows.Forms.Button();
            this.uxEditM = new System.Windows.Forms.Button();
            this.uxViewM = new System.Windows.Forms.Button();
            this.uxSandQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxNewM
            // 
            this.uxNewM.Location = new System.Drawing.Point(122, 49);
            this.uxNewM.Name = "uxNewM";
            this.uxNewM.Size = new System.Drawing.Size(112, 45);
            this.uxNewM.TabIndex = 0;
            this.uxNewM.Text = "New Map";
            this.uxNewM.UseVisualStyleBackColor = true;
            this.uxNewM.Click += new System.EventHandler(this.uxNewM_Click);
            // 
            // uxLoadM
            // 
            this.uxLoadM.Location = new System.Drawing.Point(122, 133);
            this.uxLoadM.Name = "uxLoadM";
            this.uxLoadM.Size = new System.Drawing.Size(112, 45);
            this.uxLoadM.TabIndex = 1;
            this.uxLoadM.Text = "Load Map";
            this.uxLoadM.UseVisualStyleBackColor = true;
            this.uxLoadM.Click += new System.EventHandler(this.uxLoadM_Click);
            // 
            // uxEditM
            // 
            this.uxEditM.Location = new System.Drawing.Point(122, 219);
            this.uxEditM.Name = "uxEditM";
            this.uxEditM.Size = new System.Drawing.Size(112, 45);
            this.uxEditM.TabIndex = 2;
            this.uxEditM.Text = "Edit Map";
            this.uxEditM.UseVisualStyleBackColor = true;
            this.uxEditM.Click += new System.EventHandler(this.uxEditM_Click);
            // 
            // uxViewM
            // 
            this.uxViewM.Location = new System.Drawing.Point(122, 304);
            this.uxViewM.Name = "uxViewM";
            this.uxViewM.Size = new System.Drawing.Size(112, 45);
            this.uxViewM.TabIndex = 3;
            this.uxViewM.Text = "View Map";
            this.uxViewM.UseVisualStyleBackColor = true;
            this.uxViewM.Click += new System.EventHandler(this.uxViewM_Click);
            // 
            // uxSandQ
            // 
            this.uxSandQ.Location = new System.Drawing.Point(122, 390);
            this.uxSandQ.Name = "uxSandQ";
            this.uxSandQ.Size = new System.Drawing.Size(112, 45);
            this.uxSandQ.TabIndex = 4;
            this.uxSandQ.Text = "Save and Quit";
            this.uxSandQ.UseVisualStyleBackColor = true;
            this.uxSandQ.Click += new System.EventHandler(this.uxSandQ_Click);
            // 
            // uxMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(375, 529);
            this.Controls.Add(this.uxSandQ);
            this.Controls.Add(this.uxViewM);
            this.Controls.Add(this.uxEditM);
            this.Controls.Add(this.uxLoadM);
            this.Controls.Add(this.uxNewM);
            this.Name = "uxMainMenu";
            this.Text = "uxMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxNewM;
        private System.Windows.Forms.Button uxLoadM;
        private System.Windows.Forms.Button uxEditM;
        private System.Windows.Forms.Button uxViewM;
        private System.Windows.Forms.Button uxSandQ;
    }
}