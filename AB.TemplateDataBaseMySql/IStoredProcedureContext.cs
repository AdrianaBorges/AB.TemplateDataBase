using MySql.Data.MySqlClient;

namespace AB.TemplateDataBaseMySql
{
    public interface IStoredProcedureContext
    {
        /// <summary>
        /// Nome da Stored Procedure.
        /// </summary>
        string NAME { get; }

        /// <summary>
        /// Inclui os parâmetros da Stored Procedure no SqlCommand passado por parâmetro.
        /// </summary>
        /// <param name="command">SqlCommand</param>
        void AddParameters(MySqlCommand command);
    }
}
