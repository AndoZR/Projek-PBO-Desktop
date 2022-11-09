using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CobaProjekProgresII.Views
{
    public partial class ProdukView : Form, IProdukView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public ProdukView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void AssociateAndRaiseViewEvent()
        {
            button1.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textBox1.KeyDown+=(s,e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Lain-lain
        }

        //Properties
        public string IdProduk 
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string NamaProduk 
        { 
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string HargaProduk 
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public string StokProduk 
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string SearchValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit=value; }
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message 
        { 
            get { return message; }
            set {  message = value; }
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetProdukListBindingSources(BindingSource produkList)
        {
            dataGridView1.DataSource = produkList;
        }

        public void show()
        {
            throw new NotImplementedException();
        }
    }
}
