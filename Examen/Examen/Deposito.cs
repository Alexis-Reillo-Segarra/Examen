
using System;



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
        private double MaximoAgua = 1000;      //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private double MaximoPienso = 5000;     //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE PIENSO, se comprueba antes de actualizar los niveles. 
        /// <summary>
        /// He añadido el set para poder introducir el valor del nivel de agua y del pienso.
        /// </summary>
        public double Niveldeagua
        {
            get { return NivelAgua; }
            set { NivelAgua = value; }
        }
        public double Niveldepienso
        {
            get { return NivelPienso; }
            set { NivelPienso = value; }
        }
        ///
        /// <summary>
        /// He cambiado el nombre de la funcion a "ReponerAgua", he realizado cambios al nivel de lo que realiza el
        /// "if" debido a que de esta manera comprueba que la cantidad no es negativa y que 
        /// no se va a salir del deposito al sumar la cantidad de agua a la que se encuentra ya en
        /// el deposito y he cambiado la siguiente variable.
        /// </summary>
        /// <remarks>Recuerda con confundirla con el metodo "ReponerPienso"</remarks>
        /// <param name="CantidadAgua">Sirve para medir la cantidad de agua que se desea añadir al deposito</param>
        public void ReponerAgua(double CantidadAgua)
        {
            if (CantidadAgua > 0 && MaximoAgua > (NivelAgua + CantidadAgua)) //Tamaño del depósito de agua es de 1000 l.
            {
                NivelAgua = NivelAgua + CantidadAgua;
            }
        }
        /// <summary>
        /// He cambiado el nombre de la funcion a "ReponerPienso", he realizado cambios al nivel de lo que realiza el
        /// "if" debido a que de esta manera comprueba que la cantidad no es negativa y que 
        /// no se va a salir del deposito al sumar la cantidad de pienso a la que se encuentra ya en
        /// el deposito y he cambiado la siguiente variable.
        /// </summary>
        /// <remarks>Recuerda con confundirla con el metodo "ReponerAgua"</remarks>
        /// <param name="CantidadPienso">Sirve para medir la cantidad de pienso que se desea añadir al deposito</param>
        public void ReponerPienso(double CantidadPienso)
        {
            if (CantidadPienso > 0 && MaximoPienso > (NivelPienso + CantidadPienso))  //Tamaño del depósito de pienso es de 5000 kg. 
            {
                NivelPienso = NivelPienso + CantidadPienso;
            }
        }
        /// <summary>
        /// He cambiado de nombre el metodo y he eliminado la variable "retirado1" debido a que era innecesaria
        /// y tambien he cambiado el funcionamiento del metodo debido a que como sabemos la cantidad del agua que vamos 
        /// retirar nos interesaría más conocer la cantidad de agua que nos queda en el deposito.
        /// </summary>
        /// <remarks>Recuerda con confundirla con el metodo "ConsumoPienso"</remarks>
        /// <param name="CantidadAgua">Cantidad de agua a retirar del deposito</param>
        /// <returns>Devuelve la cantidad de agua que queda en el deposito</returns>
        public double ConsumoAgua(double CantidadAgua)
        {
            if (CantidadAgua > 0 && CantidadAgua <= NivelAgua)
            {
                NivelAgua = NivelAgua - CantidadAgua;
            }

            return NivelAgua;
        }
        /// <summary>
        /// He cambiado de nombre el metodo y he eliminado la variable "retirado2" debido a que era innecesaria
        /// y tambien he cambiado el funcionamiento del metodo debido a que como sabemos la cantidad del pienso que vamos 
        /// retirar nos interesaría más conocer la cantidad de pienso que nos queda en el deposito.
        /// </summary>
        /// <remarks>Recuerda con confundirla con el metodo "ConsumoAgua"</remarks>
        /// <param name="CantidadPienso">Cantidad de pienso a retirar del deposito</param>
        /// <returns>Devuelve la cantidad de pienso que queda en el deposito</returns>
        public double ConsumoPienso(double CantidadPienso)
        {
            if (CantidadPienso > 0 && CantidadPienso <= NivelPienso)
            {
                NivelPienso = NivelPienso - CantidadPienso;
            }
            return NivelPienso;
        }
    }
}