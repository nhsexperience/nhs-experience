---
title: Data
layout: page
parent: NHS Digital Health Check
nav_order: 7
---

> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.

```mermaid!
classDiagram
    Citizen <|-- Demographics
    Citizen <|-- Observations
    class Citizen
    class Demographics{
        +string Name
        +int Age
    }
    class Observations
```

<iframe src="https://app.swaggerhub.com/apis-docs/RossBugginsNHS/RESTfulEndeavour/0.1">
</iframe>