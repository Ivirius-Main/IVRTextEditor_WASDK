namespace IVRTextEditor_WASDK.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
