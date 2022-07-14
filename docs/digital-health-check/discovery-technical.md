---
title: DHC Discovery - Technical
layout: page
permalink: /healthcheck/discovery-technical.html
parent: NHS Digital Health Check
nav_order: 2
mermaid: true
---

> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.




<div class="mermaid">
C4Context;
    Person(role_operator, Operator, "A coll");
    System(tooling, Tooling, "Set of tools");
    Rel(role_operator, tooling, Prepares, "configures");
</div>

