namespace Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        Task Save();
    }
}
