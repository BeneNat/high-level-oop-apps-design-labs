# Lab 2: Polymorphism and Abstraction

This module focuses on the implementation of polymorphism in C# using abstract classes, virtual methods, and interfaces. It includes basics of dynamic dispatch and a homework project modeling a medieval social structure.

## Part 1: Polymorphism Basics (Lab2-Basics)

The in-class exercises explored the `abstract`, `virtual`, and `override` keywords within a vehicle hierarchy.

### Key Concepts Implemented:
* **Abstract Base Class**: The `Vehicle` class serves as a template with the abstract method `GetVehicleType()`.
* **Polymorphism**: A `List<Vehicle>` is used to store mixed types (`Car`, `Bus`, `Train`). The program relies on Late Binding to execute the correct `ToString()` method at runtime.
* **Interfaces**: The `IBuyTicket` interface separates the "ticket buying" behavior from the vehicle inheritance chain, implemented by the `TicketBuyer` class.

## Part 2: Medieval Castle System (Homework)

A simulation of a medieval castle's inhabitants, focusing on hierarchy and interface implementation.

### System Architecture

The project models the castle's population using a strict inheritance tree and role-based interfaces.

#### Core Components
* **Inhabitant**: The abstract root class. It forces all derived classes to implement:
    * `Eat()`: Returns the food consumption units.
    * `ToString()`: Returns the inhabitant's description.
* **IDefender**: An interface defining the `ReadyToFight()` contract, ensuring all combat units provide a status report.

#### Class Hierarchy
1.  **Civilians**:
    * Inherit directly from `Inhabitant`.
    * Do not implement combat interfaces.
    * Consume fewer resources (2 food units).

2.  **Defenders**:
    * Inherit from `Inhabitant` and implement `IDefender`.
    * **Crossbowman**: Consumes 3 food units.
    * **Pikeman**: Consumes 4 food units.
    * Both classes provide unique implementations of the `ReadyToFight()` method.

## Project Structure

```text
├── Lab2-Basics/                 # Project: Laboratorium2
│   ├── Vehicle.cs               # Abstract base class
│   ├── Train.cs / Bus.cs...     # Derived implementations
│   ├── IBuyTicket.cs            # Behavior interface
│   └── Program.cs               # Polymorphism demonstration
│
└── MedievalCastle-System/       # Project: MedivalCastle
    ├── Inhabitant.cs            # Abstract root
    ├── IDefender.cs             # Interface for combat units
    ├── Defender.cs              # Base class for soldiers
    ├── Civilian.cs              # Non-combatant implementation
    ├── Pikeman.cs               # Concrete defender
    ├── Crossbowman.cs           # Concrete defender
    └── Program.cs               # Castle management logic
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