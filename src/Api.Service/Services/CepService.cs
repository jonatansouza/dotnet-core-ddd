using System;
using System.Threading.Tasks;
using Api.Domain.Dtos.Cep;
using Api.Domain.Entities;
using Api.Domain.interfaces.services.Cep;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class CepService : ICepService
    {
        private readonly IMapper _mapper;
        private ICepRepository _repository;

        public CepService(ICepRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CepDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<CepDto>(entity);
        }

        public async Task<CepDto> Get(string cep)
        {
            var entity = await _repository.SelectAsync(cep);
            return _mapper.Map<CepDto>(entity);
        }

        public async Task<CepDtoCreateResult> Post(CepDtoCreate cep)
        {
            var model = _mapper.Map<CepModel>(cep);
            var entity = _mapper.Map<CepEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<CepDtoCreateResult>(result);
        }

        public async Task<CepDtoUpdateResult> Put(CepDtoUpdate cep)
        {

            var model = _mapper.Map<CepModel>(cep);
            var entity = _mapper.Map<CepEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<CepDtoUpdateResult>(result);
        }
    }
}