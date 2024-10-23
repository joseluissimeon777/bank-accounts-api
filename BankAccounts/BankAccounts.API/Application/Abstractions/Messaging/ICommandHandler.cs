﻿using MediatR;

namespace BankAccounts.API.Application.Abstractions.Messaging
{
    public interface ICommandHandler<TCommand>
        : IRequestHandler<TCommand, Result> where TCommand : ICommand
    {
    }

    public interface ICommandHandler<TCommand, TResponse>
        : IRequestHandler<TCommand, Result<TResponse>> where TCommand : ICommand<TResponse>
    {

    }
}