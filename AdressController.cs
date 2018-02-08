using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using core_projects.Models;
using core_projects.Repositories;
 
namespace core_projects.Controllers
{
    public class AdressController : Controller
    {
        [HttpGet("Adress/get/{id}")]
        public Adress GetAdress(int id)
        {
            return AdressRepository.GetById(id);
        }
 
        [HttpGet("adress/remove")]
        public string RemoveAdress()
        {
            AdressRepository.Remove();
            return "Last Adress remove. Total count: "
                        + AdressRepository.GetCount();
        }
 
        [HttpGet("adress/all")]
        public List<Adress> GetAdresss()
        {
            return AdressRepository.GetAll();
        }
 
        [HttpPost("adress/save")]
        public string AddAdress([FromBody]Adress Adress)
        {
            return AdressRepository.Save(Adress);
        }
    }
}