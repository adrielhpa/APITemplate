using APITemplate.Domain;
using APITemplate.Domain.DTOs;
using APITemplate.Repository.Interfaces;

namespace APITemplate.Repository;

public class TemplateRepository : ITemplateRepository
{
    public TemplateDbContext _context { get; set; }

    public TemplateRepository(TemplateDbContext context)
    {
        _context = context;
    }

    public List<int> GetAll()
    { 
        var result = _context.List.ToList();
        return result;
    }

    public Template? GetById(int id)
    {
        //get Template by id from db and return it.
        return new Template();
    }

    public bool Create(Template templateDto)
    {
        //add in db and return a boolean as SaveChangesAsync > 0;
        return true;
    }

    public Template? Update(Template templateDto)
    {
        //update db and return the updated entity. If it has an error, return null.
        return new Template();
    }

    public bool Delete(int templateId)
    {
        //delete from db and return a boolean as SaveChangesAsync > 0;
        return true;
    }

}

