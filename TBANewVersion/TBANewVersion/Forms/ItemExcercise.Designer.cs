namespace TBANewVersion.Forms
{
    partial class ItemExcercise
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExcerciseName = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblExcerciseName
            // 
            this.lblExcerciseName.Appearance.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.lblExcerciseName.Location = new System.Drawing.Point(84, 20);
            this.lblExcerciseName.Name = "lblExcerciseName";
            this.lblExcerciseName.Size = new System.Drawing.Size(61, 29);
            this.lblExcerciseName.TabIndex = 0;
            this.lblExcerciseName.Text = "Bài  1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(18, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 10);
            this.panel1.TabIndex = 2;
            // 
            // ItemExcercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblExcerciseName);
            this.Name = "ItemExcercise";
            this.Size = new System.Drawing.Size(234, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblExcerciseName;
        private System.Windows.Forms.Panel panel1;
    }
}
