using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Dto
{
    public class AgendamentoConfiguracaoEditarDto
    {
        public int IdConfiguracao { get; set; }
        public int IdHospital { get; set; }
        public int IdEspecialidade { get; set; }
        public int IdProfissional { get; set; }
        public DateTime DataHoraInicioAtendimento { get; set; }
        public DateTime DataHoraFinalAtendimento { get; set; }
    }
}
