using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ccd.Repository;
using ccd.Models;

namespace ccd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class postreservationsController : ControllerBase


    {

        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(postreservationsController));
        ipostreservation pdb;
        public postreservationsController(ipostreservation _pdb)
        {
            pdb = _pdb;
        }

        [HttpPost]
        [Route("PostResrvation")]
        public IActionResult PostResrvation(Reservations model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var Id = pdb.AddDetail(model);
                    if (Id > 0)
                    {
                        return Ok(Id);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }
    }
}