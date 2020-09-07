using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ccd.Models;


namespace ccd.Repository
{
    public class PostReservation : ipostreservation
    {
        CCDContext db;
        public PostReservation(CCDContext _db)
        {
            db = _db;
        }
        
        public int AddDetail(Reservations data)
        {
            if (db != null)
            {
                db.Reservations.Add(data);
                db.SaveChanges();

                return data.Id;
            }

            return 0;
        }
    }
}
