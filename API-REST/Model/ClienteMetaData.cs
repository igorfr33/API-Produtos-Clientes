using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace API_REST.Model
{
    public class ClienteMetaData
    {
        [CryptoData(id = 5)]
        public string CPF { get; set; }

    }
}
