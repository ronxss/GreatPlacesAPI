using GreatPlaces.Application.Dto;
using GreatPlaces.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GreatPlaces.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AttractionsController : Controller
    {
        private readonly IApplicationServiceAttractions _applicationServiceAttractions;


        public AttractionsController(IApplicationServiceAttractions applicationServiceAttractions)
        {
            _applicationServiceAttractions = applicationServiceAttractions;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceAttractions.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceAttractions.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] AttractionsDto attractionsDTO)
        {
            try
            {
                if (attractionsDTO == null)
                    return NotFound();

                _applicationServiceAttractions.Add(attractionsDTO);
                return Ok("Ponto turístico Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] AttractionsDto attractionsDTO)
        {
            try
            {
                if (attractionsDTO == null)
                    return NotFound();

                _applicationServiceAttractions.Update(attractionsDTO);
                return Ok("Ponto turístico Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] AttractionsDto attractionsDTO)
        {
            try
            {
                if (attractionsDTO == null)
                    return NotFound();

                _applicationServiceAttractions.Update(attractionsDTO);
                return Ok("Ponto turístico Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

