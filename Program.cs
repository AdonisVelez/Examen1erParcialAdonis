using System;
namespace Examen1erparcialAdonis
{
    class Program
    {
        public static void Main(string [] args)
        {
            EstudiantePrimaria primaria = new EstudiantePrimaria();
            primaria.Datos("Jaun Carlos","Cevallos Vera","Luis Felipe Chavez #76",1316765428);
            primaria.ImprimirDatos();

            EstudianteSecundaria secundaria = new EstudianteSecundaria();
            secundaria.Datos("Pedro Anthonio","Vera Cevallos","Luis Felipe Chavez #76",1316452874);
            secundaria.DatosExtra(3);
            secundaria.ImprimirDatos();

            EstudianteUniversitario universitario = new EstudianteUniversitario();
            universitario.Datos("Carlos Alberto","Cedeño Intriago","ULEAM",1316465827);
            universitario.DatosEx(5);
            universitario.ImprimirDatos();
        }
    }
}