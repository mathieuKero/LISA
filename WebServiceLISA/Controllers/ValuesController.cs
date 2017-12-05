using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebServiceLISA.Services;
using WebServiceLISA.Models;

namespace WebServiceLISA.Controllers
{
    [Route("api")]
    public class MainController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "Format is [api/register/{login}_{password}]|[api/{token}/{type}/{id?}]";
        }

        [HttpGet("register/{login}_{pass}")]
        public string Register(string login,string pass)
        {
            if (Auth.UserExists(login, pass))
            {
                if (Auth.IsValidPassword(login, pass))
                {
                    return "Your token is: " + Auth.GetToken(login, pass);
                }
                else
                {
                    return "This account already exists, please enter a valid password\n" +
                        "Format is register/{login}_{password}";
                }
            }
            else
            {
                User user = new User
                {
                    Username = login,
                    Name = login,
                    Password = pass
                };
                user.Save();

                return "A new account has been created:\n"
                    + "username: " + user.Username + "\n"
                    + "password: " + user.Password + "\n"
                    + "token: " + user.Token + "\n\n"
                    + "Please note this information somewhere";
            }
        }

        [HttpGet("{key}/{type}")]
        public string NoID(string key,string type)
        {
            if (Auth.IsValidToken(key))
            {

                return "<?xml version=\"1.0\" encoding=\"utf-8\"?";// XMLGenerator.GenerateProduct();
            }
            else
            {
                return "BAD TOKEN";
            }
        }

        [HttpGet("{key}/{type}/{id}")]
        public string WithID(string key,string type,int id)
        {
            if (Auth.IsValidToken(key))
            {

                return "YES + ID";// XMLGenerator.GenerateProduct();
            }
            else
            {
                return "BAD TOKEN";
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
