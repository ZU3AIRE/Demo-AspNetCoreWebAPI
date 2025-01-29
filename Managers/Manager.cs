using TaskCollaborationSystem.ConsoleApp.Entities.Interface;
using TaskCollaborationSystem.ConsoleApp.Managers.Interface;

namespace TaskCollaborationSystem.ConsoleApp.Managers
{

    class Manager<EntityClass> : IManager<EntityClass>
        where EntityClass : IEntity, new()
    {
        private List<EntityClass> list = new();

        public string Add(EntityClass obj)
        {
            list.Add(obj);
            return $"{obj.Name} added successfully!";
        }

        public string Remove(string objName)
        {
            var obj = list.Find(obj => obj.Name == objName);
            if (obj == null)
            {
                return "object not found!";
            }
            list.Remove(obj);
            return $"{objName} Removed Successfully!";
        }

        public string Update(string objName, EntityClass updatedObj )
        {
            int index = list.FindIndex(obj => obj.Name == objName);

            if (index == -1)
            {
                return "Member not found!";
            }

            list[index] = updatedObj;

            return $"{objName} Updated Successfully!";
        }

        public List<EntityClass> View()
        {
            return list;
        }
        
    }
}

