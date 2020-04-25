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
    /// Descrição de um medico com os atributos code(código), name(nome), speciality(especialidade).
    /// Tem como superclass a classe abstrata (Professional).
    /// </summary>
    class Medic : Professional
    {
        private string speciality;
        private string code;
        private string name;

        #region Construtores
        public Medic() { //Construtor default sem argumentos
        }
        
        public Medic(string speciality, string code, string name)///Construtor que tem como argumentos 3 strings
        
        {
            this.speciality = speciality;///utilização do "this." para desambiguar o nome das variáveis
            this.code = code;
            this.name = name;

        }
        #endregion

        #region Propriedades
        /// Reescrição dos metodos abstratos da classse abstrata
        /// Premite a outras classe aceder e modificar os atributos de um medico
        public override string Code
        {
            get { return code; }
            set { code = value; }
        }
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }
        #endregion

        #region Overrides
        /// Metodo toString (reecrito) para mostrar as informações de um médico.
        public override string ToString()
        {
            return string.Format("Codigo= {0} - Nome= {1} - Especialidade: {2} ", Code, Name, Speciality);
        }

        #endregion


    } 
}

