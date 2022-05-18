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
        public MovimentacaoDto? CriarMovimentacao(MovimentacaoDto movimentacaoDto)
        {
            var movimentacao = _movimentacaoRepository.ObterMovimentacaoPorId(movimentacaoDto.Id);
            if (movimentacao == null)
                return null;

            movimentacao = CriarEntidadeMovimentacao(movimentacaoDto);
            _movimentacaoRepository.IncluirMovimentacao(movimentacao);

            return movimentacaoDto;
        }

        public IEnumerable<Movimentacao> ObterMovimentacoes()
        {
            return _movimentacaoRepository.ObterMovimentacoes();
        }

        private static Movimentacao CriarEntidadeMovimentacao(MovimentacaoDto movimentacaoDto)
        {
            return new Movimentacao
            {
                IdCliente = movimentacaoDto.IdCliente,
                IdTipoMovimentacao = movimentacaoDto.IdTipoMovimentacao,
                IdPassagemConteiner = movimentacaoDto.IdPassagemConteiner,
                DataCriacao = DateTime.Now

            };
        }
    }
}
