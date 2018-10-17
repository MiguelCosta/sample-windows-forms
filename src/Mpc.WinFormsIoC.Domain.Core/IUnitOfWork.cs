namespace Mpc.WinFormsIoC.Domain.Core
{
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Domain.Core.Repositories;

    public interface IUnitOfWork
    {
        IUsersRepository UsersRepository { get; }

        Task SaveChangesAsync();
    }
}
