using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CidadesController : ApiController
    {
          private MeuBanco db = new MeuBanco();

         public IQueryable<Cidade> GetCidades()
        {
            return db.cidades;

        }
        [ResponseType(typeof(Cidade))]
        public async Task<IHttpActionResult> GetCidade(int id)
        {
            Cidade cidade = await db.cidades.FindAsync(id);

            if (cidade == null)
            {
                return NotFound();
            }

            return Ok(cidade);

        }
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCidade(int id,Cidade cidade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  

            }
              
        }


    }
}
