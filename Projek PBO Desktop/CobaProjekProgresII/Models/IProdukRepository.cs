using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaProjekProgresII.Models
{
    public interface IProdukRepository
    {
        void Add(Produk produk);
        void Edit(Produk produk);
        void Delete(int id_produk);
        IEnumerable<Produk> GetAll();
        IEnumerable<Produk> GetByValue(); //Searchs
    }
}
