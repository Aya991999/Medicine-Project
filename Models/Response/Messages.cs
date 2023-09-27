using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Response
{
    public class Messages
    {
        public ParameterMessages Get_200 =new ParameterMessages();
        public ParameterMessages Save_201 = new ParameterMessages();

        public ParameterMessages Update_202 = new ParameterMessages();

        public ParameterMessages Delete_203 = new ParameterMessages();

        public ParameterMessages ExixtId_400 = new ParameterMessages();

        public ParameterMessages ExistIdDeleted_401 = new ParameterMessages();

        public ParameterMessages ExixtEnName_402 = new ParameterMessages();

        public ParameterMessages ExixtArName_403 = new ParameterMessages();
        public ParameterMessages NoDeleted_404 = new ParameterMessages();
            public ParameterMessages NoData_405 = new ParameterMessages();
        public ParameterMessages Exeption_500= new ParameterMessages();

    }
    public class ParameterMessages
    {
        public int Status_Code { get; set; }
        public string MessageAr { get; set; }
        public string MessageEn { get; set; }
        public string Description { get; set; }
    }
}
