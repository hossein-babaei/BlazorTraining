namespace BlazorTraining.Dialog.Infrastructure;

/// <summary>
/// Calculates z-index values.
/// </summary>
internal static class ZIndexManager
{
    private const int BaseModal = 1055;

    private const int Step = 20;

    public static int GetModal(int stackIndex)
        => BaseModal + (stackIndex * Step);

    public static int GetBackdrop(int stackIndex)
        => GetModal(stackIndex) - 10;
}