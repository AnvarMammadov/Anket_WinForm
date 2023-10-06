using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_WinForm
{
    public static  class FileHelper
    {
        public static void WriteJson(User user)
        {
            var ser = new Newtonsoft.Json.JsonSerializer();
            if ($"{user.Name}.json" != null)
            {
                using (var sw = new StreamWriter($"{user.Name}.json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                        ser.Serialize(jw, user);
                    }
                }
            }
        }
    }
}
