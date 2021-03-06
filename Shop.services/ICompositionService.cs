using Shop.entities; 

namespace Shop.services
{
    public interface ICompositionService : IGeneralService<Composition>
    {
        Composition GetByName(string name);
    }
}
