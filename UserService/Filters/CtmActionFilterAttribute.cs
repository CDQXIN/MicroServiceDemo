using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Filters
{
    public class CtmActionFilterAttribute : Attribute, IActionFilter
    {
        private static Dictionary<string, List<DateTime>> dicRequestTimes = new Dictionary<string, List<DateTime>>();
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string ip = context.HttpContext.Connection.RemoteIpAddress.ToString();
            int port = context.HttpContext.Connection.RemotePort;
            var requestName = $"{ip}_{port}";
            //查找是否包含当前地址
            var hasHost = dicRequestTimes.ContainsKey(requestName);
            if (hasHost)
            {
              var allTimes =   dicRequestTimes[requestName];
                //访问次数为空或者小于5次则正常访问
                if (allTimes == null || allTimes.Count<5)
                {
                    allTimes.Add(DateTime.Now);
                }
                else
                {
                    //获取当前时间到当前时间前一分钟时间段内的访问次数
                    var timeCount = allTimes.Count(m => m > DateTime.Now.AddMinutes(-1));
                    if (timeCount>=5)
                    {
                        //返回错误
                        context.Result = new JsonResult("访问过于频繁，请稍后再试") { StatusCode = 500 };
                    }
                    else
                    {
                        allTimes.Add(DateTime.Now);
                        var lessCount = allTimes.Count - timeCount;
                        allTimes.RemoveRange(0, lessCount - 1);
                    }
                }
            }
            else
            {
                List<DateTime> value = new List<DateTime>();
                value.Add(DateTime.Now);
                dicRequestTimes.Add(requestName, value);
            }
        }
    }
}
