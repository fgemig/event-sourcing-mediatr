using Domain.Enumerations;
using FluentValidator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Commands.Results
{
    public class Response
    {
        private readonly IReadOnlyCollection<Notification> _notifications;

        public Response(int? id, IReadOnlyCollection<Notification> notificacoes)
        {
            Id = id;
            _notifications = notificacoes;
        }

        public int? Id { get; private set; }

        public IReadOnlyCollection<Notification> Notifications
            => _notifications.ToList();

        public ResponseStatus Status => Notifications.Any()
            ? ResponseStatus.FAIL 
            : ResponseStatus.SUCCESS;
    }
}
