﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Copia
    {
        //idPelicula integer($int32)
        //observaciones string
        //nullable: true
        //precio number($double)
        //fechaAlta string ($date-time)
        //id integer($int32)

        private int idPelicula;
        private string observaciones;
        private double precio;
        private DateTime fechaAlta;
        private int id;

        public Copia()
        {
            fechaAlta = DateTime.Now;
        }
        public Copia(string obs)
        {
            fechaAlta = DateTime.Now;
            observaciones = obs;
        }

        [DataMember(Name="idPelicula")]
        public int IdPelicula { get => idPelicula; set => idPelicula = value; }

        [DataMember(Name = "observaciones")]
        public string Observaciones { get => observaciones;  }
        
        [DataMember(Name = "precio")]
        public double Precio { get => precio; set => precio = value; }
        
        [DataMember(Name = "fechaAlta")]
        public DateTime FechaAlta { get => fechaAlta; }
        
        [DataMember(Name = "id")]
        public int Id { get => id; set => id = value; }
    }
}
