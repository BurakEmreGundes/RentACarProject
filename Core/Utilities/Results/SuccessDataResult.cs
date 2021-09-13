﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(string message,T data):base(message,true,data)
        {

        }
        public SuccessDataResult(T data):base(true,data)
        {

        }
        public SuccessDataResult():base(true,default)
        {

        }
        public SuccessDataResult(string message):base(message,true,default)
        {

        }
    }
}
