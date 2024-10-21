using PetFolio.Communication.Responses;

namespace PetFolio.Application.UseCases.Pets.GetById
{
    public class GetPetByIdUseCase
    {
        public ResponsePetJson Execute(int Id)
        {
            return new ResponsePetJson
            {
                Id = Id,
                Name = "Kaka",
                Type = Communication.Enums.PetType.Cat,
                Birthday = new DateTime(year: 2024, month: 1, day: 1),
            };
        }
    }
}
