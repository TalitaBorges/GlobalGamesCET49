﻿using System.ComponentModel.DataAnnotations;

namespace GlobalGamesCet49.Dados.Entidades
{
    public class Jogador : IEntity
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Morada { get; set; }

        public string Localidade { get; set; }

        [Display(Name = "Cartão Cidadão")]
        public string CartaoCidadao { get; set; }

        [Display(Name = "Data de Nascimento")]
        public string DataNascimento { get; set; }

        [Display(Name = "Image")]
        public string ImageURL { get; set; }
    }
}
