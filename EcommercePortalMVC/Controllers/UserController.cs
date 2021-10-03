using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Login()
        {
            return View();
        }



        public IActionResult Logout()
        {
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
                    return RedirectToAction("Login", "User");
                }
            }
            return RedirectToAction("Login", "User");

        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {

           if(user.Email!=null && user.Password!=null)
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
                            Response.Cookies.Append("token", result, new Microsoft.AspNetCore.Http.CookieOptions
                            {
                                HttpOnly = true,

                            });
                        var handler = new JwtSecurityTokenHandler();
                        var jwtSecurityToken = handler.ReadJwtToken(result);
                        int id = int.Parse(jwtSecurityToken.Claims.First().Value);
                        return RedirectToAction("GetProducts", "Products");
                    }
                    else
                    {
                        TempData["error"] = result;
                        if (response.ReasonPhrase.Equals("Not Found"))
                        {
                            ModelState.AddModelError("Email", result);
                            return View(user);
                        }
                        else
                        {
                            ModelState.AddModelError("Password", result);
                            return View(user);
                        }
                        
                    }
                    //It would be better to make sure this request actually made it through
                    
                  
                }
                
            }
            else
            {
                return View(user);
            }
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(User user)
        {
            
            if(!ModelState.IsValid)
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
                        return RedirectToAction("Login", "User");
                    }
                    else
                    {
                        if (response.ReasonPhrase.Equals("Not Found"))
                        {
                            ModelState.AddModelError("Email", "email already exits please login");
                            return View(user);
                        }
                        return View(user);
                    }
                    //It would be better to make sure this request actually made it through


                }
                
            }
        }

    }
}
