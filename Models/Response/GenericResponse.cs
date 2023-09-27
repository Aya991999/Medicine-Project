using DataAccess.Paging;
using ImageResizer.Collections;
using Models.DBModels;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Apis.Errors
{

  
    public class GenericResponse<T> where T : class
    {
        public int StatusCode { get; set; }
        public string MessageAr { get; set; }
        public string MessageEn { get; set; }
        public bool next { get; set; }
        public T Data { get; set; }
      
    }
}
