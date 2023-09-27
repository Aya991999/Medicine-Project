//using DataAccess.UnitOfWork.LogUnitOfWork;
//using DataAccess.UnitOfWork;
//using Microsoft.AspNetCore.Http;
//using Models.DBModels;

//using System;
//using MyBusinessAPI.Models;

//namespace MyBusiness.Extention_Method
//{
//    public static class Customer
//    {
        
//        public static M_Enterprise_B_Customer AddM_Enterprise_B_Customer(this m_ent_b_Cst m_Enterprise_B_CustomerView)
//        {
           
       
//        M_Enterprise_B_Customer m_Enterprise_B_Customer1 = new M_Enterprise_B_Customer();

//            m_Enterprise_B_Customer1=m_Enterprise_B_CustomerView;
//            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Id = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Id;
//            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Arabic_Name = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Arabic_Name;
//            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_English_Name = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_English_Name;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Created_By = 1;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Created_Date = DateTime.Now;
//            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Is_Active = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Is_Active;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Is_Deleted = false;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Is_System=false;
           


//            return m_Enterprise_B_Customer1;

//        }
//        public static M_Enterprise_B_Customer UpdateM_Enterprise_B_Customer(this M_Enterprise_B_Customer m_Enterprise_B_CustomerView,M_Enterprise_B_Customer m_Enterprise_B_Customer)
//        {
//            M_Enterprise_B_Customer m_Enterprise_B_Customer1 = new M_Enterprise_B_Customer();

//            m_Enterprise_B_Customer1 = m_Enterprise_B_Customer;
//            //m_Enterprise_B_Customer1= m_Enterprise_B_CustomerView;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Id = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Id;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Ar_Name = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Ar_Name;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_En_Name = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_En_Name;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Updated_By = 1;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Is_Active = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Is_Active;
//            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Created_Date = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Created_Date;
//            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Is_Deleted = 0;
//              m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Updated_Date = DateTime.Now;

//            //m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Created_Date = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Created_Date;

//            return m_Enterprise_B_Customer1;

//        }

//    }
//}
