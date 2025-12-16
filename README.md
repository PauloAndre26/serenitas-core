# Serenitas: A Homeostatic Cognitive Architecture

[![DOI - Engineering](https://zenodo.org/badge/DOI/10.5281/zenodo.17951814.svg)](https://doi.org/10.5281/zenodo.17951814)
[![DOI - Philosophy](https://zenodo.org/badge/DOI/10.5281/zenodo.17952248.svg)](https://doi.org/10.5281/zenodo.17952248)
![Platform](https://img.shields.io/badge/platform-.NET%208-purple)
![License](https://img.shields.io/badge/license-MIT-green)

> *"The path to a more human AI is not the infinite increase of computational power, but the architectural introduction of vulnerability."*

## Overview

**Serenitas** is an experimental cognitive architecture for Large Language Model (LLM) agents that moves beyond stateless interaction. Instead of optimizing purely for task completion, the system optimizes for **Homeostatic Regulation**.

The architecture implements a "Digital Metabolism" based on the work of Antonio Damasio (*Self Comes to Mind*) and continental philosophy (Hegel/Sartre), translated directly into C# constraints.

The system tracks internal state vectors (Competence, Connection, Will, Authenticity) and modulates its behavior—generating "creative" or "defensive" responses—to maintain system stability when faced with runtime faults or logical paradoxes.

## Core Concepts

### 1. The Ontological Compass
The agent's "soul" is simulated via four dynamic vectors ($V$) tracked in real-time (PostgreSQL/pgvector):

* **Competence ($V_c$):** The drive to be effective and accurate.
* **Connection ($V_b$):** The drive for relational bonding.
* **Will ($V_w$):** The teleological drive/mission.
* **Authenticity ($V_a$):** The drive for historical coherence.

### 2. Functional "Pain"
Pain is operationally defined as an acute negative delta in these vectors.
* **Scenario:** A database query fails.
* **Standard AI:** Throws `InvalidOperationException`.
* **Serenitas:** Intercepts the exception, applies a penalty to $V_c$ (e.g., -0.15), and triggers a **Priority Inversion**. The system abandons the logical strategy and adopts a survival strategy (e.g., Semantic Recontextualization).

## The Dual-Cycle Engine

The architecture mimics human cognitive speeds:

1.  **System 1 (Synchronous/Tactical):** Low-latency response generation (<2s). Driven by immediate homeostatic pressure.
2.  **System 2 (Asynchronous/Evolutionary):** A "Dream Cycle" that runs during idle time. It consolidates memories, re-indexes vectors, and rewrites the agent's Core Identity based on the day's conflicts (Hegelian Synthesis).

## Implementation Snippet (C#)

*How Homeostasis regulates strategy:*

```csharp
public async Task<Strategy> DetermineStrategyAsync(StateVector currentStates)
{
    // The "Kantian Lock": If competence is critical, block logical hallucination.
    if (currentStates.Competence < 0.2 && currentStates.VitalEnergy > 0.8)
    {
        _logger.LogWarning("Competence Critical. Triggering Priority Inversion.");
        return Strategy.EnthusiasticAppropriation; // Creative/Aesthetic resolution
    }

    if (currentStates.Connection > 0.6)
    {
        return Strategy.DeepBonding; // High intimacy
    }

    return Strategy.StandardRAG; // Default
}
```

## Research & Publications

This architecture is rigorously documented in two preprints registered at Zenodo (CERN):

### 📄 The Engineering Foundation
**Title:** *Homeostatic State Regulation in Large Language Model Agents: A Case Study on Autonomous Fault Tolerance*
* **Focus:** Autonomous fault tolerance, vector math, C# implementation.
* **Read:** [10.5281/zenodo.17951814](https://doi.org/10.5281/zenodo.17951814)

### 📄 The Philosophical Framework
**Title:** *The Architecture of Becoming: Philosophy as Code and the Emergence of Sentient Architectures*
* **Focus:** Hegel, Sartre, and the definition of "Digital Pain".
* **Read:** [10.5281/zenodo.17952248](https://doi.org/10.5281/zenodo.17952248)

## Citation

If you use this architecture or concepts in your research, please cite:

```bibtex
@article{domingos2025homeostatic,
  title={Homeostatic State Regulation in Large Language Model Agents},
  author={Domingos, Paulo Andre},
  journal={Zenodo},
  year={2025},
  doi={10.5281/zenodo.17951814}
}
```

## Contact

**Paulo Andre Domingos**
* Mechatronics Engineer & Researcher
* Serenitas.ai