using System.Collections.Generic;

namespace FinanceDashboardBackend.Services
{
    interface IService<T>
    {
        public T Create(T obj);
        public bool Delete(int id);
        public T Edit(T obj);
        public List<T> GetAll();
        public T GetOne(int id);
    }
}