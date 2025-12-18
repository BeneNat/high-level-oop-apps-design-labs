# Lab 7: Command and Adapter Patterns

This module explores two crucial design patterns: **Command** (Behavioral) and **Adapter** (Structural). The objective is to learn how to decouple the object that invokes an operation from the one that knows how to perform it, and how to make incompatible interfaces collaborate.

## Module Overview

The assignment is divided into two projects demonstrating different aspects of these patterns.

### Part 1: Smart Home System (`Lab7-Basics`)

This project implements a control system for home automation devices.

#### Key Concepts Implemented:
* **Command Pattern**:
    * **Interface**: `ISmartHomeExecutable` defines the common contract (`Execute` method).
    * **Concrete Commands**: `StartWiFiCommand`, `SetThermostatCommand`, `SetAlarmCommand` encapsulate the request and bind it to a specific receiver.
    * **Invoker**: `SmartHomeScheduler` stores a queue of commands and triggers them sequentially. It doesn't need to know *what* device it controls, only that it can `Execute` a command.
    * **Receivers**: `WiFi`, `Thermostat`, `SecurityAlarm` contain the actual business logic.

* **Adapter Pattern**:
    * **Scenario**: Integrating a new device class (`WiFi2`) that has an incompatible interface (requires a network name argument for login) with the existing system.
    * **Solution**: `WiFiAdapter` wraps the `WiFi2` instance and implements the standard `ISmartHomeExecutable` interface, translating the call internally.

### Part 2: Tourist Trip Planner (`TouristTrip-System`)

A homework project simulating a tourist itinerary planner. It allows users to queue up a series of activities (visiting attractions, eating, shopping) and execute the entire plan at once.

#### System Architecture:
* **Command Interface**: `IVisitTouristAttraction` ensures all travel activities follow a standard execution protocol.
* **Receivers (Places)**:
    * `Museum`: Handles ticket buying and visiting logic.
    * `Park`: Manages simple visits.
    * `Restaurant`: Handles table booking and ordering.
    * `SouvenirShop`: Manages inventory and purchases.
* **Concrete Commands**:
    * `VisitMuseumCommand`, `VisitParkCommand`, `EatAtRestaurantCommand`, `BuySouvenirCommand`.
    * These classes hold references to their respective receivers and any necessary parameters (e.g., specific meals or souvenirs).
* **Invoker**:
    * `TripScheduler` acts as the itinerary manager. It allows adding commands to a list (`AddCommand`) and then running the entire trip (`RunTrip`), demonstrating the power of the Command pattern in macro recording and batch processing.

## Project Structure

```text
├── Lab7-CommandAndAdapter/
│   ├── README.md                # This documentation file
│   │
│   ├── Lab7-Basics/             # Smart Home Implementation
│   │   ├── Program.cs           # Client code
│   │   ├── ISmartHomeExecutable.cs
│   │   ├── SmartHomeScheduler.cs
│   │   ├── WiFiAdapter.cs       # Adapter Pattern implementation
│   │   └── ... (Commands & Receivers: WiFi, Thermostat, Alarm)
│   │
│   └── TouristTrip-System/      # Homework Project
│       ├── Program.cs           # Trip simulation
│       ├── TripScheduler.cs     # Invoker
│       ├── IVisitTouristAttraction.cs # Command Interface
│       │
│       ├── Commands/            # (Logical Grouping)
│       │   ├── VisitMuseumCommand.cs
│       │   ├── VisitParkCommand.cs
│       │   ├── EatAtRestaurantCommand.cs
│       │   └── BuySouvenirCommand.cs
│       │
│       └── Receivers/           # (Logical Grouping)
│           ├── Museum.cs
│           ├── Park.cs
│           ├── Restaurant.cs
│           └── SouvenirShop.cs
```

## Authors and Context

* **Author:** Filip Żurek
* **Institution:** AGH University of Krakow
* **Faculty:** Faculty of Computer Science, Electronics and Telecommunications
* **Field of Study:** Electronics and Telecommunications
* **Course:** Designing and creating high-level object-oriented applications

## License

This software is distributed under the MIT License. Refer to the [LICENSE](../LICENSE) file for the full text.

---
*AGH University of Krakow - Designing and creating high-level object-oriented applications 2025*