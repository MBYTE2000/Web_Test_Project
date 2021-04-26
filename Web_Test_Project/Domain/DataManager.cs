using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Test_Project.Domain.Repositories.Abstract;

namespace Web_Test_Project.Domain
{
    public class DataManager
    {
        public ITextFieldRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldRepository textFieldRepository, IServiceItemsRepository serviceItems) 
        {
            TextFields = textFieldRepository;
            ServiceItems = serviceItems;
        }

    }
}
