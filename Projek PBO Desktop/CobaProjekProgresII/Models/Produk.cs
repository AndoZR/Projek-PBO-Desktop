using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CobaProjekProgresII.Models
{
    public class Produk
    {
        //Fields
        private int id_produk;
        private string nama_produk;
        private string harga_produk;
        private string stok_produk;

        //Properties - Validations
        [DisplayName("ID Produk")]
        public int Id_produk 
        { 
            get { return id_produk; } 
            set { id_produk = value; } 
        }
        [DisplayName("Nama Produk")]
        [Required(ErrorMessage = "Nama produk harus ada!")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Nama harus diantara 3-50 karakter!")]
        public string Nama_produk {
            
            get { return nama_produk; } 
            set { nama_produk = value; } 
        }
        [DisplayName("ID Produk")]
        public string Harga_produk 
        { 
            get { return harga_produk; } 
            set { harga_produk = value; } 
        }
        public string Stok_produk 
        { 
            get { return stok_produk; } 
            set { stok_produk = value; } 
        }
    }
}
