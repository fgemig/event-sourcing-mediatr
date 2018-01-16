using Domain.Common;
using FluentValidator.Validation;
using System;

namespace Domain.Models
{
    public class Period : Entity
    {
        public Period(int id, DateTime start, DateTime end)
        {
            Id = id;
            Start = start;
            End = end;

            AddNotifications(new ValidationContract()
                .IsGreaterThan(Start, DateTime.Now, nameof(Start), "Start date must be greater than current date")
                .IsLowerThan(Start, End, nameof(End), "The end date must be greater than the start date"));
        }
        
        public DateTime Start { get; private set; }

        public DateTime End { get; private set; }

        public override string ToString()
        {
            return $"{Start.ToString("dd/MM HH:mm")} / {End.ToString("dd/MM HH:mm") }";
        }
    }
}
