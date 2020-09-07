using ccd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ccd.Repository
{
    public interface imenuu
    {
        List<Menuu> GetMenuus();

        Menuu GetMenuu(int? id);

    }
}
