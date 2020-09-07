using ccd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ccd.Repository
{
    public class reserverep : ireserve
    {
        CCDContext db;
        public reserverep(CCDContext _db)
        {
            db = _db;
        }
        public int AddDetail(Reservations r1)
        {
            if (db != null)
            {
                db.Reservations.Add(r1);
                db.SaveChanges();

                return r1.Id;
            }

            return 0;
        }

        public int DeleteDetail(int Id)
        {
            int result = 0;

            if (db != null)
            {

                var post = db.Reservations.FirstOrDefault(x => x.Id == Id);

                if (post != null)
                {

                    db.Reservations.Remove(post);
                    result = db.SaveChanges();
                    return 1;
                }
                return result;
            }
            return result;
        }
        public List<Reservations> GetDetails()
        {
            if (db != null)
            {
                return db.Reservations.ToList();
            }
            return null;
        }

        public Reservations GetDetail(int? inId)
        {
            if (db != null)
            {
                return (db.Reservations.Where(x => x.Id == inId)).FirstOrDefault();
            }
            return null;
        }

        public int UpdateDetail(int id, Reservations rev)
        {
            if (db != null)
            {
                Reservations val = db.Reservations.Where(x => x.Id == id).FirstOrDefault();
                Reservations valc = db.Reservations.Where(x => x.Id == id).FirstOrDefault();
                if (val != null)
                {
                    db.Reservations.Remove(val);
                    db.SaveChanges();
                    


                    db.Reservations.Add(valc);
                    db.SaveChanges();
                }
            }
            return 0;
        }
    }
}
