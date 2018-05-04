using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Application.ViewModels
{
    public class HistoriaViewModel
    {
        public HistoriaViewModel()
        {
            CodHistoria = Guid.NewGuid();
            TipoHistoria = new TipoHistoriaViewModel();
        }

        [Key]
        [Display(Name ="Cód. História")]
        public Guid CodHistoria { get; set; }
        

        [ScaffoldColumn(false)]
        [Display(Name ="Data de Inclusão")]
        public DateTime DataInclusao { get; set; }


        [ScaffoldColumn(false)]
        [Display(Name ="Data de Edição")]
        public DateTime DataEdicao { get; set; }


        [Required(ErrorMessage ="É ativo ou não?")]
        [Display(Name ="Ativo")]
        public bool Ativo { get; set; }


        [Required(ErrorMessage ="Um título é preciso.")]
        [MaxLength(400, ErrorMessage ="O limite máixmo de {0} foi extrapolado no título.")]
        [MinLength(5, ErrorMessage ="O mínimo de {0} não foi alcançado.")]
        [Display(Name ="Título")]
        public string Titulo { get; set; }


        [Required(ErrorMessage ="Uma descrição é requerida.")]
        [MinLength(10, ErrorMessage ="É preciso mais do que {0} na descrição.")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }


        [Required(ErrorMessage ="Informe o Tipo de História.")]
        [Display(Name ="Cód. Tipo História")]
        public Guid CodTipoHistoria { get; set; }
        
        public TipoHistoriaViewModel TipoHistoria { get; set; }

    }
}
