using Microsoft.AspNetCore.Mvc;
using ResponseHelper.Utils;

namespace ResponseHelper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        internal IActionResult SimpleResponse(Response response)
        {
            IActionResult result;

            if (response.IsSuccess)
                result = Ok(response.ResponseObject);
            else
                result = BadRequest(response.Exception);

            return result;
        }

        internal IActionResult HttpResponse(Response response)
        {
            IActionResult result;

            switch (response.HttpCode)
            {
                case 200:
                    result = Ok(response.ResponseObject);
                    break;
                case 400:
                    result = BadRequest(response.Exception);
                    break;
                case 404:
                    result = NotFound(response.Exception);
                    break;
                default:
                    result = StatusCode(response.HttpCode, response.GetResponseBaseadOnHttpCode());
                    break;
            }

            return result;
        }
    }
}
