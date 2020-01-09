using AppEstado.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionResult = System.Web.Mvc.ActionResult;


namespace AppEstado.Controllers
{
    [System.Web.Mvc.Route("api/[controller]")]
    [ApiController]
    public class EstadoController : Controller
    {
        private IEstadoRepositorio _estadoRepositorio;

        public EstadoController()
        {
            this._estadoRepositorio = new EstadoRepositorio(new EstadoContex());
        }

        // GET: /Estado/
        public ActionResult GetTodosEstado()
        {
           var results = from estado in _estadoRepositorio.GetEstado()
                     select estado;

            return View(results);

           
        }


        }


    }




////GET: /Estdo/Details/5
//public ActionResult Details(int id)
//{
//    Estado estado = _estadoRepositorio.GetEstadoPorID(id);
//    return View(estado);
//}

////// GET api/Estado/5
////[HttpGet("{id}")]
////public ActionResult GetById(int id)
////{
////    try
////    {
////        var empresa = await _repo.GetEmpresaAsyncById(id);
////        var result = _mapper.Map<EmpresaDto>(empresa);
////        return Ok(result);
////    }
////    catch (System.Exception)
////    {
////        return StatusCode(StatusCodes.Status500InternalServerError,
////            "Ocorreu um erro no banco de dados");
////    }




