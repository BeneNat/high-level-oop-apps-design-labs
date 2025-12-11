# Lab 3: Object-Oriented Programming in Practice II

This module involves the development of a complex simulation system for a submarine voyage. It focuses on the practical application of object-oriented principles to manage interacting components, resources, and crew members within a closed environment.

## Module Overview

Unlike previous labs, this module consists of a single, integrated project: **Submarine**. The core objective is to pass a pre-defined suite of automated tests (`TestSubmarine`) before running the actual voyage simulation.

### Key Concepts Implemented:
* **Complex System Interaction**: Managing dependencies between the `Submarine` class and its subsystems (`LifeSupportSystem`, `Engine`, `Crew`).
* **Interface-Driven Design**:
    * `ITransportable`: Enforces coupled logic between Weight and Volume properties (density-based calculation).
    * `IVisitPort`: Standardizes the behavior of restocking resources and disposing of waste.
* **Reflection-Based Testing**: The project includes a self-testing mechanism (`TestSubmarine.cs`) that validates class structures, inheritance, and method signatures at runtime.
* **Logic Encapsulation**: Specific business rules (e.g., fuel consumption, scientist work cycles) are encapsulated within their respective classes.

## Project: Submarine Simulation

The system simulates a sea voyage, monitoring the vessel's status, calculating total weight dynamically, and managing life-critical resources.

### System Architecture

The project implements a domain model based on the provided UML diagram (`C3.png`).

#### Core Logic
* **Submarine**: The central coordinator. It calculates the total weight of the vessel (summing all `ITransportable` objects) and executes the simulation loop.
* **Engine**: Manages the `FuelTank` and `Waste`. It calculates velocity based on mass and validates if a trip is feasible.
* **LifeSupportSystem**: Monitors supplies (`OxygenBottle`, `FoodContainer`) and determines crew survival probabilities.

#### Resources Hierarchy
* **Fuel (Abstract)**: Defines base properties. Derived classes `FuelDiesel` and `FuelNuclear` provide specific densities and types.
* **Containers**: Classes like `FuelTank`, `OxygenBottle`, and `FoodContainer` implement `IVisitPort` to handle refilling logic and cost calculation.
* **Waste**: Implements `IVisitPort` to handle disposal logic.

#### Crew Hierarchy
* **Human (Abstract)**: Base class implementing `ITransportable`.
* **Crewman**: Standard crew member.
* **Scientist**: Specialized crew member who uses `Equipment` to gather data during the voyage.

## Project Structure

All source files are contained within the main project directory.

```text
├── Lab3-Submarine/
│   ├── README.md                # This documentation file
│   ├── Submarine.sln            # Module-specific solution file
│   │
│   └── Submarine/               # Main Project Source
│       ├── Program.cs           # Entry point (Runs tests & simulation)
│       ├── Submarine.cs         # Main simulation loop
│       ├── TestSubmarine.cs     # Automated validation logic
│       ├── TestContents.cs      # Reflection helpers for testing
│       │
│       ├── ITransportable.cs    # Interface for weight/volume logic
│       ├── IVisitPort.cs        # Interface for port operations
│       │
│       ├── Human.cs             # Abstract base class for crew
│       ├── Crewman.cs           # Concrete crew implementation
│       ├── Scientist.cs         # Crew member using equipment
│       │
│       ├── Fuel.cs              # Abstract fuel base
│       ├── FuelDiesel.cs        # Diesel implementation
│       ├── FuelNuclear.cs       # Nuclear implementation
│       ├── FuelTank.cs          # Fuel storage logic
│       │
│       ├── Engine.cs            # Logic for movement and consumption
│       ├── LifeSupportSystem.cs # Logic for survival
│       ├── Equipment.cs         # Scientific equipment
│       ├── Waste.cs             # Waste management
│       ├── FoodContainer.cs     # Food storage
│       └── OxygenBootle.cs      # Oxygen storage
```

## Authors and Context

* **Author:** Filip Żurek
* **Institution:** AGH University of Krakow
* **Faculty:** Faculty of Computer Science, Electronics and Telecommunications
* **Field of Study:** Electronics and Telecommunications
* **Course:** Designing and creating high-level object-oriented applications

## License

This software is distributed under the MIT License. Refer to the [LICENSE](LICENSE) file for the full text.

---
*AGH University of Krakow - Designing and creating high-level object-oriented applications 2025*