namespace WindowsFormsApplication1
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
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dataGridData = new System.Windows.Forms.DataGridView();
            this.butDelete = new System.Windows.Forms.Button();
            this.buttAdd = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridData
            // 
            this.dataGridData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridData.Location = new System.Drawing.Point(12, 32);
            this.dataGridData.Name = "dataGridData";
            this.dataGridData.Size = new System.Drawing.Size(540, 190);
            this.dataGridData.TabIndex = 0;
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Firebrick;
            this.butDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDelete.Location = new System.Drawing.Point(259, 246);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(89, 61);
            this.butDelete.TabIndex = 1;
            this.butDelete.Text = "ODEBRAT";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // buttAdd
            // 
            this.buttAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttAdd.Location = new System.Drawing.Point(12, 246);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(89, 61);
            this.buttAdd.TabIndex = 2;
            this.buttAdd.Text = "PŘIDAT";
            this.buttAdd.UseVisualStyleBackColor = false;
            this.buttAdd.Click += new System.EventHandler(this.ButtAdd_Click);
            // 
            // butEdit
            // 
            this.butEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butEdit.Location = new System.Drawing.Point(463, 246);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(89, 61);
            this.butEdit.TabIndex = 3;
            this.butEdit.Text = "UPRAVIT";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.ButEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(566, 355);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.buttAdd);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.dataGridData);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridData;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button buttAdd;
        private System.Windows.Forms.Button butEdit;
    }
}

