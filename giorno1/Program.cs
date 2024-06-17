namespace giorno1
{
    class Atleti
    {
      string sport="";
       string nome="";
        string cognome = "";
        public string Sport { get{ return sport; } set { sport = value ; } }
        public string Nome { get{ return nome; } set { nome = value ; } }
        public string Cognome { get { return cognome; } set { cognome = value; } }
        public void Descriviti()
        {
            Console.WriteLine("L'atleta si chiama " + nome + " " + cognome + " e " + " pratica " + sport);
        }

    }

    class Dipendendente
    {
        string nome = "";
        string cognome = "";
        int anni = 0;

        public string Nome { get { return nome; } set { nome = value; } }
        public string Cognome { get { return cognome; } set { cognome = value; } }
        public int Anni { get { return anni; } set { anni = value; } }
        public void Descriviti()
        {
            Console.WriteLine("Il dipendente " + nome + " " + cognome + " ha " + anni + " anni e pratica ");
        }


    }

    class Animale
    {
        string razza = "";
        string colore = "";
        int anno = 0;

        public string Razza { get { return razza; } set { razza = value; } }
        public string Colore { get {  return colore; } set {colore = value; } }

        public int Anno { get { return anno; } set { anno = value; } }

        public void Descriviti()
        {
            Console.WriteLine("l'animale " + razza + "di colore " + colore + " ha " + anno);
        }
    }

    class Veicolo
    {
        string marca = "";
        string colore = "";
        int anno = 0;
        
        public string Marca { get { return marca; } set { marca = value; } }
        public string Colore { get {return colore; } set { colore = value; } }
        public int Anno { get { return anno; } set{ anno = value; } }

        public void Descriviti()
        {
            Console.WriteLine("la macchina " + marca + " " + colore + " ha " + anno + " anni  ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleti x = new Atleti();
            x.Nome = "pippo";
            x.Sport = "calcio";
            x.Cognome = "buffon";
            x.Descriviti();
            Dipendendente dipendendente = new Dipendendente();
            dipendendente.Nome = "ciccio";
            dipendendente.Cognome = "rossi";
            dipendendente.Anni = 23;
            dipendendente.Descriviti();

            Animale animale = new Animale();
            animale.Razza = "husky";
            animale.Colore = "blu";
            animale.Anno = 23;
            animale.Descriviti();

            Veicolo veicolo = new Veicolo();
            veicolo.Marca = "Poshe";
            veicolo.Anno = 2023;
            veicolo.Colore = "Black";
            veicolo.Descriviti();

            
            Console.WriteLine();
            
        } 
    } 
}
