using Projeto.Data.Dto;
using Projeto.Data.Entidades;
using Projeto.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositorio
{
    public class HospitalRepositorio : IHospitalRepositorio
    {
        private readonly Contexto.AvamedContext _contexto;

        public HospitalRepositorio(Contexto.AvamedContext contexto)
        {
            _contexto = contexto;
        }

        public int Atualizar(HospitalCadastrarDto hospitalCadastrarDto)
        {
            Entidades.Hospital  hospitalEntidadeBanco = 
               (from h in _contexto.Hospitals
                where h.IdHospital== hospitalCadastrarDto.IdHospital
                select h)
                .FirstOrDefault();

            if (hospitalEntidadeBanco== null)
            {
                return 0;
            }

            hospitalEntidadeBanco.Nome = hospitalCadastrarDto.Nome;
            hospitalEntidadeBanco.Cnpj = hospitalCadastrarDto.Cnpj;
            hospitalEntidadeBanco.Endereço = hospitalCadastrarDto.Endereço;
            hospitalEntidadeBanco.Telefone = hospitalCadastrarDto.Telefone;
            hospitalEntidadeBanco.Cnes = hospitalCadastrarDto.Telefone;
            hospitalEntidadeBanco.Ativo = hospitalCadastrarDto.Ativo;

            return _contexto.SaveChanges();

                throw new NotImplementedException();
        }

        public int Cadastrar(HospitalCadastrarDto hospitalCadastrarDto)
        {
            Entidades.Hospital hospitalEntidade = new Entidades.Hospital()
            {
                    Nome = hospitalCadastrarDto.Nome,
                    Cnpj = hospitalCadastrarDto.Cnpj,
                    Endereço = hospitalCadastrarDto.Endereço,
                    Telefone = hospitalCadastrarDto.Telefone,
                    Cnes = hospitalCadastrarDto.Telefone,
                    Ativo = hospitalCadastrarDto.Ativo          
            };

            _contexto.ChangeTracker.Clear();
            _contexto.Hospitals.Add(hospitalEntidade);
            return _contexto.SaveChanges();
            throw new NotImplementedException();
        }

        public int Excluir(int IdHospital)
        {
            Entidades.Hospital hospitalEntidade =
                (from h in _contexto.Hospitals
                 where h.IdHospital == IdHospital
                 select h).FirstOrDefault();

            if (hospitalEntidade == null || DBNull.Value.Equals(hospitalEntidade.IdHospital) || hospitalEntidade.IdHospital == 0)
            {
                return 0;
            }

            _contexto.ChangeTracker.Clear();
            _contexto.Hospitals.Remove(hospitalEntidade);
            return _contexto.SaveChanges();
            throw new NotImplementedException();
        }
        public HospitalDto ListarHospitalPorId(int IdHospital)
        {
            return (from h in _contexto.Hospitals
                    select new Dto.HospitalDto()
                    {   IdHospital = h.IdHospital,
                        Nome = h.Nome,
                        Cnpj = h.Cnpj,
                        Endereço = h.Endereço,
                        Telefone = h.Telefone,
                        Cnes = h.Telefone,
                        Ativo = h.Ativo

                    })?.FirstOrDefault()
                   ?? new HospitalDto();
            throw new NotImplementedException();
        }

        public List<HospitalDto> ListarHospitais()
        {
            return (from h in _contexto.Hospitals
                    select new Dto.HospitalDto()
                    {   
                        IdHospital = h.IdHospital,
                        Nome = h.Nome,
                        Cnpj = h.Cnpj,
                        Endereço = h.Endereço,
                        Telefone = h.Telefone,
                        Cnes = h.Telefone,
                        Ativo = h.Ativo
                    }).ToList();
            throw new NotImplementedException();
        }
    }
}
