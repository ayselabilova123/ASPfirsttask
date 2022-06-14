using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {
        private List<int> _numbers;
        public AboutController()
        {
            _numbers = new List<int>()
            {
                 3,4,5,6,7,56,100
            };
        }
        public ViewResult CheckMethod()
        {
            return new ViewResult();
        }

        public ViewResult GetNumber(int number)
        {
            var isExist = _numbers.Exists(n => n == number);
            if (isExist)
            {
                int myNumber = _numbers.Find(n => n == number);
                ViewData["Aysel"] = myNumber;
            }
            return new ViewResult();
        }

    }
}
