using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria._2
{
    public class Pizza
    {
        public Pizza()
        {
            this.queso = new Queso();
            this.tomate = new SalaTomate();
        }
        public Refresco refresco { get; set; }
        public Queso queso { get; set; }
        public SalaTomate tomate { get; set; }
        
    }
    public class Queso
    {

    }
    public class SalaTomate
    {

    }
    public class Refresco
    {
        public string tipo { get; set; }
    }
}
