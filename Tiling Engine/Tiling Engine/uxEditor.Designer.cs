namespace Tiling_Engine
{
    partial class uxEditor
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
            this.uxGenerate = new System.Windows.Forms.Button();
            this.uxBack = new System.Windows.Forms.Button();
            this.uxRBlank = new System.Windows.Forms.RadioButton();
            this.uxRGrass = new System.Windows.Forms.RadioButton();
            this.uxRDesert = new System.Windows.Forms.RadioButton();
            this.uxRMountains = new System.Windows.Forms.RadioButton();
            this.uxROcean = new System.Windows.Forms.RadioButton();
            this.uxRTundra = new System.Windows.Forms.RadioButton();
            this.uxRCity = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // uxGenerate
            // 
            this.uxGenerate.Location = new System.Drawing.Point(812, 426);
            this.uxGenerate.Name = "uxGenerate";
            this.uxGenerate.Size = new System.Drawing.Size(125, 32);
            this.uxGenerate.TabIndex = 1;
            this.uxGenerate.Text = "Generate";
            this.uxGenerate.UseVisualStyleBackColor = true;
            this.uxGenerate.Click += new System.EventHandler(this.uxGenerate_Click);
            // 
            // uxBack
            // 
            this.uxBack.Location = new System.Drawing.Point(812, 477);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(125, 32);
            this.uxBack.TabIndex = 2;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // uxRBlank
            // 
            this.uxRBlank.AutoSize = true;
            this.uxRBlank.Location = new System.Drawing.Point(844, 24);
            this.uxRBlank.Name = "uxRBlank";
            this.uxRBlank.Size = new System.Drawing.Size(61, 21);
            this.uxRBlank.TabIndex = 5;
            this.uxRBlank.TabStop = true;
            this.uxRBlank.Tag = "0";
            this.uxRBlank.Text = "Blank";
            this.uxRBlank.UseVisualStyleBackColor = true;
            this.uxRBlank.CheckedChanged += new System.EventHandler(this.uxBiomes_CheckedChanged);
            // 
            // uxRGrass
            // 
            this.uxRGrass.AutoSize = true;
            this.uxRGrass.Location = new System.Drawing.Point(844, 51);
            this.uxRGrass.Name = "uxRGrass";
            this.uxRGrass.Size = new System.Drawing.Size(64, 21);
            this.uxRGrass.TabIndex = 6;
            this.uxRGrass.TabStop = true;
            this.uxRGrass.Tag = "1";
            this.uxRGrass.Text = "Grass";
            this.uxRGrass.UseVisualStyleBackColor = true;
            this.uxRGrass.CheckedChanged += new System.EventHandler(this.uxBiomes_CheckedChanged);
            // 
            // uxRDesert
            // 
            this.uxRDesert.AutoSize = true;
            this.uxRDesert.Location = new System.Drawing.Point(844, 78);
            this.uxRDesert.Name = "uxRDesert";
            this.uxRDesert.Size = new System.Drawing.Size(68, 21);
            this.uxRDesert.TabIndex = 7;
            this.uxRDesert.TabStop = true;
            this.uxRDesert.Tag = "2";
            this.uxRDesert.Text = "Desert";
            this.uxRDesert.UseVisualStyleBackColor = true;
            this.uxRDesert.CheckedChanged += new System.EventHandler(this.uxBiomes_CheckedChanged);
            // 
            // uxRMountains
            // 
            this.uxRMountains.AutoSize = true;
            this.uxRMountains.Location = new System.Drawing.Point(844, 105);
            this.uxRMountains.Name = "uxRMountains";
            this.uxRMountains.Size = new System.Drawing.Size(91, 21);
            this.uxRMountains.TabIndex = 8;
            this.uxRMountains.TabStop = true;
            this.uxRMountains.Tag = "3";
            this.uxRMountains.Text = "Mountains";
            this.uxRMountains.UseVisualStyleBackColor = true;
            this.uxRMountains.CheckedChanged += new System.EventHandler(this.uxBiomes_CheckedChanged);
            // 
            // uxROcean
            // 
            this.uxROcean.AutoSize = true;
            this.uxROcean.Location = new System.Drawing.Point(844, 132);
            this.uxROcean.Name = "uxROcean";
            this.uxROcean.Size = new System.Drawing.Size(68, 21);
            this.uxROcean.TabIndex = 9;
            this.uxROcean.TabStop = true;
            this.uxROcean.Tag = "4";
            this.uxROcean.Text = "Ocean";
            this.uxROcean.UseVisualStyleBackColor = true;
            this.uxROcean.CheckedChanged += new System.EventHandler(this.uxBiomes_CheckedChanged);
            // 
            // uxRTundra
            // 
            this.uxRTundra.AutoSize = true;
            this.uxRTundra.Location = new System.Drawing.Point(844, 160);
            this.uxRTundra.Name = "uxRTundra";
            this.uxRTundra.Size = new System.Drawing.Size(72, 21);
            this.uxRTundra.TabIndex = 10;
            this.uxRTundra.TabStop = true;
            this.uxRTundra.Tag = "5";
            this.uxRTundra.Text = "Tundra";
            this.uxRTundra.UseVisualStyleBackColor = true;
            this.uxRTundra.CheckedChanged += new System.EventHandler(this.uxBiomes_CheckedChanged);
            // 
            // uxRCity
            // 
            this.uxRCity.AutoSize = true;
            this.uxRCity.Location = new System.Drawing.Point(844, 187);
            this.uxRCity.Name = "uxRCity";
            this.uxRCity.Size = new System.Drawing.Size(49, 21);
            this.uxRCity.TabIndex = 11;
            this.uxRCity.TabStop = true;
            this.uxRCity.Tag = "6";
            this.uxRCity.Text = "City";
            this.uxRCity.UseVisualStyleBackColor = true;
            this.uxRCity.CheckedChanged += new System.EventHandler(this.uxBiomes_CheckedChanged);
            // 
            // uxEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(990, 590);
            this.Controls.Add(this.uxRCity);
            this.Controls.Add(this.uxRTundra);
            this.Controls.Add(this.uxROcean);
            this.Controls.Add(this.uxRMountains);
            this.Controls.Add(this.uxRDesert);
            this.Controls.Add(this.uxRGrass);
            this.Controls.Add(this.uxRBlank);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.uxGenerate);
            this.Name = "uxEditor";
            this.Text = "Map Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uxGenerate;
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.RadioButton uxRBlank;
        private System.Windows.Forms.RadioButton uxRGrass;
        private System.Windows.Forms.RadioButton uxRDesert;
        private System.Windows.Forms.RadioButton uxRMountains;
        private System.Windows.Forms.RadioButton uxROcean;
        private System.Windows.Forms.RadioButton uxRTundra;
        private System.Windows.Forms.RadioButton uxRCity;
    }
}

