using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Data.Servicos
{
    public class MovimentacaoService : IMovimentacaoService
    {
        private readonly IMovimentacaoRepository _movimentacaoRepository;
        public MovimentacaoService(IMovimentacaoRepository movimentacaoRepository)
        {
            _movimentacaoRepository = movimentacaoRepository;
        }
        public MovimentacaoDto? IncluirMovimentacao(MovimentacaoDto movimentacaoDto)
        {
            var movimentacao = _movimentacaoRepository.ObterMovimentacaoPorId(movimentacaoDto.Id);
            if (movimentacao != null)
                return null;

            movimentacao = CriarEntidadeMovimentacao(movimentacaoDto);
            _movimentacaoRepository.IncluirMovimentacao(movimentacao);

            return movimentacaoDto;
        }

        public IEnumerable<Movimentacao> ObterMovimentacao()
        {
            return _movimentacaoRepository.ObterMovimentacao();
        }

        private static Movimentacao CriarEntidadeMovimentacao(MovimentacaoDto movimentacaoDto)
        {
            return new Movimentacao
            {
                IdCliente = movimentacaoDto.IdCliente,
                IdTipoMovimentacao = movimentacaoDto.IdTipoMovimentacao,
                IdPassagemConteiner = movimentacaoDto.IdPassagemConteiner,
                DataCriacao = DateTime.Now,
                DataHoraInicial = DateTime.Now,
                PauNaCara = movimentacaoDto.PauNaCara
                

            };
        }
    }
}
