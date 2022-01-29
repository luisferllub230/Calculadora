using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Controller
{
    public class CalculatorControler
    {
        private long num1, num2, num3;

        public void add(String n) {
            num1 = int.Parse(n);
            num2 += num1;
            num3 = num2;
        }

        public String answer() {
            clean();
            return ""+num3;
        }

        private void clean() {
            num1 = 0;
            num2 = 0;
        }

    }
}
