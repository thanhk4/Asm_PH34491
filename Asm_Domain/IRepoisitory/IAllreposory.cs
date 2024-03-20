using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm_Domain.IRepoisitory
{
    internal interface IAllreposory<T> where T : class
    {
        public ICollection<T> GetAll(); // Lấy ra tất cả

        public T GetbyID(dynamic id); // lấy bởi ID

        public bool Create(T obj); // Tạo mới và  thêm vào trong Db  

        public bool Update(T obj); // Sửa và lưu vào CSDL 

        public bool Delete(dynamic id); // Xóa đối tượng trong DB


    }
}
