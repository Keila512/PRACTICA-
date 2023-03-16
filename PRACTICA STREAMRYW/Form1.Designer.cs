namespace PRACTICA_STREAMRYW
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribr = new System.Windows.Forms.Button();
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnBinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(112, 67);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(122, 47);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "LEER";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribr
            // 
            this.btnEscribr.Location = new System.Drawing.Point(323, 67);
            this.btnEscribr.Name = "btnEscribr";
            this.btnEscribr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEscribr.Size = new System.Drawing.Size(116, 47);
            this.btnEscribr.TabIndex = 1;
            this.btnEscribr.Text = "ESCRIBIR";
            this.btnEscribr.UseVisualStyleBackColor = true;
            this.btnEscribr.Click += new System.EventHandler(this.btnEscribr_Click);
            // 
            // richTxtBox
            // 
            this.richTxtBox.Location = new System.Drawing.Point(37, 139);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.Size = new System.Drawing.Size(707, 299);
            this.richTxtBox.TabIndex = 2;
            this.richTxtBox.Text = "";
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(522, 67);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(117, 47);
            this.btnBinario.TabIndex = 3;
            this.btnBinario.Text = "ESCRIBIR BINARIO";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.richTxtBox);
            this.Controls.Add(this.btnEscribr);
            this.Controls.Add(this.btnLeer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribr;
        private System.Windows.Forms.RichTextBox richTxtBox;
        private System.Windows.Forms.Button btnBinario;
    }
}

