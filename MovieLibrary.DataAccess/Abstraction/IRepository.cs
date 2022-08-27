namespace MovieLibrary.DataAccess.Abstraction
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        public void Add(T Entity);
        public void Update(T Entity);
        public void Delete(T Entity);
    }
}
