using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskCollaborationSystem.ConsoleApp.Entities;
using TaskCollaborationSystem.ConsoleApp.Managers;
using TaskCollaborationSystem.ConsoleApp.Managers.Interface;

namespace ApplePie.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        static IManager<Member> manager = new Manager<Member>();

        [HttpPost]
        public string Add(Member obj)
        {
            return manager.Add(obj);
        }

        [HttpGet]
        public List<Member> GetAll()
        {
            return manager.View();
        }

        [HttpGet]
        public string Delete(string objName)
        {
            return manager.Remove(objName);
        }

        [HttpPost]
        public string Update(string objName, Member updatedObj)
        {
            return manager.Update(objName, updatedObj);
        }
    }
}
