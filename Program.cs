using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{

    class Personas
    {
        protected string Nombre;
        protected string Edad;
        protected string Fecha;
        protected string Mtrla;
        protected string Carra;
        protected string Sld;
        protected string Contenido;
        

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string edad
        {
            get { return Edad; }
            set { Edad = value; }
        }
        public string fecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }
        public string mTrla
        {
            get { return Mtrla; }
            set { Mtrla = value; }
        }
        public string caRra
        {
            get { return Carra; }
            set { Carra = value; }
        }
        public string sLd
        {
            get { return Sld; }
            set { Sld = value; }
        }
        public string cont
        {
            get { return Contenido; }
            set { Contenido = value; }
        }

        class Alumnos : Personas
        {
            public string Personas(string Name, string Fec, string Age, string Raiz, string Place)
            {
                Nombre = Name;
                Edad = Age;
                Fecha = Fec;
                Mtrla = Raiz;
                Carra = Place;
                
                return Contenido = ( Name + Age + Fec + Raiz + Place  );
            }

        }
        class Empleado : Personas
        {
            public string Personas(string Name, string Fec, string Age, string Mnx)
            {
                Nombre = Name;
                Edad = Age;
                Fecha = Fec;
               
                Sld = Mnx;
                return Contenido = (Name + Age + Fec + Mnx);
            }

        }
        class Docente : Personas
        {
            public string Personas(string Name, string Fec, string Age, string Raiz, string Mnx)
            {
                Nombre = Name;
                Edad = Age;
                Fecha = Fec;
                Mtrla = Raiz;
                Sld = Mnx;
                return Contenido = (Name + Age + Fec + Raiz + Mnx);
            }

        }
        static class Program
        {

            /// <summary>
            /// Punto de entrada principal para la aplicación.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

            }
        }
    }
}
