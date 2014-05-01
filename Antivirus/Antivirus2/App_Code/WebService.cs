using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.IO;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for WebService2
/// </summary>
[WebService(Namespace = "http://www.tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService2 : System.Web.Services.WebService
{

    public WebService2()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        String[] te = { " " };
        int i = 0;

        string[] search = Directory.GetFiles("C:\\User\\Aviral\\Desktop", "*.*");

        foreach (string item in search)
        {

            try
            {
                StreamReader stream = new StreamReader(item);
                string read = stream.ReadLine();

                string[] virus = new string[] { "trojan", "virus", "hacker" };
                foreach (string st in virus)
                {
                    if (Regex.IsMatch(read, st))
                    {
                        te[i] = item;
                        i++;
                    }
                }
            }

            catch
            {
                string read = item;

                string[] virus = new string[] { "trojan", "virus", "hacker" };
                foreach (string st in virus)
                {
                    if (Regex.IsMatch(read, st))
                    {
                        te[i] = item;
                        i++;
                    }
                }

            }
        }

        
             string txt = te[i].ToString();
             FileInfo TheFile = new FileInfo(txt);
            if (TheFile.Exists)
            {
                File.Delete(txt);
            }

                    return ("0");
    }
}

