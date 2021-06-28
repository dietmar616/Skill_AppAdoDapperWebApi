using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using DAL.Data;
using DAL.Interfaces;

namespace DAL.Repositories

{

    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

       
        public async Task DeleteById(int id)
        {
            var entityToDelete = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(entityToDelete);
            await _context.SaveChangesAsync();
        }


        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
      
        
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        





        /*public async Task<TEntity> Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            await _context.SaveChangesAsync();
            return obj;
        }*/

    }
}








/*
 using DAL.Interfaces;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace DAL.Repositories
{
    public class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        protected IConnectionFactory _connectionFactory;
        private readonly string _tableName;
        private readonly bool _isSoftDelete;

        public GenericRepository(IConnectionFactory connectionFactory, string tableName, bool isSoftDelete)
        {
            _connectionFactory = connectionFactory;
            _tableName = tableName;
            _isSoftDelete = isSoftDelete;
        }

        public int Add(TEntity entity)
        {
            var columns = GetColumns();
            var stringOfColumns = string.Join(", ", columns);
            var stringOfProperties = string.Join(", ", columns.Select(e => "@" + e));
            var query = "SP_InsertRecordToTable";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                var InsertionStatement = db.Query<string>(
                    sql: query,
                    param: new { P_tableName = _tableName, P_columnsString = stringOfColumns, P_propertiesString = stringOfProperties },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();

                var InsertedEntityId = db.Execute(
                    sql: InsertionStatement,
                    param: entity,
                    commandType: CommandType.Text);

                return InsertedEntityId;
            }
        }

        public void Update(TEntity entity)
        {
            var columns = GetColumns();
            var stringOfColumns = string.Join(", ", columns.Select(e => $"{e} = @{e}"));
            
            using (var db = _connectionFactory.GetSqlConnection)
            {
                var query = "SP_UpdateRecordInTable";

                var UpdateStatement = db.Query<string>(
                    sql: query,
                    param: new { P_tableName = _tableName, P_columnsString = stringOfColumns, P_Id = entity.Id },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();

                db.Execute(
                    sql: UpdateStatement,
                    param: entity,
                    commandType: CommandType.Text);
            }
        }

        public void Delete(TEntity entity)
        {
            if (_isSoftDelete) // applying soft delete
            {
                var columns = GetColumns();
                var isActiveColumnUpdateString = columns.Where(e => e == "IsActive").Select(e => $"{e} = 0").FirstOrDefault();

                using (var db = _connectionFactory.GetSqlConnection)
                {
                    var query = "SP_UnActivateRecordInTable";

                    var UnActivateStatement = db.Query<string>(
                        sql: query,
                        param: new { P_tableName = _tableName, P_columnsString = isActiveColumnUpdateString, P_Id = entity.Id },
                        commandType: CommandType.StoredProcedure).FirstOrDefault();

                    db.Execute(
                        sql: UnActivateStatement,
                        param: entity,
                        commandType: CommandType.Text);
                }
            }
            else // delete directly
            {
                using (var db = _connectionFactory.GetSqlConnection)
                {
                    var query = "SP_DeleteRecordFromTable";
                    var result = db.Execute(
                        sql: query,
                        param: new { P_tableName = _tableName, P_Id = entity.Id },
                        commandType: CommandType.StoredProcedure);
                }
            }
        }

        public TEntity Get(TId Id)
        {

            var query = "SP_GetRecordByIdFromTable";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                return db.Query<TEntity>(query,
                    new { P_tableName = _tableName, P_Id = Id },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            var query = "SP_GetAllRecordsFromTable";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                return db.Query<TEntity>(query,
                    new { P_tableName = _tableName },
                    commandType: CommandType.StoredProcedure);
            }
        }

        private IEnumerable<string> GetColumns()
        {
            return typeof(TEntity)
                    .GetProperties()
                    .Where(e => e.Name != "Id" && !e.PropertyType.GetTypeInfo().IsGenericType)
                    .Select(e => e.Name);
        }
    }
}
*/