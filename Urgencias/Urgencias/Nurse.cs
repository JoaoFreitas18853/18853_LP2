using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Autor:João Freitas
/// Descrição:Gestão de uma urgência
/// Data:12/04/2020
/// </summary>

namespace Urgencias
{   
    /// <summary>
    /// Descrição de um enfermeiro com atributos: codigo(code),nome(name)
    /// Subclasse de profissional
    /// </summary>
    class Nurse : Professional
    {
        private string code;
        private string name;
        
        
        #region Construtores
        
        public Nurse() //construtor default de enfermeiro
        {
        }

        public Nurse (string code, string name)//construtor que recebe como argumento duas strings(codigo e nome)
        {
            this.code = code;
            this.name = name;
        }
        #endregion


        #region Propriedades
        /// <summary>
        /// Permite às outras classe aceder e alterar estas variaveis que estao definidas como private
        /// </summary>
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
        #endregion

        #region Overrides
        //A toString escreve uma frase com os atributos associados a um objeto paciente.
        public override string ToString()
        {
            return string.Format("Enfermeira:{1}\n codigo:{0}", Code, Name);
        }

        #endregion


    }



}
