using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstacaoRecargaDDD.Dominio.Entidades
{
    public class EstacaoRecarga
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public double Longitude { get; set; }
    }
}
