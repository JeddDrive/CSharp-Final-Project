using JeddoreProject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace JeddoreLab4
{
    public static class ProductsDB
    {
        private const string PATH = @"..\..\JeddoreProducts.xml";

        /* Name: GetProducts
         * Sent: Nothing
         * Returned: List of Products
         * This ftn checks a xml file for products (comic books), and puts them into a Products list
         which is returned from the ftn. */
        public static List<Products> GetProducts()
        {
            // create the list
            List<Products> products = new List<Products>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;


            //try
            try
            {
                // create the first XmlReader object (for comicbooks)
                XmlReader xmlIn = XmlReader.Create(PATH, settings);

                // create the second XmlReader object (for graphic novels)
                XmlReader xmlInTwo = XmlReader.Create(PATH, settings);
                // read past all descendant nodes to the first ComicBook node
                if (xmlIn.ReadToDescendant("ComicBook"))
                {
                    // create one Product object for each ComicBook node
                    do
                    {
                        xmlIn.ReadStartElement("ComicBook");
                        //call the custom constructor of ComicBooks
                        //reading in 3 strings, 3 ints, and 1 decimal
                        ComicBooks comicBookItem = new ComicBooks(
                            xmlIn.ReadElementContentAsString(),
                            xmlIn.ReadElementContentAsString(),
                            xmlIn.ReadElementContentAsDecimal(),
                            xmlIn.ReadElementContentAsInt(),
                            xmlIn.ReadElementContentAsString(),
                            xmlIn.ReadElementContentAsInt(),
                            xmlIn.ReadElementContentAsInt());

                        //add this order item to the list called products
                        products.Add(comicBookItem);

                    } while (xmlIn.ReadToNextSibling("ComicBook"));
                }

                // close the first XmlReader object
                xmlIn.Close();

                // read past all descendant nodes to the first GraphicNovel node
                if (xmlInTwo.ReadToDescendant("GraphicNovel"))
                {
                    do
                    {
                        xmlInTwo.ReadStartElement("GraphicNovel");
                        //call the custom constructor of GraphicNovels
                        //reading in 3 strings, 3 ints, and 1 decimal
                        GraphicNovels graphicNovelItem = new GraphicNovels(
                            xmlInTwo.ReadElementContentAsString(),
                            xmlInTwo.ReadElementContentAsString(),
                            xmlInTwo.ReadElementContentAsDecimal(),
                            xmlInTwo.ReadElementContentAsInt(),
                            xmlInTwo.ReadElementContentAsString(),
                            xmlInTwo.ReadElementContentAsInt(),
                            xmlInTwo.ReadElementContentAsInt());

                        //add this order item to the list called products
                        products.Add(graphicNovelItem);

                    } while (xmlInTwo.ReadToNextSibling("GraphicNovel"));
                }

                // close the second XmlReader object
                xmlInTwo.Close();
            }

            //catch
            catch (Exception ex)
            {
                //display msg
                MessageBox.Show(ex.Message, "Unable To Get Products");
            }

            //list called products, is returned from this ftn
            return products;

        }

        /* Name: GetProducts (overloaded)
         * Sent: One string
         * Returned: List of Products
         * This ftn sends in a string for the OFD file path and checks a xml file for products (comic books), 
         * and puts them into a Products list which is returned from the ftn. */
        public static List<Products> GetProducts(string sentInFilePath)
        {
            // create the list
            List<Products> products = new List<Products>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            //try
            try
            {
                // create the first XmlReader object (for comicbooks)
                XmlReader xmlIn = XmlReader.Create(sentInFilePath, settings);

                // create the second XmlReader object (for graphic novels)
                XmlReader xmlInTwo = XmlReader.Create(sentInFilePath, settings);

                // read past all descendant nodes to the first ComicBook node
                if (xmlIn.ReadToDescendant("ComicBook"))
                {
                    // create one Product object for each ComicBook node
                    do
                    {
                        xmlIn.ReadStartElement("ComicBook");
                        //call the custom constructor of ComicBooks
                        //reading in 3 strings, 3 ints, and 1 decimal
                        ComicBooks comicBookItem = new ComicBooks(
                            xmlIn.ReadElementContentAsString(),
                            xmlIn.ReadElementContentAsString(),
                            xmlIn.ReadElementContentAsDecimal(),
                            xmlIn.ReadElementContentAsInt(),
                            xmlIn.ReadElementContentAsString(),
                            xmlIn.ReadElementContentAsInt(),
                            xmlIn.ReadElementContentAsInt());

                        //add this order item to the list called products
                        products.Add(comicBookItem);

                    } while (xmlIn.ReadToNextSibling("ComicBook"));
                }

                // close the first XmlReader object
                xmlIn.Close();

                // read past all descendant nodes to the first GraphicNovel node
                if (xmlInTwo.ReadToDescendant("GraphicNovel"))
                {
                    do
                    {
                        xmlInTwo.ReadStartElement("GraphicNovel");
                        //call the custom constructor of GraphicNovels
                        //reading in 3 strings, 3 ints, and 1 decimal
                        GraphicNovels graphicNovelItem = new GraphicNovels(
                            xmlInTwo.ReadElementContentAsString(),
                            xmlInTwo.ReadElementContentAsString(),
                            xmlInTwo.ReadElementContentAsDecimal(),
                            xmlInTwo.ReadElementContentAsInt(),
                            xmlInTwo.ReadElementContentAsString(),
                            xmlInTwo.ReadElementContentAsInt(),
                            xmlInTwo.ReadElementContentAsInt());

                        //add this order item to the list called products
                        products.Add(graphicNovelItem);

                    } while (xmlInTwo.ReadToNextSibling("GraphicNovel"));
                }

                // close the second XmlReader object
                xmlInTwo.Close();
            }

            //catch
            catch (Exception ex)
            {
                //display msg
                MessageBox.Show(ex.Message, "Unable To Get Products");
            }

            //list called products, is returned from this ftn
            return products;

        }

        /* Name: SaveProducts
         * Sent: List of Products
         * Returned: nothing
         * This ftn sends in a list of products, and saves them to the xml file when there's a certain action, 
         * like when the form for customers or the admin is exited. */
        public static void SaveProducts(List<Products> products)
        {
            //declaring a new comicbooks list and a new graphicnovels list
            List<ComicBooks> comicBooksList = new List<ComicBooks>();
            List<GraphicNovels> graphicNovelsList = new List<GraphicNovels>();

            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            //try
            try
            {
                // create the XmlWriter object
                XmlWriter xmlOut = XmlWriter.Create(PATH, settings);

                // write the start of the document
                xmlOut.WriteStartDocument();

                //start tag for the root (Books) element
                xmlOut.WriteStartElement("Books");

                foreach (Products item in products)
                {
                    if (item.GetType() == typeof(ComicBooks))
                    {
                        comicBooksList.Add((ComicBooks)item);
                    }

                    else
                    {
                        graphicNovelsList.Add((GraphicNovels)item);
                    }
                }

                // write each comicbooks object to the xml file
                foreach (ComicBooks item in comicBooksList)
                {
                    xmlOut.WriteStartElement("ComicBook");
                    xmlOut.WriteElementString("Code",
                        item.Code);
                    xmlOut.WriteElementString("Description",
                        item.Description);
                    xmlOut.WriteElementString("Price",
                        Convert.ToString(item.Price));
                    xmlOut.WriteElementString("InStock",
                        Convert.ToString(item.InStock));
                    xmlOut.WriteElementString("Name",
                        item.Name);
                    xmlOut.WriteElementString("Pages",
                        Convert.ToString(item.Pages));
                    xmlOut.WriteElementString("Issues",
                        Convert.ToString(item.IssueNumber));
                    xmlOut.WriteEndElement();
                }

                // write each graphicnovels object to the xml file
                foreach (GraphicNovels item in graphicNovelsList)
                {
                    xmlOut.WriteStartElement("GraphicNovel");
                    xmlOut.WriteElementString("Code",
                        item.Code);
                    xmlOut.WriteElementString("Description",
                        item.Description);
                    xmlOut.WriteElementString("Price",
                        Convert.ToString(item.Price));
                    xmlOut.WriteElementString("InStock",
                        Convert.ToString(item.InStock));
                    xmlOut.WriteElementString("Name",
                        item.Name);
                    xmlOut.WriteElementString("Pages",
                        Convert.ToString(item.Pages));
                    xmlOut.WriteElementString("Issues",
                        Convert.ToString(item.Issues));
                    xmlOut.WriteEndElement();
                }

                // write the end tag for the root (Books) element
                xmlOut.WriteEndElement();

                // close the first xmlWriter object
                xmlOut.Close();
            }

            //catch
            catch (Exception ex)
            {
                //display message
                MessageBox.Show(ex.Message, "Unable to Save Products");
            }
        }
    }
}
