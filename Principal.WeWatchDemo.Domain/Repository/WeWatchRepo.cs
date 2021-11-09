using Principal.WeWatchDemo.Domain.ModelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Principal.WeWatchDemo.Domain.Repository
{
    public class WeWatchRepo : IWeWatchRepo
    {

        List<ItemModel> listItemModels = new List<ItemModel>
        {
            new ItemModel
            {
                Id = 1,
                OwnerId = 1,
                DateOfEvent = DateTime.Now,
                Latitude = 40.741895,
                Longitude = -73.989308,
                Title = "Car crash into tree",
                Description = "I crashed into tree with my car.",
                Created = DateTime.Now,
                Updated = DateTime.Now,

                Type = ModelDtos.Enums.IncidentTypes.CarAccident,
                IsClosed = false,
                IsOwnerVictim = true,
                IsIncident = true,
                IncidentId = null,
                Medias = new List<MediasDto>
                {
                    new MediasDto
                    {
                        Id = 1,
                        Name = "Obrázok stromu",
                        BlobFileAddress = "https://upload.travelawaits.com/ta/uploads/2021/04/e42a03187099bd58a4db67edbac89e42a03-800x800.jpg",
                        Created = DateTime.Now,
                    },
                                        new MediasDto
                    {
                        Id = 2,
                        Name = "Obrázok auta",
                        BlobFileAddress = "https://www.funny-jokes.com/fun_pictures/car_cinque_ports.jpg",
                        Created = DateTime.Now,
                    }
                },

                UserId = 1,
                UserEmail = "admin@admin.com",
                UserPassword = "123",
                UserDeviceId = "AXW555",
                UserToken = Guid.NewGuid(),
                UserForename = "Bolek",
                UserSurname = "Polívka",
                UserPhone = "555 111 222",
                UserCity = "Praha",
                UserStreet = "V Poříčí",
                UserZip = "14200",
                UserCreated = DateTime.Now,
                UserProfilePic = "https://static.markiza.sk/a501/image/file/2/0035/FQqp.ded_jpg.jpg",
            },

            new ItemModel
            {
                Id = 2,
                OwnerId = 1,
                DateOfEvent = DateTime.Now,
                Latitude = 40.741895,
                Longitude = -73.989308,
                Title = "Car crash into tree",
                Description = "I crashed into tree with my car.",
                Created = DateTime.Now,
                Updated = DateTime.Now,

                Type = ModelDtos.Enums.IncidentTypes.CarAccident,
                IsClosed = false,
                IsOwnerVictim = true,
                IsIncident = false,
                IncidentId = 1,

                Medias = new List<MediasDto>
                {
                    new MediasDto
                    {
                        Id = 1,
                        Name = "Obrázok stromu",
                        BlobFileAddress = "https://upload.travelawaits.com/ta/uploads/2021/04/e42a03187099bd58a4db67edbac89e42a03-800x800.jpg",
                        Created = DateTime.Now,
                    },

                    new MediasDto
                    {
                        Id = 2,
                        Name = "Obrázok auta",
                        BlobFileAddress = "https://www.funny-jokes.com/fun_pictures/car_cinque_ports.jpg",
                        Created = DateTime.Now,
                    }
                },

                UserId = 1,
                UserEmail = "admin@admin.com",
                UserPassword = "123",
                UserDeviceId = "AXW555",
                UserToken = Guid.NewGuid(),
                UserForename = "Bolek",
                UserSurname = "Polívka",
                UserPhone = "555 111 222",
                UserCity = "Praha",
                UserStreet = "V Poříčí",
                UserZip = "14200",
                UserCreated = DateTime.Now,
                UserProfilePic = "https://static.markiza.sk/a501/image/file/2/0035/FQqp.ded_jpg.jpg",
            }
        };

        List<ItemGridModel> listItemGridModels = new List<ItemGridModel>
        {
            new ItemGridModel
            {
                Id = 1,
                IncidentOrEvidenceId = 1,
                Forename = "Daniel",
                Surname = "Húlka",
                Latitude = 40.741895,
                Longitude = -73.989308,
                ProfilePic = "https://hudba.zoznam.sk/media/obrazky/magazin/galeria/82141/daniel-hulka-muzikal-dracula.jpg",
                Created = DateTime.Now,
                IsClosed = false,
                IsIncident = true,
                AssociatedEvidenceCount = 3
            },

            new ItemGridModel
            {
                Id = 2,
                IncidentOrEvidenceId = 2,
                Forename = "Zdenek",
                Surname = "Švestka",
                Latitude = 40.741895,
                Longitude = -73.989308,
                ProfilePic = "https://hudba.zoznam.sk/media/obrazky/magazin/galeria/82141/daniel-hulka-muzikal-dracula.jpg",
                Created = DateTime.Now,
                IsClosed = false,
                IsIncident = false,
                AssociatedEvidenceCount = null
            },

            new ItemGridModel
            {
                Id = 3,
                IncidentOrEvidenceId = 2,
                Forename = "Milos",
                Surname = "Zeman",
                Latitude = 40.741895,
                Longitude = -73.989308,
                ProfilePic = "https://hudba.zoznam.sk/media/obrazky/magazin/galeria/82141/daniel-hulka-muzikal-dracula.jpg",
                Created = DateTime.Now,
                IsClosed = false,
                IsIncident = false,
                AssociatedEvidenceCount = null
            }
        };





        public List<ItemModel> GetAllItemModels()
        {
            return listItemModels;
        }

        public ItemModel GetItemModelDetail(int id)
        {
            return listItemModels.FirstOrDefault(x => x.Id == id);
        }

        public void CreateItemModel(ItemModel itemModel)
        {
            listItemModels.Add(itemModel);
        }

        public List<ItemGridModel> GetAllItemGridModels()
        {
            return listItemGridModels;
        }
    }
}
