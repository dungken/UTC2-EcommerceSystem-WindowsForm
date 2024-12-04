using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.Dtos.Order;
using Source.Dtos.Role;

namespace Source.Dtos.Reponse
{
    public class PermissionRespone
    {
        public List<PermissionDto> permissionList { get; set; }
    }
}
