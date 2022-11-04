---
title: NHS Account (Platform)
layout: page
nav_order: 2.01
has_children: true
---

## Account Vision

## Frequently Asked Questions

### How does Proxy fit into this?

### Safeguarding & IG

### Where does NHS Login fit into this?

## Previous

- Account and Proxy separate services
- Proxy for delegating access to Primary care records
- Account was a term used for grouping together functionality for a citizen to update their info
- It wasn't "a thing"
- Proxy was proving relationships, recording them, and storing what access was available with them

## Suggested

### Account "Control"

- Account designed as Authorisation platform
- Controls who can access what and via what client apps
- Standard oauth scopes + UMA
- Account stores an NHS number which is the context for all account operations - not the NHS number that is part of the NHS Login identity
- All data and functionality exposed via NHS Account does not need to worry about "Proxy". The standard authorisation of Account Control has taken care of that.

### Account "Data"

- Account Data - standardised data API endpoint to enforce Account authorisation rules

### Proxy

- Service that is used for validating external relationship and identity proofs
- Updates account control to set desired access based on the proofs given

### Why?

- Account "Control" becomes authorisation as a platform
- Account "Data" becomes an API endpoint (gateway) platform with standard authorisation model

### Organisation Controlled Apps with User Contented Access to what apps can use data on their behalf

- Users consent to what data is used with what app
- eg Citizen consents to "Blood Pressure Readings" being read by NHS App
- Consent is for both "primary" apps eg NHS App, other NHS developed apps, eg Digital Health Check, and would be the same for third party apps
- The organisation(s) eg NHS England - control what apps are added as available to the Account Platform
- Local Organisations could control what subset of these apps are available to citizens in their area
- Users choose what apps they want "installed" into their account
- USers then consent to what data is shared with those applications
- Users can easily view all apps they have consented to and what "access" levels they have. Can revoke at any time.

### Controlling Who

- Citizens can see a list of users that they have "added" to their account and what access they have.
- Can add, remove or modify at any time
- Proxy service works with this to update the list based on external proofs, without their involvement.

#### Example "Account Apps"

- NHS App England
- NHS App Wales - eg user wants to share data with Wales App - maybe they live on the border and it would make life easier for them for data to be accessible there
- A "NHS Digital Health Check" - if an app developed by OHID, they may want to store data in an account, eg blood pressure, but also work to expose the results of the Health Check through the "Account Data" platform.
- A "Health Analysis Service" - a background service developed by NHS that monitors users self generated obs (eg Blood pressure) and also GP added BP readings. Allowing real time analysis to spot problems early.
- A third party developed Sleep Apnoea service - monitoring both data from CPAP for a user (already existing by supplier) but also wearables data. Supplier also exposes summary data to "Account Data" to allow it to be easily consumed inside NHS (with users specific consent)/ 

## Diagram

https://app.diagrams.net/#Uhttps%3A%2F%2Fraw.githubusercontent.com%2FRossBugginsNHS%2Fnhs-experience%2Flatest%2Fdocs%2Fnhs-account-v2%2FProxy%2520and%2520Account.drawio

Note - preview here may not be latest version.
![Proxy and Account](ProxyandAccount.svg "Proxy and Account")

## Notes

Account is a Platform

Account

- Account Control
- Account Roles
- Account Resources (Data)
- Account Apps
- Account Clients
- Apps as a Service
- Data Sources as a Service
- Authorisation
- 

Account Resource

- Data
- Information
- Knowledge
- Wisdom


Testing 2

- Account control
- Account data
- Authorisation
- Proxy
- Data Sources / Resource
- Identity


To involve

- platform app / uk
- SCR
- GP IT
- 