namespace GSL.Infra.Data.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}