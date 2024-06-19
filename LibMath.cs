using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMath_OBSEQUION {
	internal class LibMath {
		public double AreaLosango(double diagonalMaior, double diagonalMenor)
		{
			return (diagonalMaior * diagonalMenor) / 2;
		}

        //Area do Triangulo H03
        public double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
  
		    // Area do Retangulo
		    public double AreaRetangulo(double b, double h) {
			    return b * h;
		    }
	}
}
