using Grpc.Core;
using server.Data;
using System;
using server.Operations;
namespace server.Services{ // export item service

    public class ExportItemService : ExportItem.ExportItemBase

    {
        private readonly ILogger<ExportItemService> _logger;

        public ExportItemService(ILogger<ExportItemService> logger)
        {
            _logger = logger;
        }

        // public void sort(List<Dictionary<string,string> items,string sort){
        //     items.Sort((lhs,rhs) => lhs[sort].CompareTo(rhs[sort]));
        // }
        
        public override async Task FindItems(QueryRequest request,IServerStreamWriter<QueryResponse> responseStream, ServerCallContext context)
        {
            string req = request.Filter;
            req.Trim();
            string[] sep = req.Split(" ");
            string flag = "";
            string subj = "";
            string parameterOfSorting = "";
            string orderOfSorting = "";
            string[] selection = null;
            for(int i = 0 ; i < sep.Length ; i++){
                if(sep[i].Contains("HasAttachments")){
                    if(sep[i+2] == "true"){
                        flag = "true";
                    }
                    else{
                        flag = "false";
                    }
                }
                if(sep[i].Contains("subject")){
                    subj = sep[i+2];
                }
                if(sep[i].Contains("sortby")){
                    parameterOfSorting = sep[i+2];
                    orderOfSorting = sep[i+3];
                }
                 if(sep[i].Contains("select")){     //  select = CollectionId,Date
                    string sel = sep[i+2];
                    selection = sel.Split(',');
                }
            }
            
            List<Dictionary<string,string>> items = MessageData.GetQueries();
            // Filer
            items = Filter.filter(items,flag,subj);
            
            // Sort
            if(parameterOfSorting != "" && orderOfSorting != ""){
                items = Sortby.sortby(items,orderOfSorting,parameterOfSorting);
            }
            
            // Select
            if(selection != null){
                items = Select.select(items,selection);
            }
            
            
            QueryResponse response = new QueryResponse();
            foreach(var item in items){
                PropertyBag pb = new PropertyBag();
                pb.Mapp.Add(item);
                response.Properties.Add(pb);
            }

            await responseStream.WriteAsync(response);
        }
    }
}

//C:\Users\t-anigupta\grpcexamp\server\Services\ExportItemService.cs