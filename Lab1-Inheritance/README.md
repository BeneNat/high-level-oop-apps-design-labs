# Lab 1: Inheritance and Class Hierarchy Design

This module covers the core principles of class inheritance in C#, including access control, constructor chaining, and the practical application of these concepts in designing a structured, multi-level class system.

## Module Overview

The assignment is composed of two distinct components: a focused, in-class exercise (`Lab1-Basics`) and a complex design project (`WorldTour-System`) based on a provided UML specification.

### Part 1: Inheritance Fundamentals (`Lab1-Basics`)

This section focuses on the strict rules governing access to inherited members. The primary objective was to:

* **Access Control Demonstration**: Verify visibility and accessibility of `public`, `protected`, and `private` members across a three-level hierarchy (`Animal` -> `Bird` -> `Flamingo`).
* **Constructor Implementation**: Utilize the `base` keyword to ensure proper initialization and state management in the base classes when derived class objects are instantiated.
* **Polymorphic Behavior**: Extend base functionality by overriding or adding specialized methods (e.g., `LayEggs`, `Incubation`).

### Part 2: WorldTour System - UML Implementation

The `WorldTour-System` is an implementation of a complex class hierarchy modeling a global travel management system. The design strictly adheres to the provided UML diagram to demonstrate capability in translating architectural specifications into functional C# code.

#### System Architecture Overview

The system manages travel itineraries, costs, and modes of transport for a planned world tour.

* **Core Entities**: `WorldTour` (Budget & Date Management), `Itinerary` (Plan Management).
* **Transport Hierarchy**: A deep inheritance tree for various travel modes, ensuring the **Is-A relationship** is maintained throughout:

| Level | Base Class (Abstract/Concrete) | Example Derived Classes | Design Focus |
| :--- | :--- | :--- | :--- |
| **1** | `GlobalTransport` | `IntercontinentalFlight`, `OceanCruise` | High-level, long-distance travel. |
| **2** | `LocalTransport` | `RoadTransport`, `AirTransport` | Intermediate abstract layer for regional travel. |
| **3** | `RoadTransport` | `BusTransport`, `TrainTransport`, `TaxiTransport` | Specialized cost/speed calculation based on ground transport type. |

This structure leverages polymorphism, allowing the system to treat all transport types uniformly while executing their specific logic.

## Project Structure (Lab 1 Module)

```text
├── Lab1-Inheritance/
│   ├── README.md                # This documentation file
│   │
│   ├── Lab1-Basics/             # In-class exercise project
│   │   └── ... (Animal.cs, Bird.cs, Program.cs)
│   │
│   └── WorldTour-System/        # Homework project
│       ├── WorldTour.drawio     # Original UML diagram (for reference)
│       ├── Transport/           # Folder for the Transport Hierarchy classes
│       ├── Itinerary/           # Folder for Planning Hierarchy classes
│       └── ... (Program.cs)
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