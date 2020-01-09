using AppEstado.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AppEstado.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string ApiBaseUrl = "http://homologacao.service.mergefusao.agrohub.com.br/Services/CategoriaOficialService.svc/ObterPorEstadoFazenda/2"; 
            string MetodoPath = "Estado/GetTodosEstado"; 

            var model = new EstadoViewModel();
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl + MetodoPath);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var retorno = JsonConvert.DeserializeObject<List<string>>(streamReader.ReadToEnd());

                    if (retorno != null)
                        model.ListaEstados = retorno;
                }
            }
            catch (Exception e)
            {
                throw e;
            }


            return View(model);
        }
    }
}


