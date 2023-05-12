using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        //snippet=kod parçacığı (Biz prop yazınca altında çıkan küçük kare bunun hazr kodları olduğunu ifade ediyor.)
        public int Id { get; set; }
        public int CategoryId { get; set; } //Foreign key genelde ikinci sıraya yazılır.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        //CRUD- Create, Read, Update, Delete
    }
}
