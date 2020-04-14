using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Add_or_Edit : Form
    {
        public TelefonRepository repository { get; set; }
        public telefony telefony { get; set; } = new telefony();
        public DataModel Model = new DataModel();
        private Form1 Form1;

        public Add_or_Edit(Form1 form1)
        {
            this.Form1 = form1;
            InitializeComponent();
            this.Refresh();
            this.repository = this.Form1.repository;
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButAdd_Click(object sender, EventArgs e)
        {

            this.telefony.vyrobek = this.txVyrobek.Text;
            this.telefony.model = this.txModel.Text;
            this.telefony.pamet = Convert.ToInt32(this.cbPamet.Text);
            this.telefony.datumVydani = this.dateTimePicker1.Value;

            if (this.telefony.id == 0)
            {
                // insert
                this.repository.Insert(this.telefony);
            }
            else
            {
                // update
                this.repository.Update(this.telefony);
            }

            this.DialogResult = DialogResult.OK;
            this.Form1.Refresh();
            this.Close();
        }
        public void Write(telefony telefony)
        {
            this.txVyrobek.Text = telefony.vyrobek;
            this.txModel.Text = telefony.model;
            this.cbPamet.SelectedValue = telefony.pamet.ToString();
            this.dateTimePicker1.Value = telefony.datumVydani;
        }
        
    }
}
