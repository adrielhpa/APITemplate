using System;
using APITemplate.Domain;
using APITemplate.Domain.DTOs;

namespace APITemplate.Repository.Interfaces
{
	public interface ITemplateRepository
	{
		List<int> GetAll();
        Template? GetById(int id);
        bool Create(Template templateDto);
        Template? Update(Template templateDto);
        bool Delete(int templateId);
    }
}

