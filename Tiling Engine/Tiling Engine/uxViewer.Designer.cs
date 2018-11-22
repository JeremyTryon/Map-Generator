namespace Tiling_Engine
{
    partial class uxViewer
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
            this.uxBack = new System.Windows.Forms.Button();
            this.uxPView = new System.Windows.Forms.Button();
            this.uxRBHide = new System.Windows.Forms.RadioButton();
            this.uxRBShow = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // uxBack
            // 
            this.uxBack.Location = new System.Drawing.Point(577, 106);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(89, 34);
            this.uxBack.TabIndex = 0;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // uxPView
            // 
            this.uxPView.Location = new System.Drawing.Point(577, 33);
            this.uxPView.Name = "uxPView";
            this.uxPView.Size = new System.Drawing.Size(89, 48);
            this.uxPView.TabIndex = 1;
            this.uxPView.Text = "Open Player View";
            this.uxPView.UseVisualStyleBackColor = true;
            this.uxPView.Click += new System.EventHandler(this.uxPView_Click);
            // 
            // uxRBHide
            // 
            this.uxRBHide.AutoSize = true;
            this.uxRBHide.Location = new System.Drawing.Point(577, 185);
            this.uxRBHide.Name = "uxRBHide";
            this.uxRBHide.Size = new System.Drawing.Size(105, 21);
            this.uxRBHide.TabIndex = 2;
            this.uxRBHide.TabStop = true;
            this.uxRBHide.Tag = "7";
            this.uxRBHide.Text = "Hide Square";
            this.uxRBHide.UseVisualStyleBackColor = true;
            this.uxRBHide.CheckedChanged += new System.EventHandler(this.uxVis_CheckedChanged);
            // 
            // uxRBShow
            // 
            this.uxRBShow.AutoSize = true;
            this.uxRBShow.Location = new System.Drawing.Point(577, 224);
            this.uxRBShow.Name = "uxRBShow";
            this.uxRBShow.Size = new System.Drawing.Size(110, 21);
            this.uxRBShow.TabIndex = 3;
            this.uxRBShow.TabStop = true;
            this.uxRBShow.Tag = "6";
            this.uxRBShow.Text = "Show Square";
            this.uxRBShow.UseVisualStyleBackColor = true;
            this.uxRBShow.CheckedChanged += new System.EventHandler(this.uxVis_CheckedChanged);
            // 
            // uxViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 442);
            this.Controls.Add(this.uxRBShow);
            this.Controls.Add(this.uxRBHide);
            this.Controls.Add(this.uxPView);
            this.Controls.Add(this.uxBack);
            this.Name = "uxViewer";
            this.Text = "Viewer";
            this.Load += new System.EventHandler(this.uxViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.Button uxPView;
        private System.Windows.Forms.RadioButton uxRBHide;
        private System.Windows.Forms.RadioButton uxRBShow;
    }
}