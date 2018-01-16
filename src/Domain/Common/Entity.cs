using FluentValidator;

namespace Domain.Common
{
    public abstract class Entity : Notifiable
    {
        public int Id { get; set; }
    }
}
