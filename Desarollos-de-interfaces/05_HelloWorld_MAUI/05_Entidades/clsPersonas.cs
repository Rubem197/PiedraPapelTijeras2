using System;

namespace _05_Entidades
{


    public class clsPersonas
    {
        #region Atributos
        private string nombre;
        private string apellidos;
        #endregion

        #region Propiedades
        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }        
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        #endregion

        #region Constructores
        public clsPersonas()
        {
            this.nombre = "";
            this.apellidos = "";
        }

        public clsPersonas(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        #endregion
    }
}
