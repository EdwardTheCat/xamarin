using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLoginHibooks.Data.Util
{
    class LowerCaseFirstSerializer
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                ContractResolver = new LowerCaseFirstContractResolver()
            };

            public static string SerializeObject(object o)
            {
                return JsonConvert.SerializeObject(o, Formatting.Indented, Settings);
            }

            public class LowerCaseFirstContractResolver : DefaultContractResolver
            {
                protected override string ResolvePropertyName(string propertyName)
                { 
                    return propertyName.ToLower();
                }
            }
        }  
}
