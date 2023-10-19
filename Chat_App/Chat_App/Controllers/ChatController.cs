using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;


namespace Chat_App.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        [HttpGet]
        [EnableCors("AllowOrigin")]
        public ActionResult<string> Login(string uname, string pass)
        {
            if (CRUD_ADO.CRUD.chkValidity(uname, pass))
            {
                return "Login successful";
            }
            return "Username or password not found. Register to log in";
        }

        [HttpGet("AddUser")]
        [EnableCors("AllowOrigin")]
        public ActionResult<string> AddUser(string name, string uname, string pass)
        {
            if (CRUD_ADO.CRUD.AddUser(name, uname, pass))
            {
                return "User added successfully";
            }
            return "Failed to add user";
        }
        [HttpGet("SendMessage")]
        [EnableCors("AllowOrigin")]
        public ActionResult<string> SendMessage(string uname, string rname, string message)
        {
            string Message = CRUD_ADO.CRUD.SendMessage(uname, rname, message);
            return Message;
        }

        [HttpGet("Messages")]
        [EnableCors("AllowOrigin")]
        public ActionResult<List<(string,string)>>GetMessages(string uname)
        {

            var list = new List<(string,string)>();
            list = CRUD_ADO.CRUD.GetUserMessages(uname);
            return list;
        }
        [HttpGet("user")]
        [EnableCors("AllowOrigin")]
        public ActionResult<string> UserID(string uname)
        {
            return CRUD_ADO.CRUD.GetMessage(uname);
        }
    }
}
