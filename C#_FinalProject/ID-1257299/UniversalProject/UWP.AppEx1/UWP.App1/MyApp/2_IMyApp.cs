namespace ConPJ1.MyApp
{
    public interface IMyApp
    {
        ActionType Action { get; set; }
        void ShowMenu();
        void ReadMenuSelection();        
        void WaitForGoBack();
        void ManageAllAction();
        void ShowAllDataAction();
        void SearchByIDAction();
        void SearchByNameAction();
        void AddNewItemAction();
        void UpdateByIDAction();
        void DeleteByIDAction();
        void AboutThisProject();
        void DevelopedBy();
    }//i
}//ns
