using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Autor:João Freitas
/// Descrição:Gestão de uma urgência
/// Data:12/04/2020
/// </summary>
namespace Urgencias
{    /// <summary>
     /// Criação de uma ficha de triagem que está contida no paciente contendo esta 
     /// uma cor e um tipo de consulta como atributo.
     /// </summary>
    class FichaTriagem
    {
        // Atributos da ficha de triagem, color(cor, tendo em conta a gravidade),tipoConsulta(tipo de consulta).
        private string color;
        private string tipoConsulta;
        

        #region construtor

        public FichaTriagem()//Construtor default para a criação de uma ficha de triagem sem argumentos
        {
        }

        public FichaTriagem(string color, string tipoConsulta)//Construtor que recebe como argumentos duas strings

        {
            this.color = color;
            this.tipoConsulta = tipoConsulta;
        }
        #endregion

        #region Propriedades
        //Propriedade que permite a outras classes alterar e aceder a estas variáveis declaradadas como private
        public string Color
        {
            get { return color; }
            set { Color = value; }
        }
        public string TipoConsulta
        {
            get { return tipoConsulta;}
            set { TipoConsulta = value;}
        }
    

        #endregion
        
        #region Metodos

        
        #endregion

        #region Overrides
        /// Metodo toString reescrito para retornar uma string formatada com informações sobre uma ficha de triagem.
        
        public override string ToString()
        {
            return string.Format("Color: {0} - Tipo de Consulta: {1} ", Color, TipoConsulta);
        }
        #endregion
    }

}
