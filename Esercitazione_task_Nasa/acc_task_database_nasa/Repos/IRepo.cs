﻿namespace acc_task_database_nasa.Repos
{
    public interface IRepo<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(int id);

    }
}
