﻿namespace Subscriber.core.Response
{
    public class BaseResponseGeneric<T> : BaseResponse
    {
        public T Data { get; set; }
    }
}
