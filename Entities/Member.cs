using System;
using TaskCollaborationSystem.ConsoleApp.Entities.Interface;

namespace TaskCollaborationSystem.ConsoleApp.Entities
{
    public class Member : IEntity
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
