using System;

namespace Pelicula
{
    class pelicula 
    {
        //Creacion de los atributos
        public string titulo;
        public int16 año;
        public string pais;
        public string director;
        
         //Creacion de los metodos 
         public void setTitulo (string tit)
         {
             this.titulo = tit;
         }
         public string getTitulo ()
         {
             return this.titulo;
         }
         public void setAño ( int16 a)
         {
            this.año = a;
         }
         public int16 getAño ()
         {
             return this.año;
         }
         public void setPais( string pa)
         {
             this.pais= pa;
         }
         public string getPais()
         {
             return this.pais;
         }
         public void setDirector(string dir)
         {
             this.director= dir;
         }
         public string getDirector()
         {
             return this.director;
         }




    }
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de los objetos
            pelicula p1 = new pelicula();
            p1.setTitulo("La forma del agua");
            p1.setAño(2018);
            p1.setPais("Estados Unidos");
            p1.setDirector("Guillermo del Toro");
            Console.WriteLine("{0}{1}"),p1.getTitulo() + p1.getAño());
            pelicula p2 = new pelicula();
            Console.WriteLine();
        }
    }
}
