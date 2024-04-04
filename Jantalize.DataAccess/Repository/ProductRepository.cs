using Jantalize.DataAccess.Data;
using Jantalize.DataAccess.Repository.IRepository;
using Jantalize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jantalize.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>,
    IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) :
        base(db)
        {
            _db = db;
        }

        //public void Save()
        //{
        //    _db.SaveChanges();
        //}

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
