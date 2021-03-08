using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiemensApi.Model
{
    public class ResponseMessage
    {
        private string msgType;
        private string msg;

        public string MsgType
        {
            get { return msgType; }
            set { this.msgType = value; }
        }
        public string Msg
        {
            get { return msg; }
            set { this.msg = value; }
        }
    }
}
