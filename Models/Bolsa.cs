using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pc1Jorge.Models
{
    public class Bolsa
    {
        public string? NombreApellido { get; set; }
        public string? Correo { get; set; }

        public string? Fecha { get; set; }

        public List<string>? Instrumentos { get; set; }

        public decimal MontoTotal { get; set; }

        public decimal Igv { get; set; }


        public void CalcularInversion(){
            
            decimal Comision;
            decimal totalAbonar;
            decimal montoIgv;

            if(Monto > 300)    
            {
                Comision=1; 
                MontoTotal= MontoTotal +Comision;
            }else{
                Comision=3;
                MontoTotal= MontoTotal +Comision;
            }

            Igv = 0.18m;
            montoIgv = MontoTotal * (1+Igv);

            totalAbonar = montoIgv + Comision;
        }
    }


}