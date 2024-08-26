using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace LPL_ContractChasingProject
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _runWorkflowHandler(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default);
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public void InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config, string Hoowla_URL, string UserName, System.Security.SecureString Password)
        {
            var result = _runWorkflowHandler(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"Hoowla_URL", Hoowla_URL}, {"UserName", UserName}, {"Password", Password}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test1.xaml
        /// </summary>
        public void Test1()
        {
            var result = _runWorkflowHandler(@"Test1.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Read_InputExcel.xaml
        /// </summary>
        public void Read_InputExcel(System.Collections.Generic.Dictionary<string, object> Config)
        {
            var result = _runWorkflowHandler(@"Read_InputExcel.xaml", new Dictionary<string, object>{{"Config", Config}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Home pages.xaml
        /// </summary>
        public void Home_pages()
        {
            var result = _runWorkflowHandler(@"Home pages.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Chasing contract Performer.xaml
        /// </summary>
        public void Chasing_contract_Performer(string In_CaseID, bool Is_CaseOpened, string Comment_BE, string LastChasingDate, System.DateTime StartTimeDT, System.DateTime EndTimeDT, string AHT_DT, string StartTime, int TransactionNumber, string CaseStatus, string OtherSolicitorCLient, string Address, string Is_MailSend, System.Collections.Generic.Dictionary<string, object> In_Config, string DateDifference, string LastChaseDateDifference, bool Postcode_Status, string FinalLastChaseMMMM)
        {
            var result = _runWorkflowHandler(@"Chasing contract Performer.xaml", new Dictionary<string, object>{{"In_CaseID", In_CaseID}, {"Is_CaseOpened", Is_CaseOpened}, {"Comment_BE", Comment_BE}, {"LastChasingDate", LastChasingDate}, {"StartTimeDT", StartTimeDT}, {"EndTimeDT", EndTimeDT}, {"AHT_DT", AHT_DT}, {"StartTime", StartTime}, {"TransactionNumber", TransactionNumber}, {"CaseStatus", CaseStatus}, {"OtherSolicitorCLient", OtherSolicitorCLient}, {"Address", Address}, {"Is_MailSend", Is_MailSend}, {"In_Config", In_Config}, {"DateDifference", DateDifference}, {"LastChaseDateDifference", LastChaseDateDifference}, {"Postcode_Status", Postcode_Status}, {"FinalLastChaseMMMM", FinalLastChaseMMMM}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
        public void ProcessTestCase()
        {
            var result = _runWorkflowHandler(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
        public void InitAllApplicationsTestCase()
        {
            var result = _runWorkflowHandler(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the LPL_ChasingContracts_PublicNote/ChasingContract_PublicNotes.xaml
        /// </summary>
        public void ChasingContract_PublicNotes()
        {
            var result = _runWorkflowHandler(@"LPL_ChasingContracts_PublicNote\ChasingContract_PublicNotes.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
        public void Process(UiPath.Core.QueueItem in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config, string In_CaseID, int TransactionNumber)
        {
            var result = _runWorkflowHandler(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_TransactionItem", in_TransactionItem}, {"in_Config", in_Config}, {"In_CaseID", In_CaseID}, {"TransactionNumber", TransactionNumber}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData)
        {
            var result = _runWorkflowHandler(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default);
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Send EMail.xaml
        /// </summary>
        public (bool Is_ClientNotFound, string Comment_BE, string CaseStatus, string Is_MailSend, string Is_publicNoteAdd) Send_EMail()
        {
            var result = _runWorkflowHandler(@"Send EMail.xaml", new Dictionary<string, object>{}, default, default, default);
            return ((bool)result["Is_ClientNotFound"], (string)result["Comment_BE"], (string)result["CaseStatus"], (string)result["Is_MailSend"], (string)result["Is_publicNoteAdd"]);
        }

        /// <summary>
        /// Invokes the Excel test.xaml
        /// </summary>
        public void Excel_test()
        {
            var result = _runWorkflowHandler(@"Excel test.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Case_OverView.xaml
        /// </summary>
        public (string LastChasingDate, bool Is_Do_Chasing, string Comment_BE, string CaseStatus) Case_OverView(System.Data.DataTable Case_OverviewList, string CaseDateRow, string CaseDescriptionRow, string BreakTriggerScopeInArgument, string NoContract_Date)
        {
            var result = _runWorkflowHandler(@"Case_OverView.xaml", new Dictionary<string, object>{{"Case_OverviewList", Case_OverviewList}, {"CaseDateRow", CaseDateRow}, {"CaseDescriptionRow", CaseDescriptionRow}, {"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}, {"NoContract_Date", NoContract_Date}}, default, default, default);
            return ((string)result["LastChasingDate"], (bool)result["Is_Do_Chasing"], (string)result["Comment_BE"], (string)result["CaseStatus"]);
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
        public void WorkflowTestCaseTemplate()
        {
            var result = _runWorkflowHandler(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
        public void InitAllSettingsTestCase()
        {
            var result = _runWorkflowHandler(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the LPL_ChasingContracts_PublicNote/test.xaml
        /// </summary>
        public void test()
        {
            var result = _runWorkflowHandler(@"LPL_ChasingContracts_PublicNote\test.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions)
        {
            var result = _runWorkflowHandler(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, default, default);
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _runWorkflowHandler(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, default, default);
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Title_Check.xaml
        /// </summary>
        public (bool RequestMarkAsIn, bool ContractMarkDone, string GetAddress1, string OtherSolicitor) Title_Check(System.Data.DataTable TODO_Mark, string BreakTriggerScopeInArgument, string GetAddress)
        {
            var result = _runWorkflowHandler(@"Title_Check.xaml", new Dictionary<string, object>{{"TODO_Mark", TODO_Mark}, {"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}, {"GetAddress", GetAddress}}, default, default, default);
            return ((bool)result["RequestMarkAsIn"], (bool)result["ContractMarkDone"], (string)result["GetAddress1"], (string)result["OtherSolicitor"]);
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(string in_OrchestratorQueueName, string in_OrchestratorQueueFolder)
        {
            var result = _runWorkflowHandler(@"Main.xaml", new Dictionary<string, object>{{"in_OrchestratorQueueName", in_OrchestratorQueueName}, {"in_OrchestratorQueueFolder", in_OrchestratorQueueFolder}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Comparedates.xaml
        /// </summary>
        public (string DateDifference, string FinalLastChaseMMMM) Comparedates(string LastChasingDate, string FinalLastChasingDate1, string FinalLastChasingDate)
        {
            var result = _runWorkflowHandler(@"Comparedates.xaml", new Dictionary<string, object>{{"LastChasingDate", LastChasingDate}, {"FinalLastChasingDate1", FinalLastChasingDate1}, {"FinalLastChasingDate", FinalLastChasingDate}}, default, default, default);
            return ((string)result["DateDifference"], (string)result["FinalLastChaseMMMM"]);
        }

        /// <summary>
        /// Invokes the Chasing Contract Milestone.xaml
        /// </summary>
        public void Chasing_Contract_Milestone(System.Data.DataTable TODO_Mark, string BreakTriggerScopeInArgument, string GetAddress1, string GetAddress)
        {
            var result = _runWorkflowHandler(@"Chasing Contract Milestone.xaml", new Dictionary<string, object>{{"TODO_Mark", TODO_Mark}, {"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}, {"GetAddress1", GetAddress1}, {"GetAddress", GetAddress}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
        public void MainTestCase()
        {
            var result = _runWorkflowHandler(@"Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
        public void GetTransactionDataTestCase()
        {
            var result = _runWorkflowHandler(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _runWorkflowHandler(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default);
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _runWorkflowHandler(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications()
        {
            var result = _runWorkflowHandler(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Sequence.xaml
        /// </summary>
        public void Sequence()
        {
            var result = _runWorkflowHandler(@"Sequence.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Hoowla_Login.xaml
        /// </summary>
        public bool Hoowla_Login(string UserName, System.Security.SecureString Password, string Hoowla_URL)
        {
            var result = _runWorkflowHandler(@"Hoowla_Login.xaml", new Dictionary<string, object>{{"UserName", UserName}, {"Password", Password}, {"Hoowla_URL", Hoowla_URL}}, default, default, default);
            return (bool)result["Is_HoowlaLogin"];
        }

        /// <summary>
        /// Invokes the CheckingSolicitor_Postcode.xaml
        /// </summary>
        public (bool Postcode_Status, string FeeEarner) CheckingSolicitor_Postcode(string SolicitorAddress)
        {
            var result = _runWorkflowHandler(@"CheckingSolicitor_Postcode.xaml", new Dictionary<string, object>{{"SolicitorAddress", SolicitorAddress}}, default, default, default);
            return ((bool)result["Postcode_Status"], (string)result["FeeEarner"]);
        }

        /// <summary>
        /// Invokes the Amend Document.xaml
        /// </summary>
        public void Amend_Document(string In_LastDate)
        {
            var result = _runWorkflowHandler(@"Amend Document.xaml", new Dictionary<string, object>{{"In_LastDate", In_LastDate}}, default, default, default);
        }
    }
}