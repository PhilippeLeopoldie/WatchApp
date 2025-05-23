using WhatchApp.Web.Models;

namespace WhatchApp.Web.Services;

public interface IService
{

    public IEnumerable<Watch> GetAll();

    public Watch? GetById(int id);

    public void Add(Watch watch);
}
