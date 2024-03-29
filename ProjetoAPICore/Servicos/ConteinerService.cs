﻿using ProjetoAPICore.Dtos;
using ProjetoAPICore.Dtos.Interfaces;
using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Servicos
{
    public class ConteinerService : IConteinerService
    {
        private readonly IConteinerRepository _conteinerRepository;

        public ConteinerService(IConteinerRepository conteinerRepository)
        {
            _conteinerRepository = conteinerRepository;
        }
        public ConteinerDto? CriarConteiner(ConteinerDto conteinerDto)
        {
            var conteiner = _conteinerRepository.ObterConteinerPorId(conteinerDto.Id);
            if (conteiner != null)
                return null;

            conteiner = CriarEntidadeConteiner(conteinerDto);

            _conteinerRepository.CriarConteiner(conteiner);

            return conteinerDto;
        }

        public IEnumerable<Conteiner> ObterConteiners()
        {
            return _conteinerRepository.ObterConteiners();
        }

        public Conteiner ObterConteinerPorNome(String nome)
        {
            return _conteinerRepository.ObterConteinerPorNome(nome);
        }

        public ConteinerDto? AlterarConteiner(ConteinerDto conteinerDto)
        {
            var conteiner = _conteinerRepository.ObterConteinerPorId(conteinerDto.Id);
            if (conteiner == null)
                return null;

            conteiner.Numero = conteinerDto.Numero;
            conteiner.Tipo = conteinerDto.Tipo;
            conteiner.DataAlteracao = DateTime.Now;

            _conteinerRepository.AlterarConteiner(conteiner);
            return conteinerDto;
        }

        private Conteiner CriarEntidadeConteiner(ConteinerDto conteinerDto)
        {
            return new Conteiner
            {
                Numero = conteinerDto.Numero,
                Tipo = conteinerDto.Tipo,
                DataCriacao = DateTime.Now

            };

        }
    }
}
