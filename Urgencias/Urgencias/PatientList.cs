using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Autor:João Freitas
/// Descrição:Gestão de uma urgência
/// Data:12/04/2020
/// </summary>

namespace Urgencias
{   /// <summary>
    /// Organização dos pacientes em listas.
    /// Uma lista com todos os pacientes.
    /// Uma lista vermelha(Maxima gravidade).
    /// Uma lista amarela(Media gravidade).
    /// Uma lista verde(Baixa gravidade).
    /// </summary>
    class PatientList
    {
        #region Listas
        private List<Patient> patients = new List<Patient>();
        private List<Patient> redList = new List<Patient>();
        private List<Patient> yellowList = new List<Patient>();
        private List<Patient> greenList = new List<Patient>();
        #endregion

        #region Construtor 
        public PatientList()    //Construtor default sem argumentos
        {
        }
        #endregion

        #region Metodos
        ///Metodo para inserir um paciente na lista de pacientes e simultâneamente associa-lo 
        ///a uma lista de cor, consoante a gravidade.
        public void checkIn(Patient p) {

            patients.Add(p);

            if(p.Color == "red")
            {
                redList.Add(p);
            }
            if(p.Color == "yellow")
            {
                yellowList.Add(p);
            }
            if(p.Color == "green")
            {
                greenList.Add(p);
            }
        }
        /// Permite remover um paciente da lista de pacientes e ao mesmo tempo remove-lo 
        /// da lista de cor onde está inserido. Fazendo assim o "checkout" de um paciente 
        /// da lista de pacientes em espera.
        public void checkOut(Patient p)
        {
            patients.Remove(p);

            if (p.Color == "red")
            {
                redList.Remove(p);
            }
            if (p.Color == "yellow")
            {
                yellowList.Remove(p);
            }
            if (p.Color == "green")
            {
                greenList.Remove(p);
            }
        }
        /*public string patientsRed()   //tema a explorar
        {
            foreach (Patient p in redList)
            {
                
                return string.Format("Paciente:{0} - {1}", p.Name, p.Code);

            }
            return null;
        }*/
        #endregion

        #region Overrides
            //Mostrar o conteudo das listas( ainda nao esta  funcionar como pretendo 
        public override string ToString()
        {
            return string.Format("Lista de todos os pacientes: {0}\n Lista Vermelha: {1} \n " +
                "Lista Amarela: {2}\n Lista verde:{3}", patients, redList, yellowList, greenList);
        }

        #endregion

    }
}
