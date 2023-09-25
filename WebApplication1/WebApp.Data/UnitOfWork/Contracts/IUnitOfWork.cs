namespace WebApp.Data.UnitOfWork.Contracts
{
    public interface IUnitOfWork
    {
        Task Complete();

    }
}
