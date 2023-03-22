using APITemplate.Domain;
using APITemplate.Domain.DTOs;
using APITemplate.Repository.Interfaces;
using APITemplate.Service.Interfaces;
using AutoMapper;

namespace APITemplate.Service;

public class TemplateService : ITemplateService
{
    private IMapper _mapper;
    public ITemplateRepository _templateRepository { get; set; }

    public TemplateService(ITemplateRepository templateRepository, IMapper mapper)
    {
        _templateRepository = templateRepository;
        _mapper = mapper;
    }

    public List<int> GetAll()
    {
        var result = _templateRepository.GetAll();
        return result;
    }

    public bool Create(TemplateDto templateDto)
    {
        var template = _mapper.Map<Template>(templateDto);

        var result = _templateRepository.Create(template);

        if (!result) throw new Exception();

        return result;
    }

    public TemplateDto Update(TemplateDto templateDto)
    {
        if (templateDto.Id == 0) throw new Exception();

        var template = _templateRepository.GetById(templateDto.Id);

        if (template is null) throw new Exception();

        //template.someProp = templateDto.someProop;
        //template.someProp = templateDto.someProop;
        //template.someProp = templateDto.someProop;
        //template.someProp = templateDto.someProop;
        //template.someProp = templateDto.someProop;

        var result = _templateRepository.Update(template);

        if (result is null) throw new Exception();

        return _mapper.Map<TemplateDto>(result);
    }

    public bool Delete(int templateId)
    {
        if (templateId == 0) throw new Exception();

        var result = _templateRepository.Delete(templateId);
        return result;
    }
}

