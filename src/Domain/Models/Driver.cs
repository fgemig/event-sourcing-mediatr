using Domain.Common;
using FluentValidator.Validation;

namespace Domain.Models
{
    public class Driver : Entity
    {
        public Driver(int id, string name, string document)
        {
            Id = id;
            Name = name;
            Document = document;

            AddNotifications(new ValidationContract()
                .HasMinLen(Name, 3, nameof(Name), "Driver name must be at least 3 characters")
                .HasLen(Document, 11, nameof(Document), "Document number is invalid"));
        }

        public string Name { get; private set; }

        public string Document { get; private set; }

        public override string ToString()
        {
            return $"{Name}, Document: {Document}";
        }
    }
}
