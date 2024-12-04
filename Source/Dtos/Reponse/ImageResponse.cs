using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Dtos.Product;

namespace Source.Dtos.Reponse
{
    public class ImageResponse
    {
        public List<CreateImageDTO> uploadedImages { get; set; }
    }
}
