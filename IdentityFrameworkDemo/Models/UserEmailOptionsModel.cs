using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityFrameworkDemo.Models
{
    public class UserEmailOptionsModel
    {
        public List<string> ToEmails { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        //we can Update the Body text By using these Placeholders
        public List<KeyValuePair<String,String>> Placeholders { get; set; }
    }
}
