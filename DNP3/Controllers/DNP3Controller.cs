using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DNP3.Models;
using DNP3.Repo;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace DNP3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DNP3Controller : ControllerBase
    {
        private Repository _repository;

        public DNP3Controller(Repository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults()
        {
            try
            {
                IList<Adult> adults = await _repository.GetAdultsAsync();
                foreach (var adult in adults)
                {
                    Console.WriteLine(adult.ToString());
                }

                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("{id:int")]
        public async Task<ActionResult<Adult>> GetFilteredAdult([FromRoute] int id)
        {
            try
            {
                Adult adult = await _repository.GetFilteredAdultsAsync(id);
                return Ok(adult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Adult adultAsync = await _repository.AddAdultAsync(adult);
                return Created($"/{adultAsync.Id}", adultAsync);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task DeleteAdult([FromRoute] int id)
        {
            try
            {
                await _repository.RemoveAdultAsync(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
            
        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string username, [FromQuery] string password)
        {
            try
            {
                var user = await _repository.ValidateUser(username, password);
                Console.WriteLine(user.ToString());
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        }
    }