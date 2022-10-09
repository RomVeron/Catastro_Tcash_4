using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraReports.UI;

namespace f2.clases
{
    public class AlzaReporte
    {
        WSAlzaArchivos.extractos _alzaArchivos;
        byte[] _array;
        string _path;
        XtraReport _reporte;
        public AlzaReporte(byte[]arrayByte,
                           string path,
                           XtraReport reporte) 
        {
            _alzaArchivos = new WSAlzaArchivos.extractos();
            _array = arrayByte;
            _reporte = reporte;
            _path = path;
        }

        public bool alzarArchivo() 
        {
            return _alzaArchivos.alzarArchivoPAS("pas", DateTime.Now.Ticks.ToString(),
                    utiles.GetMD5("lkjsfywdfgDRTEr89(((45%%#" + DateTime.Now.Ticks.ToString()),
                    _path, _array);
        }
    }
}
