# Lab 6: Behavioral Design Patterns

This module focuses on **Behavioral Design Patterns**, specifically **State** and **Strategy**. The goal is to learn how to alter an object's behavior when its internal state changes and how to define a family of algorithms, encapsulate each one, and make them interchangeable.

## Module Overview

The assignment is divided into three distinct parts covering different aspects of behavioral modeling.

### Part 1: Game State Management (`Lab6_task1`)

Implementation of the **State Pattern** to control a simple game context.
* **Context**: `GameApp` maintains an instance of a `GameState` subclass that defines the current behavior.
* **States**:
    * `MenuState`: Starting point, allows transitioning to the game.
    * `DuringGame`: Active gameplay, handles keys differently than menu.
    * `ShopState`, `ChatState`: Specialized modes with unique key bindings.
* **Mechanism**: Methods like `EnterButton()`, `EscapeButton()` delegate execution to the current state object, allowing dynamic behavior changes without complex `if-else` chains.

### Part 2: Sorting Strategy (`Lab6_task2`)

Implementation of the **Strategy Pattern** for sorting algorithms.
* **Context**: `Sorter` class that delegates the sorting task to a `SortingAlgorithm`.
* **Strategies**: `InsertionSort`, `SelectionSort` (and potential others).
* **Benefit**: The sorting algorithm can be swapped at runtime (e.g., based on dataset size) without modifying the client code.

### Part 3: Water Lifecycle System (`WaterDropLifeCycle`)

A homework project simulating the lifecycle of a water drop using the **State Pattern**. The simulation models the transitions of water through various environmental states.

#### System Architecture:
* **Context**: `WaterDrop` represents the water particle moving through the cycle.
* **Abstract State**: `DropState` defines the contract for all environmental states.
* **Concrete States**:
    * `Chmura` (Cloud), `Rzeka` (River), `Ocean`, `Studnia` (Well)
    * `Roslina` (Plant), `Zwierze` (Animal), `Czlowiek` (Human)
    * `Oczyszczalnia` (Purification Plant)
* **Transitions**: Each state encapsulates the logic for where the water drop can go next (e.g., from *River* to *Ocean*, from *Human* to *Purification Plant* or *Cloud* via respiration).

## Project Structure

```text
├── Lab6-StateAndStrategy/
│   ├── README.md                # This documentation file
│   │
│   ├── Lab6-Basics/
│   │   ├── Lab6_task1/          # State Pattern (Game)
│   │   │   ├── GameApp.cs       # Context
│   │   │   ├── GameState.cs     # Abstract State
│   │   │   ├── MenuState.cs
│   │   │   └── ...
│   │   │
│   │   └── Lab6_task2/          # Strategy Pattern (Sorter)
│   │       ├── Sorter.cs        # Context
│   │       ├── SortingAlgorithm.cs # Strategy Interface
│   │       ├── SelectionSort.cs
│   │       └── ...
│   │
│   └── WaterLifecycle-System/   # Homework Project
│       └── WaterDropLifeCycle/
│           ├── WaterDrop.cs     # Context class
│           ├── DropState.cs     # State Base Class
│           ├── Chmura.cs        # Concrete State 1
│           ├── Rzeka.cs         # Concrete State 2
│           ├── Ocean.cs         # ...
│           └── Program.cs       # Simulation loop
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