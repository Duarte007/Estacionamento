﻿using System;

public class Lavagem:IServico {
		public Lavagem() {
		}

        public static double PrecoLavagem = 6 ;

        #region IServico members

        /// <summary>
        ///
        /// </summary>
        /// <returns>Retorna o Valor da Lavagem</returns>
        public double valor() {
            return PrecoLavagem;
        }

        #endregion
}
