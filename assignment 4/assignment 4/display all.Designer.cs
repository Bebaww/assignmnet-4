namespace assignment_4
{
    partial class display_all
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
            this.txt_display = new System.Windows.Forms.TextBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.datadisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datadisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_display
            // 
            this.txt_display.Location = new System.Drawing.Point(118, 45);
            this.txt_display.Name = "txt_display";
            this.txt_display.Size = new System.Drawing.Size(100, 20);
            this.txt_display.TabIndex = 0;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(297, 41);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 23);
            this.btn_display.TabIndex = 1;
            this.btn_display.Text = "display all";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // datadisplay
            // 
            this.datadisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadisplay.Location = new System.Drawing.Point(537, 30);
            this.datadisplay.Name = "datadisplay";
            this.datadisplay.Size = new System.Drawing.Size(240, 150);
            this.datadisplay.TabIndex = 2;
            // 
            // display_all
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datadisplay);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.txt_display);
            this.Name = "display_all";
            this.Text = "display all";
            ((System.ComponentModel.ISupportInitialize)(this.datadisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_display;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.DataGridView datadisplay;
    }
}