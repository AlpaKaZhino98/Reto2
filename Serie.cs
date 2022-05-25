/*
 Crearemos una clase llamada Serie con las siguientes características:
Sus atributos son titulo, numero de temporadas, entregado, genero y creador.
Por defecto, el numero de temporadas es de 3 temporadas y entregado false.
El resto de atributos serán valores por defecto según el tipo del atributo.
Los constructores que se implementaran serán:
Un constructor por defecto.
Un constructor con el titulo y creador. 
El resto por defecto.
Un constructor con todos los atributos, excepto de entregado.
Los métodos que se implementara serán:
Métodos get de todos los atributos, excepto de entregado.
Métodos set de todos los atributos, excepto de entregado.
Sobrescribe los métodos toString.*/


class Serie : IMiInterface{

    //Atributos
    private bool entregado = false;
    private int numeroTemporadas = 3;
    private string creador;
    private string titulo;
    private string genero;
    public bool prestado{ get; set; }

    //Constructor por defecto
    public Serie() {
    }

    //Constructor por titulo y creador
    public Serie(string ptitulo, string pcreador) {
        this.creador = pcreador;
        this.titulo = ptitulo;
    }

    //Constructor con todos los atributos menos entregado
    public Serie(int pnumtemp, string pcreador, string ptitulo, string pgenero) {
        this.numeroTemporadas = pnumtemp;
        this.creador = pcreador;
        this.titulo = ptitulo;
        this.genero = pgenero;
    }

    //GETTERS AND SETTERS
    public int NumeroTemporadas {
        get { return numeroTemporadas; }
        set { numeroTemporadas = value; }
    }
    public string Creador{
        get { return creador; }
        set { creador = value; }
    }
    public string Titulo    {
        get { return titulo; }
        set { titulo = value; }
    }
    public string Genero {
        get { return genero; }
        set { genero = value; }
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
        return $"Serie: {titulo}" +
               $"\nGenero: {genero}" +
               $"\nAutor: {creador}" +
               $"\nNumero de temporadas: {numeroTemporadas}" +
               $"\nDisponibilidad: {entregado}";
    }
}


