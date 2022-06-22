using server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace server.Operations{
    public class Sortby{
        public static List<Dictionary<string,string>> sortby(List<Dictionary<string,string>> items,string order,string parameter){

            items.Sort((lhs,rhs) => lhs[parameter].CompareTo(rhs[parameter])); 
            
            if(order.Equals("Dsc")){
                items.Reverse();
            }

            return items;
        } 
    }
}