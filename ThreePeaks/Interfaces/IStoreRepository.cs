

using ThreePeaks.Models;

namespace ThreePeaks.Interfaces
{
    public interface IStoreRepository
    {
         IEnumerable<StoreModel> GetStoreList();
         void ImportData(IFormFile excelFile);   
    }
}
