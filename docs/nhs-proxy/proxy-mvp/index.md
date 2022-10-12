---
title: Proxy MVP
layout: page
parent: NHS Account Proxy
nav_order: 4.31
---

# Summary


# Non Technical Requirements

## Process Flow
```mermaid
sequenceDiagram
    actor Delegator
    actor Delegate
    participant ProxyService as Proxy Service
    participant NHSLogin
    participant PDS
    actor GP
    participant GPIT as GP IT System

    Delegator->>+ProxyService: Start process to give access to Delegate
    ProxyService->>Delegator: Redirect to Login
    Delegator->>+NHSLogin: Delegator Login
    NHSLogin->>-ProxyService: Confirms Delegators Identity
    ProxyService->>+PDS: Request Delegates contact details
    PDS->>-ProxyService: Returns contact details
    par To Delegator
        ProxyService->>-Delegator: Notify Delegator that Delegation process has started
    and To Delegate
        ProxyService->>Delegate: Notify Delegate that they are being requested to have delegate access
    end
    Delegate->>+ProxyService: Starts delegation acceptance process
    ProxyService->>Delegate: Redirect to Login
    Delegate->>+NHSLogin: Delegates Login
    NHSLogin->>-ProxyService: Confirms Delegates Identity 
    ProxyService->>Delegate: Request if happy to have access   
    Delegate->>ProxyService: Confirms happy to have access
    par To Delegate
        ProxyService->>Delegate: Notify Delegate that they have accepted
    and To Delegator
        ProxyService->>-Delegator: Notify Delegator that Delegate has accepted and sent to GP       
    and To GP
        ProxyService->>+GP: Send Delgator and Delegates details 
    end
    GP->>GPIT: Manually configure ACLs
    GP->>-ProxyService: Confirm has set ACLs
    ProxyService->>Delegator: Notify Delegator that GP has configured Delegation
    GPIT-->>Delegate: Grants Access to Delgators data
    Delegate->>GPIT: Accesses delegators data

```


# Benefits

# Technical Requirements

## Actors Involved

### Delgate

### Delegator

### GP Staff

## External Systems Involved

### NHS Login

### PDS

### Email / Mesh

## New Services / System Required

### NHS Proxy Service


## Data Inputs

### Delegates details (supplied by delegator)
- NHS Number
- Email
- Dob
- First Name
- Surname

### Delegates contact details 
Supplied from PDS Lookup


## Data Outputs

## Processing / Validation

### Validate Delegates details (supplied by delegator) and lookup delegates contact details
Details for delegate that are supplied by delegator (i.e. who to "invite") should be verified against PDS

