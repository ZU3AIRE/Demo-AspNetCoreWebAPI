using TaskCollaborationSystem.ConsoleApp.Entities.Interface;

namespace TaskCollaborationSystem.ConsoleApp.Entities
{

    class MemberTask : IEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime DueDate { get; set; }
        public Member? Assigne { get; set; }

        public void InputAndPopulate()
        {
            Console.Write("Enter Task Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Task Description: ");
            Description = Console.ReadLine();

            Console.Write("Enter Task Due Date: ");
            DueDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Task Status: ");
            Status = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine($"Task Name: {Name} ");
            Console.WriteLine($"Task Description: {Description}");
            Console.WriteLine($"Task Due Date:{DueDate} ");
            Console.WriteLine($"Task Status:{Status} \n");
        }


    }
}
