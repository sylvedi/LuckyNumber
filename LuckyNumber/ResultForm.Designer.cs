namespace LuckyNumber
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.lbl_LuckyNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_LuckyNumber
            // 
            this.lbl_LuckyNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LuckyNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LuckyNumber.Location = new System.Drawing.Point(251, 410);
            this.lbl_LuckyNumber.Name = "lbl_LuckyNumber";
            this.lbl_LuckyNumber.Size = new System.Drawing.Size(566, 126);
            this.lbl_LuckyNumber.TabIndex = 1;
            this.lbl_LuckyNumber.Text = "0";
            this.lbl_LuckyNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 1009);
            this.Controls.Add(this.lbl_LuckyNumber);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_LuckyNumber;
    }
}