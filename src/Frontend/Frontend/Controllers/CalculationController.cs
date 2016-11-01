using System.Web.Http;
using Frontend.Domain;

namespace Frontend.Controllers
{
    [RoutePrefix("Calculation")]
    public class CalculationController : ApiController
    {
        public IHttpActionResult Calculate()
        {
            //TODO provide values
            var calculation = new Calculation();

            calculation.Calculate();
            
            return Ok(calculation);
        }
    }
}