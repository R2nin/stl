namespace ArquivoSTL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPoints = new System.Windows.Forms.Label();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.lblExternalRadius = new System.Windows.Forms.Label();
            this.numExternalRadius = new System.Windows.Forms.NumericUpDown();
            this.lblInternalRadius = new System.Windows.Forms.Label();
            this.numInternalRadius = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateStarSTL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExternalRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInternalRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(12, 15);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(89, 13);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.Text = "Number of Points:";
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(150, 13);
            this.numPoints.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.numPoints.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(120, 20);
            this.numPoints.TabIndex = 1;
            this.numPoints.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblExternalRadius
            // 
            this.lblExternalRadius.AutoSize = true;
            this.lblExternalRadius.Location = new System.Drawing.Point(12, 45);
            this.lblExternalRadius.Name = "lblExternalRadius";
            this.lblExternalRadius.Size = new System.Drawing.Size(85, 13);
            this.lblExternalRadius.TabIndex = 2;
            this.lblExternalRadius.Text = "External Radius:";
            // 
            // numExternalRadius
            // 
            this.numExternalRadius.DecimalPlaces = 1;
            this.numExternalRadius.Location = new System.Drawing.Point(150, 43);
            this.numExternalRadius.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numExternalRadius.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numExternalRadius.Name = "numExternalRadius";
            this.numExternalRadius.Size = new System.Drawing.Size(120, 20);
            this.numExternalRadius.TabIndex = 3;
            this.numExternalRadius.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblInternalRadius
            // 
            this.lblInternalRadius.AutoSize = true;
            this.lblInternalRadius.Location = new System.Drawing.Point(12, 75);
            this.lblInternalRadius.Name = "lblInternalRadius";
            this.lblInternalRadius.Size = new System.Drawing.Size(82, 13);
            this.lblInternalRadius.TabIndex = 4;
            this.lblInternalRadius.Text = "Internal Radius:";
            // 
            // numInternalRadius
            // 
            this.numInternalRadius.DecimalPlaces = 1;
            this.numInternalRadius.Location = new System.Drawing.Point(150, 73);
            this.numInternalRadius.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numInternalRadius.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numInternalRadius.Name = "numInternalRadius";
            this.numInternalRadius.Size = new System.Drawing.Size(120, 20);
            this.numInternalRadius.TabIndex = 5;
            this.numInternalRadius.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 105);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(63, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Star Height:";
            // 
            // numHeight
            // 
            this.numHeight.DecimalPlaces = 1;
            this.numHeight.Location = new System.Drawing.Point(150, 103);
            this.numHeight.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(120, 20);
            this.numHeight.TabIndex = 7;
            this.numHeight.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnGenerateStarSTL
            // 
            this.btnGenerateStarSTL.Location = new System.Drawing.Point(15, 140);
            this.btnGenerateStarSTL.Name = "btnGenerateStarSTL";
            this.btnGenerateStarSTL.Size = new System.Drawing.Size(255, 30);
            this.btnGenerateStarSTL.TabIndex = 8;
            this.btnGenerateStarSTL.Text = "Generate Star STL";
            this.btnGenerateStarSTL.UseVisualStyleBackColor = true;
            this.btnGenerateStarSTL.Click += new System.EventHandler(this.GenerateStarSTL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.btnGenerateStarSTL);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.numInternalRadius);
            this.Controls.Add(this.lblInternalRadius);
            this.Controls.Add(this.numExternalRadius);
            this.Controls.Add(this.lblExternalRadius);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.lblPoints);
            this.Name = "Form1";
            this.Text = "Star STL Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExternalRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInternalRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label lblExternalRadius;
        private System.Windows.Forms.NumericUpDown numExternalRadius;
        private System.Windows.Forms.Label lblInternalRadius;
        private System.Windows.Forms.NumericUpDown numInternalRadius;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Button btnGenerateStarSTL;
    }
}