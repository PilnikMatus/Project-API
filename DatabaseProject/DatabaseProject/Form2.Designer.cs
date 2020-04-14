namespace WindowsFormsApplication1
{
    partial class Add_or_Edit
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
            this.butAdd = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.txVyrobek = new System.Windows.Forms.TextBox();
            this.txModel = new System.Windows.Forms.TextBox();
            this.cbPamet = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(22, 146);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "OK";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(223, 146);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Storno";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // txVyrobek
            // 
            this.txVyrobek.Location = new System.Drawing.Point(22, 13);
            this.txVyrobek.Name = "txVyrobek";
            this.txVyrobek.Size = new System.Drawing.Size(135, 20);
            this.txVyrobek.TabIndex = 2;
            // 
            // txModel
            // 
            this.txModel.Location = new System.Drawing.Point(22, 39);
            this.txModel.Name = "txModel";
            this.txModel.Size = new System.Drawing.Size(135, 20);
            this.txModel.TabIndex = 3;
            // 
            // cbPamet
            // 
            this.cbPamet.FormattingEnabled = true;
            this.cbPamet.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64",
            "128"});
            this.cbPamet.Location = new System.Drawing.Point(163, 13);
            this.cbPamet.Name = "cbPamet";
            this.cbPamet.Size = new System.Drawing.Size(135, 21);
            this.cbPamet.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Add_or_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 190);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbPamet);
            this.Controls.Add(this.txModel);
            this.Controls.Add(this.txVyrobek);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butAdd);
            this.Name = "Add_or_Edit";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TextBox txVyrobek;
        private System.Windows.Forms.TextBox txModel;
        private System.Windows.Forms.ComboBox cbPamet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}