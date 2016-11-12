using System.Web.Http;
using Frontend.Domain;

namespace Frontend.Controllers
{
    [RoutePrefix("calculation")]
    public class CalculationController : ApiController
    {
        [HttpGet]
        [Route("calc")]
        public IHttpActionResult Calculate()
        {
            //TODO provide values
            var calculation = new Calculation();

            calculation.Calculate();
            
            //TODO multidimensional arrays not supported
            return Ok(calculation);
        }
    }
}