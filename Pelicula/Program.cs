﻿using System;

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
         public void Imprime()
         {
             Console.WriteLine("{0}({1})", this.getTitulo(), this.getAño());
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
            p1.titulo ="La forma del agua";
            p1.año = 2018;
            p1.pais = "Estados Unidos";
            p1.director = "Guillermo del Toro";
            Console.WriteLine("{0}{1}"), "La pelicula es: " + p1.titulo + "El año es: " + p1.año;

            pelicula p2 = new pelicula();
            p2.setTitulo("La la land");
            p2.setAño(2016);
            p2.titulo = "Estados Unidos";
            p2.año = 2016;
            p2.pais = "Estados Unidos";
            p2.director = "Damien Chazelle";
            Console.WriteLine("{0}{1}"), "La pelicula es: " + p2.titulo + "El año es: " + p2.año;;
        }
    }
}
