using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Application.ViewModels
{
    public class TipoHistoriaViewModel
    {
        public TipoHistoriaViewModel()
        {
            CodTipoHistoria = Guid.NewGuid();
        }
        
        [Key]
        [Display(Name ="Cód. Tipo História")]
        public Guid CodTipoHistoria { get; set; }


        [ScaffoldColumn(false)]
        [Display(Name ="Data de Inclusão")]
        public DateTime DataInclusao { get; set; }


        [ScaffoldColumn(false)]
        [Display(Name ="Data de Edição")]
        public DateTime? DataEdicao { get; set; }


        [Required(ErrorMessage ="É ativo ou não?")]
        [Display(Name ="Ativo")]
        public bool Ativo { get; set; }


        [Required(ErrorMessage ="Um título é requerido.")]
        [MaxLength(400, ErrorMessage ="O limite máximo de {0} foi extrapolado.")]
        [MinLength(5, ErrorMessage ="O mínimo {0} não foi alcançado.")]
        [Display(Name ="Título")]
        public string Titulo { get; set; }


        [Required(ErrorMessage ="Uma descrição é requerida.")]
        [MaxLength(800, ErrorMessage ="O limite máximo de {0} foi extrapolado.")]
        [MinLength(5, ErrorMessage ="O mínimo de {0} não foi alcançado.")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
    }
}
