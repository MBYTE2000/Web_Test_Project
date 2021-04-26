using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Test_Project.Domain.Entities;
using Web_Test_Project.Domain.Repositories.Abstract;

namespace Web_Test_Project.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldRepository
    {
        private readonly AppDbContext context;
        public EFTextFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteTextField(Guid id)
        {
            context.TextFields.Remove(new TextField() { id = id});
            context.SaveChanges();
        }

        public IQueryable<TextField> GetTextField()
        {
            return context.TextFields;
        }

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public TextField GetTextFieldById(Guid id)
        {
            return context.TextFields.FirstOrDefault(x => x.id == id);
        }

        public void SaveTextField(TextField entity)
        {
            if (entity.id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
