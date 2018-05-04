using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Domain.Entities
{
    public class TipoHistoria
    {
        public TipoHistoria()
        {
            CodTipoHistoria = Guid.NewGuid();
        }
        public Guid CodTipoHistoria { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataEdicao { get; set; }
        public bool Ativo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
