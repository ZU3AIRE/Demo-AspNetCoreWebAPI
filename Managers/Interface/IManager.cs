namespace TaskCollaborationSystem.ConsoleApp.Managers.Interface
{
    public interface IManager<EntityClass>
    {
        string Add(EntityClass obj);
        string Remove(string objName);
        string Update(string objName, EntityClass updatedObj);
        List<EntityClass> View();
    }
}
