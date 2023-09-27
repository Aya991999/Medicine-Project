﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.TopWave
{
    public class DivisionViewModel
    {
        /// <summary>
        /// m_ent_b__Div __ Division Number
        /// </summary>
        public int m_ent_b__Div__Div_Id { get; set; }
        public long? m_ent_b__Div__Unique_Code { get; set; }

        /// <summary>
        /// m_ent_b__Div __ Enterprise Number
        /// </summary>
        public int m_ent_b__Div__Ent_Id { get; set; }

        /// <summary>
        /// m_ent_b__Div __ Customer Number
        /// </summary>
        public int m_ent_b__Div__Cst_Id { get; set; }

        /// <summary>
        /// m_ent_b__Div __ English Name
        /// </summary>
        public string m_ent_b__Div__En_Name { get; set; } = null!;

        /// <summary>
        /// m_ent_b__Div __ Arabic Name
        /// </summary>
        public string m_ent_b__Div__Ar_Name { get; set; } = null!;

        /// <summary>
        /// m_ent_b__Div __ Note
        /// </summary>
        public string? m_ent_b__Div__Notes { get; set; }

        public bool m_ent_b__Div__Is_Act { get; set; }

        public int m_ent_b__Div__Crt_By { get; set; }

        public DateTime m_ent_b__Div__Crt_Date { get; set; }

        public int? m_ent_b__Div__Upd_By { get; set; }

        public DateTime? m_ent_b__Div__Upd_Date { get; set; }

        public bool m_ent_b__Div__Is_Dlt { get; set; }

        public int? m_ent_b__Div__Dlt_By { get; set; }

        public DateTime? m_ent_b__Div__Dld_Date { get; set; }

        public bool? m_ent_b__Div__Is_Sys { get; set; }

        public string EnterpriseEnglishName { get; set; }
        public string EnterpriseArabicName { get; set; }
      
    }
}
