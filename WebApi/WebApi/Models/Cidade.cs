using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Cidade
    {   [Key]
        public int cod_cidade { get; set; }
        [Required]
        [StringLength(100,ErrorMessage ="Tamanho Invalido", MinimumLength =5)]
        public string nome_cidade { get; set; }
        [StringLength(2, ErrorMessage = "Tamanho Invalido", MinimumLength = 2)]
        public string uf_cidade { get; set; }
        [StringLength(8, ErrorMessage = "Tamanho Invalido", MinimumLength =8 )]
        public string cep_cidade { get; set; }

    }
}