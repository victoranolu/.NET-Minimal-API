using SixMinAPI.Models;

namespace SixMinAPI.Data 
{
    public interface 
    {
        Task SaveChanges();
        Task <Command?> GetCommandbyId(int id);
        Task <IEnumerable<Command>> GetAllCommands();
        Task CreateCommand(Command cmd);

        void DeleteCommand(Command cmd);
    }
}