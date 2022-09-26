---
title: NHS Account Proxy
layout: page
has_children: true
nav_order: 2.1
regenerate: true
---

# What is NHS Proxy?

NHS Proxy is a term used to define one citizen having the ability to .......

# Aims
- Reduce burden on NHS Staff
- Move burnden of proof to issuers
- Ease process for citizen

# Will Need
- Cooperation between organisations


{% pdf "http://img.labnol.org/di/PowerPoint.ppt" %}

 
{% pdf "/nhs-proxy/Proxy_Architecture_Strawman_v0_3.pptx" %}

{% pdf "../wellness-prevention/wellness-alpha-report_v1.pdf" %}

## something


<div class="reveal reveal4" style="width:100%;padding-bottom:56.25%;">
<div class="slides">
<section data-markdown="/_slides/p2.md">
</section>
</div>
</div>

<script>
    window.nhsce.UseReveal(document, "reveal4", true);

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
