using System;

namespace _03_HelloWorld_EntidadesEstandar
{


    public class clsPersonas
    {
        #region Atributos
        private string nombre;
        private string apellido;
        #endregion

        #region Propiedades
        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }        
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        #endregion

        #region Constructores
        public clsPersonas()
        {
            this.nombre = "";
            this.apellido = "";
        }

        public clsPersonas(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion
    }
}
