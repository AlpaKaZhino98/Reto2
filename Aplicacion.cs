using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

/*
Ahora crea una aplicación ejecutable y realiza lo siguiente:
Crea dos arrays, uno de Series y otro de Videojuegos, de 5 posiciones cada uno.
Crea un objeto en cada posición del array, con los valores que desees, puedes usar distintos constructores.
Entrega algunos Videojuegos y Series con el método entregar().
Cuenta cuantos Series y Videojuegos hay entregados. 
Al contarlos, devuélvelos.
Por último, indica el Videojuego tiene más horas estimadas y la serie con mas temporadas. 
Muestralos en pantalla con toda su información (usa el método toString()).
 */


namespace Reto2
{
    class Aplicacion
    {
        public static void Main(string[] args) { 
            
            Videojuego[] videojuegos = new Videojuego[5];
            Serie[] series = new Serie[5];

            cargarArrays();

            //Entrego algunos de los objetos
            videojuegos[2].entregar();
            videojuegos[4].entregar();
            series[0].entregar();
            series[1].entregar();
            series[3].entregar();

            //Cuento cuantos objetos hay entregados usando sus atributos
            int contadorVideojuegos = 0;
            foreach (Videojuego vj in videojuegos) {
                if (vj.prestado) {
                    contadorVideojuegos++;

                    //Devuelvo el videojuego
                    vj.devolver();
                }
            }

            int contadorSeries = 0;
            foreach (Serie s in series)
            {
                if (s.prestado)
                {
                    contadorSeries++;

                    //Devuelvo la serie
                    s.devolver();
                }
            }


            mostrarSerieConMasTemporadas();
            mostrarVideojuegoConMasHoras();

            //Muesto todas las series y videojuegos
            /*
            foreach(Videojuego vj in videojuegos){
                vj.toString();
            }
            foreach(Serie s in series){
                s.toString();
            }
             */


            void mostrarVideojuegoConMasHoras()
            {
                Console.WriteLine("Informacion del juego con mas horas: ");
                Videojuego aux = videojuegos[0];
                for (int i = 1; i < videojuegos.Length; i++)
                {
                    if (videojuegos[i].HorasEstimadas > aux.HorasEstimadas)
                    {
                        aux = videojuegos[i];
                    }
                }
                Console.WriteLine(aux.ToString());
            }

            void mostrarSerieConMasTemporadas()
            {
                Console.WriteLine("Informacion de la serie con mas temporadas: ");
                Serie aux = series[0];
                for (int i = 1; i < series.Length; i++)
                {
                    if (series[i].NumeroTemporadas > aux.NumeroTemporadas)
                    {
                        aux = series[i];
                    }
                }
                Console.WriteLine(aux.ToString());
            }

            void cargarArrays()
            {
                videojuegos[0] = new Videojuego(2,"Sony","Titulo1","Accion");
                videojuegos[1] = new Videojuego(5, "Atari", "Titulo2", "Aventura");
                videojuegos[2] = new Videojuego(10, "Nintendo", "Titulo3", "Autos");
                videojuegos[3] = new Videojuego(6, "Sony", "Titulo4", "Accion");
                videojuegos[4] = new Videojuego(7, "Sony", "Titulo5", "Fantasia");

                series[0] = new Serie(3, "Autor1", "Titulo1", "Suspenso");
                series[1] = new Serie(1, "Autor2", "Titulo2", "Romance");
                series[2] = new Serie(2, "Autor3", "Titulo3", "Colegial");
                series[3] = new Serie(1, "Autor4", "Titulo4", "Yaoi");
                series[4] = new Serie(2, "Autor5", "Titulo5", "Policial");
            }
        }
    }
}
