---
title: NHS Account Proxy
layout: page
has_children: true
nav_order: 2.1
---


> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.

# What is NHS Proxy?

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
