using server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace server.Operations{
    public class Filter{
        public static List<Dictionary<string,string>> filter(List<Dictionary<string,string>> items,string flag,string subj){
            int n = items.Count();
            for(int i = 0; i < n ; i++){
                if(!items[i]["HasAttachments"].Contains(flag) || !items[i]["subject"].Contains(subj)){
                    items.Remove(items[i]);
                    i = i-1;
                    n = n-1;
                }
            }
            return items;
        } 
    }
}