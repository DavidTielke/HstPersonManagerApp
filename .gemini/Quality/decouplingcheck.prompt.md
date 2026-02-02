---
mode: agent
description: "decoupling of managment classes"
---

- Concept of management classes and data classes is described in qacontext.md
- Classes ignored for this check are described in qacontext.md

# Context of a decoupling check
- Shortcut for decoupling check is "DC"
- Management classes are allowed to depend on data classes
- Management classes should not depend on other management classes
- Management classes should only depend on abstractions (interfaces) of other management classes, not on concrete implementations
- Management classes are allowed to depend on external libraries if necessary
- management classes have to implement a interface with the same name prefixed with "I" (e.g. UserManager has to implement IUserManager)
