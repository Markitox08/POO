using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VETERINARIA.Utilidades
{
    public class Procedimientos
    {

        public static void validarSoloLetra_Numeros (KeyPressEventArgs e) {

            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && (e.KeyChar !=(char)Keys.Back)) 
            {
                MessageBox.Show("Solo se permiten letras y numeros!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        } 
    }
}
