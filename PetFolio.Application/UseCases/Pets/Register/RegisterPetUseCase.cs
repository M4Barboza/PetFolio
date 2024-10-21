using PetFolio.Communication.Requests;
using PetFolio.Communication.Responses;

namespace PetFolio.Application.UseCases.Pet.Register
{
    public class RegisterPetUseCase
    {
        public ResponseRegisteredPetJson Execute(RequestPetJson request)
        {
            return new ResponseRegisteredPetJson
            {
                Id = 7,
                Name = request.Name,
            };
        }
    }
}
