using System.Threading.Tasks;

namespace WebAPITest.Commands.Abstract
{
    public interface IMyDependency
    {
        Task WriteUserRecordsAsync();

        Task WriteReservetionRecordsAsync();
    }
}
