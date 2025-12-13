# Lab 5: Creational Design Patterns

This module focuses on **Creational Design Patterns**, specifically **Factory Method** and **Abstract Factory**. The goal is to understand how to encapsulate object creation logic, promote loose coupling, and manage families of related objects.

## Module Overview

The assignment consists of two distinct projects demonstrating different applications of factory patterns.

### Part 1: Factory Patterns in Transport Systems (`lab5`)

This project refactors the Vehicle hierarchy from Lab 2 to use professional creation patterns.

#### Key Concepts Implemented:
* **Factory Method Pattern**:
    * `VehicleFactory` (Abstract Creator) defines the interface for creating objects.
    * `TrainFactory`, `CarFactory`, `BusFactory` (Concrete Creators) implement the creation logic for specific vehicle types.
    * Allows the client code (`Program.cs`) to work with the abstract `VehicleFactory` without knowing the concrete classes of vehicles being created.

* **Abstract Factory Pattern**:
    * `TransportFactory` defines a contract for creating families of related or dependent objects (e.g., a Vehicle AND a Ticket).
    * **Families**:
        * **City Transport**: Creates `Bus` and `BusTicket`.
        * **InterCity Transport**: Creates `Train` and `TrainTicket`.
    * Ensures that client code receives compatible objects (e.g., you don't get a Train with a Bus Ticket).

### Part 2: Ice Cream Shop System (`IceCreamStand`)

A simulation of an ice cream vendor where the product offering changes dynamically based on the day of the week or time of day.

#### System Architecture:
* **IceCream Hierarchy**: Abstract base class with concrete implementations (`CreamyIceCream`, `Sorbet`, `FruityIceCream`, `ItalianIceCream`).
* **Dynamic Factory (`IceCreamFactory`)**:
    * Implements logic to switch `ProductionMode` (e.g., `ChocolateDay`, `FruitDay`).
    * The `SpecialOfTheDay()` method returns different object types depending on the internal state of the factory.
* **Vendor (`IceCreamVendor`)**:
    * Depends only on the `IceCreamFactory`.
    * Does not control *what* is produced, only *sells* what the factory provides, adhering to the Single Responsibility Principle.

## Project Structure

```text
├── Lab5-FactoryPattern/
│   ├── README.md                # This documentation file
│   │
│   ├── lab5/                    # Basics & Advanced Factories
│   │   ├── Program.cs           # Client code demonstrating patterns
│   │   ├── Vehicle.cs           # Abstract Product A
│   │   ├── Ticket.cs            # Abstract Product B
│   │   │
│   │   ├── Factories/           # (Logical Grouping)
│   │   │   ├── VehicleFactory.cs        # Factory Method Base
│   │   │   ├── TransportFactory.cs      # Abstract Factory Base
│   │   │   ├── CityTransportFactory.cs  # Concrete Family 1
│   │   │   └── InterCity...             # Concrete Family 2
│   │   └── ... (Concrete Implementations)
│   │
│   └── IceCreamStand/           # Homework Project
│       ├── Program.cs           # Simulation loop
│       ├── IceCreamVendor.cs    # Client class
│       ├── IceCreamFactory.cs   # Factory with state logic
│       ├── ProductionMode.cs    # Enum for factory states
│       └── IceCream/            # Product implementations
│           ├── IceCream.cs
│           ├── Sorbet.cs
│           └── ...
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