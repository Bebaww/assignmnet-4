namespace assignment_4
{
    partial class product_managment
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.production_date = new System.Windows.Forms.DateTimePicker();
            this.expiry_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_batch = new System.Windows.Forms.TextBox();
            this.chk_box = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.packed = new System.Windows.Forms.RadioButton();
            this.unpacked = new System.Windows.Forms.RadioButton();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(256, 46);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 20);
            this.txt_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "production date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "expiry date";
            // 
            // production_date
            // 
            this.production_date.Location = new System.Drawing.Point(256, 100);
            this.production_date.Name = "production_date";
            this.production_date.Size = new System.Drawing.Size(200, 20);
            this.production_date.TabIndex = 7;
            // 
            // expiry_date
            // 
            this.expiry_date.Location = new System.Drawing.Point(256, 148);
            this.expiry_date.Name = "expiry_date";
            this.expiry_date.Size = new System.Drawing.Size(200, 20);
            this.expiry_date.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "batch_no";
            // 
            // txt_batch
            // 
            this.txt_batch.Location = new System.Drawing.Point(256, 195);
            this.txt_batch.Name = "txt_batch";
            this.txt_batch.Size = new System.Drawing.Size(200, 20);
            this.txt_batch.TabIndex = 10;
            // 
            // chk_box
            // 
            this.chk_box.AutoSize = true;
            this.chk_box.Location = new System.Drawing.Point(615, 53);
            this.chk_box.Name = "chk_box";
            this.chk_box.Size = new System.Drawing.Size(68, 17);
            this.chk_box.TabIndex = 11;
            this.chk_box.Text = "available";
            this.chk_box.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(462, 122);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(343, 150);
            this.dataGridView.TabIndex = 16;
            // 
            // packed
            // 
            this.packed.AutoSize = true;
            this.packed.Location = new System.Drawing.Point(542, 313);
            this.packed.Name = "packed";
            this.packed.Size = new System.Drawing.Size(61, 17);
            this.packed.TabIndex = 17;
            this.packed.TabStop = true;
            this.packed.Text = "packed";
            this.packed.UseVisualStyleBackColor = true;
            this.packed.CheckedChanged += new System.EventHandler(this.packed_CheckedChanged);
            // 
            // unpacked
            // 
            this.unpacked.AutoSize = true;
            this.unpacked.Location = new System.Drawing.Point(542, 348);
            this.unpacked.Name = "unpacked";
            this.unpacked.Size = new System.Drawing.Size(73, 17);
            this.unpacked.TabIndex = 18;
            this.unpacked.TabStop = true;
            this.unpacked.Text = "unpacked";
            this.unpacked.UseVisualStyleBackColor = true;
            this.unpacked.CheckedChanged += new System.EventHandler(this.unpacked_CheckedChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(642, 96);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "price";
            // 
            // product_managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.unpacked);
            this.Controls.Add(this.packed);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk_box);
            this.Controls.Add(this.txt_batch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expiry_date);
            this.Controls.Add(this.production_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "product_managment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "product_managment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker production_date;
        private System.Windows.Forms.DateTimePicker expiry_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_batch;
        private System.Windows.Forms.CheckBox chk_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RadioButton packed;
        private System.Windows.Forms.RadioButton unpacked;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label6;
    }
}