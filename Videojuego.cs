/* Crearemos una clase Videojuego con las siguientes características:
Sus atributos son titulo, horas estimadas, entregado, genero y compañia.
Por defecto, las horas estimadas serán de 10 horas y entregado false. 
El resto de atributos serán valores por defecto según el tipo del atributo.
Los constructores que se implementaran serán:
Un constructor por defecto.
Un constructor con el titulo y horas estimadas. 
El resto por defecto.
Un constructor con todos los atributos, excepto de entregado.
Los métodos que se implementara serán:
Métodos get de todos los atributos, excepto de entregado.
Métodos set de todos los atributos, excepto de entregado.
Sobrescribe los métodos toString. */

class Videojuego : IMiInterface{
    //Atributos
    private bool entregado = false;
    private int horasEstimadas = 10 ;
    private string compania;
    private string titulo;
    private string genero;
    public Boolean prestado { get; set; }

    //GETTERS AND SETTERS
    public int HorasEstimadas{
        get{ return horasEstimadas; }
        set{ horasEstimadas = value; }
    }
    public string Compania
    {
        get { return compania; }
        set { compania = value; } 
    }
    public string Titulo {
        get { return titulo; }
        set { titulo = value; }
    }
    public string Genero
    {
        get { return genero; }
        set { genero = value; }
    }

    //Constructor por defecto
    public Videojuego() {
    }

    //Constuctor por titulo y horas estimadas
    public Videojuego(string ptitulo, int phoras) {
        this.titulo = ptitulo;
        this.horasEstimadas = phoras;
    }

    public Videojuego(int phoras, string pcompania, string ptitulo, string pgenero) {
        this.horasEstimadas = phoras;
        this.compania = pcompania;
        this.titulo = ptitulo;
        this.genero = pgenero;
    }


    public void entregar()
    {
        this.prestado = true;
    }

    public void devolver()
    {
        this.entregado = true;
        this.prestado = false;
    }

    public bool isEntregado()
    {
        return this.prestado;
    }

    public override string ToString()
    {
        return $"Videojuego: {titulo}" +
               $"\nGenero: {genero}" +
               $"\nCompañia: {compania}" +
               $"\nHoras estimadas: {horasEstimadas}" +
               $"\nDisponibilidad: {entregado}";
    }
}

