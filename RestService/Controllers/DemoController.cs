using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XamarinRestServices.Models;

namespace RestService.Controllers
{
        
    [RoutePrefix("demo")]
    public class DemoController : ApiController
    {
        [HttpGet]
        [Route("getdata")]
        public HttpResponseMessage GetData([FromUri]string id)
        {
            if ( string.IsNullOrWhiteSpace(id) )
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "invalid id");
            }

            return Request.CreateResponse(HttpStatusCode.OK, "id: " + id);
            
        }

        [HttpPost]
        [Route("registeruser")]
        public HttpResponseMessage RegisterUser(UserModel model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "invalid model");
            }

            try
            {     
                //some other code to actually register a user somewhere
                return Request.CreateResponse(HttpStatusCode.OK, "true");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
    }
}
