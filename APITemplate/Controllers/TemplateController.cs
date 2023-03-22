using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITemplate.Domain.DTOs;
using APITemplate.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APITemplate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemplateController : ControllerBase
    {
        public ITemplateService _templateService { get; set; }

        public TemplateController(ITemplateService templateService)
        {
            _templateService = templateService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _templateService.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("{templateId}")]
        public IActionResult GetById(int templateId)
        {
            try
            {
                var result = _templateService.GetById(templateId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost("new")]
        public IActionResult Create(TemplateDto templateDto)
        {
            try
            {
                var result = _templateService.Create(templateDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPut("update")]
        public IActionResult Update(TemplateDto templateDto)
        {
            try
            {
                var result = _templateService.Update(templateDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpDelete("{templateId}")]
        public IActionResult Delete(int templateId)
        {
            try
            {
                var result = _templateService.Delete(templateId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

