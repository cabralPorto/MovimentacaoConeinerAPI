using Dapper;
using Microsoft.EntityFrameworkCore;
using ProjetoAPICore.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoAPICore.Data.Repository
{
    public class DapperBaseRepository: IDapperBaseRepository
    {
        private readonly IDbConnection _connection;
        public DapperBaseRepository(DbContexto contexto)
        {
            _connection = contexto.Database.GetDbConnection();
        }

        public DapperBaseRepository(string conexao)
        {           
            _connection = new SqlConnection(conexao);
        }

        public IDbConnection ObterConexao() => _connection;

        /// <summary>
        /// Executa a consulta enviada como parametro (Verifica se a consulta obteve resultado)
        /// </summary>
        /// <returns>
        /// Retorna bool de acordo com o resultado (TRUE - Existe, FALSE - Nao)
        /// </returns>
        public async Task<bool> Existe(string consulta)
        {
            var resultado = await _connection.QueryFirstOrDefaultAsync<object>(consulta);

            return resultado != null;
        }
        /// <summary>
        /// Executa a consulta enviada como parametro (A consulta deve retornar apenas UMA linha)
        /// </summary>
        /// <returns>
        /// Retorna o objeto passado como parametro com o resultado da consulta.
        /// </returns>
        public async Task<TResultado> Obter<TResultado>(string consulta)
        {
            return await _connection.QueryFirstOrDefaultAsync<TResultado>(consulta);
        }
        /// <summary>
        /// Executa a consulta enviada como parametro (A consulta deve retornar varias linha) 
        /// </summary>
        /// <returns>
        /// Retorna um IEnumerable do objeto passado como parametro com o resultado da consulta.
        /// </returns>
        public async Task<IEnumerable<TResultado>> ObterLista<TResultado>(string consulta)
        {
            return await _connection.QueryAsync<TResultado>(consulta);
        }

        public async Task<DataTable> Obter(string consulta)
        {
            var dataTable = new DataTable();
            var dataReader = await _connection.ExecuteReaderAsync(consulta);

            dataTable.Load(dataReader);

            return dataTable;
        }

        public TResultado ObterSync<TResultado>(string consulta)
        {
            return _connection.QueryFirstOrDefault<TResultado>(consulta);
        }

        public IEnumerable<TResultado> ObterListaSync<TResultado>(string consulta)
        {
            return _connection.Query<TResultado>(consulta);
        }

        public bool ExisteSync(string consulta)
        {
            var resultado = _connection.QueryFirstOrDefault<object>(consulta);

            return resultado != null;
        }
    }
}
