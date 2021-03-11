using JobTracking.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.WebApi.Controllers
{
    public class BaseController : Controller
    {
        protected ActionResult Execute(Action action)
        {
            try
            {
                action();
                return Json(new JobTrackingResponse(ResponseType.Success));
            }
            catch (Exception exp)
            {
                return Json(new JobTrackingResponse(ResponseType.Error, exp.Message));
            }

        }
        protected ActionResult Execute<T>(Func<T> func)
        {
            try
            {
                T t = func();

                return Json(new JobTrackingResponse<T>(t, ResponseType.Success));
            }
            catch (Exception exp)
            {
                return Json(new JobTrackingResponse(ResponseType.Error, exp.Message));
            }
        }
    }
}
