
using System;


//namespace EDexamenT6a8


namespace Deposito
{
    /*Clase que representa la gestión de los depósitos de una granja.
     * Tiene dos depósitos: pienso y agua. 
     * La propiedad devuelve el nivel de agua y pienso. 
     * Los métodos permiten reponer o consumir tanto pienso como agua.
     * Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
     */
    class Deposito
    {
        /// <summary>
        /// He cambiado el nombre de las variables para que sean más claras y concisas.
        /// </summary>
        private double NivelAgua;
        private double NivelPienso;
        private double MaximoAgua;      //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private double MaximoPienso;     //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE PIENSO, se comprueba antes de actualizar los niveles. 
        public double Niveldeagua
        {
            get { return NivelAgua; }
        }
        public double Niveldepienso
        {
            get { return NivelPienso; }
        }
        /// <summary>
        /// He cambiado el nombre de la funcion a "ReponerAgua" y he cambiado la siguiente variable.
        /// </summary>
        /// <param name="CantidadAgua">Sirve para medir la cantidad de agua que se desea añadir al deposito</param>
        public void ReponerAgua(double CantidadAgua)
        {
            MaximoAgua = CantidadAgua + NivelAgua;
            if (CantidadAgua > 0 && MaximoAgua < 10000) //Tamaño del depósito de pienso es de 1000 l.
            {
                NivelAgua = NivelAgua + CantidadAgua;
            }
        }
        public void ReponerPienso(double CantidadPienso)
        {

            MaximoPienso = CantidadPienso + NivelPienso;
            if (CantidadPienso > 0 && MaximoPienso < 5000)  //Tamaño del depósito de pienso es de 5000 kg. 
            {
                NivelPienso = NivelPienso + CantidadPienso;
            }
        }


        public double ConsumoAgua(double cantidadaretirardeagua)
        {
            double retirado1 = 0; //Cantidad que se retira
            if (cantidadaretirardeagua > 0 && cantidadaretirardeagua <= NivelAgua)
            {
                retirado1 = cantidadaretirardeagua;
                NivelAgua = NivelAgua - cantidadaretirardeagua;
            }

            return retirado1;
        }
        public double ConsumoPienso(double cantidadaretirardepienso)
        {
            double retirado2 = 0; //Cantidad que se retira
            if (cantidadaretirardepienso > 0 && cantidadaretirardepienso <= NivelPienso)
            {
                retirado2 = cantidadaretirardepienso;
                NivelPienso = NivelPienso - cantidadaretirardepienso;
            }
            return retirado2;
        }








    }
}