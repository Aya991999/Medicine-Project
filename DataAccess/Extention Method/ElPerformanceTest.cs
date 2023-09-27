//using Models.DBModels;
//using MyBusiness.Models;
//using System;

//namespace MyBusiness.Extention_Method
//{
//    public static class ElPerformanceTest
//    {
//        public static EI_TEST_PERFORMANCE AddM_Enterprise_B_Customer(this EI_TEST_PERFORMANCE m_Enterprise_B_CustomerView)
//        {
//            EI_TEST_PERFORMANCE m_Enterprise_B_Customer1 = new EI_TEST_PERFORMANCE();
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Id = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Id;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Arabic_Name = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Arabic_Name;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_English_Name = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_English_Name;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Created_By = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Created_By;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Created_Date = DateTime.Now;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Is_Active = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Is_Active;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Is_Deleted = 0;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Is_System = 0;



//            return m_Enterprise_B_Customer1;

//        }
//        public static EI_TEST_PERFORMANCE UpdateM_Enterprise_B_Customer(this EI_TEST_PERFORMANCE m_Enterprise_B_CustomerView)
//        {
//            EI_TEST_PERFORMANCE m_Enterprise_B_Customer1 = new EI_TEST_PERFORMANCE();
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Id = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Id;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Arabic_Name = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Arabic_Name;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_English_Name = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_English_Name;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Updated_By = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Updated_By;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Created_By = "no";
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Created_Date = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Created_Date;
//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Is_Deleted = 0;
//            //    m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Updated_Date = DateTime.Now;

//            m_Enterprise_B_Customer1.M_Enterprise_B_Customer_Created_Date = m_Enterprise_B_CustomerView.M_Enterprise_B_Customer_Created_Date;

//            return m_Enterprise_B_Customer1;

//        }

//    }
//}
