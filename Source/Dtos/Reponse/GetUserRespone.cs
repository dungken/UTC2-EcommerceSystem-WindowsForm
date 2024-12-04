using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Models;
namespace Source.Dtos.Reponse
{
    public class GetUserRespone
    {
        Source.Models.User user { get; set; }
        IList<string> Roles { get; set; }
        List<string> Permissions { get; set; }
    }
}
