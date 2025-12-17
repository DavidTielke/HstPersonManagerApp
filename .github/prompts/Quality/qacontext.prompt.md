# Data Classes vs Management Classes
- A management class is a class, that is not placed inside a namespace containing ".DataClasses"
- A data class is a class, that is placed inside a namespace containing ".DataClasses"

# Ignored classes for qa analysis
- App
- *Controller
- Program
- ServiceCollectionInitializer

# QA Check
Doing a QA check (Shortcut : "QA Check") means:
- Checking for PCC (Pattern Consistency Check) : Described in namingconsistency.prompt.md
- Checking for DC (Decoupling Check) : Described in decouplingcheck.prompt.md
- Doind a Code Review (CR) : Described in codeguidelines.prompt.md