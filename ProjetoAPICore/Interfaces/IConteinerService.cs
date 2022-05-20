﻿using ProjetoAPICore.Modelos;
namespace ProjetoAPICore.Dtos.Interfaces
{
    public interface IConteinerService
    {
        ConteinerDto? IncluirConteiner(ConteinerDto conteinerDto);

        IEnumerable<Conteiner> ObterConteiner();

        Conteiner ObterConteinerPorNome(String numero);

        ConteinerDto AlterarConteiner(ConteinerDto conteinerDto);
        


    }
}
