using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;

using System.Xml.Linq;
using System.Xml;
namespace E_health
{
    public partial class surfacelogin
    {
       public string CurrentUser = "";
        public surfacelogin(string id)
        {
            surface_login(id);
        }
        protected void surface_login(string id)
        {
        


            XmlDocument xd = new XmlDocument();
            xd.Load("C:\\Users\\sai-sanath\\Documents\\Visual Studio 2010\\Projects\\E-health\\E-health\\E-HealthUsers.xml");

            XmlNodeList xnl = xd.GetElementsByTagName("user");

            foreach (XmlNode xn in xnl)
            {


                if (xn.ChildNodes.Item(0).InnerText == id)
                {
                    CurrentUser = xn.ChildNodes.Item(1).InnerText;

                
                }





            }



        }
    }
}