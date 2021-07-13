using System;

namespace Test.Web.Data
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

        public void CopyFrom(TodoItem original)
        {
            this.Id = original.Id;
            this.Title = original.Title;
            this.IsDone = original.IsDone;
            this.Created = original.Created;
        }
        
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Title)}: {Title}, {nameof(IsDone)}: {IsDone}, {nameof(Created)}: {Created}";
        }
    }
}