using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// snippent
namespace OPP1
{   // CRUD Oparation
    internal class Product // Entity : Varlık
    {
        public int Id { get; set; }
        public string ProductName { get; set; } // Urun Adı
        public double UnitPrice { get; set; } // Satıs Fiyati
        public int CategoryId { get; set; } // Kategory ID
        public int UnitsInStock { get; set; } // Stok Adeti
    }
}
