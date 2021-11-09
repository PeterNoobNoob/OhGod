using Principal.WeWatchDemo.Domain.ModelDtos;
using System.Collections.Generic;

namespace Principal.WeWatchDemo.Domain.Repository
{
    public interface IWeWatchRepo
    {
        List<ItemModel> GetAllItemModels();
        ItemModel GetItemModelDetail(int id);
        void CreateItemModel(ItemModel itemModel);
        List<ItemGridModel> GetAllItemGridModels();
    }
}