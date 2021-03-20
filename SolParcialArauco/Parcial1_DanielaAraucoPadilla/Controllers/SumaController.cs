using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Parcial1_DanielaAraucoPadilla.Controllers
{
    public class SumaController : ApiController
    {
        [HttpPost]
        [Route("Add")]
        public int Add([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa + numb;
        }

        [HttpGet]
        [Route("Add")]
        public int Add2(int numa, int numb)
        {
            return numa + numb;
        }
    }
}
