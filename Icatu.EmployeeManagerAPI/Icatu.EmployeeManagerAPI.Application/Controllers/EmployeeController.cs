using Icatu.EmployeeManagerAPI.Domain.Entities;
using Icatu.EmployeeManagerAPI.Service.Services;
using Icatu.EmployeeManagerAPI.Service.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Icatu.EmployeeManagerAPI.Application.Controllers
{
    [Route("api/employees")]
    [ApiController]

    public class EmployeeController:ControllerBase
    {
        private BaseService<Employee> service = new BaseService<Employee>();

        // GET api/values
        [HttpGet("{page_size}/{page}")]
        public IActionResult GetAll(int page_size = 10, int page = 1)
        {
            try
            {
                var result = service.Get();

                int totalPaginas = (int)Math.Ceiling(result.Count() / Convert.ToDecimal(page_size));

                if (totalPaginas >= page)
                {
                    var paginacao = result.OrderBy(x => x.Id).Skip(page_size * (page - 1)).Take(page_size);
                    return new ObjectResult(paginacao);
                }
                else
                {
                    return new ObjectResult(result);
                }

            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET api/values/5
        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var result = service.Get(id);

                return new ObjectResult(result);

            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            try
            {
                service.Post<EmployeeValidator>(employee);

                return new ObjectResult(employee);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/values/5
        [HttpPut("id")]
        public IActionResult Put(Guid id, [FromBody] Employee employee)
        {
            try
            {
                var result = service.Put<EmployeeValidator>(employee);

                return new ObjectResult(result);

            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        // DELETE api/values/5
        [HttpDelete("id")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                service.Delete(id);

                return new ObjectResult(HttpStatusCode.OK);

            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
