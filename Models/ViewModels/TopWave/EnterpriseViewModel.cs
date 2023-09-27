using Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.TopWave
{
    public class EnterpriseViewModel
    {
        public int m_ent_b__Ent__Ent_Id { get; set; }
        public long? m_ent_b__Ent__Unique_Code { get; set; }

        /// <summary>
        /// m_ent_b__Ent __ Customer Number
        /// </summary>
        public int? m_ent_b__Ent__Cst_Id { get; set; }

        /// <summary>
        /// m_ent_b__Ent __ English Name
        /// </summary>
        public string m_ent_b__Ent__En_Name { get; set; } = null!;

        /// <summary>
        /// m_ent_b__Ent __ Arabic Name
        /// </summary>
        public string m_ent_b__Ent__Ar_Name { get; set; } = null!;

        /// <summary>
        /// m_ent_b__Ent __ Note
        /// </summary>
        public string? m_ent_b__Ent__Notes { get; set; }

        public bool m_ent_b__Ent__Is_Act { get; set; }

        public int m_ent_b__Ent__Crt_By { get; set; }

        public DateTime m_ent_b__Ent__Crt_Date { get; set; }

        public int? m_ent_b__Ent__Upd_By { get; set; }

        public DateTime? m_ent_b__Ent__Upd_Date { get; set; }

        public bool m_ent_b__Ent__Is_Dlt { get; set; }

        public int? m_ent_b__Ent__Dlt_By { get; set; }

        public DateTime? m_ent_b__Ent__Dld_Date { get; set; }

        public bool? m_ent_b__Ent__Is_Sys { get; set; }

        public string   EnglishName { get; set; }
        public string   ArabicName { get; set; }

    }
}
