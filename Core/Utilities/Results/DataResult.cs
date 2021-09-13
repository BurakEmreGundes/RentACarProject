using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T>:Result,IDataResult<T>
    {
        public T Data { get; }

        public DataResult(string message,bool success,T data):base(message,success)
        {
            this.Data = data;
        }

        public DataResult(bool success,T data) : base(success)
        {
            this.Data = data;
        }

    }
}
