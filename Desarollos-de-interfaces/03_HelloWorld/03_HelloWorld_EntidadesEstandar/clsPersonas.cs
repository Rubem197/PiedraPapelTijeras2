using System;

namespace _03_HelloWorld_EntidadesEstandar
{


    public class clsPersonas
    {
        #region Atributos
        private string nombre;
        #endregion

        #region Propiedades
        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }        
        }
        #endregion

        #region Constructores
        public clsPersonas()
        {
            this.nombre = "";
        }

        public clsPersonas(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion
    }
}
