using server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace server.Data
{
public class MessageData
    { // messagedata.cs
        public static List<Dictionary<string,string>> GetQueries(){
            List<Dictionary<string,string>> pb = new List<Dictionary<string,string>>();
            Dictionary<string,string> dict = new Dictionary<string, string>();
            dict.Add("CollectionId","1");
            dict.Add("HasAttachments","true");
            dict.Add("subject","Important Informa");
            dict.Add("Date","2015-01-01");
            // PropertyBag propertyBag = new PropertyBag();
            // propertyBag.Mapp.Add(dict);
            pb.Add(dict);

            Dictionary<string,string> dict1 = new Dictionary<string, string>();
            dict1.Add("CollectionId","2");
            dict1.Add("HasAttachments","false");
            dict1.Add("subject","Important Information");
            dict1.Add("Date","2015-02-01");
            // PropertyBag propertyBag1 = new PropertyBag();
            // propertyBag1.Mapp.Add(dict1);
            pb.Add(dict1);

            Dictionary<string,string> dict2 = new Dictionary<string, string>();
            dict2.Add("CollectionId","3");
            dict2.Add("HasAttachments","true");
            dict2.Add("subject","Payment Info");
            dict2.Add("Date","2014-02-01");
            // PropertyBag propertyBag2 = new PropertyBag();
            // propertyBag2.Mapp.Add(dict2);
            pb.Add(dict2);
//             queryresponse.Properties.Add(propertyBag2);
            Dictionary<string,string> dict3 = new Dictionary<string, string>();
            dict3.Add("CollectionId","4");
            dict3.Add("HasAttachments","true");
            dict3.Add("subject","Null");
            dict3.Add("Date","2012-01-04");
            // PropertyBag propertyBag3 = new PropertyBag();
            // propertyBag3.Mapp.Add(dict3);
             pb.Add(dict3);
//             queryresponse.Properties.Add(propertyBag3);

            Dictionary<string,string> dict4 = new Dictionary<string, string>();
            dict4.Add("CollectionId","5");
            dict4.Add("HasAttachments","false");
            dict4.Add("subject","Info about your Payment");
            dict4.Add("Date","2015-11-01");
            // PropertyBag propertyBag4 = new PropertyBag();
            // propertyBag4.Mapp.Add(dict4);
            pb.Add(dict4);
//             queryresponse.Properties.Add(propertyBag4);
               return pb;
        }
    }
}