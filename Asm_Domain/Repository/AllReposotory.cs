using app_data_class.Models;
using Asm_Domain.IRepoisitory;
using Microsoft.EntityFrameworkCore;

namespace Asm_Domain.Repository
{
    public class AllReposotory<G> : IAllreposory<G> where G : class
    {
        SD18302_NET104Context context;
        DbSet<G> dbSet; // Tạo ra để CRUD trên DbSet vì nó đại diện cho bảng 
        // khi cần gọi lại và dùng thật thì lại cần chính xác nó là DbSet nào 
        // Lúc đó ta sẽ gán DbSet = DbSet cần dùng 
        public AllReposotory()
        {
            context = new SD18302_NET104Context();
        }
        public AllReposotory(DbSet<G> dbset, SD18302_NET104Context context)
        {
            dbSet = dbset; // gán lại khi dùng 
            this.context = context;
        }
      
        public bool Create(G obj) // thêm mới 
        {
            try
            {
                dbSet.Add(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(dynamic id)
        {
            try
            {
                var delete = dbSet.Find(id); // find truyền vào thuộc tính chỉ sử dụng với PK
                dbSet.Remove(delete);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public ICollection<G> GetAll()
        {
            return dbSet.ToList();
        }

        public G GetbyID(dynamic id)
        {
            return dbSet.Find(id);
        }

        public bool Update(G obj)
        {

            try
            {

                dbSet.Update(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
