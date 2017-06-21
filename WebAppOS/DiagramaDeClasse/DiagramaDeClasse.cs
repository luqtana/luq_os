using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using WebAppOS.DAL;

namespace WebAppOS.DiagramaDeClasse
{
    public static class DiagramaDeClasse
    {
        public static void GerarDiagrama()
        {

            using (var ctx = new Contexto())
            {
                using (var writer = new XmlTextWriter(@"C:\Users\luqta\OneDrive\Documentos\visual studio 2015\Projects\WebAppOS\WebAppOS\DiagramaDeClasse\Model.edmx", Encoding.Default))
                {
                    EdmxWriter.WriteEdmx(ctx , writer);

                }

            }
        }

    }
}