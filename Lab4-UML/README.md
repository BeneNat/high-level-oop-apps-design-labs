# Lab 4: UML and Class Diagrams

This module focuses on software design and modeling using the Unified Modeling Language (UML). The primary objective was to create a comprehensive class diagram representing a complex object-oriented system, adhering to strict architectural standards and design principles.

## Assignment Overview

The task required designing a complete system architecture for the "Trip around the world" topic (initially explored in Lab 1). The resulting diagram serves as a technical blueprint for the application, visualizing static structure and relationships between components.

### Design Requirements
* **Complexity**: The model includes over **15 non-trivial classes** (classes with unique fields, properties, or methods).
* **Relationships**: The diagram demonstrates extensive use of **inheritance**, **implementation** (interfaces), **aggregation**, and **composition**.
* **Correctness**: The design follows standard UML syntax and avoids common modeling errors discussed during lectures.

## System Architecture (WorldTour)

The designed system manages the logistics, financials, and participants of a world tour. Key architectural modules include:

* **Core Management**:
    * `WorldTour`: The central aggregate root managing destinations, the itinerary, and the total budget.
    * `TravelGroup`: Manages a list of participants and provides filtering logic (e.g., `GetAdultsOnly`).
* **Logistics**:
    * **Transport**: Abstract base for different travel modes (`Flight`, `Train`, `Car`, `Boat`).
    * **Accommodation**: Abstract base for staying options (`Hotel`, `Hostel`, `Airbnb`).
    * `Reservation`: Links specific accommodations and transport to dates and confirmation numbers.
* **Financial Module**:
    * `Budget`: Handles expenses and calculates remaining funds.
    * `CurrencyConverter`: A utility class (Singleton pattern) for handling monetary conversions.
* **Participant Management**:
    * `Participant`: Stores personal details and documents.
    * `Document` & `IVisaChecker`: Interfaces and classes responsible for validating travel documents and visa requirements based on the destination.

## Project Structure

```text
├── Lab4-UML/
│   ├── README.md                    # This documentation file
│   └── WorldTour-Diagram/           # Diagram artifacts
│       ├── WorldTourUML.drawio      # Editable source file (draw.io)
│       └── WorldTourUML.png         # Exported visual representation
```

## Tools Used
draw.io

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