using Microsoft.EntityFrameworkCore;

namespace StartUpNETCoreProject.Database.Tables.TableHandlers
{
    public class LoggingHandler : ITableHandler<Logging>
    {
        AppDBContext? dbContext;

        public LoggingHandler(AppDBContext dbcont)
        {
            dbContext = dbcont;
        }

        public IQueryable<Logging>? GetAll()
        {
            return dbContext.Loggings.OrderBy(x => x.Login);
        }

        public Logging GetById(int id)
        {
            return dbContext.Loggings.Single(x => x.Id == id);
        }

        public Logging GetByName(string login)
        {
            return dbContext.Loggings.Single(x => x.Login == login);
        }

        public bool Save(Logging entity)
        {
            if (entity.Id == default)
                dbContext.Entry(entity).State = EntityState.Added;
            else
                dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.SaveChanges();
            return true;
        }
        public bool Delete(Logging entity)
        {
            dbContext.Loggings.Remove(entity);
            dbContext.SaveChanges();
            return true;
        }
    }
}
