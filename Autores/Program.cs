using System;

namespace Autores
{
    class Pelciula
    {
        private string titulo;
        private int ano;
        private string pais;
        private string : actores;
        private int nacimiento;

        public string getTitulo()
        {
            return titulo;
        }
        public void setTitulo(string Tit)
        {
            titulo = Tit;
        }
        public int getAno()
        {
            return ano;
        }
        public void setAno(int a)
        {
            ano = a;
        }
        public string getPais()
        {
            return pais;
        }
        public void setPais( string p)
        {
            pais = p;
        }
        public string getDirector()
        {
            return director;
        }
        public void setDirector(string dir)
        {
            director = dir;

        }
        peliculas string (string Tit, int a, string p, string dir)
        {
            titulo = Tit;
            ano = a;
            pais = p;
            director = dir;
        }
        public void imprime()
        {
            Console. WriteLine("{0}({1}) Pais: {2} Dirigida por: {3}", getTitulo(),getPais(),getDirector());
        }

        peliculas string ( string act, int nac)
        {
            actores = actor;
            nacimiento = nac;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List <peliculas> peli = new List <pelculas>();
            peli. Add (new peliculas("Scarlett Johansson"));
            peli. Add(new peliculas("Cecilia Hawkins"));
            

            peliculas p1= new peliculas("Avangers:Endgame", 2019,"Estados Unidos" );
            p1.imprime();
            peliculas p2 = new peliculas("La forma del agua", 2017, " Estados Unidos");
            p2.imprime();

        }
    }
}
