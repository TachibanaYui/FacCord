// Generated by struct?.GetType() simple repo parttern generator!
using IsekaiTechnologies.FacCord.Core.Models.Mines;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsekaiTechnologies.FacCord.Core.DAL.Repositories.Mines
{
    public interface IDimensionRepository : IRepository<Dimension>
    {
        IAsyncEnumerable<Dimension> GetAllWidthPossibleResourcesAsync();
    }
}
