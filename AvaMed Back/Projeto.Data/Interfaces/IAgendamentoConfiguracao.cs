using Projeto.Data.Entidades;
using Projeto.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Interfaces
{
    public interface IAgendamentoConfiguracao
    {
        List<AgendamentoConfigDto> ListarTodos();
        AgendamentoConfigDto ListarPorId(int id);
        AgendamentoConfiguracao Criar(AgendamentoConfiguracaoCriarDto beneficiario);
        AgendamentoConfiguracao Editar(AgendamentoConfiguracaoEditarDto beneficiario);
        int Excluir(int Id);
    }
}
