using System;
using System.Collections.Generic;
using System.Text;

namespace LerArquivos
{
    class LogRecord
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }


        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is LogRecord))
            {
                return false;
            }
            else
            {
                LogRecord other = obj as LogRecord;
                return UserName.Equals(other.UserName);
            }
            
        }
    }
}
