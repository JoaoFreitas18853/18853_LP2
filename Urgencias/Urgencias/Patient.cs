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
    /// Descreve um paciente e permite criar uma ficha de triagem associada a esse paciente. 
    /// A ficha contem uma cor consoante a gravidade do paciente, associada a ela tmb o tipo 
    /// de consulta.
    /// </summary>
    class Patient 
    {
        /// <summary>
        /// Pacientes identificados por um codigo(code), nome(name), e uma ficha com o seu estado(fichaTriagem),
        /// idade(age), e uma data de entrada e saída(dateEntry;dateExit,respetivamente).
        /// </summary>        
        private string color;
        private string tipoConsulta;
        private FichaTriagem fichaTriagem;
        private string code;
        private string name;
        private DateTime dateEntry;
        private DateTime dateExit;
        private int age;
        #region Construtor 
        //Construtor default para Paciente
        public Patient()
        {
        }

        //Construtor com dados vindo do exterior
        public Patient(String code,string name,int age) 
        {
            this.age = age;
            this.code = code;
            this.name = name;
          
        }
        #endregion

        #region Propriedades
        //Propriedades que permitem às outras classes alterar e aceder às variáveis que estão definidas como private
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    
        public DateTime DateEntry
        {
            get { return dateEntry; }
            set { dateEntry = value; }
        }
        public DateTime DateExit
        {
            get { return dateExit; }
            set { dateExit= value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }            
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string TipoConsulta
        {
            get { return tipoConsulta; }
            set { tipoConsulta = value; }
        }

        #endregion

        #region Metodos
        /// <summary>
        ///  Premite criar uma ficha, inicializando o construtor de ficha de triagem,
        ///  recebendo como argumentos cor e o tipo de consulta.
        /// </summary>
        public void criarFicha(string color, string tipoConsulta)
        {
            fichaTriagem = new FichaTriagem (color, tipoConsulta);
            this.color = color;
            this.tipoConsulta = tipoConsulta;

        }
        #endregion

        #region Overrides
        /// <summary>
        /// Permite a comparação entre dois objetos neste caso a comparação do codigo de cada objeto 
        /// cada um terá um codigo diferente, nao sendo necessario comparar outras variaveis
        /// </summary>
        public override bool Equals(Object obj)
        {
            return (this.code == ((Patient)obj).code);
        }
        // A toString escreve uma frase com os atributos associados a um objeto paciente.
        public override string ToString()
        {
            return string.Format("Paciente:{0}-{1}\n Ficha de triagem ==> {2}",name,code,fichaTriagem);
        }

        #endregion

    }
}



 