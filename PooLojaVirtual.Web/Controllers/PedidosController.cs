using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PooLojaVirtual.Core;
using PooLojaVirtual.Infraestructure;
using PooLojaVirtual.Models;

namespace PooLojaVirtual.Web.Controllers
{
    public class PedidosController : Controller
    {
        private readonly IRepositorio<Pedido> _repositorioPedidos;

        public PedidosController(IRepositorio<Pedido> repositorioPedidos)
        {
            _repositorioPedidos = repositorioPedidos;
        }

        public IActionResult Index()
        {
            var pedidos = _repositorioPedidos.GetAll().OrderByDescending(p => p.Data);
            return View(pedidos);
        }
    }
}