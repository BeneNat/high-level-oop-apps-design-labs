# Lab 1: Inheritance and Class Hierarchy Design

This module investigates the impact of access modifiers on inheritance and the implementation of complex polymorphic structures in C#. It consists of basic exercises validating language rules and a comprehensive system modeling a world travel itinerary.

## Part 1: Inheritance Fundamentals (Lab1-Basics)

The objective of the in-class exercises was to explore how C# handles member accessibility and initialization in an inheritance chain.

### Key Concepts Implemented:
* **Access Modifiers**: Verification of visibility for `public`, `protected`, and `private` members between base and derived classes. Implemented in the `Animal` class[cite: 2].
* **Class Hierarchy**: Implementation of a linear chain: `Animal` $\to$ `Bird` $\to$ `Flamingo`[cite: 5, 17].
* **Constructor Chaining**: Usage of the `base` keyword to correctly initialize parent class state (e.g., passing `name` and `weight` to the `Animal` constructor)[cite: 17].
* **Behavior Extension**: Adding specific methods such as `LayEggs` in `Bird` and `Incubation` in `Flamingo` to demonstrate functional extension[cite: 5, 17].

## Part 2: WorldTour System (Homework)

The `WorldTour-System` project implements a complex inheritance hierarchy based on the "Trip around the world" topic. It models a budget and itinerary management system, strictly adhering to the **Is-A relationship** principle[cite: 12].

### System Architecture

The system is visualized in the `WorldTour.drawio` UML diagram[cite: 22].

#### Core Components
* **WorldTour**: The central base class managing the budget, number of countries, and start date[cite: 11].
* **Itinerary**: Handles the logic for adding places and tracking travel modes[cite: 26].

#### Transport Hierarchy (Polymorphism)
The project features a deep inheritance tree allowing for polymorphic handling of various transport modes:

1.  **Global Level**:
    * `GlobalTransport` extends `WorldTour` to handle long-distance travel metrics like average cost[cite: 8].
    * Derived classes: `IntercontinentalFlight` (Airline details) [cite: 10] and `OceanCruise` (Ship details)[cite: 27].

2.  **Local Level**:
    * `LocalTransport`: Abstract layer for regional travel[cite: 6].
    * `RoadTransport`: Base for ground vehicles (`Bus`, `Train`, `Taxi`), managing speed limits and toll costs[cite: 21, 15, 9, 7].
    * `AirTransport`: Base for regional flights, managing baggage and airport codes[cite: 25].
        * Derived classes include `DomesticFlight` [cite: 20] and `HelicopterTransport`[cite: 12].

#### Planning Hierarchy
* **ContinentalPlan**: Tracks visited countries on a specific continent[cite: 14].
* **CityPlan**: Extends the continental plan to manage specific city landmarks[cite: 4].

## Project Structure

The module is divided into two projects:

```text
├── Lab1-Basics/                 # Namespace: zadanie1
│   ├── Animal.cs
│   ├── Bird.cs
│   ├── Flamingo.cs
│   └── Program.cs
│
└── WorldTour-System/            # Namespace: WorldTour
    ├── WorldTour.drawio         # UML Diagram
    └── WorldTour/               # Main Project Source
        ├── WorldTour.cs         # Base Class
        ├── Itinerary.cs         # Planning Logic
        ├── Transport/           # (Logical Grouping)
        │   ├── GlobalTransport.cs
        │   ├── LocalTransport.cs
        │   ├── RoadTransport.cs
        │   └── AirTransport.cs
        └── ... (Concrete Implementations: Taxi, Bus, Train, etc.)
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