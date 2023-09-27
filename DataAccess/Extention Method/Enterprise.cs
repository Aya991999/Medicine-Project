using Models.DBModels;
using MyBusinessAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Extention_Method
{
    public static class Enterprise
    {
        public static M_Enterprise_B_Enterprise AddM_Enterprise_B_Enterprise(this M_Enterprise_B_Enterprise enterprise)
        {


            M_Enterprise_B_Enterprise enterprise_B_Enterprise  = new M_Enterprise_B_Enterprise();

            enterprise_B_Enterprise = enterprise;
            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Id = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Id;
            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Arabic_Name = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Arabic_Name;
            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_English_Name = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_English_Name;
            enterprise_B_Enterprise.M_Enterprise_B_Enterprise_Created_By = 1;
            enterprise_B_Enterprise.M_Enterprise_B_Enterprise_Created_Date = DateTime.Now;
            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Is_Active = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Is_Active;
            enterprise_B_Enterprise.M_Enterprise_B_Enterprise_Is_Deleted = false;
            enterprise_B_Enterprise.M_Enterprise_B_Enterprise_Is_Deleted = false;



            return enterprise_B_Enterprise;

        }
        public static M_Enterprise_B_Enterprise UpdateM_Enterprise_B_Enterprise(this M_Enterprise_B_Enterprise enterpriseFromApi, M_Enterprise_B_Enterprise enterpriseFromDB)
        {
            M_Enterprise_B_Enterprise m_Enterprise = new M_Enterprise_B_Enterprise();

            m_Enterprise = enterpriseFromDB;
            //m_Enterprise_B_Customer1= m_Enterprise_B_CustomerView;
            m_Enterprise.M_Enterprise_B_Enterprise_Id = enterpriseFromApi.M_Enterprise_B_Enterprise_Id;
            m_Enterprise.M_Enterprise_B_Enterprise_Ar_Name = enterpriseFromApi.M_Enterprise_B_Enterprise_Ar_Name;
            m_Enterprise.M_Enterprise_B_Enterprise_En_Name = enterpriseFromApi.M_Enterprise_B_Enterprise_En_Name;
            m_Enterprise.M_Enterprise_B_Enterprise_Updated_By = 1;
            m_Enterprise.M_Enterprise_B_Enterprise_Is_Active = enterpriseFromApi.M_Enterprise_B_Enterprise_Is_Active;
            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Created_Date = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Created_Date;
            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Is_Deleted = 0;
            //m_Enterprise.M_Enterprise_B_Enterprise_Updated_Date = 1;

            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Created_Date = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Created_Date;

            return m_Enterprise;

        }

    }
}
