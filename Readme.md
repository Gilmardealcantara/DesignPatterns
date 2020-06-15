# Design Patterns Using C# and .NET Core

Generalized, reusable solutions to common design issues in software engineering.

- Groups:

  - Creational:
    Patterns are all about instantiating objects, how objects are instantiating and
    how many instances of them we are allowed to create.

  - Structural:
    Patterns are about the app's structure. Sometime you have complex class or objects or objects that are
    composed from smaller class or objects. Structural design pattern offers the most efficient way to work in situations like this and solve any challenges that may arise.

  - Behavior:
    Determine ways of application flow and how objects communicate with each other and how they interact
    with each other.

- https://github.com/PacktPublishing/Design-Patterns-using-C-and-.NET-Core
- https://refactoring.guru/design-patterns

## 1 - SOLID Principles

- 1.1 - Single Responsibility Principle
  A class or method should be responsible for a single part of the functionality
  A class or method has only one reason for change.

- 1.2 - Open/d Principle
  Open to extension and close to modification

- 1.3 - Liskov Substitution Principle
  Also Know as Substitutability. You should be able to use a subclass
  in place of its parent class, or
  a subclass should be used wherever its base class can be used

- 1.4 - Interface Segregation Principle
  Your classes and modules should depends on abstractions instead of concrete implementations (abstractions = interfaces)

## 2 - Creational Design Patterns

- 2.1 - Singleton Pattern
  You can have only a single instance of a specific class throughout the entire application

- 2.2 - Factory Pattern
  Combine SRP and OCP.
  Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

- 2.3 - Loose Coupling
  Software parts that communicate with each other have little to no knowledge of each other's actual implementation

  Loose coupling is all about interfaces. Parts of the system communicate through conventions that are established and enforced through interfaces. They don't have to know about how each of the parts is designed.

- 2.4 - Object Pool (not implemented)
  A pool of pre-initialized objects whose initialization is heavyweight. Every time we need such and object
  we take one from the pool and return it back to the pool.

## 3 - Dependency Injection

- 3.1 - Introduction (DI)

  - 'new' is not allowed
  - OOP not exists without 'new'
  - Allowed to create instance of VOs (Value Objects)
  - Factories
  - Not allowed to use 'new' with dependencies
  - Need a DI Container

- 3.2 - Creating a Custom Container

  - DI Container = IoC Container
  - Register and resolver dependencies

- 3.3 - Built-in ASP.NET Core IoC Container

- 3.4 - Singleton Versus Transient Versus Scoped

  - Singleton:
    The service is instantiated once and used throughout the application
    The service is created the first time we request it.
  - Transient:
    A new instance is created every time we request it.
  - Scoped:
    A new instance is created for every Http Request, not by service request

- 3.5\* - DIP vs IoC vs DI
  https://www.tutorialsteacher.com/ioc/introduction

## 4 - Structural Design Patterns

- 4.1 - Decorator Pattern
  Decorator is a structural design pattern that lets you attach new behaviors to objects by placing these
  objects inside special wrapper objects that contain the behaviors.
  -Respect the Open/Close Principle
  -Used here to combine cards

- 4.2 - Adapter Pattern (Convert a interface in another) (WeaponAdapter)

- 4.3 - Facade Pattern
  The goals is to simplify an interface -> (GameBoard, GameBoardFacade)
  Law of Demeter

- 4.4 - Composite Pattern
  To create part-whole collections in the form of tree-like
  structures that can contain both individual items and collections as well
  part-whole collections

- 4.5 - Proxy Pattern
  The proxy pattern is specialize in call a remote method
  The proxy stands as a middleware between the api of bards and the Game board Facade.

## 5 - Behavioral Design Patterns

- 5.1 - Strategy Pattern
  The primary advantage that the strategy pattern is the ability to pick the most appropriated algorithm from a group of similar algorithms at runtime. Used here to implements notifications.

- 5.2 - Observer Pattern
  The concept is pretty simple. You have an entity, a subject that you might want to watch for changes. It could be a property or it could be an event that's usually triggered. Then, you have a list of observers that register to that property, and when that property changes they are notified back with the change and each and every one of them may behave differently depending on their specific task. But all of them will be notified at the same time as a group for the change of the property. In c# the implementation is built in using events.

- 5.3 - Command Pattern
  Encapsulate a request as an object, thereby letting you parametrize clients with different requests, queue or log requests, and support undoubled operations.
  Promote "invocation of a method on an object" to full object status

  Here we will encapsulate the battle between the two entities in a command.

  Command vs strategy

  - Strategy pattern handles the objects, the command also change the state.
  - Strategy algorithms are swappable.
  - The command pattern allows the execution of different encapsulated commands.
  - The command pattern can be stored, reused or used for und purposes.

- 5.4 - Template Method
  Template pattern use inheritance instead of interfaces. We demonstrate the template method pattern by an example, and that example will be the creation of multiple battlefields in our application.

- 5.5 - State Pattern
  The state pattern is great at well, imitating states in your app. This is a finite state machine diagram. We begin with three states for our multiplayer mode subscription.
