---
mode: agent
description: "decoupling of managment classes"
---

- Concept of management classes and data classes is described in qacontext.md
- Classes ignored for this check are described in qacontext.md
- SHortcut for code review is "CR"
- If a rule is violated, output the corresponding rule number



# Basisprinzipien

## (SRP) Single Responsibility Principle
[cite_start]Das Single-Responsibility-Prinzip (SRP) besagt, dass jedes System nur eine fest definierte Aufgabe zu erfüllen hat[cite: 131]. [cite_start]Mehr als eine Verantwortung für eine Klasse führt zu mehreren Bereichen, in denen zukünftige Änderungen notwendig werden können[cite: 132].

## (ISP) Interface Segregation Principle
[cite_start]Das Interface-Segregation-Prinzip besagt, dass zu große Schnittstellen in mehrere schlanke Schnittstellen aufgeteilt werden müssen[cite: 136, 138]. [cite_start]Dies führt zu einer verbesserten Wartbarkeit, da Klassen nur noch die Methoden implementieren, die sie wirklich benötigen[cite: 138].

## (DIP) Dependency Inversion Principle
[cite_start]Das Dependency Inversion Principle (DIP) beschreibt, dass Module höherer Ebenen nicht von Modulen niedrigerer Ebenen abhängig sein sollen[cite: 141]. [cite_start]Beide sollten von Abstraktionen abhängen[cite: 142].

---

# Basismuster

## Factory
[cite_start]Das Muster beschreibt, wie ein Objekt durch Aufruf einer Methode anstatt durch direkten Aufruf eines Konstruktors erzeugt wird[cite: 148]. [cite_start]Die Fabrikmethode wird angewendet, wenn eine Klasse die von ihr zu erzeugenden Objekte nicht kennen kann bzw. soll[cite: 149].

## Singleton
Das Singleton stellt sicher, dass von einer Klasse genau ein Objekt existiert. [cite_start]Dieses Singleton ist darüber hinaus üblicherweise global verfügbar[cite: 153].

## Dependency Injection
Als Dependency Injection wird ein Entwurfsmuster bezeichnet, welches die Abhängigkeiten eines Objekts zur Laufzeit reglementiert. [cite_start]Die Abhängigkeit ist an einem zentralen Ort hinterlegt und wird nicht vom initialisierten Objekt selbst erzeugt[cite: 155].

## Decorator
[cite_start]Der Decorator ist eine flexible Alternative zur Unterklassenbildung, um eine Klasse um zusätzliche Funktionalitäten zu erweitern[cite: 158].

## MVC Pattern
[cite_start]Model View Controller (MVC) ist ein Muster zur Trennung von Software in die drei Komponenten Datenmodell (Model), Präsentation (View) und Programmsteuerung (Controller)[cite: 161].

---

# Namensgebung

## (BC0301) Sprache von Bezeichnern ist US Englisch
[cite_start]Bezeichner sind in US Englisch zu schreiben[cite: 166, 168].

## (BC0302) Domänenbegriffe auf Deutsch
[cite_start]Domänenbegriffe (gezielte Fachbegriffe) sind auf Deutsch geschrieben[cite: 170].

## (BC0303) Keine Sonderzeichen verwenden
[cite_start]Im gesamten Quellcode sind keine Sonderzeichen wie zum Beispiel ä, ö oder ü vorhanden[cite: 174, 175].

## (BC0304) Keine Nummern in Bezeichnern
[cite_start]Nummern werden in Bezeichnern nicht verwendet[cite: 177]. [cite_start]Einzige Ausnahme bilden domänenspezifische Nummern[cite: 178].

## (BC0305) Keine Typinformationen in Bezeichnern
[cite_start]In Bezeichnern werden keine Typinformationen wie zum Beispiel int, string oder str, verwendet[cite: 181, 182].

## (BC0306) Keine untergeordneten Wiederholungen
[cite_start]Die Namen der Member einer Klasse oder Enums beinhalten nie den Namen ihrer übergeordneten Klasse[cite: 185, 186].

---

# Layout

## (BC0401) Kommentare nur wenn nötig
[cite_start]Kommentare im Quellcode werden nur geschrieben, wenn diese wirklich nötig sind[cite: 192, 193].

## (BC0402) var nur verwenden, wenn Typ offensichtlich ist
[cite_start]`var` als Typ Information wird nur verwendet, wenn der Typ des Ergebnisses sofort erkennbar ist[cite: 197]. [cite_start]`var` wird bei jeder LINQ-Abfrage benutzt[cite: 198].

## (BC0403) Deklaration und Initialisierung von Variablen so spät wie möglich
[cite_start]Variablen in Methoden werden immer dann deklariert, wenn sie auch wirklich benutzt werden[cite: 201, 202].

## (BC0404) Nutze Object und Collection Initialisierer
[cite_start]Im Quellcode werden Objekt Initialisierer und Collection Initialisierer benutzt[cite: 205].

## (BC0405) Kein expliziter Vergleich mit true oder false
[cite_start]Ein Vergleich auf einen boolschen Wert mit einer Abfrage auf `true` oder `false` wird im gesamten Quellcode nicht verwendet[cite: 208, 209].

## (BC0406) Default in switch/case
[cite_start]Eine `switch case` Anweisung endet immer mit einem `default` Block[cite: 212, 213]. [cite_start]Darf der `default` Block nie erreicht werden, wird hier eine aussagekräftige Ausnahme geworfen[cite: 214].

## (BC0407) else-if mit else beenden
[cite_start]Eine `else-if` Anweisung endet immer mit einem `else` Block[cite: 217, 218].

## (BC0408) Keine ref und out Parameter verwenden
[cite_start]Es werden keine `ref` oder `out` Parameter verwendet[cite: 221]. [cite_start]Werden mehrere Rückgabe Parameter benötigt, wird immer ein Parameterobjekt zurückgegeben[cite: 223].

## (BC0409) Ergebnis einer as-Operation überprüfen
[cite_start]Jedes Ergebnis aus einem Cast einer `as`-Operation wird auf `null` überprüft[cite: 225, 226].

## (BC0410) Keinen Code auskommentieren
[cite_start]Auskommentierter Quellcode ist im gesamten Quellcode nicht vorhanden[cite: 230, 231].

## (BC0411) Keine "Magic Numbers" verwenden
Es gibt keine Vergleiche auf Strings wie "01", „1“ oder „001“. [cite_start]Verglichen werden muss auf Enums oder konstante Strings[cite: 233, 234].

---

# Komponentendesign

## (BC0501) Komponenten
[cite_start]Jede Komponente besitzt das Präfix „???.“ gefolgt vom Komponentennamen[cite: 243]. [cite_start]Eine Komponente entspricht immer einem Ordner in der jeweiligen Schicht[cite: 244].

## (BC0502) Namespaces
[cite_start]Der Namespace beginnt immer mit ??? gefolgt von dem Name des Layer und dem Komponentennamen (Data, Business, Common), in dem sich die Komponente befindet[cite: 247, 248].

## (BC0503) Eine Aufgabe pro Komponente
[cite_start]Eine Komponente darf nur eine einzige Aufgabe erfüllen[cite: 252, 253].

## (BC0504) Kontrakt und Implementierung
[cite_start]Eine Komponente besitzt immer genau einen Kontrakt, dazu mindestens eine oder mehrere Implementierungen[cite: 256, 257].

## (BC0505) Ausnahmen / Exceptions im Kontrakt
[cite_start]Jede Komponente besitzt genau eine komponentenspezifische Basis-Ausnahme, welche von der Klasse `Exception` abgeleitet ist[cite: 271]. [cite_start]Tritt eine Ausnahme auf, die dem Kontrakt nicht bekannt ist, muss die Implementierung diese in eine Ausnahme von seinem Kontrakt umwandeln[cite: 274].

## (BC0506) Datenklassen im Kontrakt
[cite_start]Datenklassen (im Ordner Datenklassen des Kontrakts) besitzen nur Eigenschaften[cite: 277, 278]. [cite_start]In Datenklassen ist jegliche Funktionalität verboten[cite: 279].

## (BC0507) Callbacks im Kontrakt
[cite_start]Wenn die Implementierung das Auslösen von Events unterstützt, so müssen die Delegaten und Callbacks im Kontrakt definiert werden[cite: 281, 282].

## (BC0508) Schnittstellen im Kontrakt
[cite_start]Im Root Verzeichnis liegen die Interfaces der Komponente, welche die Funktionalität der Komponente beschreiben[cite: 286].

## (BC0509) Interne Abhängigkeiten
[cite_start]Da die Testbarkeit auf Klassenebene nicht gefordert ist, müssen nicht alle Abhängigkeiten auf Klassenebene entkoppelt werden[cite: 294, 295].

## (BC0510) Externe Abhängigkeiten nur gegen Kontrakte
[cite_start]Abhängigkeiten von Komponenten werden immer über den Kontrakt einer anderen Komponente referenziert[cite: 297, 298]. [cite_start]Eine Komponenten Implementierung besitzt nie eine Referenz auf eine weitere Implementierung[cite: 299].

---

# Klassendesign

## (BC0601) Klassen
[cite_start]Klassen werden im PascalCase geschrieben[cite: 310, 311].

## (BC0602) Interfaces
[cite_start]Interfaces werden im PascalCase mit führendem `I` geschrieben[cite: 313, 314].

## (BC0603) Enums
[cite_start]Enums werden im PascalCase geschrieben[cite: 316, 317].

## (BC0604) Delegaten
[cite_start]Delegaten werden in PascalCase geschrieben und besitzen den Suffix `Handler`[cite: 319, 320].

## (BC0605) Extension Klasse mit Suffix Extension
[cite_start]Extension Klassen werden im PascalCase geschrieben und müssen den Suffix `Extension` enthalten[cite: 322, 323].

## (BC0606) Basisklassen mit Suffix Base
[cite_start]Basisklassen werden im PascalCase geschrieben, müssen den Suffix `Base` enthalten und immer als `Abstract` deklariert werden[cite: 326, 327].

## (BC0607) Keine Klasse mit mehr als 220 LOC
[cite_start]Eine Klasse darf **220 Zeilen Quellcode** nicht überschreiten[cite: 329, 330].

## (BC0608) Keine Klasse mit mehr als 10 Methoden
[cite_start]Eine Klasse darf maximal **10 Methoden** besitzen[cite: 333, 334].

## (BC0609) Verhältnis öffentlichen zu privaten Methoden nicht mehr als 2:1
[cite_start]Eine Klasse sollte ein Verhältnis von öffentlichen zu geschützten Methoden von **zwei zu eins** nicht unterschreiten[cite: 337, 338].

## (BC0610) Eine Aufgabe pro Klasse
[cite_start]Eine Klasse darf nur eine einzige Aufgabe erfüllen (SRP)[cite: 341, 342].

## (BC0611) Klassen mit Schnittstellen entkoppeln
[cite_start]Abhängigkeiten innerhalb und außerhalb von Komponenten sind mit Schnittstellen zu entkoppeln[cite: 347, 348, 349].

## (BC0612) Keine bidirektionalen Abhängigkeiten
[cite_start]Eine Klasse darf keine bidirektionalen Abhängigkeiten besitzen[cite: 351, 352].

## (BC0613) Keine statischen Klassen
[cite_start]Es werden keine statischen Klassen implementiert[cite: 354, 355].

## (BC0614) Keine nested Klassen
[cite_start]Es werden keine nested Klassen (Klassen in Klassen) implementiert[cite: 358, 359].

## (BC0615) Ein Typ pro Datei
[cite_start]In einer Datei ist genau ein Typ Implementiert[cite: 361, 362].

## (BC0616) Die Sichtbarkeit von Klassen so weit wie möglich einschränken
[cite_start]Klassen werden nur dann als `public` deklariert, wenn diese auch wirklich von außen gebraucht werden[cite: 364, 365]. [cite_start]Andernfalls werden Klassen als `internal` deklariert[cite: 366].

## (BC0617) Dependency Injection nur über Konstruktor
[cite_start]Das Injizieren von Objekten mittels DIP erfolgt **ausschließlich über den Konstruktor** der Klasse[cite: 368, 369]. [cite_start]Die Felder der Objekte werden als `private readonly` deklariert[cite: 370].

## (BC0618) Member einer Klasse in richtiger Reihenfolge
[cite_start]Die Member einer Klasse sind immer in einer festgelegten Reihenfolge zu schreiben (beginnend mit privaten Feldern, endend mit privaten Methoden)[cite: 372, 373, 374, 380].

---

# Memberdesign

## (BC0701) Enumerationswerte
[cite_start]Enumerationswerte werden im PascalCase geschrieben[cite: 390, 391].

## (BC0702) Events
[cite_start]Eventnamen beschreiben immer einen Status der Gegenwart (Clicking), der Vergangenheit (Clicked) oder einen allgemeinen Status (Click)[cite: 393, 394].

## (BC0703) Felder
[cite_start]Feldnamen werden in camelCase mit führendem Unterstrich geschrieben[cite: 397, 398].

## (BC0704) Methode
[cite_start]Methodennamen werden im PascalCase geschrieben und sollten immer die Aufgabe der Methode widerspiegeln[cite: 400, 401].

## (BC0705) Eigenschaft
[cite_start]Eigenschaftsnamen werden im PascalCase geschrieben[cite: 403, 404].

## (BC0706) Typparameter
Zur Benennung von generischen Typparametern sind beschreibende Namen zu verwenden. [cite_start]Reicht ein Buchstabe, ist `T` zu verwenden[cite: 407, 408].

## (BC0707) Lokale Variablen
[cite_start]Lokale Variablennamen werden in camelCase geschrieben[cite: 410, 411].

## (BC0708) Parameter
[cite_start]Parameternamen werden immer in camelCase geschrieben[cite: 413, 414].

## (BC0709) Eine Methode darf nur eine Aufgabe haben
[cite_start]Eine Methode darf nur eine einzige Aufgabe erfüllen[cite: 416, 417].

## (BC0710) Methode mit maximal 20 LOC
[cite_start]Eine Methode hat maximal **20 Zeilen Quellcode**[cite: 421, 422].

## (BC0711) Methode mit maximaler Zyklomanischer Komplexität von 7
[cite_start]Eine Methode hat eine maximale **Zyklokomplexität von 7**[cite: 425, 426].

## (BC0712) Methode mit maximal 5 Parametern
[cite_start]Eine Methode darf maximal **fünf Parameter** besitzen[cite: 431, 432].

## (BC0713) Konstruktor mit maximal 5 Parametern
[cite_start]Ein Konstruktor darf maximal **fünf Parameter** besitzen[cite: 435, 436].

## (BC0714) Keine statischen Member
[cite_start]Es werden keine statischen Klassen, Funktionen oder weitere Member implementiert[cite: 439, 440].

## (BC0715) Keine öffentlichen Felder
[cite_start]Keine Klasse besitzt Öffentliche Felder[cite: 442, 443]. [cite_start]Felder sind immer geschützt (`private` oder `protected`) implementiert[cite: 443].

## (BC0716) Event Rasing Method
[cite_start]Die Methode zum Auslösen eines Events muss `protected`, `virtual` sein, den Namen `On<Eventname>` tragen und Delegateinstanzen threadsicher auslösen[cite: 446, 447, 448, 449, 450].

## (BC0717) Member nur public wenn von außerhalb zugegriffen wird
[cite_start]Member werden nur dann als öffentlich deklariert, wenn diese auch wirklich von außen gebraucht werden[cite: 452, 453].

## (BC0718) Schnittstellen anstatt Collections zurückgeben
[cite_start]Bei Methoden, die eine Auflistung zurückliefern, wird der Rückgabewert als Interface definiert (z.B. `IQueryable<T>`, `IEnumerable<T>`, `IReadOnlyList<T>`)[cite: 456, 457, 458].

## (BC0719) Zu Beginn einer Methode Parameter prüfen
Die Implementierung erfolgt defensiv. [cite_start]Zu Beginn jeder Methode sind die Parameter auf ihre Gültigkeit zu prüfen[cite: 460, 461].

## (BC0720) Keine Textkonstanten verwenden
Im Quellcode werden keine Textkonstanten verwendet. [cite_start]Anstatt Textkonstanten werden Enums oder Stringenumerationen verwendet[cite: 464, 465].

---

# Datenzugriff

## (BC0801) Bei Auflistungen immer IQueryable<T> verwenden
[cite_start]Alle Methoden, die einen direkten Datenzugriff haben, müssen **`IQueryable<T>`** zurückgeben[cite: 470, 471].

## (BC0802) Methoden, die Collections zurückgeben, mit GetAll benennen
[cite_start]Bei allen Methoden, die Collections zurückgeben, muss das Präfix **„GetAll“** im Namen verwandt werden[cite: 474, 475].

## (BC0803) Methoden, die ein einzelnes Element zurückgeben, mit Get oder GetOrDefault benennen
[cite_start]Bei allen Methoden, die einzelne Objekte zurückgeben, muss das Präfix **„Get“** oder **„GetOrDefault“** im Namen verwendet werden[cite: 477, 478].

---

# Ausnahmen

## (BC0901) Rückgabewerte nicht für Fehler verwenden
[cite_start]Im Fehlerfall muss eine Ausnahme zurückgegeben werden[cite: 485, 486].

## (BC0902) Aussagekräftige Ausnahmemeldungen
[cite_start]Fehlermeldungen sollten so aufgebaut sein, dass eine Fehler-Lokalisierung und -Behebung in kurzer Zeit möglich ist[cite: 488, 489].

## (BC0903) Keine Ausnahmen verschlucken
Ausnahmen müssen immer behandelt werden. [cite_start]Leere „catch-Blöcke" sind zu vermeiden[cite: 492, 493].

---

# ASP.NET Web API

## (BC1001) Actions müssen immer ein IHttpActionResult zurückgeben
[cite_start]Jede Action eines Controllers gibt ein **`IHttpActionResult`** zurück[cite: 501, 502].

## (BC1002) Für jede Action muss eine Route per Attribut angegeben werden
[cite_start]Für jede Action eines Controllers muss eine **Route** angegeben werden[cite: 505, 506].

## (BC1003) Jede Sicherheitsrelevante Action mit Attribut ???SecurityActionFilter authorisieren
[cite_start]Jede Action muss mit einem `???SecurityActionFilter` attributiert werden, damit die entsprechenden Sicherheitsprüfungen durchgeführt werden können[cite: 508, 509].

## (BC1004) Nur Service Model Objekte aus einer Action zurückgeben
Service Model Objekte werden entkoppelt zu Objekten der Cross-Cutting-Ebene. [cite_start]Objekte direkt aus dem Entity-Framework oder der Cross-Cutting-Ebene dürfen nicht zurückgegeben werden[cite: 511, 512].

## (BC1006) Daten müssen per Verb GET geladen werden
[cite_start]Alle Actions, bei denen Daten geladen werden, erhalten das Attribut **`[HttpGet]`**[cite: 517, 518].

## (BC1007) Daten müssen per Verb POST hinzugefügt werden
[cite_start]Bei jedem Controlleraufruf, die Datensätze hinzufügen, wird das http-Verb **`[HttpPost]`** angegeben[cite: 520, 521].

## (BC1008) Daten müssen per Verb PUT aktualisiert werden
[cite_start]Actions, die Daten aktualisieren, werden mit dem Verb **`[HttpPut]`** attributiert[cite: 523, 524].

## (BC1009) Daten müssen per Verb DELETE gelöscht werden
[cite_start]Actions, die Daten löschen, werden mit dem Verb **`[HttpDelete]`** attributiert[cite: 526, 527].

---

# Protokollieren

## (BC1101) Protokollierungsgrad Debug: Für Kontrollflußprotokollierung
[cite_start]Der Protokollierungsgrad Debug wird verwendet, um den Kontrollfluss der Applikation zu protokollieren[cite: 533, 534].

## (BC1102) Protokollierungsgrad Info: Für Operationsergebnisse
[cite_start]Ereignisse, die im Rahmen eines korrekten Programmablaufes auftreten, werden im Protokollierungsgrad „Info“ protokolliert[cite: 537, 538].

## (BC1103) Protokollierungsgrad Warning: Für unerwartete Zustände
[cite_start]Unerwartete Ereignisse, die jedoch nicht zu einem Abbruch der Hauptfunktion oder zu Fehler führen, werden im Protokollierungsgrad „Warning“ protokolliert[cite: 541, 542].

## (BC1104) Protokollierungsgrad Error: Für fehlgeschlagene Systemaufgaben
[cite_start]Fehlgeschlagene Systemaufgaben, die jedoch nicht zu einem vollständigem Programmabbruch führten, werden im Protokollierungsgrad „Error“ ausgegeben[cite: 544, 545].

## (BC1105) Protokollierungsgrad Fatal: Für Terminierungszustände
[cite_start]Zustände, die zu einem vollständigem Programmabbruch führen, werden im Protokollierungsgrad „Fatal“ protokolliert[cite: 547, 548].