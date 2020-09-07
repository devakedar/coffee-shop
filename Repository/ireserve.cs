using ccd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ccd.Repository
{
    public interface ireserve
    {
        List<Reservations> GetDetails();
        Reservations GetDetail(int? Id);
        int AddDetail(Reservations data);
        int DeleteDetail(int Id);
        int UpdateDetail(int id, Reservations rev);
    }
}
