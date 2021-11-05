using Microsoft.AspNetCore.Mvc.Filters;
using ShowProduct.Core.CrossCuttingConcert.UserLogging;
using ShowProduct.DataAccess.Concrete.EntityFramework.Context;
using ShowProduct.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Business.Extensions.UserLogging
{
    public class UserLogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var request = filterContext.HttpContext.Request;
            UserLog audit = new UserLog()
            {
                UserName = (request.HttpContext.User.Identity.IsAuthenticated) ? filterContext.HttpContext.User.Identity.Name : "Anonymous",
                IPAddress = request.HttpContext.Connection.RemoteIpAddress?.ToString(),
                //IPAddress = UserIPAddress.FindUserIp(),
                Browser = request.HttpContext.Request.Headers["User-Agent"].ToString(),
                BrowserVersion = request.HttpContext.Request.Headers["User-Agent-Version"].ToString(),
                Language = request.HttpContext.Request.Headers["Accept-Language"].ToString(),
                AreaAccessed = request.HttpContext.Request.QueryString.ToUriComponent(),
                //Device = request.Browser.MobileDeviceManufacturer,
                //IsMobile = request.Browser.IsMobileDevice,
                //DeviceModel = request.Browser.MobileDeviceModel,
                //Platform = request.Browser.Platform,
                MacAddress = PCMacAddress.GetMACAddress(),
                CreatedDate = DateTime.Now
            };

            ApplicationDbContext context = new ApplicationDbContext();
            context.UserLogs.Add(audit);
            context.SaveChanges();
            base.OnActionExecuting(filterContext);
        }
    }
}
