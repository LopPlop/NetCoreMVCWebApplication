namespace StartUpNETCoreProject.Database.Tables.TableHandlers
{
    public interface ITableHandler<T> where T : class
    {
        T? GetById(int id);
        T? GetByName(string name);
        IQueryable<T>? GetAll();
        bool Save(T entity);
        bool Delete(T entity);
    }
}
