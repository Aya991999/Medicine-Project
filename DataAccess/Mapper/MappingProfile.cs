using AutoMapper;
using Models.DBModels;
using Models.ViewModels.General;
using Models.ViewModels.TopWave;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile() { 
        CreateMap<M_Enterprise_B_System_Function, SystemFunctionViewModel>().ReverseMap();
            CreateMap<m_ent_b__Ent, EnterpriseViewModel>().ForMember(c => c.EnglishName, opt => opt.MapFrom(s => $"{s.m_ent_b__Ent__Cst.m_ent_b__Cst__En_Name}")).ForMember(c => c.ArabicName, opt => opt.MapFrom(s => s.m_ent_b__Ent__Cst.m_ent_b__Cst__Ar_Name)).ReverseMap();
            //    CreateMap<M_Enterprise_B_System_Function_Display, SystemFunctionDisplayViewModel>().ReverseMap();
            CreateMap<m_ent_b__Div, DivisionViewModel>().
                ForMember(c => c.EnterpriseEnglishName, opt => opt.
                MapFrom(s => $"{s.m_ent_b__Div__Ent.m_ent_b__Ent__En_Name}")).
                ForMember(c => c.EnterpriseArabicName, opt => opt.
                MapFrom(s => s.m_ent_b__Div__Ent.m_ent_b__Ent__Ar_Name))
    .ReverseMap();
            CreateMap<m_ent_b__Brn, BranchViewModel>().
              ForMember(c => c.DivisionEnglishName, opt => opt.
               MapFrom(s => $"{s.m_ent_b__Brn__Div.m_ent_b__Div__En_Name}"))
               .ForMember(c => c.DivisionEnglishName, opt => opt.
               MapFrom(s => s.m_ent_b__Brn__Div.m_ent_b__Div__Ar_Name)).

               ReverseMap();
            CreateMap<m_gen_b__File_Path,FileViewModel>().ReverseMap();
        }
    }
}
