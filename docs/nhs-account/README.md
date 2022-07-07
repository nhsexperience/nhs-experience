|**Warning**|
|--| 
|⚠️ **Draft Documents**: May not represent real world scenarios or be accurate|
|--|

# NHS Account

# Defining Problem Statement

## What's the current state?

## Whats the desired state?

### Problem Definition

#### Key measurables

## What is envisioned for NHS Account?



## User Controlled Consent - Empower the patient

## How to best Model Access to Data 

## API Design

## Back End Design

## Authentication

## Authorisation

## Decentralised Identity / Verifyable Credentials

## API Management

## API Resource Design
- FHIR vs not FHIR

## Resource User Access Control

## Application Management

## Distributed Identity

## Proxy Delegated Access

## Service Application Design

## Eventual Consistency

## Idempotency

## Commands

## Event Sourcing / CQRS

### Event Store

## Message Bus

## Distributed Actor

## Micro Services

## Tartget API Times
- Max for any GET - xx ms
- Max for any POST - xx ms
- Max for and PUT - xx ms

### Support RESTful Endeavour (Promise) Pattern
- Utilise Event Sourcing and 202 / 201 HTTP Status codes instead of just a POST returning a 200.

## Monitoring and Metrics

### The Four Golden Signals
The four golden signals of monitoring are latency, traffic, errors, and saturation. If you can only measure four metrics of your user-facing system, focus on these four.

- Latency
- Traffic
- Errors
- Saturation

https://sre.google/sre-book/monitoring-distributed-systems/#xref_monitoring_golden-signals

## Logging 