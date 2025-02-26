﻿using System.Diagnostics.CodeAnalysis;
using Orleans.Runtime;

namespace Orleans.TestKit;

public sealed class TestGrainActivationContext : IGrainContext
{
    public ActivationId ActivationId { get; set; }

    public IServiceProvider ActivationServices { get; set; }

    public GrainAddress Address { get; set; }

    public Task Deactivated { get; set; }

    public GrainId GrainId { get; set; }

    public IAddressable GrainIdentity { get; set; }

    [SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
    public object GrainInstance => throw new NotImplementedException();

    public GrainReference GrainReference { get; set; }

    public Type GrainType { get; set; }

    public IGrainLifecycle ObservableLifecycle { get; set; }

    public IWorkItemScheduler Scheduler { get; set; }

    public void Activate(Dictionary<string, object> requestContext, CancellationToken? cancellationToken = null) => throw new NotImplementedException();

    public void Deactivate(DeactivationReason deactivationReason, CancellationToken? cancellationToken = null) => throw new NotImplementedException();

    public bool Equals(IGrainContext other) => throw new NotImplementedException();

    public TComponent GetComponent<TComponent>() where TComponent : class => throw new NotImplementedException();

    public TTarget GetTarget<TTarget>() where TTarget : class => throw new NotImplementedException();

    public void ReceiveMessage(object message) => throw new NotImplementedException();

    public void SetComponent<TComponent>(TComponent value) where TComponent : class => throw new NotImplementedException();
}
