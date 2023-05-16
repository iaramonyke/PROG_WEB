using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProjeto.Models
{
    public class Home
    {
        public IOrderedQueryable<Fabricante> fabricantes;
        public IOrderedQueryable<Categoria> categorias;

    }
}