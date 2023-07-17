using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatform();
        Platform? GetPlatformById(int id);
        void CreatePlatform(Platform platform);
    }

    public interface IRepository<T>
    {
        bool Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
