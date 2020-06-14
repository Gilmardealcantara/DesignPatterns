# Design Patterns Using C# and .NET Core

## 1 - SOLID Principles

1.1 - Single Responsibility Principle
1.2 - Open/d Principle
1.3 - Liskov Substitution Principle
1.4 - Interface Segregation Principle
1.5 - Dependency Inversion Principle
1.5.1 - DIP vs IoC vs DI

2.3 - Loose Coupling

## 2 - Creational Design Patterns

2.1 - Singleton Pattern
2.2 - Factory Pattern
2.4 - Object Pool

## 3 - Dependency Injection

3.1 - Creating a Custom Container
3.2 - Built-in ASP.NET Core IoC Container
3.3 - Singleton Versus Transient Versus Scoped

## 4 - Structural Design Patterns

4.1 - Decorator Pattern

4.2 - Adapter Pattern (Convert a interface in another) (WeaponAdapter)

4.3 - Facade Pattern
The goals is to simplify an interface -> (GameBoard, GameBoardFacade)
Law of Demeter

4.4 - Composite Pattern
To create part-whole collections in the form of tree-like
structures that can contain both individual items and collections as well
part-whole collections

4.5 - Proxy Pattern
The proxy pattern is specialize in call a remote method
The proxy stands as a middleware between the api of bards and the Game board Facade.

## 5 - Behavioral Design Patterns

5.1 - Strategy Pattern
The primary advantage that the strategy pattern is the ability to pick the most appropriated
algorithm from a group of similar algorithms at runtime. Used here to implements notifications

5.2 - Observer Pattern
The concept is pretty simple. You have an entity, a subject that you might want to watch for changes. It could be a property or it could be an event that's usually triggered. Then, you have a list of observers that register to that property, and when that property changes they are notified back with the change and each and every one of them may behave differently depending on their specific task. But all of them will be notified at the same time as a group for the change of the property.

In c# the implementation is built in using events.

5.3 - Command Pattern
5.4 - Template Method
5.5 - State Pattern
