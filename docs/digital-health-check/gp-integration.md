---
title: GP Integration
layout: page
parent: NHS Digital Health Check
nav_order: 3
---

> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.


# GP IT General Challenges
-	Multiple GP IT systems providers
-	Big backlog for GP IT to implement changes
-	No RESTful API for GP connect

GP System Suppliers are able to be resistant to change. To be a GP supplier, there are certain APIs you must expose for GP Connect to call. However, there are no versions / expir dates on these, so whenever GP connect wants to add new functionality, it is then about entering negotiations with suppliers to expose new apis themselves that implement that required change.

## Current Landscape
### GP Connect Summary
GP Connect designed to be platform agnostic interface to those systems
However, its not a silver bullet:

GP Connect is FHIR STU3. Goes through SPINE security proxy, not API Management. It is an RPC style call, not RESTful API.

- Authentication and Authorisation uses TLS Mutual Auth 
- A ll offloaded to the client - ie a client is trusted to do anything
- Spine Security Proxy - All wildcarded - all can see all
- Machine to Machine - 
- IM1 - functional standard, not technical
GP connect - the future 
Want to get GP Connect onto API management with Oauth and open id
Can then give patient view. This would be redacted (ie some GP notes are ticked to hide).
Its planned / wished for a full re write to be RESTful APIs - however, no time frame and unsure on Business case for GP connect? 

## SendDoc API Versions
### Version 1.5.1 
IS NOT AVAILABLE AND SHOULDN’T BE PUBLIC
Versions 1.4 and 1.5 of the Send/Update should not have been published and they should be getting puled, the FHIR profiles haven’t been curated/validated by IOPS and the architecture hasn’t been reviewed by either myself or TRG.  
 Version 1.3 is what is actually there and available.

### Version 1.3
https://developer.nhs.uk/apis/gpconnect-messaging-1-3/senddocument_payload.html

- Supports sending a base64 binary encoded file. 
- Can send a structured document as the payload
- However, needs GPIT & GP Supplier involvement to take that file and to write it into specific places in the GP record.
- Any development request to GPIT will take a long time (years?).
Summary for Read Data from GPs

GP Connect has:
- HTML View - basic HTML view of some data (used for shared care records??)
- V1.2 Meds and allergies
- V1.5 currently in testing with first of type - full record (minus any GP redacted record data items)

## Summary for Send Data to GPs
### Technical Challenges
No API to say, write item x into field y of record
Connect has a “write api” but just for taking a structured file (via MESH), which then needs GPIT to implement a connector to write that data into the specific record location

### Procedural Challenges
GPIT understaffed - big (multi year) backlog wait time for changes.

### Cultural / Medical Challenges
- GPs not trusting / wanting external data into “their” patients records - genuine concern over being overwhelmed by to much unsolicited inbound data 
- Can medical plans/decisions/etc be based upon user generated data?

## Possible Options
### Sending “unstructured data”

Send PDF / word / etc via MESH, for GP staff to manually enter into system.
Would they do it?
Is there value for them in entering “untrusted data” into a record
Who is liable for errors / non factual data?

### Pull Based Model
GPs have a way to access patient generated data, via different system.

Integrate CIS2 OpenId as an additional identity provider alongside NHS Login. This would then allow GP’s to login to access data, rather than pulls.

### No direct access
Data kept in patients account, they shared when physically in with GP?

### Use NRL instead to share data
Is this possible?

### Benefits of NOT pushing data to GPs, but GP’s pulling data
⦁	Data stays in control of the patient
⦁	Single source of truth maintained

### Other Ongoing Work in this Area
NHS D are also looking a GP integration for their BP collection. JV at D has created options paper. 

## Next Steps
- Explore CIS2 as a OpenId method for Authentication for Health Professional
- Understand how / what GPS currently use CIS2 for
- User research - GPs and what they want / perceive push vs pull