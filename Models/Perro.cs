using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace POO_ABSTRACT.Models;

public  class Perro : Animal
{
    //estas son las propiedades de mi padre:
    public override int Id { get; set; }
    public override string Nombre { get; set; }
    public override string Especie { get; set; }

    //estas son mis propiedades:
    public bool EsCriollo { get; set; }

    public Perro(int id, string nombre, string especie, bool esCriollo)
    : base(id, nombre, especie)
    {
        EsCriollo = esCriollo;
    }

    public override void Saludar() //el override solo sobreescribe lo que le envío del padre
    {
        Console.WriteLine($"Hola me llamo: {Nombre}");
    }

    // public string GetNombre()  se usa cuando el encapsulamiento de la propiedad es protected o private
    // {
    //     return Nombre;
    // }
}