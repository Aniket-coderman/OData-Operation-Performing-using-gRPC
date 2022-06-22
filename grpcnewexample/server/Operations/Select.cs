using server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace server.Operations{
    public class Select{
        public static List<Dictionary<string,string>> select(List<Dictionary<string,string>> items,string[] selection){
            List<String> myKeys = items[0].Keys.ToList();
            if(selection != null){
                int n = selection.Length;
                foreach(var key in myKeys){
                      if(!selection.Contains(key)){
                        for(int i = 0 ; i < items.Count() ; i++){
                            items[i].Remove(key);
                        }
                      }
                }
            }
            return items;
        } 
    }
}