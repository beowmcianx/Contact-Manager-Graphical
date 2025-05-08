using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var tag = tags.FirstOrDefault(t => t.TagId == tagId);
            if (tag != null)
            {
                tags.Remove(tag);
                return true;
            }
            return false;
        }

        // Получаване на всички тагове
        public List<Tag> GetAllTags()
        {
            return tags;
        }

        // Намиране на таг по име
        public Tag GetTagByName(string name)
        {
            return tags.FirstOrDefault(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Намиране на таг по ID
        public Tag GetTagById(int tagId)
        {
            return tags.FirstOrDefault(t => t.TagId == tagId);
        }
    }

    // Модел за таг
    public class Tag
    {
        public int TagId { get; set; } 
        public string Name { get; set; } 

        public Tag(int tagId, string name)
        {
            TagId = tagId;
            Name = name;
        }
    }
}
