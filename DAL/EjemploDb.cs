﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;
namespace DAL
{
    public class EjemploDb : DbContext
    {
        public EjemploDb() : base("name=ConStr")
        {

        }
        public virtual DbSet<Usuarios> Usuario { get; set; }
    }


}
