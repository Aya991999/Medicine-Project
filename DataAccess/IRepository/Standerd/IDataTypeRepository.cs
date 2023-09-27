using DataAccess.Paging;
using Models.ViewModels.TopWave;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository.Standerd
{
    public interface IDataTypeRepository : IRepository<M_Standard_B_Data_Type>
    {
        M_Standard_B_Data_Type GetOneDataType(long Id);
        M_Standard_B_Data_Type GetOneDataTypeEnName(string enname);
        M_Standard_B_Data_Type GetOneDataTypeArName(string arname);
        M_Standard_B_Data_Type GetOneDataTypeEnName(int id, string enname);
        M_Standard_B_Data_Type GetOneDataTypeArName(int id, string arname);
        bool Delete(long Id);
        PageList<M_Standard_B_Data_Type> GetDataType(PagingParameterViewModel customerSFPViewModel);
        bool isNext(int _PageIndex, int _PageSize);
    }
}
