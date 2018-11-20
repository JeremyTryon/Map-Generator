namespace Tiling_Engine
{
    partial class uxSizeInput
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
            this.uxConfirmSize = new System.Windows.Forms.Button();
            this.uxTextSize = new System.Windows.Forms.TextBox();
            this.uxSizeExplanation = new System.Windows.Forms.Label();
            this.uxSizeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxConfirmSize
            // 
            this.uxConfirmSize.Location = new System.Drawing.Point(57, 136);
            this.uxConfirmSize.Name = "uxConfirmSize";
            this.uxConfirmSize.Size = new System.Drawing.Size(133, 42);
            this.uxConfirmSize.TabIndex = 0;
            this.uxConfirmSize.Text = "Confirm";
            this.uxConfirmSize.UseVisualStyleBackColor = true;
            this.uxConfirmSize.Click += new System.EventHandler(this.uxConfirmSize_Click);
            // 
            // uxTextSize
            // 
            this.uxTextSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextSize.Location = new System.Drawing.Point(94, 82);
            this.uxTextSize.Name = "uxTextSize";
            this.uxTextSize.Size = new System.Drawing.Size(65, 34);
            this.uxTextSize.TabIndex = 1;
            // 
            // uxSizeExplanation
            // 
            this.uxSizeExplanation.Location = new System.Drawing.Point(12, 16);
            this.uxSizeExplanation.Name = "uxSizeExplanation";
            this.uxSizeExplanation.Size = new System.Drawing.Size(240, 63);
            this.uxSizeExplanation.TabIndex = 2;
            this.uxSizeExplanation.Text = "Please input your desired map size. (e.g. intput \"30\" to create a 30x30 square):";
            // 
            // uxSizeError
            // 
            this.uxSizeError.Location = new System.Drawing.Point(12, 198);
            this.uxSizeError.Name = "uxSizeError";
            this.uxSizeError.Size = new System.Drawing.Size(226, 58);
            this.uxSizeError.TabIndex = 3;
            this.uxSizeError.Text = "That is not a valid value. Make sure the number is greater than 0 and less than 1" +
    ",000";
            this.uxSizeError.Visible = false;
            // 
            // uxSizeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 263);
            this.Controls.Add(this.uxSizeError);
            this.Controls.Add(this.uxSizeExplanation);
            this.Controls.Add(this.uxTextSize);
            this.Controls.Add(this.uxConfirmSize);
            this.Name = "uxSizeInput";
            this.Text = "Input Map Size";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxConfirmSize;
        private System.Windows.Forms.TextBox uxTextSize;
        private System.Windows.Forms.Label uxSizeExplanation;
        private System.Windows.Forms.Label uxSizeError;
    }
}