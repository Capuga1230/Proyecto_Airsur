﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSur.EntidadesDeNegocio
{
    public class Pais
    {
        [Key]
        public long id_pais { get; set; }

        public string nombre { get; set; }
    }
}
