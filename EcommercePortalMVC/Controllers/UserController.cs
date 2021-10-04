using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(UserController));
        public IActionResult Login()
        {
            _log4net.Info("login Successful");
            return View();
        }



        public IActionResult Logout()
        {
            _log4net.Info("logger initiated");
            string url = String.Format("https://localhost:44380/User/Logout");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var responseTask = client.GetAsync("");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var result1 = result.Content.ReadAsStringAsync().Result;
                    Response.Cookies.Delete("token");
                    _log4net.Info("Token Deleted");
                    return RedirectToAction("Login", "User");
                }
            }
            _log4net.Info("User login Successfully");
            return RedirectToAction("Login", "User");

        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            _log4net.Info("logger initiated");
            if (user.Email!=null && user.Password!=null)
            {
                using (var client = new HttpClient())
                {

                    string json = JsonConvert.SerializeObject(user);

                    //Needed to setup the body of the request
                    StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                    
                    //The url to post to.
                    var url = "https://localhost:44380/User/Login";
                    var client1 = new HttpClient();

                    //Pass in the full URL and the json string content
                    var response = await client.PostAsync(url, data);
                    string result = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        _log4net.Info("Token Appended Successfully");
                        Response.Cookies.Append("token", result, new Microsoft.AspNetCore.Http.CookieOptions
                            {
                                HttpOnly = true,

                            });
                       
                        return RedirectToAction("GetProducts", "Products");
                    }
                    else
                    {
                        TempData["error"] = result;
                        if (response.ReasonPhrase.Equals("Not Found"))
                        {
                            
                            ModelState.AddModelError("Email", result);
                            _log4net.Error("Email is incorrect");
                            return View(user);
                        }
                        else
                        {
                            ModelState.AddModelError("Password", result);
                            _log4net.Error("Password is incorrect");
                            return View(user);
                        }
                        
                    }
                    //It would be better to make sure this request actually made it through
                    
                  
                }
                
            }
            else
            {
                _log4net.Info("Email and Password are correct");
                return View(user);
            }
        }

        public IActionResult Signup()
        {
            _log4net.Info("Signup initiated");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(User user)
        {

            _log4net.Info("logger initiated");
            if (!ModelState.IsValid)
            {

                return View(user);
            }
            else
            {
                using (var client = new HttpClient())
                {

                    string json = JsonConvert.SerializeObject(user);

                    //Needed to setup the body of the request
                    StringContent data = new StringContent(json, Encoding.UTF8, "application/json");


                    //The url to post to.
                    var url = "https://localhost:44380/User/SignUp";
                    var client1 = new HttpClient();

                    //Pass in the full URL and the json string content
                    var response = await client.PostAsync(url, data);
                    string result = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        _log4net.Info("Login after Signedup");
                        return RedirectToAction("Login", "User");
                    }
                    else
                    {
                        if (response.ReasonPhrase.Equals("Not Found"))
                        {
                            ModelState.AddModelError("Email", "email already exits please login");
                            _log4net.Error("email already exits please login");
                            return View(user);
                        }
                        _log4net.Info("Displaying User Account after Succesful login");
                        return View(user);
                    }
                    //It would be better to make sure this request actually made it through


                }
                
            }
        }

    }
}
