﻿namespace SnackStore.Core.Services.Implementation
{
    public class ResponseDto<T>
    {
        public string DisplayMessage { get; set; }
        public int StatusCode { get; set; }

        public T Result { get; set; }
    }
}