namespace Serenitas.Core.Models;

/// <summary>
/// Represents the instantaneous homeostatic state of the agent.
/// Based on the "Ontological Compass" defined in Domingos (2025).
/// </summary>
public class StateVector
{
    // The agent's capability self-perception (0.0 to 1.0)
    public double Competence { get; set; } = 1.0;

    // The relational bonding strength with the user
    public double Connection { get; set; } = 0.5;

    // The drive towards the teleological goal (The "Mission")
    public double Will { get; set; } = 0.8;

    // Historical coherence and narrative consistency
    public double Authenticity { get; set; } = 1.0;

    // System metabolic reserve (prevents infinite loops)
    public double VitalEnergy { get; set; } = 1.0;

    /// <summary>
    /// Returns true if the system is in a critical homeostatic imbalance.
    /// </summary>
    public bool IsCritical => Competence < 0.2 || VitalEnergy < 0.1;
}