using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Reloj
{
    [Serializable]
    public class ZonaHoraria
    {
        private TimeSpan m_Diferencia = new TimeSpan();

        public TimeSpan Diferencia
        {
            get { return m_Diferencia; }
            set { m_Diferencia = value; }
        }
        private bool m_Positivo = true;

        public bool Positivo
        {
            get { return m_Positivo; }
            set { m_Positivo = value; }
        }
        private string m_Nombre = "";
        public string Nombre
        {
            get { return m_Nombre; }
            set { m_Nombre = value; }
        }


    }
}