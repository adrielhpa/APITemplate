using System;
using APITemplate.Domain;
using APITemplate.Domain.DTOs;

namespace APITemplate.Service.Interfaces
{
	public interface ITemplateService
	{
		List<int> GetAll();
		bool Create(TemplateDto templateDto);
        TemplateDto Update(TemplateDto templateDto);
		bool Delete(int templateId);
	}
}

