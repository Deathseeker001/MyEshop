using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyEshop.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        public string Test1()
        {
            return "Test 1";
        }

        public string Test2()
        {
            return "Test 2";
           
        }
    }
}
