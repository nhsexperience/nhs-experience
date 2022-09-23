---
title: NHS Account Proxy
layout: page
has_children: true
nav_order: 2.1
---

# What is NHS Proxy?

NHS Proxy is a term used to define one citizen having the ability to .......

# Aims
- Reduce burden on NHS Staff
- Move burnden of proof to issuers
- Ease process for citizen

# Will Need
- Cooperation between organisations


{% assign author = site.presentations | where:"id", "p1"  | first %}


<div class="reveal reveal2" style="width:100%;padding-bottom:56.25%;">
  <div class="slides">
    <section data-auto-animate data-background-gradient="linear-gradient(to bottom, #283b95, #17b2c3)">
      <h2>🍦</h2>
    </section>
    <section data-auto-animate>
        <h1>Slide 1 - Title</h1>
        <p>Let's make some bullet points!</p>
        <ul>
            <li class="fragment">Some info</li>
            <li class="fragment">Some more info</li>
            <li class="fragment">Some extra info</li>
        </ul>
    </section>
    <section data-auto-animate>
      <pre><code data-trim data-noescape data-line-numbers>
        (def lazy-fib
          (concat
          [0 1]
          ((fn rfib [a b]
                (lazy-cons (+ a b) (rfib b (+ a b)))) 0 1)))
      </code></pre>
    </section>
  </div>
</div>

<script>
    window.nhsce.UseReveal("reveal2");
</script>



## To Architect
  

  
- Authentication
- Authorisation
- Data model of credentials and presentations
- Proxy relationship establishment application
- Credential validation service
- Decentralised identifier (DID) documents
- Trust framework system
- Credential gateway


## Definitions

Identity / Authentication vs Authorisation

Proxy - "Imitating the Identity"

Delegated Access

Role Based Access

# Proxy Service MVP - June 2023?
## Deglatation
```mermaid
sequenceDiagram
    actor Delegator
    actor Delegate
    participant ProxyService as Proxy Service
    participant NHSLogin
    participant PDS
    participant GP
    participant GPIT as GP IT System

    Delegator->>ProxyService: Start process to give access to Delegate
    ProxyService->>NHSLogin: Validate Delegators Identity
    NHSLogin->>ProxyService: Confirms Identity
    ProxyService->>PDS: Request Delegates contact details
    PDS->>ProxyService: Returns contact details
    ProxyService->>Delegate: Request if happy to have access
    Delegate->>ProxyService: Confirms happy to have access
    ProxyService->>GP: Send Delgator and Delegates details
    GP->>GPIT: Manually configure ACLs
    GPIT->>Delegate: Grants Access to Delgators data

```
