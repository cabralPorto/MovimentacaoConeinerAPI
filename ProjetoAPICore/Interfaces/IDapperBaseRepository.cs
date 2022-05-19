using System.Data;

namespace ProjetoAPICore.Interfaces
{
    public interface IDapperBaseRepository
    {
        /// <summary>
        /// Executa a consulta enviada como parametro (A consulta deve retornar apenas UMA linha)
        /// </summary>
        /// <returns>
        /// Retorna o objeto passado como parametro com o resultado da consulta.
        /// </returns>
        Task<TResultado> Obter<TResultado>(string consulta);
        /// <summary>
        /// Executa a consulta enviada como parametro (A consulta deve retornar varias linha) 
        /// </summary>
        /// <returns>
        /// Retorna um IEnumerable do objeto passado como parametro com o resultado da consulta.
        /// </returns>
        Task<IEnumerable<TResultado>> ObterLista<TResultado>(string consulta);
        /// <summary>
        /// Executa a consulta enviada como parametro (Verifica se a consulta obteve resultado)
        /// </summary>
        /// <returns>
        /// Retorna bool de acordo com o resultado (TRUE - Existe, FALSE - Nao)
        /// </returns>
        Task<bool> Existe(string consulta);

        Task<DataTable> Obter(string consulta);

        IDbConnection ObterConexao();
    }
}
