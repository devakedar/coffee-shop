using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ccd.Models;
using ccd.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ccd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuuController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(MenuuController));

        imenuu udb;
        public MenuuController(imenuu _udb)
        {
            udb = _udb;
        }

        public MenuuController(Menuu @object)
        {
        }

        [HttpGet]
        [Route("GetMenuu")]
        public IActionResult GetMenuu(int? Id)
        {
            _log4net.Info("MenuuController Http GET");
            if (Id == null)
            {
                return BadRequest();
            }

            try
            {
                var data = udb.GetMenuu(Id);
                if (data == null)
                {
                    return NotFound();
                }
                return Ok(data);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("GetMenuus")]
        public IActionResult GetMenuus()
        {
            _log4net.Info("MenuuController Http GET ALL");
            try
            {
                var bookin = udb.GetMenuus();
                if (bookin == null)
                {
                    return NotFound();
                }

                return Ok(bookin);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}