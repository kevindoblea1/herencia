using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Carro
            {
                Marca = "Toyota",
                Modelo = "Corolla",
                Año = 2020,
                NumeroPuertas = 4,
                TipoCombustible = "Gasolina"
            },
            new Carro
            {
                Marca = "Tesla",
                Modelo = "Model 3",
                Año = 2022,
                NumeroPuertas = 4,
                TipoCombustible = "Eléctrico"
            },
            new Moto
            {
                Marca = "Yamaha",
                Modelo = "FZ",
                Año = 2019,
                Cilindrada = 250,
                TieneMaletero = true
            },
            new Moto
            {
                Marca = "Honda",
                Modelo = "CBR",
                Año = 2021,
                Cilindrada = 500,
                TieneMaletero = false
            },
            new Bicicleta
            {
                Marca = "Giant",
                Modelo = "Talon",
                Año = 2018,
                Tipo = "Montaña"
            },
            new Bicicleta
            {
                Marca = "Specialized",
                Modelo = "Allez",
                Año = 2020,
                Tipo = "Ruta"
            }
        };

        foreach (var vehiculo in vehiculos)
        {
            vehiculo.MostrarInformacion();
            Console.WriteLine("---------------------------");
        }
    }
}
