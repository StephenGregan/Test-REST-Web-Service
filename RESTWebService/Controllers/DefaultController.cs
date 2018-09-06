using RESTWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTWebService.Controllers
{
    // Web API 2 Controller with read / write actions
    // This class inherites from the ApiController
    public class DefaultController : ApiController
    {
        // GET: api/Default
        // Return type UserInfo
        public IEnumerable<UserInfo> Get()
        {
            // Declare a List of type UserInfo
            var userInfoList = new List<UserInfo>();
            // Create 10 entries.
            for (int i = 0; i < 10; i++)
            {
                // Create an instance of UserInfo
                var userInfo = new UserInfo
                {
                    Location = $"Location: {i}",
                    Degree = i * 23 / 5,
                    DateTime = DateTime.Now.ToUniversalTime()
                };

                // Add info to userInfoList
                userInfoList.Add(userInfo);
            }
            // Then return the List
            return userInfoList;
        }

        // NuGet Package Swashbucke was added to see what is going on and how you can
        // benefit from using it.
        // GET: api/Default/5
        public UserInfo Get(int id)
        {
            return new UserInfo
            {
                Location = $"Location: {id}",
                Degree = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()
            };
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
