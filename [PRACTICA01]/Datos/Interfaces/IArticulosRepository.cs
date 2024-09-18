﻿using Practica01.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PRACTICA01_.Datos.Interfaces
{
    public interface IArticulosRepository
    {
        public bool Delete(int id);
        List<Articulos> GetAll();
        public Articulos GetById(int id);
        public bool Save(Articulos factura);
    }
}
