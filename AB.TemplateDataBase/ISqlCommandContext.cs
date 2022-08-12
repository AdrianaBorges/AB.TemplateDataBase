using System.Data.SqlClient;

namespace AB.TemplateDataBase
{
    public interface ISqlCommandContext
    {
        /// <summary>
        /// Commando SQL.
        /// </summary>
        string SQL { get; }

        /// <summary>
        /// Inclui os parâmetros do SQL no SqlCommand passado por parâmetro.
        /// </summary>
        /// <param name="command">SqlCommand</param>
        void AddParameters(SqlCommand command);
    }
}
