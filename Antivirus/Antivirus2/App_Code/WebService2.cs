using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;


/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://www.tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {




    }


    [WebMethod(Description = "Scan and Delete Virus")]
    public string Antivirus()
    {

        if (File.Exists("C:\\Users\\Aviral\\Desktop\\gta-vc.lnk"))
        {
            File.Delete("C:\\Users\\Aviral\\Desktop\\gta-vc.lnk");
            return ("virus detected and deleted");
        }
        else if (File.Exists("C:\\Users\\Aviral\\Desktop\\iTunes.lnk"))
        {
            File.Delete("C:\\Users\\Aviral\\Desktop\\iTunes.lnk");
            return ("virus detected and deleted");
        }
        else if (File.Exists("C:\\Users\\Aviral\\Desktop\\music.lnk"))
        {
            File.Delete("C:\\Users\\Aviral\\Desktop\\music.lnk");
            return ("virus detected and deleted");
        }
        else if (File.Exists("C:\\Users\\Aviral\\Desktop\\IPMsg.lnk"))
        {
            File.Delete("C:\\Users\\Aviral\\Desktop\\IPMsg.lnk");
            return ("virus detected and deleted");
        }
        else if (File.Exists("C:\\Users\\Aviral\\Desktop\\My Computer.lnk"))
        {
            File.Delete("C:\\Users\\Aviral\\Desktop\\My Computer.lnk");
            return ("virus detected and deleted");
        }
        else if (File.Exists("C:\\Users\\Aviral\\Desktop\\McAfee Security.lnk"))
        {
            File.Delete("C:\\Users\\Aviral\\Desktop\\McAfee Security.lnk");
            return ("virus detected and deleted");
        }
        else if (File.Exists("C:\\Users\\Aviral\\Desktop\\Internet explorer.lnk"))
        {
            File.Delete("C:\\Users\\Aviral\\Desktop\\Internet explorer.lnk");
            return ("virus detected and deleted");
        }
        else if (File.Exists("C:\\Users\\Aviral\\Desktop\\VLC media player.lnk"))
        {
            File.Delete("C:\\Users\\Aviral\\Desktop\\VLC media player.lnk");
            return ("virus detected and deleted");
        }
        else if (File.Exists("C:\\Users\\Aviral\\Desktop\\DC++.lnk"))
        {
            File.Delete("C:\\Users\\Aviral\\Desktop\\DC++.lnk");
            return ("virus detected and deleted");
        }
        else if (File.Exists("C:\\Users\\Aviral\\Desktop\\netbeans.lnk"))
        {
            File.Delete("C:\\Users\\Aviral\\Desktop\\netbeans.lnk");
            return ("virus detected and deleted");
        }
        else
        {
            return ("No virus detected");
        }

    }
}
