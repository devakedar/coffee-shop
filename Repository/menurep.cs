using ccd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ccd.Repository
{
    public class menurep : imenuu
    {
        CCDContext db;

        public menurep(CCDContext _db)
        {
            db = _db;
        }
        public List<Menuu> GetMenuus()
        {
            if (db != null)
            {
                return db.Menuu.ToList();
            }
            return null;
        }

        public Menuu GetMenuu(int? inId)
        {
            if (db != null)
            {
                return (db.Menuu.Where(x => x.Id == inId)).FirstOrDefault();
            }
            return null;
        }
    }
}
