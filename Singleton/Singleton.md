# Singleton Desing Pattern

### C# implementation

- Private contructores
- Read-only Instance
- Static Accessor
- The class shold be sealed
- Instance inicialized in a static constructor

- Static contructor provides:

  - lazy loading
    - Sometime initialize can be prettier have, and the instance is initiated only when we needed
  - Thread Safety
    - You can safely use this in multi-threading applications withou having to worry that two or more will perhaps get different intances of the application. The static contrucor runs only once in the whole application domain

- Not however, that if your object is immutable then you shouldn't be worrying about read safety any away, In the case of our primayPlayer Class, it still isn't immutable so we are worried, but this may change in the future.

- The singleton pattern as we defined it may be considered an anti-pattern, and a direct violation of the single responsibility principle by some developers. The reaseon is because it assumes the responsibility of creating a instance of itself, so it violates the SRP by having extra responsability beyond the ones that have to do with its functionality.

There is actually an even better way to define a singleton class, not that the way we show here is bad per se, but it`s always better to use dependency injection, but that's another story.
