using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication1.Controllers
{
    public class HomeController
    {
        public JsonResult SayHello()
        {
            var obj = new
            {
                firstname="Aysel",
                lastname="Abilova",
                age=21
            };
            JsonResult jsonResult = new JsonResult(obj);
            return jsonResult;
        }

        public ContentResult SayContentResult()
        {
            ContentResult contentResult = new ContentResult();

            contentResult.Content = "Hey you!";

            return contentResult;
        }

       public ViewResult ViewMethod()
        {
            ViewResult viewResult = new ViewResult();
            viewResult.ViewName = "Test";
            return viewResult;
        }



    }

}
