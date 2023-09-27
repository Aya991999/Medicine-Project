//using Models.DBModels;
//using Models.ViewModels.TopWave;
//using System.Collections.Generic;

//namespace MyBusiness.Extention_Method
//{
//    public static class System_Function
//    {
//        //public static M_Enterprise_B_System_Function ViewModelToSystemFunction(this SystemFunctionViewModel systemFunctionViewModel)
//        //{
//        //    var systemFunction = new M_Enterprise_B_System_Function();
//        //    systemFunction.M_Enterprise_B_System_Function_M_Level = systemFunctionViewModel.MEnterpriseBuSystemFunctionsMyLevel;
//        //     systemFunction.M_Enterprise_B_System_Function_Added_By = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsAddedBy;
//        //    systemFunction.M_Enterprise_B_System_Function_Added_Date = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsAddedDate;
//        //    systemFunction.M_Enterprise_B_System_Function_Arabic_Description = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsArabicDescription;
//        //    systemFunction.M_Enterprise_B_System_Function_Arabic_Name = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsArabicName;
//        //    systemFunction.M_Enterprise_B_System_Function_Below_Level_1 = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsBelowLevel1;
//        //    systemFunction.M_Enterprise_B_System_Function_Below_Level_2 = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsBelowLevel2;
//        //    systemFunction.M_Enterprise_B_System_Function_Below_Level_3 = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsBelowLevel3;
//        //    systemFunction.M_Enterprise_B_System_Function_Deleted_Date = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsDeletedDate;
//        //    systemFunction.M_Enterprise_B_System_Function_Is_Deleted = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsDeletedFlag;
//        //    systemFunction.M_Enterprise_B_System_Function_English_Description = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsEnglishDescription;
//        //    systemFunction.M_Enterprise_B_System_Function_English_Name = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsEnglishName;
//        //    systemFunction.M_Enterprise_B_System_Function_Function_Type = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsFunctionType;
//        //    systemFunction.M_Enterprise_B_System_Function_Has_Child= systemFunctionViewModel.MyEnterpriseBuSystemFunctionsHasChild;
//        //    systemFunction.M_Enterprise_B_System_Function_Icon = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsIcon.Name;
//        //    systemFunction.M_Enterprise_B_System_Function_Is_Active= systemFunctionViewModel.MyEnterpriseBuSystemFunctionsIsActive;
//        //    systemFunction.M_Enterprise_B_System_Function_Serial_Menu = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsSerialInMenu;
//        //    systemFunction.M_Enterprise_B_System_Function_Status_Color_Id = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsStatusColorId;
//        //    systemFunction.M_Enterprise_B_System_Function_Ver_2012_Link = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVer2012Link;
//        //    systemFunction.M_Enterprise_B_System_Function_Ver_2017_Link = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVer2017Link;
//        //    systemFunction.M_Enterprise_B_System_Function_Ver_2020_Link = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVer2020Link;
//        //    systemFunction.M_Enterprise_B_System_Function_Ver_2023_Link = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVer2023Link;
//        //    systemFunction.M_Enterprise_B_System_Function_Ver_Html_Link = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVerHtmlLink;
//        //    systemFunction.M_Enterprise_B_System_Function_Ver_Other_Link = systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVerOtherLink;


//        //    return systemFunction;

//        //}
//        //public static List<M_Enterprise_B_System_Function_Status_Color> ViewModelToStatusColor(this SystemFunctionViewModel systemFunctionViewModel)
//        //{
//        //    var StatusColor = new List<M_Enterprise_B_System_Function_Status_Color>();
//        //    foreach(var item in systemFunctionViewModel.myEnterpriseBuSystemFunctionStatusColors)
//        //    {
//        //        var StatusColorEntity = new M_Enterprise_B_System_Function_Status_Color();
//        //        StatusColorEntity.M_Enterprise_B_System_Function_Status_Color_Colors = item.M_Enterprise_B_System_Function_Status_Color_Colors;
//        //        StatusColorEntity.M_Enterprise_B_System_Function_Status_Color_Id = item.M_Enterprise_B_System_Function_Status_Color_Id;
//        //        StatusColorEntity.M_Enterprise_B_System_Function_Status_Color_Is_Delete= item.M_Enterprise_B_System_Function_Status_Color_Is_Delete;
//        //        StatusColor.Add(StatusColorEntity);
//        //    }
                
//        //        return StatusColor;

//        //}
       
//        public static List<M_Enterprise_B_System_Function_Remark> ViewModelToRemarks(this SystemFunctionViewModel systemFunctionViewModel,
//              M_Enterprise_B_System_Function myEnterpriseBuSystemFunction)
//        {
//            var Remarks = new List<M_Enterprise_B_System_Function_Remark>();
//            foreach (var item in systemFunctionViewModel.myEnterpriseBuSystemFunctionRemarks)
//            {
//                var RemarksEntity = new M_Enterprise_B_System_Function_Remark();
//                RemarksEntity.M_Enterprise_B_System_Function_Remarks_Remark = item.M_Enterprise_B_System_Function_Remarks_Remark;
//                RemarksEntity.M_Enterprise_B_System_Function_Remarks_Id = item.M_Enterprise_B_System_Function_Remarks_Id;
//                RemarksEntity.M_Enterprise_B_System_Function_Remarks_Is_Delete = item.M_Enterprise_B_System_Function_Remarks_Is_Delete;
//                RemarksEntity.M_Enterprise_B_SystemFunctions_Id = myEnterpriseBuSystemFunction.M_Enterprise_B_System_Function_Id;
//                Remarks.Add(RemarksEntity);
//            }

//            return Remarks;

//        }
//        public static List<M_Enterprise_B_System_Function_Note_Link> ViewModelToNoteLink(this SystemFunctionViewModel systemFunctionViewModel
//            , M_Enterprise_B_System_Function myEnterpriseBuSystemFunction)
//        {
//            var NotesLink = new List<M_Enterprise_B_System_Function_Note_Link>();
//            foreach (var item in systemFunctionViewModel.myEnterpriseBuSystemFunctionNoteLinks)
//            {
//                var NotesLinkEntity = new M_Enterprise_B_System_Function_Note_Link();
//                NotesLinkEntity.M_Enterprise_B_System_Function_Note_Link_Links = item.M_Enterprise_B_System_Function_Note_Link_Links;
//                NotesLinkEntity.M_Enterprise_B_System_Function_Note_Link_Notes = item.M_Enterprise_B_System_Function_Note_Link_Notes;
//                NotesLinkEntity.M_Enterprise_B_System_Function_Note_Link_Id = item.M_Enterprise_B_System_Function_Note_Link_Id;
//                NotesLinkEntity.M_Enterprise_B_System_Function_Id = myEnterpriseBuSystemFunction.M_Enterprise_B_System_Function_Id;
                
//                NotesLink.Add(NotesLinkEntity);
//            }

//            return NotesLink;

//        }
//        public static List<M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color> ViewModelToSystemFunctionStatusColor(
//            this M_Enterprise_B_System_Function myEnterpriseBuSystemFunction,  List<M_Enterprise_B_System_Function_Status_Color> myEnterpriseBuSystemFunctionStatusColors)
//        {
//            var SFSC = new List<M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color>();
//            foreach (var item in myEnterpriseBuSystemFunctionStatusColors)
//            {
//                var SFSCEntity = new M_Enterprise_B_System_FunctionsM_Enterprise_B_System_Function_Status_Color();
//                SFSCEntity.M_Enterprise_B_System_Function_Status_Color_Id = item.M_Enterprise_B_System_Function_Status_Color_Id;
//                SFSCEntity.M_Enterprise_B_System_Functions_System_Functions_Id = myEnterpriseBuSystemFunction.M_Enterprise_B_System_Function_Id;

//                SFSC.Add(SFSCEntity);
//            }

//            return SFSC;

//        }

//        public static List<SystemFunctionViewModel> SystemFunctionToViewModel(this List<M_Enterprise_B_System_Function> systemFunctionList)
//        {
//            var systemFunctionViewModelList = new List<SystemFunctionViewModel>();
//            foreach(var systemFunction in systemFunctionList) {
//                var systemFunctionViewModel = new SystemFunctionViewModel();

//                systemFunctionViewModel.MEnterpriseBuSystemFunctionsMyLevel = systemFunction.M_Enterprise_B_System_Function_M_Level;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsAddedBy = systemFunction.M_Enterprise_B_System_Function_Added_By;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsAddedDate = systemFunction.M_Enterprise_B_System_Function_Added_Date;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsArabicDescription = systemFunction.M_Enterprise_B_System_Function_Arabic_Description;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsArabicName = systemFunction.M_Enterprise_B_System_Function_Arabic_Name;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsBelowLevel1 = systemFunction.M_Enterprise_B_System_Function_Below_Level_1;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsBelowLevel2 = systemFunction.M_Enterprise_B_System_Function_Below_Level_2;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsBelowLevel3 = systemFunction.M_Enterprise_B_System_Function_Below_Level_3;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsDeletedDate = systemFunction.M_Enterprise_B_System_Function_Deleted_Date;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsDeletedFlag = systemFunction.M_Enterprise_B_System_Function_Is_Deleted;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsEnglishDescription = systemFunction.M_Enterprise_B_System_Function_English_Description;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsEnglishName = systemFunction.M_Enterprise_B_System_Function_English_Name;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsFunctionType = systemFunction.M_Enterprise_B_System_Function_Function_Type;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsHasChild = systemFunction.M_Enterprise_B_System_Function_Has_Child;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsIconName = systemFunction.M_Enterprise_B_System_Function_Icon;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsIsActive = systemFunction.M_Enterprise_B_System_Function_Is_Active;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsSerialInMenu = systemFunction.M_Enterprise_B_System_Function_Serial_Menu;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsStatusColorId = systemFunction.M_Enterprise_B_System_Function_Status_Color_Id;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsSystemFunctionsId = systemFunction.M_Enterprise_B_System_Function_Id;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVer2012Link = systemFunction.M_Enterprise_B_System_Function_Ver_2012_Link;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVer2017Link = systemFunction.M_Enterprise_B_System_Function_Ver_2017_Link;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVer2020Link = systemFunction.M_Enterprise_B_System_Function_Ver_2020_Link;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVer2023Link = systemFunction.M_Enterprise_B_System_Function_Ver_2023_Link;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVerHtmlLink = systemFunction.M_Enterprise_B_System_Function_Ver_Html_Link;
//                systemFunctionViewModel.MyEnterpriseBuSystemFunctionsVerOtherLink = systemFunction.M_Enterprise_B_System_Function_Ver_Other_Link;
//                systemFunctionViewModelList.Add(systemFunctionViewModel);
//            }
            
//            return systemFunctionViewModelList;
//        }

//    }
//}
