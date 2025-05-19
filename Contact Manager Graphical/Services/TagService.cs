using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager_Graphical.Models;

namespace Contact_Manager_Graphical.Services
{
    public class TagService
    {
        private List<Tag> tags;

        public TagService()
        {
            tags = new List<Tag>();
        }

        // Добавяне на нов таг
        public void AddTag(Tag tag)
        {
            // Проверка дали тагът вече съществува
            if (!tags.Any(t => t.Name.Equals(tag.Name, StringComparison.OrdinalIgnoreCase)))
            {
                tags.Add(tag);
            }
            else
            {
                throw new InvalidOperationException("Tag already exists.");
            }
        }

        // Обновяване на съществуващ таг
        public bool UpdateTag(int tagId, Tag updatedTag)
        {
            var tag = tags.FirstOrDefault(t => t.TagId == tagId);
            if (tag != null)
            {
                tag.Name = updatedTag.Name;
                return true;
            }
            return false;
        }

        // Изтриване на таг
        public bool DeleteTag(int tagId)
        {
           
            using (var context = new ContactmanagerContext())
            {
                 var tag = tags.FirstOrDefault(t => t.TagId == tagId);
                if (tag != null)
                {
                  tags.Remove(tag);
                  return true;
                }
                 return false;
            }
        }

        /// <summary>
        /// Извлича всички тагове от базата данни.
        /// </summary>
        /// <returns>
        /// Списък от всички обекти от тип <see cref="Tag"/> налични в базата данни.
        /// </returns>
        /// <remarks>
        /// Методът създава нова инстанция на <see cref="ContactmanagerContext"/> и използва я, за да достъпи таговете.
        /// В текущата си реализация методът връща променлива <c>tags</c>, която не е дефинирана или инициализирана.
        /// Вместо това трябва да се използва:
        /// <code>return context.Tags.ToList();</code>
        /// </remarks>
        public List<Tag> GetAllTags()
        {
           
            using (var context = new ContactmanagerContext())
            {
                return tags;
            }
        }

        /// <summary>
        /// Намира и връща таг от базата данни по зададено име.
        /// </summary>
        /// <param name="name">
        /// Името на тага, който трябва да бъде намерен.
        /// </param>
        /// <returns>
        /// Обект от тип <see cref="Tag"/>, който съответства на зададеното име, или <c>null</c>, ако такъв не съществува.
        /// </returns>
        /// <remarks>
        /// Методът използва LINQ заявка с <see cref="Queryable.FirstOrDefault{TSource}(System.Linq.IQueryable{TSource}, System.Linq.Expressions.Expression{System.Func{TSource,bool}})"/> 
        /// за да върне първия таг, съвпадащ с даденото име.
        /// </remarks>
        public Tag GetTagByName(string name)
        {
            using(var context = new ContactmanagerContext())
            {
                return context.Tags.FirstOrDefault(t => t.Name == name);
            }
            
        }

        // Намиране на таг по ID
        public Tag GetTagById(int tagId)
        {
            
            using (var context = new ContactmanagerContext())
            {
                return tags.FirstOrDefault(t => t.TagId == tagId);
            }
        }
    }

   
}
