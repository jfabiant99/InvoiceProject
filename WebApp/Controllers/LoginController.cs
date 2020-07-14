using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Models.Request;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();

        }



        [HttpPost]
        public ActionResult Login(Login_Request user)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44378/api/Login/Post");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Login_Request>("Post", user);
                postTask.Wait();

                var result = postTask.Result;

                Console.WriteLine("RESULT", result);

                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(user);
        }
    }
}