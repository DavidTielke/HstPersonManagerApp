---
mode: agent
decription: Ensure consistent naming conventions across the codebase.
---

Concept of management classes and data classes is described in qacontext.md

# Description is the conecpt "naming patterns"
- Shortcut for pattern consistency check is "PCC"
- A "Pattern Catalogue" is a list of naming patterns for management classes
- A naming pattern is a allowed class name suffix for management classes, alloed suffixes are listed in the namepattern catalogue below.
- For each nameing pattern a list of allowed method name must be provided
	- A "full method name" (e.g.: Add) means that class can have this method with this exact name and an additional suffix "Async" if the method is async
	- A "partial method name" (e.g. Get*) means that class can have methods starting with this name, e.g. "Get", "GetById", "GetAll" are all allowed if "Get" is in the allowed method names list and async versions "GetAsync", "GetByIdAsync", "GetAllAsync" are also allowed
	- No other method names are allowed for this class except the ones in the allowed method names list (with or without "Async" suffix)
- Pattern Concistency means: All Management classes (except classes from class blacklist) must follow one of the naming patterns in the Pattern Catalogue

# Expected Output
- A Mesasage on top decribing if the codebase is consistent with the naming patterns or not
- A list of all management classes that do not follow the naming patterns with explanation what is wrong (e.g. invalid class name, invalid method name)
- Just this output and nothing more

# Class Blacklist
- "Program", "ServiceCollectionInitializer", "*Controller", "App"

# Namepattern Catalogue

- "Manager" : Add, Update, Remove, Get*, Is*, Are*
- "DisplayCommands" : Display*
- "Parser" : Parse*
- "Repository" : Insert, Update, Delete, Query
- "Reader" : Read*