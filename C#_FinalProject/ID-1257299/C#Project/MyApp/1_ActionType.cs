using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPJ1.MyApp
{
    public enum Packages
    {
        Product=1, FishMarked, FruitMarked
    }
    public enum ActionType
    {
        ShowAllData = 1,
        SearchByID,
        SearchByName,
        AddNewItem,
        UpdateByID,
        DeleteByID,
        AboutThisProject,
        DevelopedBy
    } 
}
