using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class MeuBanco:DbContext
    {
        public MeuBanco(): base("bancoDados")
        {

        }
        public DbSet<Cidade> cidades { get; set; }

    }

}