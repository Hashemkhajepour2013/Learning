using WebApp.Data.UnitOfWork.Contracts;

namespace WebApp.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }
    }
}
