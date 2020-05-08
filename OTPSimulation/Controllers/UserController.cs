using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OtpNet;
using OTPSimulation.Database;
using OTPSimulation.Database.Enitities;

namespace OTPSimulation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DatabaseContext db;
        public UserController()
        {
            db = new DatabaseContext();
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetUser")]
        public User GetUser(int id)
        {
            return db.Users.Find(id);
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User usermdl)
        {
            try
            {
                //string OTP  = GenerateOTP(db.Users.ToList().Count);
               
                db.Users.Add(usermdl);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, usermdl);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        private string GenerateOTP(int id)
        {
            Hotp hotp = new Hotp(Base32Encoding.ToBytes("CouriersPlease"), hotpSize: 6);

            return hotp.ComputeHOTP(id);

        }
    }
}
