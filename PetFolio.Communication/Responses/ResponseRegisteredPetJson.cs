using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFolio.Communication.Responses
{
    public class ResponseRegisteredPetJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
