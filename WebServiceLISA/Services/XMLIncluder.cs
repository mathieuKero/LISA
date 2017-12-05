using Lisa_GetXmlValues;
using System;
using System.Xml;

namespace WebServiceLISA.Services
{
    public class XMLIncluder
    {
        public static void AddOperation()
        {

            XmlDocument OpeDoc = new XmlDocument();
            OpeDoc.Load("OP120.xml");

            string xpathId = "//operation/@id";

            XmlNodeList results = OpeDoc.SelectNodes(xpathId);
            foreach (XmlNode node in results)
            {
                int IdValue = Convert.ToInt32(node.Value);

                string xpathCode = "//operation/code";
                results = OpeDoc.SelectNodes(xpathCode);
                string CodeValue = "";
                foreach (XmlNode nodeCode in results)
                {
                    CodeValue = nodeCode.InnerText;
                }

                string xpathTitle = "//operation/title";
                results = OpeDoc.SelectNodes(xpathTitle);
                string TitleValue = "";
                foreach (XmlNode nodeTitle in results)
                {
                    TitleValue = nodeTitle.InnerText;
                }

                string xpathStartTime = "//operation/startDate";
                results = OpeDoc.SelectNodes(xpathStartTime);
                long StartTimeValue = 0;
                foreach (XmlNode startDate in results)
                {
                    StartTimeValue = Convert.ToInt64(startDate.InnerText);
                }

                string xpathEndTime = "//operation/endDate";
                results = OpeDoc.SelectNodes(xpathEndTime);
                long EndTimeValue = 0;
                foreach (XmlNode endDate in results)
                {
                    EndTimeValue = Convert.ToInt64(endDate.InnerText);
                }

                Operation ope = new Operation(IdValue, CodeValue, TitleValue, StartTimeValue, EndTimeValue);
            }
        }

        public static void AddCatalog()
        {

            XmlDocument CataDoc = new XmlDocument();
            CataDoc.Load("OP120.xml");

            string xpathId = "//catalog/@id";

            XmlNodeList results = CataDoc.SelectNodes(xpathId);
            foreach (XmlNode nodeId in results)
            {
                int IdValue = Convert.ToInt32(nodeId.Value);


                string xpathType = "//catalog//type";
                results = CataDoc.SelectNodes(xpathType);
                string TypeValue = "";
                foreach (XmlNode nodeType in results)
                {
                    TypeValue = nodeType.InnerText;
                }

                string xpathLabel = "//catalog//label";
                results = CataDoc.SelectNodes(xpathLabel);
                string LabelValue = "";
                foreach (XmlNode nodeLabel in results)
                {
                    LabelValue = nodeLabel.InnerText;
                }

                string xpathSpeed = "//catalog//speed";
                results = CataDoc.SelectNodes(xpathSpeed);
                string SpeedValue = "";
                foreach (XmlNode nodeSpeed in results)
                {
                    SpeedValue = nodeSpeed.InnerText;
                }

                string xpathWidth = "//catalog//catalogWidth";
                results = CataDoc.SelectNodes(xpathWidth);
                int WidthValue = 0;
                foreach (XmlNode nodeWidth in results)
                {
                    WidthValue = Convert.ToInt32(nodeWidth.InnerText);
                }

                string xpathHeight = "//catalog//catalogHeight";
                results = CataDoc.SelectNodes(xpathHeight);
                int HeightValue = 0;
                foreach (XmlNode nodeHeight in results)
                {
                    HeightValue = Convert.ToInt32(nodeHeight.InnerText);
                }

                Catalog cata = new Catalog(IdValue, TypeValue, LabelValue, SpeedValue, WidthValue, HeightValue);
            }
        }

        public static void AddPage()
        {

            XmlDocument PageDoc = new XmlDocument();
            PageDoc.Load("OP120.xml");

            string xpathId = "//page/@id";

            XmlNodeList results = PageDoc.SelectNodes(xpathId);
            foreach (XmlNode nodeId in results)
            {
                int IdValue = Convert.ToInt32(nodeId.Value);

                string xpathNum = "//page[" + IdValue + "]//number";
                results = PageDoc.SelectNodes(xpathNum);
                int NumValue = 0;
                foreach (XmlNode nodeNum in results)
                {
                    NumValue = Convert.ToInt32(nodeNum.InnerText);
                }


                string xpathCataId = "//page[@id=1]/../../../catalog/@id";
                results = PageDoc.SelectNodes(xpathCataId);
                int IdCataValue = 0;
                foreach (XmlNode nodeCataId in results)
                {
                    IdCataValue = Convert.ToInt32(nodeCataId.InnerText);
                }

                Page page = new Page(IdValue, NumValue, IdCataValue);
            }
        }

        public static void AddProduit()
        {

            XmlDocument prodDoc = new XmlDocument();
            prodDoc.Load("OP120.xml");

            string xpathId = "//product/@id";
            XmlNodeList results = prodDoc.SelectNodes(xpathId);
            foreach (XmlNode nodeId in results)
            {
                int idValue = Convert.ToInt32(nodeId.Value);


                string xpathCode = "//product[@id=" + idValue + "]/code";
                results = prodDoc.SelectNodes(xpathCode);
                string CodeValue = "";
                foreach (XmlNode nodeCode in results)
                {
                    CodeValue = nodeCode.InnerText;
                }

                string xpathLabel = "//product[@id=" + idValue + "]/label";
                results = prodDoc.SelectNodes(xpathLabel);
                string LabelValue = "";
                foreach (XmlNode nodeLabel in results)
                {
                    LabelValue = nodeLabel.InnerText;
                }

                string xpathDescription = "//product[@id=" + idValue + "]/description";
                results = prodDoc.SelectNodes(xpathDescription);
                string DescriptionValue = "";
                foreach (XmlNode nodeDescription in results)
                {
                    DescriptionValue = nodeDescription.InnerText;
                }

                string xpathCategory = "//product[@id=" + idValue + "]/category";
                results = prodDoc.SelectNodes(xpathCategory);
                string CategoryValue = "";
                foreach (XmlNode nodeCategory in results)
                {
                    CategoryValue = nodeCategory.InnerText;
                }

                string xpathPrice = "//product[@id=" + idValue + "]/price";
                results = prodDoc.SelectNodes(xpathPrice);
                long PriceValue = 0;
                foreach (XmlNode nodePrice in results)
                {
                    PriceValue = Convert.ToInt64(nodePrice.InnerText);
                }

                string xpathEcotaxe = "//product[@id=" + idValue + "]/price";
                results = prodDoc.SelectNodes(xpathEcotaxe);
                long EcotaxeValue = 0;
                foreach (XmlNode nodeEcotaxe in results)
                {
                    EcotaxeValue = Convert.ToInt64(nodeEcotaxe.InnerText);
                }

                string xpathImagePath = "//product[@id=" + idValue + "]/image";
                results = prodDoc.SelectNodes(xpathImagePath);
                string ImagePathValue = "";
                foreach (XmlNode nodePathValue in results)
                {
                    ImagePathValue = nodePathValue.InnerText;
                }

                string xpathPictoPath = "//product[@id=" + idValue + "]/picto";
                results = prodDoc.SelectNodes(xpathPictoPath);
                string PictoPathValue = "";
                foreach (XmlNode nodePictoValue in results)
                {
                    PictoPathValue = nodePictoValue.InnerText;
                }

                string xpathOrigin = "//product[@id=" + idValue + "]/origin";
                results = prodDoc.SelectNodes(xpathOrigin);
                string OriginValue = "";
                foreach (XmlNode nodeOrigin in results)
                {
                    OriginValue = nodeOrigin.InnerText;
                }

                string xpathMention = "//product[@id=" + idValue + "]/mention";
                results = prodDoc.SelectNodes(xpathMention);
                string MentionValue = "";
                foreach (XmlNode nodeMention in results)
                {
                    MentionValue = nodeMention.InnerText;
                }

                string xpathMowerPrice = "//product[@id=" + idValue + "]/lowerprice";
                results = prodDoc.SelectNodes(xpathMowerPrice);
                long LowerPriceValue = 0;
                foreach (XmlNode nodeLowerPrice in results)
                {
                    LowerPriceValue = Convert.ToInt64(nodeLowerPrice.InnerText);
                }

                string xpathColor = "//product[@id=" + idValue + "]/color";
                results = prodDoc.SelectNodes(xpathColor);
                string ColorValue = "";
                foreach (XmlNode nodeColor in results)
                {
                    ColorValue = nodeColor.InnerText;
                }

                new Product(idValue, CodeValue, LabelValue, DescriptionValue, CategoryValue, PriceValue, EcotaxeValue, ImagePathValue, PictoPathValue, OriginValue, MentionValue, LowerPriceValue, ColorValue);


            }

        }

        public static void AddShop()
        {
            //TODO
        }
    }
}
