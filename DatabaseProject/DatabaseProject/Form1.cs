using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.tables;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public DataModel Model { get; set; } = new DataModel();

        public TelefonRepository repository { get; set; } = new TelefonRepository();

        private Mobile Telefony;
        private admin admin;

        public AdminRepository AdminRepository { get; set; } = new AdminRepository();

        //private Add_or_Edit Form2;

        public Form1()
        {
            InitializeComponent();

            this.dataGridData.DataSource = this.Model;
            this.Refresh();
        }

        public void Refresh()
        {
            List<admin> admins = this.AdminRepository.FindAll();

            this.Model.Data.Clear();

            foreach (admin item in admins)
            {
                this.Model.Data.Add(item);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(this.dataGridData.CurrentCell.Value);
            this.Telefony = this.repository.FindById(index);

            this.repository.Remove(this.Telefony);
            this.Refresh();
        }

        private void ButtAdd_Click(object sender, EventArgs e)
        {
            /*
            this.Form2 = new Add_or_Edit(this);
            this.Form2.ShowDialog();
            */
        }

        private void ButEdit_Click(object sender, EventArgs e)
        {
            /*
            this.Form2 = new Add_or_Edit(this);

            if (this.dataGridData.CurrentRow.Cells[0].Value == null)
                return;

            int index = Convert.ToInt32(this.dataGridData.CurrentRow.Cells[0].Value);
            this.Telefony = this.repository.FindById(index);




            this.Form2.telefony = this.Telefony;
            this.Form2.Write(this.Telefony);
            this.Form2.ShowDialog();
            */
        }
    }
}
