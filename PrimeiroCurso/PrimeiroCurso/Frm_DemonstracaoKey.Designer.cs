namespace PrimeiroCurso
{
    partial class Frm_DemonstracaoKey
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
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Input
            // 
            this.Txt_Input.Location = new System.Drawing.Point(8, 8);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(100, 20);
            this.Txt_Input.TabIndex = 0;
            this.Txt_Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Frm_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.Txt_Input);
            this.Name = "Frm_DemonstracaoKey";
            this.Text = "Demonstração Evendo Key";
            this.Load += new System.EventHandler(this.Frm_DemonstracaoKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Input;
    }
}