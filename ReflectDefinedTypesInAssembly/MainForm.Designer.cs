namespace ReflectDefinedTypesInAssembly
{
    partial class MainForm
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
         this.label1 = new System.Windows.Forms.Label();
         this.txtFilePath = new System.Windows.Forms.TextBox();
         this.btnSelectFile = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.txtResult = new System.Windows.Forms.TextBox();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(110, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Assembly (*.exe, *.dll):";
         // 
         // txtFilePath
         // 
         this.txtFilePath.Location = new System.Drawing.Point(137, 13);
         this.txtFilePath.Name = "txtFilePath";
         this.txtFilePath.ReadOnly = true;
         this.txtFilePath.Size = new System.Drawing.Size(641, 20);
         this.txtFilePath.TabIndex = 1;
         // 
         // btnSelectFile
         // 
         this.btnSelectFile.Location = new System.Drawing.Point(784, 11);
         this.btnSelectFile.Name = "btnSelectFile";
         this.btnSelectFile.Size = new System.Drawing.Size(138, 23);
         this.btnSelectFile.TabIndex = 2;
         this.btnSelectFile.Text = "Select File And Get Types";
         this.btnSelectFile.UseVisualStyleBackColor = true;
         // 
         // panel1
         // 
         this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel1.BackColor = System.Drawing.Color.FloralWhite;
         this.panel1.Controls.Add(this.txtResult);
         this.panel1.Location = new System.Drawing.Point(16, 42);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(906, 579);
         this.panel1.TabIndex = 3;
         // 
         // txtResult
         // 
         this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtResult.Location = new System.Drawing.Point(0, 0);
         this.txtResult.Multiline = true;
         this.txtResult.Name = "txtResult";
         this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtResult.Size = new System.Drawing.Size(906, 579);
         this.txtResult.TabIndex = 0;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Cornsilk;
         this.ClientSize = new System.Drawing.Size(934, 633);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.btnSelectFile);
         this.Controls.Add(this.txtFilePath);
         this.Controls.Add(this.label1);
         this.Name = "MainForm";
         this.Text = "Defined types";
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResult;
   }
}

