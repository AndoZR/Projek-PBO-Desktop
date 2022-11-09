using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CobaProjekProgresII.Views
{
    public interface IProdukView
    {
        //Properties - Fields
        string IdProduk { get; set; }
        string NamaProduk { get; set; }
        string HargaProduk { get; set; }
        string StokProduk { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetProdukListBindingSources(BindingSource produkList);
        void show();

    }
}
