using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Utilities
{
    public static class CommonUtility
    {
        public static int DbType  {get; set;}
        public static string conn = "";
      
       public static string SqlConnection 
        { 
            get {

                if (DbType == 1)
                {
                 //   return "Data Source=198.38.84.196;Initial Catalog=admin_m_ent_b;User Id=admin_m_mybusiness_b;Password=MB_Mocha!1;TrustServerCertificate=True";
                    return "Data Source=198.38.84.196;Initial Catalog=admin_m_ent_b;User Id=admin_myshop;Password=WaveSoft2021;TrustServerCertificate=True";

                }
                else if (DbType == 4)
                {
                   // return "Data Source=198.38.84.196;Initial Catalog=admin_m_ent_b_dev;User Id=admin_m_mybusiness_b;Password=MB_Mocha!1;TrustServerCertificate=True";

                    return "Data Source=198.38.84.196;Initial Catalog=admin_m_ent_b_dev;User Id=admin_myshop;Password=WaveSoft2021;TrustServerCertificate=True";
                }
                else
                {
                    return "";
                }
            } set {

                
            } }
     
        public static string SQLConnectionStanderd = "Data Source=198.38.84.196;Initial Catalog=admin_m_standard_b;User Id=admin_myshop;Password=WaveSoft2021;TrustServerCertificate=True";
        
        public static string SQLConnectionLog = "Data Source=198.38.84.196;Initial Catalog=admin_m_log_b;User Id=admin_myshop;Password=WaveSoft2021;TrustServerCertificate=True";
        //public static string SQLConnectionLoginTraing = "Data Source=198.38.84.196;Initial Catalog=admin_m_login_b_dev;User Id=admin_m_mybusiness_b;Password=MB_Mocha!1;TrustServerCertificate=True";
        public static string SQLConnectionLogin
        {
            get
            {

                if (DbType == 1)
                {
                    //   return "Data Source=198.38.84.196;Initial Catalog=admin_m_gen_b;User Id=admin_m_mybusiness_b;Password=MB_Mocha!1;TrustServerCertificate=True";
                    return "Data Source=198.38.84.196;Initial Catalog=admin_m_lgn_b_dev;User Id=admin_m_mybusiness_b;Password=WaveSoft2021;TrustServerCertificate=True";

                }
                else if (DbType == 4)
                {
                    // return "Data Source=198.38.84.196;Initial Catalog=admin_m_gen_b_dev;User Id=admin_m_mybusiness_b;Password=MB_Mocha!1;TrustServerCertificate=True";

                    return "Data Source=198.38.84.196;Initial Catalog=admin_m_lgn_b_dev;User Id=admin_m_mybusiness_b;Password=WaveSoft2021;TrustServerCertificate=True";
                }
                else
                {
                    return "Data Source=198.38.84.196;Initial Catalog=admin_m_lgn_b_dev;User Id=admin_m_mybusiness_b;Password=WaveSoft2021;TrustServerCertificate=True";
                }
            }
            set
            {


            }
        }
        //client setup
        // public static string SQLConnectionClientSetup = "Data Source=198.38.84.196;Initial Catalog=admin_client_setup;User Id=admin_m_mybusiness_b;Password=MB_Mocha!1;TrustServerCertificate=True";

        public static string SQLConnectionClientSetup
        {
            get
            {

                if (DbType == 1)
                {
                    //   return "Data Source=198.38.84.196;Initial Catalog=admin_client_setup;User Id=admin_m_mybusiness_b;Password=MB_Mocha!1;TrustServerCertificate=True";
                    return "Data Source=198.38.84.196;Initial Catalog=admin_client_setup;User Id=admin_m_mybusiness_b;Password=WaveSoft2021;TrustServerCertificate=True";

                }
                else if (DbType == 4)
                {
                    // return "Data Source=198.38.84.196;Initial Catalog=admin_client_setup;User Id=admin_m_mybusiness_b;Password=MB_Mocha!1;TrustServerCertificate=True";

                    return "Data Source=198.38.84.196;Initial Catalog=admin_client_setup;User Id=admin_m_mybusiness_b;Password=WaveSoft2021;TrustServerCertificate=True";
                }
                else
                {
                    return "Data Source=198.38.84.196;Initial Catalog=admin_client_setup;User Id=admin_m_mybusiness_b;Password=WaveSoft2021;TrustServerCertificate=True";
                }
            }
            set
            {


            }
        }
        //General
        // public static string SQLConnectionGeneral = "Data Source=198.38.84.196;Initial Catalog=admin_m_gen_b_dev;User Id=admin_m_mybusiness_b;Password=MB_Mocha!1;TrustServerCertificate=True";
        public static string SQLConnectionGeneral
        {
            get
            {

                if (DbType == 1)
                {
                    //   return "Data Source=198.38.84.196;Initial Catalog=admin_m_gen_b;User Id=admin_m_mybusiness_b;Password=MB_Mocha!1;TrustServerCertificate=True";
                    return "Data Source=198.38.84.196;Initial Catalog=admin_m_gen_b;User Id=admin_m_mybusiness_b;Password=WaveSoft2021;TrustServerCertificate=True";

                }
                else if (DbType == 4)
                {
                    // return "Data Source=198.38.84.196;Initial Catalog=admin_m_gen_b_dev;User Id=admin_m_mybusiness_b;Password=WaveSoft2021;TrustServerCertificate=True";

                    return "Data Source=198.38.84.196;Initial Catalog=admin_m_gen_b_dev;User Id=admin_m_mybusiness_b;Password=WaveSoft2021;TrustServerCertificate=True";
                }
                else
                {
                    return "";
                }
            }
            set
            {


            }
        }
    }
}


