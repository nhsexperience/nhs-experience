---
title: Data
layout: page
grand_parent: NHS Digital Health Check
parent: Architecture
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

[View Swaggerhub OpenAPI v3]({% link digital-health-check/data-swagger/html2/index.html %})

[Swaggerhub Source](https://app.swaggerhub.com/apis/RossBugginsNHS/hc1/v0.1#/)

<iframe width="100%" height="1000px" src="/digital-health-check/data-swagger/html2/">
</iframe>