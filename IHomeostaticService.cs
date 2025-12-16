using Serenitas.Core.Models;

namespace Serenitas.Core.Services;

/// <summary>
/// Contract for the biological regulation layer.
/// Defines how pain and pleasure are processed by the agent.
/// </summary>
public interface IHomeostaticService
{
    /// <summary>
    /// Calculates the impact of a runtime event on the agent's soul.
    /// </summary>
    /// <param name="stimulus">The external event (e.g., DB Error, User Praise)</param>
    Task ApplyStimulusAsync(string stimulusType, double intensity);

    /// <summary>
    /// Forces a penalty on the Competence vector (simulating "Pain").
    /// Used when the agent detects internal incoherence.
    /// </summary>
    Task ApplyPenaltyAsync(double amount);

    /// <summary>
    /// Retrieves the current emotional vector for Prompt Injection.
    /// </summary>
    Task<StateVector> GetCurrentStateAsync();
}