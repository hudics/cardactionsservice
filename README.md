# Card Actions Service

Card Actions Service is a microservice that consists of the following components:

- **API**: This component handles the HTTP requests and responses. It exposes endpoints for interacting with the card actions service.
- **Domain**: This component contains the core business logic and domain models. It is responsible for the main functionalities and rules of the card actions service.
- **Infrastructure**: This component deals with the data access and external integrations. It includes repositories, data sources, and other infrastructure-related code.
- **Tests**: This component could includes unit tests, integration tests, and other types of tests to ensure the quality and correctness of the card actions service.

Each component is designed to be modular and independent, allowing for easy maintenance and scalability.

## Project Purpose

This project is created for recruitment purposes. To deliver a prototype, SQLite has been used as the database.

### Why?

It was decided to use the database to store information about the available actions for cards. This makes the system more flexible and allows for easy addition or removal of actions without modifying the code or recompiling the application.

The database stores only the allowed actions for specific combinations of card type and status. It is assumed that if an action is not present in the database, it means it is not available. Regarding the PIN requirement, the rule established is that if the RequiresPin field is not set, the action does not require additional authentication and is available according to the remaining rules.

