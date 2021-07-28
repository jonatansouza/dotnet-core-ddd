using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.UF;
using Api.Domain.interfaces.services.UF;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class UfService : IUfService
    {
        private readonly IMapper _mapper;
        private IUfRepository _repository;
        public UfService(IUfRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UfDto>> GetAll()
        {
            var entities = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UfDto>>(entities);
        }

        public async Task<UfDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<UfDto>(entity);
        }
    }
}
