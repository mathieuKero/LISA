using Lisa_GetXmlValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceLISA.Services
{
    public class XMLGenerator
    {
        public static string GenerateProduct(List<Product> products)
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<products>";
            foreach(Product product in products)
            {
                xml += "<product>";
                    xml += "<id>"           + product.Id            + "</id>";
                    xml += "<code>"         + product.Code          + "</code";
                    xml += "<label>"        + product.Label         + "</label>";
                    xml += "<description>"  + product.Description   + "</description>";
                    xml += "<category>"     + product.Category      + "</category>";
                    xml += "<price>"        + product.Price         + "</price>";
                    xml += "<ecotaxe>"      + product.Ecotaxe       + "</ecotaxe>";
                    xml += "<pictopath>"    + product.PictoPath     + "</pictopath>";
                    xml += "<origin>"       + product.Origin        + "</origin>";
                    xml += "<mention>"      + product.Mention       + "</mention>";
                    xml += "<lowerprice>"   + product.LowerPrice    + "</lowerprice>";
                    xml += "<color>"        + product.Color         + "</color>";
                xml += "</product>";
            } 

            return xml + "</products>";
        }
    }
}
