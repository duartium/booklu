using booklu.api.Core.Application.Enums;
using booklu.api.Core.Application.Interfaces.IApplication;
using booklu.api.Infraestructure.Persistence;
using System.Data;

namespace booklu.api.Infraestructure.Factories
{
    public class DatabaseFactory
    {
       public IDatabaseAdapter GetDatabaseAdapter(DBEngine dBEngine)
        {
            switch (dBEngine)
            {
                
                case DBEngine.PostgreSql:
                    return new PostgreSqlAdapter();
                case DBEngine.Default:
                case DBEngine.MsSql:
                default:
                    return new MsSqlAdapter();
            }
        }
    }
}
