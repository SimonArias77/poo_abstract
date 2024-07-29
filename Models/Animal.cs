using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//SINTAXIS, FORMAS DE ESCRIBIR CÓDIGO
// camel case => miNombreEsJavier
// pascal case => MiNombreEsJavier
// snake cae => mi_nombre_es_javier
// kebat case => mi-nombre-es-javier

namespace POO_ABSTRACT.Models;

public abstract class Animal // como la clase es abstracta(palabra reservada) el constructor solo podrá ser usado por las clases hijas
{
    public abstract int Id { get; set; }
    public abstract string Nombre { get; set; }
    public abstract string Especie { get; set; }

public Animal(int id, string nombre, string especie)
{
    Id = id;
    Nombre = nombre;
    Especie = especie;
}

public abstract void Saludar(); // con una propiedad o metodo que sea abstracta, toda la clase se convierte en abstract


// // metodo get de la propiedad Nombre. Se usa cuando el hay encapsulamiento(osea cuando son protected o private)
// public string GetNombre()
// {
//     return Nombre;
// }

// // metodo set de la propiedad Nombre
// public void SetNombre(string nuevoNombre)
// {
//     if (nuevoNombre.Length > 0)
//     {
//         Nombre = nuevoNombre;
//     }
//     else
//     {
//         Console.WriteLine("El nombre no puede estar vacío");
//     }
// }
}

