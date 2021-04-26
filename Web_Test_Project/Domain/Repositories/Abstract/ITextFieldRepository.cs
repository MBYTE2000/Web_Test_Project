using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Test_Project.Domain.Entities;

namespace Web_Test_Project.Domain.Repositories.Abstract
{
    public interface ITextFieldRepository
    {
        IQueryable<TextField> GetTextField();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
