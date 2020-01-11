using AppEstado.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionResult = System.Web.Mvc.ActionResult;


namespace AppEstado.Controllers
{
    
    public class EstadoController : Controller
    {
      
        public ActionResult GetTodosEstado()
        {

            var estado = new RestClient("http://homologacao.service.mergefusao.agrohub.com.br/Services/CategoriaOficialService.svc");
            var estados = new RestRequest("/ObterPorEstadoFazenda/2", DataFormat.Json);

            var response = estado.Get(estados);

            var objObterEstados = JsonConvert.DeserializeObject<dynamic>(response.Content);
            //((Newtonsoft.Json.Linq.JProperty)((Newtonsoft.Json.Linq.JContainer)(JsonConvert.DeserializeObject<Object>(response.Content))).First).Value
            //var objEstados = JsonConvert.DeserializeObject<Estado>(objObterEstados);
            return View(objObterEstados);

            // return View(response.Content);

        }

  
        }

    }




     


