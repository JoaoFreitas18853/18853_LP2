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
    ///Esta classe representa qualquer profissional
    ///podendo neste caso ser medico ou enfemeiro
    ///Sendo esta classe abstrata, nao se pode criar um objeto/instancia de profissional
    /// </summary>
    abstract class Professional

    {
        //cada profissional tem como atributos um codigo(code) e um nome(name)
        private string code;
        private string name;

        #region Propriedades
        //propriedades abstratas
        //estas obrigam as subclasses a reescrever estes metodos
        public abstract string Code
        {
            get;
            set;
        }
        public abstract string Name
        {
            get;
            set;
        }
        #endregion

        #region Overrides
        // Permite a comparação entre dois objetos neste caso a comparação do codigo de cada objeto
        //Cada um terá um codigo diferente, nao sendo necessario comparar outras variaveis
        public override bool Equals(Object obj)
        {
            return (this.code == ((Professional)obj).code);
        }
        #endregion
    }
}

