using EntityFrameworkCore.EncryptColumn.Attribute;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace API_REST.Model
{
    public partial class Cliente
    {
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int id { get; set; }
        [EncryptColumn]
        public  string CPF{ get; set; }

       
    }
}
