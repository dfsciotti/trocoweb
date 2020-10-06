using CalculaTroco.Services;
using System;
using System.Web.Mvc;

namespace WebTroco.Controllers
{
    public class HomeController : Controller
    {
        private CalculaTrocoService _service;
        private string vsTroco = "";

        public ActionResult Index()
        {
            return View();
        }
               
        public string CalculaTroco(double vlrCompra, double vlrPagto)
        {
            try
            {
                _service = new CalculaTrocoService();
                var troco = _service.CalculaTroco(vlrCompra, vlrPagto);
                if (troco.ItensTroco != null)
                {
                    for (int i = 0; i < troco.ItensTroco.Count; i++)
                    {
                        vsTroco += troco.ItensTroco[i].Quantidade + " " +
                                   troco.ItensTroco[i].Tipo + " de " +
                                   troco.ItensTroco[i].Valor + " " +
                                   troco.ItensTroco[i].Especie;
                        if (i < troco.ItensTroco.Count -1)
                        {
                            vsTroco += ", ";
                        }
                    }
                }
                else
                {
                    return troco.Mensagem;
                }
                return vsTroco;
            }
            catch (Exception ex)
            {
                return "Erro ao calcular troco!\n" + ex.Message;
            }

        }
    }
}