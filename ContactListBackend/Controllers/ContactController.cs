using ContactListBackend.Models;
using ContactListBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactListBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private ContactServices _ContactService;

        public ContactController(ContactServices contactService)
        {
            _ContactService = contactService;
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int Id)
        {
            return Ok(_ContactService.GetContact(Id));
        }

        [HttpGet("GetAllContact")]

        public IActionResult GetAllContact()
        {
            return Ok(_ContactService.GetAllContact());
        }

        [HttpPost("SaveContact")]

        public IActionResult SaveContact(Contact contacts)
        {
            return Ok(_ContactService.SaveContact(contacts));
        }

        [HttpPut("UpdateContact")]

        public IActionResult UpdateContact(Contact contacts)
        {
            return Ok(_ContactService.UpdateContact(contacts));
        }

        [HttpDelete("DeleteContact")]

        public IActionResult DeleteContact(int id)
        {
            return Ok(_ContactService.DeleteContact(id));
        }
    }
}
