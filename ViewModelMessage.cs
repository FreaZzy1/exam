using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ViewModelMessage
    {
        List<string>Message = new List<string>();
        public ViewModelMessage(List<string> message)
        {
            this.Message = message;
        }

    }
}
