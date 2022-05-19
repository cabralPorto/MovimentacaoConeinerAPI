using Dapper;
using System.Data;

namespace ProjetoAPICore.Configuracoes
{
    public class TratamentoGuidString : SqlMapper.TypeHandler<Guid>
    {
        public override void SetValue(IDbDataParameter parameter, Guid guid)
        {
            parameter.Value = guid.ToString();
        }

        public override Guid Parse(object value)
        {
            return new Guid((string)value);
        }
    }
}
