using System;

namespace duracion
{
    class Duracion 
    {
        public int horas;
        public int minutos;
        public int segundos;

        public Duracion( int h, int m, int s)
        {
            this.horas = h;
            this. minutos = m;
            this.segundos = s;
        }
        public void impremehms()
        {
            Console.WriteLine("{0}:{1}:{2} hrs", horas, minutos, segundos);

        }
        public void conversions()
        {
            int s;
            s=(horas*3600) + (minutos*60) + segundos;
            Console.WriteLine("la hora en segundos es:{0} ", s);
        }

        public void conversionM()
        {
            int m;
            m=(horas*60)+ minutos+(segundos/60);
            Console.WriteLine("La hora en minutos es: {0}", m);
        }
        public Duracion(int s)
        {
            this.segundos=s;
            horas=(int) s/3600;
            minutos=(int)(s-(horas*3600))/60;
            segundos=(int)(s-(horas*3600)-(minutos*60));
        }

        public void imprimeT()
        {
            Console.WriteLine("{0}:{1}:{2} hrs", horas, minutos, segundos);
        }
        public static Duracion operator +(Duracion hms, Duraciont)
        {
            int s= 0;
            s=((hms.horas+ T.horas)*3600)+((hms.minutos + T.minutos)*60) + (hms.segundos + T.segundos);
            return new Duracion(s);
        }

        public void imprimeSuma()
        {
            Console.WriteLine("La suma es: {0}:{1}:{2} hrs", horas, minutos, segundos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion hms= new Duracion(8, 45,13);
            hms.imprime hms();
            hms.conversions();
            hms.conversionM();

            Duracion hms = new Duracion(7000);
            Console.WriteLine("7000 segundos equivale a :");
            hms.impremehms();

            Duracion suma;
            suma.imprimeSuma();
            
        }
    }
}
