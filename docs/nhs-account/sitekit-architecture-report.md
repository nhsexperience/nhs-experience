---
title: Account Sitekit Report
layout: page
parent: NHS Account
nav_order: 9
author: Sitekit
last_modified_date: Jul 26 2022 at 07:51 AM
tags: 
    - report 
    - external 
    - nhs account
description: A discovery into the possibilities for NHS Account, authored by Sitekit, April 2022.
todo:
    - verify docx export to markdown
    - images to extract and add
    - additional tables are missing
    - All claims made in the report are yet to be independently verified
---



## Executive Summary Contents

NHS Account is a solution designed to provide patients with a joined-up experience across NHS digital
services and establish the foundations that will enable greater personalisation of digital services for end-
users.
By implementing NHS Account the NHS will continue to build on the ambitions stated in the Long Term
Plan to empower patients to participate in their own health care, which will lead to improved experiences
and healthcare outcomes.
NHS Account will establish the technical foundations that will make patients known to the NHS across
digital services and empower them to control their profile and privacy settings. It represents a necessary
bridge between existing digital services and an envisioned future state where patients are known to the
NHS, needs can be predicted and step-up care optimised.
The designs proposed in this document complement the key use cases identified during NHS Discovery
and Alpha, delivering immediate benefit to end-users and the NHS while providing a platform for a
sustained evolution and development of NHS digital services.
At present users do not have a consistent experience of NHS digital services. Users of the NHS App have
a logged in experience, while NHS.UK does not offer a logged in and known experience. The NHS Digital
MVP currently being developed will provide users with a logged in experience in both channels, with
limited information known about the end-user made available to the NHS.
NHS Account will build on the NHS Digital MVP, delivering the technical components that enables key
patient information to be shared across digital services, empowers patients to control their digital profile
and privacy settings and improve digital service suggestions for the end user.
This will provide the foundations for fully actualised personalised digital services, which will enable the
NHS to embrace the latest developments in predictive and preventative medicine via an empowered and
engaged population that are active participants in their own health.
By implementing the designs proposed here, the NHS will be in a position to realise its ambitions to
provide modern care and services that are convenient for patients, efficient for the NHS and which get
people the right care for them as quickly as possible.


Outline

This architectural documentation represents the culmination of a seven month programme of work and
builds on the outputs represented below:









## 1. Introduction

## 1.1. Purpose


This document provides a solution architecture for NHS Account.
NHS Account is a solution which is being designed to help empower patients to participate in their own
health care. Participation leads to improved experience and healthcare outcomes.
Several architectural views are used to depict aspects of the design. It is intended to capture and convey
the rational for significant architectural decisions.
Intended Audience

- Technical Reference Group.
- NHS Account Development Team.
- Digital Service / Tool Development Teams (e.g. Wellness Hub Team).
- NHS Account Dependencies (e.g. NHS Login and PDS Team).
- Information Governance and InfoSec Teams.

## 1.2. Scope


This document focuses on:

- Joining up Digital Services using a new concept called the user profile.
- Personalising Digital Service recommendations, based on eligibility.

## 1.3. Overview


The NHS offers an expanding range of Digital Services (tools) to NHS service users. These tools can be
classified into two groups:

- Transactional services / tools.
- Information guidance services / tools.
Transactional tools allow NHS service users to transact with the NHS – for example, booking an
appointment and ordering a repeat prescription.
Information / guidance tools allow NHS service users to obtain trusted advice and guidance on a wide
range of healthcare topics.
From a technical perspective “the NHS Account is a collection of currently available and newly developed
technical components which sit behind NHS login. They enable the user to manage their User Profile
through NHS digital channels; and Facilitate a conduit between other Digital Services, the Account and
the user to deliver a personalised experience governed in accordance with the user’s consent settings
and eligibility criteria” [1].
From a user perspective “the NHS account allows the user to maintain their own profile in one place and
provides them with a conduit to all available Digital Services, seamless to them, that they want and need
including service suggestions. From their perspective it is their window on the world to their digital care
services - “My NHS”. They are able to see what the NHS knows about them and can update their
information (including contact and consent preferences) when they want the NHS to know something new
about them or when something has changed” [1].
From an NHS System perspective “the NHS Account creates a joined up view of a user across the
system and a bi-directional link to NHS and third party Digital Services. It allows the NHS to identify










cohorts providing the opportunity to target communications and offer them relevant service; creates a
springboard for enhancing NHS patient facing Digital Services; and facilitates innovative local and system
wide improvements which help to predict patient needs and reduce the need for step up care” [1].


NHS Personalisation Maturity Model


Note: the “A” at the top of the pyramid represents actualisation – a definitional of actually personalised
national health service.









## 2. Architectural Representation & Approach


The technical design for the NHS Account is represented in this document using several
architectural views. Each view is intended to describe one or more concerns involved in the
system.
View Name Concern
Use Case / Scenarios Consists of a set of use cases or scenarios, which guide the design
of the architecture. The view specifies the actors (users) involved
and what system and functionality they have access to. Unified
Modelling Language (UML) use case diagrams will be used to
articulate this view.


Logical Concerned with the functional requirements – what the system will
do. UML state machine diagrams will be used to articulate this view.


Process Decomposes the system into communicating processes – shows
how the system works. UML sequence diagrams will be used to
articulate this view.


Development / implementation Decomposes the solution into layers, subsystems, and components,
showing how it is structured. UML component diagrams and C
context and container diagrams will be used to articulate this view.


The physical view is omitted from the design. Low level decisions relating to how the NHS Account will be
deployed, managed and operated in production are deferred to a later stage of the product development
process.









## 3. Architectural Goals and Constraints

## 3.1. Hardware, Software & Hosting Constraints


The NHS Account will be operated by NHS Digital. A public cloud service provider (CSP) will be used for
hosting (likely Microsoft Azure).
Dependency on downstream systems such as PDS and NHS Login are already available over the public
cloud. NHS private wide area network (HSCN / Express Route) connectivity is not thought to be needed.
The goal of the design is to find an acceptable balance between;

- Functional requirements (minimally viable product).
- Cost of product development and hosting.
- Time to market.
- Performance.
- Scalability.
- Modifiability.
- Security.
- Integrability.
- Testability.
- Supportability.

## 3.2. User Interaction Constraints


End users of the NHS Account are NHS service users. The user base is likely to extend to include proxies
of NHS service users and health professionals in the future. Due to the anticipated scale of use, the
system must be intuitive to use and offer self-service support where possible.

## 3.3. Security and Information Governance Constraints


Extensive user research was undertaken during the discovery phase. Users voiced their requirement for
privacy and control over how their data is used and who it is shared with [4][5][6].
The NHS Account system is subject to UK GDPR regulation. This design takes into account the
information governance principles that have been defined, documented, reviewed, and agreed [12].









## 4. References


This document forms part of the NHS Account Alpha Project deliverables. The following documents were
delivered earlier in project and helped to inform this document.
1 NHS Account Definitions
Solution Concept (solution architecture phase 1)
2 NHS Account Concept (aka NHS Account Infographic).
Initiation (solution architecture phase 2)
3 Solution Vision Statement
Discovery (solution architecture phase 3)
4 Discovery Findings Report
5 Discovery Report (Deep Dive)
6 Additional Research Report


Solution Outline and Analysis (solution architecture phase 4)
7 Solutions outlines + Options Appraisal.

Logical Design & PoC (solution architecture phase 5)

Full Logical Design (this document)
8 Identity and Access Management (IAM) Design
9 NHS Account Minimum Data Set (MDS)

10 Micro Frontend Evaluation

Other

11 NHS Account Principles

12 NHS Account IG Principles
13 NHS Account Use Cases - UX Perspective

14 NHS App Integration Options
https://digital.nhs.uk/services/nhs-app/partners-and-developers/integrate-with-the-nhs-app/explore-
api-and-web-integration

15 NHS App Web Integration Option
https://digital.nhs.uk/services/nhs-app/partners-and-developers/developer-resources/web-

integration-overview

16 Micro Frontend Overview
https://martinfowler.com/articles/micro-frontends.html

17 Information Commissioners Office (ICO) UK GDPR Guidance on Lawful Basis for Processing and

Consent

https://ico.org.uk/for-organisations/guide-to-data-protection/guide-to-the-general-data-protection-
regulation-gdpr/lawful-basis-for-processing/
https://ico.org.uk/for-organisations/guide-to-data-protection/guide-to-the-general-data-protection-
regulation-gdpr/lawful-basis-for-processing/consent/

18 Bounded Context Overview
https://martinfowler.com/bliki/BoundedContext.html

19OAuth 2.0 Authorization Framework Spec
https://datatracker.ietf.org/doc/html/rfc

20 OpenID Connect Specs
https://openid.net/developers/specs/









## 5. Scenario View


Consists of a set of use cases which guide the design of the architecture. The view specifies the users
of the system (the actors), and what each user can do with the system. Unified Modelling Language
(UML) use case diagrams will be used to articulate this view.

## 5.1. Use Case Summary


Section Use Case Titles
5.3 Overview Manage User Profile
Access User Profile
Suggest Services
5.4 Registration Use
Cases


View benefits
Grant processing consent
5.5. Management
Use Cases


View Profile
Add data item to profile
Update data item in profile
Delete data item from profile
View My Account Digital Services
Amend My Account Digital Services permissions
5.6. Query Profile
Use Cases


Request Access
Access Granted
Query Profile Data
5.7 Update Profile
Use Cases


Request authorisation
Internal service authorisation grant
External service authorisation grant
Add data item
Update data item
Validate data item
Delete data item
Delete data item version
Raise change
5.8. Query Profiles
Use Cases (Plural)


Authenticate & Authorise
Connect
Execute cross profile query
5.9. Eligibility Use
Cases


View list of Suggested Digital Services
Add / Remove Selected Service to / from Your Services
View My Services










Open Digital Service
Digital Service Onboarding
Request access to Core Profile Service
Prompt for User Consent
Access NHS Profile
Contextual Eligibility Use Cases (various)
5.10. Processing
Consent Use Cases


Accept T&Cs
View current terms and conditions
View consent options
Opt-in to option
Opt-out of option
Reject T&Cs
Accept amended T&Cs
Publish T&Cs
Publish Consent Options
Publish updated T&Cs
Update Consent Options
Deprecate T&Cs
Check Consent Granted
Delegate Consent Capture
5.11. Eligibility
Extension with Digital
Services Use Cases


Authorise
Add Digital Service suggestion
View list of suggested Digital Services
5.12. Record
Interactions with
Care Services Use
Cases


Add Record Pointer
Query Patient Pointers
Get Patient Record
Get Profile Including Interactions
View Interactions
5.13. Data
Provenance


Capture Data Item
Compute Provenance
Create Signed Hash of Entire Data Item
Sign Hash
Get User Private Key
Create Update Data Item
Store Data Item
Get User Profile
Get Data Items including Provenance










Validate Provenance
Get Public Key
Validate Signature

## 5.2. Actors


NHS Identified
User


Dig ital Service


Internal
Digital Service


External
Digital Service


Health Campaign
Dig ital Service


Actors


NHS Identified User A user who has authenticated with and is identified by the NHS Login
service.


Digital Service NHS and third-party services. For example, Wellness and Prevention,
Patient Knows Best (PKB) which are accessed by digital means. [1]










Internal Digital Service
An internal Digital Service is a specialist type of Digital Service. An
internal Digital Service is one which is run by the NHS. Internal Digital
Services run within the same security context as the national channels
and the NHS Account User Profile. Being within the same security
context means that internal services share the same client identity, client
credentials, and access control policy permissions (to the authorisation
component, they are the same entity). In practical terms, internal service
A can call the APIs of internal service B, and vice versa. Internal
services A and B may share identity and access tokens. The Wellness
Hub may be one example of an internal Digital Service.


External Digital Service An external Digital Service is a specialist type of Digital Service. An
external Digital Service is one which is run by a third-party organisation
(they are not run by the NHS directly). External Digital Services run in a
separate security context to each other, to internal Digital Services, and
to the national channels and the NHS Account User Profile. Being within
a different security context means that external services have their own
client identity, client credentials, and access control policy permissions
(to the authorisation component, they are an independent entity which
the user will be asked to make separate authorisation decisions about).
In practical terms, external service A is not implicitly allowed to call the
APIs of external service B, and vice versa.









## 5.3. Use Case Overview


Use Cases
Manage User Profile Allows an NHS identified user to manage their user profile. The user
profile is a collection of personal information about the user.


Access User Profile Allows authorised Digital Services to share a common set of
information about the NHS Identified User. Each authorised Digital
Service can access a NHS Identified User's user profile. Access to
the user profile allows the Digital Service to provide an improved user
experience to the NHS Identified User. The Digital Service UX can be
improved, based on the NHS Identified User's personal information
(e.g., if the user is a smoker, offer them a feature related to smoking).
Digital service forms can be auto-populated, based on information
held in the user profile (removing the burden on the NHS Identified
User retyping the information again). New information captured in a
Digital Service can be contributed back into the user profile in order
to maintain an up-to-date user profile.


Suggest Services Digital Services can be suggested to the user based on the
information contained within their user profile, information available in
the channel (current location), and identity information (level of
assurance).









## 5.4. Registration Use Cases


Use Cases Registration
View benefits Allows an NHS Identified User to view the benefits of having a user
profile before they sign up to having one.


Grant processing consent Allows an NHS Identified User to view and explicitly consent to the
terms and conditions of having a user profile. Related processing
consent use cases are listed in the processing consent use case
section. The user is not allowed to use the NHS Account user profile
unless they have consented to the current version of the processing
terms and conditions. When the user grants processing consent, a
record of their user id, date of consent, version of terms and
conditions and any opt-ins are recorded in the consent service.









## 5.5. Management Use Cases


This diagram represents the operations performed by an NHS identified user in the context of
Managing their User Profile.


Use Cases Management
View Profile An NHS Identified User can view the data in their User Profile. For
example, a User can view their height and weight if those items have
already been added to their User Profile.


Add data item (instance) to
profile


An NHS Identified User can add data to their User Profile. For
example, a User can add a measurement of their Height or Weight on
a given date, and both the measurement and date would be stored in
their User Profile.










Update data item (instance) in
profile


An NHS Identified User can update data items that are stored in their
User Profile. For example, if a Height or Weight measurement had
been stored in the User Profile for a given date and either the
measurement or date was found to be incorrect, the User can modify
the data to reflect the correct value, and the new value will be stored
in the User Profile, replacing the incorrect value.


Delete data item (instance)
from profile


An NHS Identified User can delete data item instances that are
stored in their User Profile. For example, if a Height or Weight
measurement had been stored in the User Profile for a given date in
error, the User can delete the data so that the erroneous value is no
longer stored in the User Profile.


View My Account Digital
Services


An NHS Identified User can view the list of Digital Services which
they have selected to use, and hence are permitted to access the
data in their NHS Account. For example, if the User has selected to
use a “BMI Service”, that service would appear in their list of Digital
Services, and the BMI Service would be able to access their NHS
Account data.


Amend My Account Digital
Services permissions.


An NHS Identified User can amend the permissions that the Digital
Services which they have selected to use have with respect to a, and
hence are permitted to access the data in their NHS Account. For
example, a User could revoke the permissions that a BMI Service
may have to access the data in their NHS Account, so that Service
would no longer be able to access that data.












## 5.6. Query Profile Use Cases


This diagram represents the operations performed by the NHS Identified User or by a Digital Service in
the context of querying the NHS Account’s profile data.


Use Cases Query Profile
NHS Login Authenticate User



NHS Login authenticates the user’s identity. The External Digital
Service delegates this responsibility to NHS Login via an identity
federation (sharing of trust).


NHS Account Authorization
Service Authorise Access


The NHS Account Authorization Service authorised an External
Digital Service’s access to an NHS Account User Profile.


NHS Account Health Profile
Service C/R/U/D


Once authorised to do so, the External Digital Service can create,
read, update, and delete data within a user’s Health User Profile.
NHS Account Demographic
Profile Service C/R/U/D


Once authorised to do so, the External Digital Service can create,
read, update, and delete data within a user’s Demographic User
Profile.












## 5.7. Update Profile Use Cases


Use Cases Update Profile
Request authorisation A Digital Service requests authorisation to a given scope of access
(to update all or part of the user profile).


Internal service authorisation
grant


Internal services share the same client identity. An NHS Identified
User can grant or deny internal services access to their NHS Account
user profile as one atomic entity.


External service authorisation
grant


External Digital Services have their own client identity. An NHS

NHS Account user profile on an individual basis.













Add data item instance A Digital Service adds an instance of a data item to an NHS Identified
User's user profile (for example an instance of a weight observation)


Update data item instance A Digital Service updates a data item instance held within an NHS

new version of the data item instance to be created. The version
history of a data item instance can be queried. Updates can only be
performed by the originally contributing client, or the profile web
application.


Validate data item instance When a data item instance is added or updated, the change is
validated against validation rules. If the change does not meet the
validation criteria, the change is not persisted to the user profile. The
client will be informed of the validation failure.


Delete data item instance A Digital Service sends a request to delete a data item instance from
the NHS Account user profile. Deletion includes deletion of the
version history of the data item instance. Deletion can only be
performed by the originally contributing client, or the profile web
application.


Delete data item instance
version


A Digital Service sends a request to delete a data item instance
version from an NHS Account user profile. The client can only delete
the head data item instance version. Version deletion can only be
performed by the originally contributing client, or the profile web
application.


Raise change
Raise event to notify any subscribers that the NHS Identified User's
profile has changed. Include the data item type in the event
notification and a URL to the changed item.












## 5.8. Query Profiles Use Cases (Plural)


Actors
NHS Identified Employee A user who has is employed by the NHS, can be digitally identified,
and has been granted rights to query the NHS Account User Profile
Analytics Database.


Cohorting Service A service being developed by NHS Digital to provide the NHS with a
multi-dimensional array of patient data. The Cohorting Service may
be used as a data source to identify patient cohorts, with a view to
communicating with these cohorts.


Use Cases Query Profiles
Authenticate & Authorise The credentials contained within the connection string are used to
authenticate the user and authorise their access.


Connect A connection is made to the database using a connection string.


Execute cross profile query
The Cohorting Service can execute queries against the User Profile
Analytics Database.












## 5.9. Eligibility Use Cases


The following diagrams represent the operations that can be performed by NHS Identified Users in the
context of viewing Digital Service suggestions and adding suggested Digital Services to their NHS
Account.













Use Cases
View list of Suggested Digital
Services


An NHS Identified User can view a list of Digital Services. The list will
be a relevant subset of all Digital Services for which the User is
eligible and where that Service has not previously been added to the
user’s Selected Services. The eligibility for any given Digital Service
is assessed using the information in the User’s profile.


Add / Remove Selected
Service to / from Your
Services


An NHS Identified User can read the benefits of using a Digital
Service and may choose to Add a Digital Service to “My Services”.
The NHS Identified User can also remove Digital Services from My
Services. The NHS may decide that some Digital Services are
mandatory. In these cases, the NHS Identified User will not be able to
remove the Digital Service from My Services.


View My Services An NHS Identified User can view a list of the Digital Services that
they have added to their NHS Account. This differentiates suggested
services from services that the user has selected to use.


Open Digital Service Once a Digital Service is added to My Services, the user can click on
the Digital Service link / icon, which is displayed within the My
Services view. Clicking on the Digital Service opens / launches the
service.












### 5.9.1. Contextual Eligibility Use Cases


A number of discreet eligibility problems have been defined and are covered in more detail in the
appendix (9.1). The following use cases provide an interpretation of what the NHS Account needs to do,
in order to solve these problems. Concrete scenarios and actors are used, rather than abstractions, for
ease of understanding.
5.9.1.1. Actors
Actors
NHS Identified User with No
GP Registration
(MoD User will be used as one
concrete example of this
scenario)


An NHS service user who is employed by the MoD. These actors
do not have a GP ODS code associated with their identity. This is
because they receive primary care from the MoD (not the NHS).


NHS Identified User
with GP Registration


An NHS service user who is registered with a GP for primary
care.


NHS Identified User
Resident in England


An NHS service user who is resident in England. This actor is
used to represent country and regional variation.


NHS Identified User
with COPD


An NHS service user who has been diagnosed with COPD. This
actor is used to represent service users with a specific condition.













5.9.1.2. Service Suggestions - No GP Registration
Discussed in “problem 1” – see appendix, section 9.1.


Use Cases
Authenticate Users without a GP ODS (such as MoD users) must be able to
authenticate with NHS Login. This is supported today.


Sign In Users without a GP ODS (such as MoD users) must be able to sign
in to the NHS App. This is NOT supported today. The NHS App has
to ensure that users are from England only and this is done using
ODS Code. Until this constraint is removed, MoD and other users
without an ODS code will not be able to sign in to the NHS App.













View Covid Pass Link In
Service Suggestions List


The Covid Pass Digital Service is used as an example of a Digital
Service which is offered on a national basis. This means that GP
ODS code does not form part of its eligibility criteria. Signed in users
both with and without a GP ODS code must be able to view the Covid
Pass link in the service suggestions list.


View Links to All Eligible
Services In Service
Suggestions List


NHS Identified Users without a GP ODS code should be able to sign
in to the NHS App and view links to all services which do not require
a GP ODS code as part of their eligibility criteria.













5.9.1.3. Service Suggestions - With GP Registration


Use Cases
View Links to All Eligible “GP
Services” In Service
Suggestions List


Some Digital Services are restricted by an NHS Identified User’s GP
registration. These are known as “GP Services”.
An NHS Identified User with a GP registration must be able to see all
their GP Services, as well as all the services which are not limited by
GP ODS code.













5.9.1.4. Service Suggestions – Country and Regional Variation
Discussed in “problem 6” – see appendix, section 9.1.


Use Cases
View Links to All Eligible
Scottish Services, In Service
Suggestions List


Some Digital Services are offered across regional and national
boundaries. Where a patient receives care across a regional or
national boundary, they should be able to access Digital Services
which are provided as part of this care package. However, NHS

may not be eligible to see these Digital Services.













5.9.1.5. Service Suggestions – Condition Based


Use Cases
View Links to all COPD
Related Services, In Service
Suggestions List


Some Digital Services are offered on the basis of condition. In this
example, where a patient has asserted that they have COPD in their
user profile, they should be able to view links to COPD related
services in their service suggestion list.













5.9.1.6. Service Suggestions – Multi Category
Discussed in “problem 2” – see appendix, section 9.1.


Use Cases
View Link to PHR Digital
Service A & B


Digital services are grouped together in categories – for example
PHR, online consultation. NHS Identified User’s should be able to
view multiple services from the same category, within the service
suggestion list. This provides choice for the service user. This is not
currently supported.












## 5.10. Processing Consent Use Cases


This diagram represents the operations performed by the NHS Identified User or by a Digital Service, or
the NHS Account User Profile, in the context of processing consent. Processing consent grants the
processor the legal right to process the user’s data for a particular purpose or purposes.


Use Case Processing Consent
Accept T&Cs An NHS Identified User accepts the current terms and conditions.
The acceptance of the terms and conditions, as well as any granted
options, forms the contract for processing the data within the context
of:
A. The service to which the terms and conditions relate.
B. The processing purposes specified by the service (defined within
the terms and conditions and options).


View current terms and
conditions


Allows an NHS Identified User to read the terms that they must agree
to before using the service to which the terms and conditions relate.


View consent options Displays any optional consent options that the NHS Identified User
may be able to opt into.


Opt in to option An NHS Identified User opts into an optional consent option. Each
option must be set to "opted out" by default. Therefore, opting in is an
explicit action taken by the user.













Opt out of option An NHS Identified User opts out of an optional consent option. Each
option must be set to "opted out" by default. Therefore, opting out
may be implied by taking no action (accepting the default setting).


Reject T&Cs An NHS Identified User rejects the current terms and conditions. The
related service will behave accordingly (for example not allowing the
user to access the service).


Accept amended T&Cs
When a service’s terms and conditions are amended, existing
processing consent is based on an outdated version of the terms and
conditions. The service may decide to force the user to agree to the
new terms and conditions before they are able to access the service
again.


Publish T&Cs
Used to publish a first version of the processing terms and conditions
a user must agree to, prior to using the subject Digital Service.


Publish Consent Options
Consent options are associated with the processing consent terms
and conditions. A user can opt into or out of options.


Publish updated T&Cs Used to publish an updated version of the processing terms and
conditions a user must agree to, prior to using (or continuing to use)
the subject Digital Service.


Update Consent Options Consent options can be amended when a new version of the terms
and conditions are published. Consent options can be carried forward
between terms and condition versions, if they remain unchanged.


Deprecate T&Cs Removes the terms and conditions from publication.


Check Consent Granted A Digital Service can query the consent management service, to see
whether a user has consented to a particular version of the services
terms, conditions, and options.
Delegate Consent Capture
A Digital Service can delegate the responsibility for displaying the
services terms and conditions, capturing the user’s consent, and
storing the consent.












## 5.11. Eligibility Extension with Digital Services Use Cases


Actors
External Digital Service Admin
Tool


A software tool used by a Digital Service. This tool is not provided
as part of the NHS Account.


Use Cases – Eligibility Extension with Digital Services

## Authorize Pre-condition: the Digital Service has onboarded with NHS Account,


and has been granted offline access for the purpose of making service
suggestions.


Trigger: the Digital Service wishes to be recommended to the NHS

pathway.


The External Digital Service Admin Tool requests authorisation to
make a recommendation of itself to an individual patient. The
authorisation service authenticates the External Digital Service Admin













Tool’s credential(s) and grants this access, based on a successful
evaluation of the access control policy.
Result: the External Digital Service Admin Tool is granted access to
recommend itself to a specific user.


Please note: this use case does not grant the Digital Service rights to
access the user’s user profile. This authorisation is granted at a later
stage.


Add Digital Service

## suggestion


Pre-condition: the External Digital Service Admin Tool has been
granted access to recommend the service to an individual user.


Result: a record of the recommendation is recorded by the Service
Suggestion Service.


View list of suggested

## Digital Services


An NHS Identified User can view a list of Digital Service suggestions.
Any Digital Services which have gone through the “add Digital Service
suggestion” step for the logged in user, will appear amongst this list.


The user can add / remove this Digital Service to / from “My Services”,
in the same as is articulated in the earlier use case.












## 5.12. Record Interactions with Care Services Use Cases


NHS Identified User


View Interactions


Clinical System


Add Record Pointer


Get
Patient Record


Digital Service


Including InteractionsGet Profile


NHS AccountUser Profile


Patient PointersQuery


Use Cases - Record Interactions with Care Services
Add Record Pointer When a user/patient has an interaction with a care provider, and care
provider makes a digital record of that interaction, the care provider
may use the Add Record Pointer functionality of the Registration
Repository System to allow other parties to locate that digital record.
Query Patient Pointers Precondition: The NHS Account User Profile has been granted
access to query the Registry Repository System for pointer which
relate to a specific NHS Identified User.
The NHS Account User Profile makes a request to the Registry
Repository System to obtain a list of pointers that have been
registered for the current NHS Identified User. Each item in the list
contains information that indicates the location of a patient record.
The referenced patient record contains details of an interaction that
the user had had with a care provider.













Get Patient Record Precondition: the NHS Account User Profile is authorised to access
the referenced record.
The NHS Account User Profile can use the record pointer to locate
and query the referenced record.
Get Profile Including
Interactions


Allows a Digital Service to read the NHS Account Profile of the
current NHS Identified User, where the contents of the Profile are
extended to include a list of the interactions that the User has had
with one or more care providers.
View Interactions The current NHS Identified User can view a list of their previous
interactions with one or more care providers.












## 5.13. Data Provenance


Get Data ItemsInc Data Item
Provenence


Create /Update
Data Item


Data ItemStore


<<include>>


Sign Hash


Private KeyGet User


<<include>>


Capture Data Item


Compute Provenence


Hash of EntireCreate Signed
Data Item


<<include>>


NHS Identified User <<include>> <<include>> NHS Identified User


ProvenenceValidate


SignatureValidate
<<include>>


Get User Profile
<<include>>


<<include>>


<<include>>


PublicGet User Key


<<include>>


Use Case Data Provenance for Digital Service Producer
Capture Data Item The Digital Service captures personal data inputs
of an NHS identified user.
Compute Provenance The Digital Service then computes the
provenance of the data (e.g. which NHS Identified
User entered the data and which Digital Service
was being used to enter the data). NHS Identified
User proxies may have access to the NHS
Account user profile in the future.
Create Signed Hash of Entire Data Item The Digital Service then generates a unique hash
for the entire data item.
Sign Hash Once the unique hash has been generated the
Digital Service makes a request to the Trust
Framework Policy of NHS Account so that it can
sign the hash.
Get User Private Key The Trust Framework Policy of NHS Account
uses a user’s private key in order to sign the
hash.













Create Update Data Item The signed hash is returned back to the Digital
Service. The Digital Service then calls the User
Profile Service of NHS Account to save the data
item.
Store Data Item The User Profile Service then stores the data
item, provenance and signed hash in the user’s
personal online data store.


Use Case Data Provenance for Digital Service Consumer
Get User Profile A Digital Service triggers a need to get the user’s
profile.
Get Data Items including Provenance Prerequisite: the Digital Service is authorized to
access the user profile and the user is signed in.


The Digital Service makes a request to the NHS
Account User Profile Service and the profile data
including provenance and signed hash is
returned.
Validate Provenance Once the profile data is returned to the Digital
Service it then proceeds in validating the
provenance of the data.
Get Public Key The Digital Service makes a request to the Trust
Framework Service of NHS Account in order to
get the author’s public key. The Digital Service
may have business rules relating to the author of
the data (which may not be the subject or logged
in user).
Validate Signature Verification of the signature is done by using the
public key, obtained from the Trust Framework
Service of NHS Account.












## 6. Development View

## 6.1. Level 1 – System Context


The diagram below represents a technical overview of the NHS Account and it’s interactions with other
external systems, tools and services.


NHS App Channel [Software System]
Allows patients to access a range of NHS services.


NHS Identified User [Person]
A user who has authenticated with and is identified by the
NHS Login service


NHS.uk Channel [Software System]
public content. Allows patients Provides access to a range of
to access a range of NHS services.


Anonymous User [Person]
Anybody on the web.


NHS Login Service [Software System]
Provides NHS Patient identity assurance and authentication
services


Covid Pass Digital Tool [Software System]
Provides NHS Patientdomestic and foreign covid s with the
vaccination passes


NHS Account Service [Software System]
Allows patients to see and manage their user profile.
Provides personalised digital service suggestions.


and transacts with the NHS usingViews personal information
content usingViews public


manage user profileAllow user to manage user profileAllow user to


Primary Demographics Service
[Software System]
The national electronic database of NHS patient details such as
name, address, date of birth


view & manageAllows user to


Service BusService
[Software System]
A message broker, used to decouple applications and
service from each other.
user profile changesRaises event when


information. Updates Gets user profile
user profile information.Can access one patient at
a time (with patient logged in)
Delegates identity assurance and authentication. Gets identity claims such as NHS Number, family
name, given name, email, phone number, GP information, etc


Covid Pass used as a representative example of a
patient facing Digital Service / Tool


NOTE: NHS.uk id verification and authentication delegated to NHS
(lines removed for brevity)Login.


Cohorting Service [Software System]
Provides the NHS with a multidimensional array of patient -
data.


NHS Administrator [Person]
An NHS Employer whose role includes sending health
message campaigns to patients


health messaging campaignSets up and runs


profiles. Can access many Queries across user
same time. Patientpatient profiles at the s do
not need to be logged in.


Health Messaging Campaign Tool
[Software System]
with a tool to segment & send Provides NHS care providers
bulk communications to their patients


Query (hyper)cubeto identify cohorts.


A digital service can add their service to a user s
profile on behalf of the user.


Element Type
person icon person
person icon external person
square box system
square box external system
square box container


System Context diagram for NHS Account












## 6.2. Level 2 – Container Context


The diagram below represents a technical overview of the NHS Account and it’s high-level components
highlighted in green.























## 6.3. Level


The NHS Account is divided up into small Services, each of which implement a subset of the overall
functionality, based on domain driven design and bounded contexts [18]. This is generally described as a
Micro Service approach and supports architectural principles such as common closure and common
reuse.

### 6.3.1. Health Profile Service


Description
The Health Profile Service provides access to the subset of the NHS User Profile data that relates to
health.
A Digital Service can access the Health Profile Service by using the Health API. It is dependent on the
Health API for access to the User Profile health related data. The Health API is a HL7 FHIR R4 compliant
endpoint, with additional FHIR profiling (for validation). Access to the Health API is authorized using the
NHS Account Authorization Service and the OAuth 2.0. authorisation protocol.
The Health Profile Service is responsible for all the health domain business logic and processing,
delegating to the Health POD for persistence.












### 6.3.2. Demographic Profile Service


Description
The Demographic Profile Service provides access to the subset of the NHS User Profile data that relates
to demographics.
A Digital Service can access the Demographic Profile Service by using the Demographic API. It is
dependent on the Demographic API for access to the User Profile demographic related data. The
Demographic API resource model is out of the scope of this design. Access to the Demographic API is
authorized using the NHS Account Authorization Service and the OAuth 2.0. authorisation protocol.
The Demographic Profile Service is responsible for all the demographic domain business logic and
processing. It delegates to the Advanced Demographic POD or PDS FHIR API for persistence,
dependent on the type of the demographic data item. The Advanced Demographic POD is designed to
allow the amount of demographic data to be increased over time, without requiring PDS upgrades.












### 6.3.3. Authorisation Service


Description
Each Micro Service API is a protected resource. Access to each API must be authorised. Each API has
one or more scopes of access – a client may be authorised to access zero, one or more scopes of
access. NHS Account authorisation decisions are delegated to the NHS Account Authorization Service.
This is an implementation of a standard authorisation protocol called OAuth 2.0 [19].
OAuth 2.0 is a simple and secure authorisation framework and is described by the OAuth2 RFC 6749
specification [19]. It allows applications (clients) to acquire an access token for authorised API access via
various workflows supported within the OAuth2 specification.
A client obtains an access token by sending an authorisation request to the NHS Account Authorization
Service. In the Authorization Code Flow scenario, the NHS Account Authorization Service delegates
authentication to NHS Login (more details below). Once the user has been authenticated, the NHS
Account Authorization Service checks to see if the identified user has already consented to share their
information with the client for the scope of access specified (in the authorisation request). If not, the NHS
Account Authorization Service asks the user for their sharing consent (to the requested scopes of
access). Assuming the user consents to share their information in this way, the NHS Account













Authorization Service stores a record of this sharing consent and issues an access token to the client
application accordingly.
The NHS Account Authorization Service does not provide authentication or identity verification. These
responsibilities are delegated to NHS Login. A federated integration is made between the NHS Account
Authorization Service and NHS Login, using the Open ID Connect authentication federation protocol
standard [20].
NHS Login’s mechanism for achieving single sign-on must be used to suppress the need for the user to
have to provide credentials upon each authorisation request. Authorisation must be short lived and least
privilege, which means that there may be a lot of individual authorisation requests throughout the course
of a user’s session. Ideally the user only enters their credentials once, when they first sign-in to their
session (this is typically not part of an authorisation request).
The NHS Account Authorization Service may not send an authentication request to NHS Login in order to
satisfy every authorisation request. The NHS Account Authorization Service may cache a user’s
authentication, in the form of the id token issued by NHS Login (thereby becoming “stateful” and
establishing an authorisation session with the user). This would happen as part of the first authorisation
request in the user’s session. This is subject to access control policy decisions.

### 6.3.4. Processing Consent Service


Description
The Processing Consent Service provides the NHS Account and Digital Services with a delegated
processing consent service. Digital Services do not have to use the Processing Consent Service. It is
offered to them as an optional service. If Digital Services do not use the Processing Consent Service,
they must make their own processing consent arrangements.













The Processing Consent Service is designed to help Digital Services and the NHS Account to fulfil any
obligations that arise in conjunction with the consent lawful basis for data processing, as defined in UK
General Data Protection Regulation (GDPR) [17].
The Management API allows Digital Service’s to publish versions of their service terms, conditions and
options. The Processing Consent Service is multi-tenanted. It can hold terms, conditions and options for
multiple Digital Services (tenants). Each Digital Service has its own logical separation within the
Processing Consent Service, meaning that a Digital Service’s terms, conditions and options are isolated
from those of other Digital Services. Within each tenant, there may be multiple versions of terms,
conditions and options. Each version of terms and conditions will be addressable via a URL.
For example, consider the following URL scheme:
https://processing-consent.account.nhs.uk/{service-title}/{T&C version}
Where:
https://processing-consent.account.nhs.uk/wellness-hub/1.0
Related to the 1st version of the Wellness Hub terms, conditions and options.
The Management API also allows a Digital Service to check which version of their terms and conditions
an NHS Identified User has agree to, and any options that the user has accepted. The Management API
is authorised using the standard OAuth 2.0. client credential grant flow, in conjunction with the NHS
Account Authorization Service.
The Terms and Conditions Web Application allows Digital Service’s to redirect a user’s browser, for the
purpose of displaying terms, conditions and options, as well as capturing processing consent from the
user. Capturing processing consent means collecting the user’s explicit consent to the terms and
conditions. The terms and conditions published by the service should clearly describe what data the
service intends to process, how it intends to process the data and what the processing purposes are. This
is achieved using a consent request and response mechanism, explored further in the process view
(section 7.1).
There is an identity federation (sharing of trust) between the Digital Service, the Terms and Conditions
Web Application, and NHS Login. This allows for a single sign-on experience.












### 6.3.5. Service Suggestion


Description
The NHS Account Client Application (App) is a Single Page Application (SPA) that initiates user
authentication, serves as a container for imported components and provides user context.
The Core Profile is a relatively small collection of health and demographic profile data, downloaded and
cached on the user’s agent (web browser). The core profile does not contain the entire user profile
history, but the head version of a number of key attributes (e.g. the latest weight observation, not all
weight observations over time). The NHS Account Client Application obtains the core profile by interacting
with the Health Profile Service and Demographic Profile Service via the BFF (although these
dependencies are not shown in the diagram, for brevity).













6.3.5.1. Core Profile Visualisation
Notional / test data only


The Service Suggestion Service JavaScript Component provides Digital Service suggestions to an
authenticated NHS Identified User. The list of service suggestions is calculated based on the user’s core
profile, identity profile and Digital Service eligibility rules. The Service Suggestion Service JavaScript
Component interacts with the Service Suggestion Service (via the BFF) in order to obtain a list of eligible
Digital Services for the logged in user. Each eligible service is returned and described by a set of
metadata (e.g. Digital Service name, description, URL).
Each eligible service may provide their own additional eligibility rules. In these cases, the eligibility rules
are defined in a JavaScript component (one per Digital Service), which is provided and hosted by the
Digital Service. The URL for this JavaScript component is contained within the Digital Service metadata
(configured during onboarding time).
Where a Digital Service has specified its own eligibility rules, the Service Suggestion Service JavaScript
Component imports the service’s Eligibility JavaScript Component using the URL configured in the Digital
Service metadata. Once imported, the Service Suggestion Service JavaScript Component invokes a
JavaScript function, defined within the service’s Eligibility JavaScript Component. The core profile data
collection is passed into this function as a parameter. The body of the function defines the service’s
eligibility rules. Once the rules have been run, the Eligibility JavaScript Component returns an eligibility
result (true / false) to the Service Suggestion Service JavaScript Component.
As the Eligibility JavaScript Component is imported, it executes within the security & processing consent
context of the NHS Account (not the Digital Service). The Digital Service defines the rules. The NHS
Account runs the rules and acts upon the result of the rules.
The BFF (Backend for Frontend) provides a reusable session management, token management and
authorisation capability to internal Digital Services.













The Digital Service Registry Service provides a registry of NHS Account approved Digital Services,
including metadata and centrally defined eligibility rules. The Digital Service metadata is configured into
the registry during service onboarding time.
The Service Suggestion Service provides service suggestion functionality via a JSON/HTTPS and
XML/HTTPS API. The Service Suggestion Service depends on the Digital Service Registry Service, to
provide a list of all approved Digital Services, including Digital Services metadata and Digital Services
eligibility rules. The Service Suggestion Service act as a rules engine. It uses the rules obtained from the
Digital Service Registry Service, and the full user profile obtained from the Health Profile Service and
Demographic Profile Service, to calculate whether the user is eligible for each Digital Service.












### 6.3.6. Eligibility Extension with Digital Services


Description
The Digital Service is a third-party component. The exact implementation of this component is not
specified and is out of the scope of this specification. The purpose of this component is to allow a third-
party service provider to trigger the suggestion of their Digital Service to an individual user.
The Service Suggestion Service exposes a Suggestion API. The API allows authorised Digital Service
clients to send a service suggestion request. The service suggestion request allows a Digital Service to
suggest itself to exactly one user (per request). The suggestion is stored in the Service Suggestion
Service, for later use. This API is a web API accessible via the public cloud (Internet). The scope of the
API may develop with future use cases, such as allowing a Digital Service to un-suggest itself.
The dependency between the Service Suggestion Service and the Digital Services is designed in the
direction of stability (the Service Suggestion Service Suggestion API is more stable as it likely to change
less frequently than a collection of APIs provided by each Digital Service). This is a component coupling
architectural principle.
The Service Suggestion Service Suggestion API is authorised by an access token being passed in the
HTTP header of the service suggestion request. The Digital Service becomes a bearer of this access
token by following the standard OAuth 2.0. client credential grant flow (protocol), with the NHS Account
Authorization Service. This grant flow is selected because the NHS Identified User will not be using the
system at the time of the service suggestion request (offline access is required).
The Service Suggestion Service displays a list of service suggestions to an individual user, when they
login and go to the service suggestion view. The service suggestion request documented in this section is
one of several types of “eligibility” rules, used to compile this list of service suggestions.












### 6.3.7. Record Interactions with Care Services


Description
When a patient has an interaction with a health service provider, the provider makes a record of the
interaction in their electronic patient record (EPR) system.
The provider’s EPR can register a pointer to this patient record by sending a message to the Record
Registry Repository. The pointer provides a reference to the instance of the patient interaction, held in the
EPR. This is not shown in the diagram as the Record Registry Repository and its relationship with EPRs
is outside of the scope of this specification.
The NHS Account Health Profile Service can a) query the Record Registry Repository to obtain a list of
pointers (interactions) that have been registered for the current NHS Identified User, and b) retrieve the
corresponding records from the EPR. This allows the Health Profile Service to supplement self-asserted
health profile data with records of healthcare service interactions.
The Health Profile Service may implement a caching mechanism. The caching mechanism is designed to
reduce the request burden on EPRs (improve scalability) and improve the Health Profile API response
times.
The Record Registry Repository API is outside the scope of the NHS Account. The Health Profile Service
uses this API, but in doing so there may be security protocols and other technical security constraints that
must be followed. These protocols and constraints are outside of the scope of this specification.
The EPR API is outside the scope of the NHS Account and may be located within a secure clinical
network. The Health Profile Service may be able to use this API by making a request over the Spine
Secure Proxy Service (SSP). In doing so there may be security protocols and other technical security
constraints that must be followed. These protocols and constraints are out of the scope of this
specification.












## 6.4. Digital Service Integration Patterns


Digital Services currently integrate with the NHS App using one of two integration options [14].
NHSX asked Sitekit to look at alternative Digital Service integration options, with a view to improving user
experience.
Several Micro Frontend Pattern techniques [16] were analysed, including the Micro App and (JavaScript)
Framework Based Component techniques.
The existing NHS App web integration option [15] is an implementation of the Micro App technique. Each
Digital Service executes within its own run-time.
The Framework Based Component technique is a popular alternative technique across industry. It
involves a base web application importing JavaScript Framework Based components, which execute in
the web browser and work with the DOM. The base app can implement horizontal slicing (multiple
components executing concurrently in one view) or vertical slicing (each component is imported into its
own view / page). The technique is typically used to separate independent application features (in line
with the separation of microservices and domain driven design). Sitekit looked at the technique with a
view to separating Digital Services as Framework Based Components.
Web Components (based on the following W3C standards: custom elements, HTML templates, shadow
DOM and HTML imports) were also considered. However, this approach was discounted at the time of
writing (03/2022) due to the lack of support in older web browsers and the lack of control over public user
browser upgrades.
Comparing techniques.
Micro Frontend Techniques
Micro App Framework Based
Component


Web Component

Autonomous Features (^)
Team Ownership (^)
Tech Agnostic (^)
User Experience (^)
Value Driven (^)
Microservice Driven (^)
Browser Back
Compatibility
Implementation Simplicity (^)
Independent Security
Context
The existing Micro App / Web Integration approach remains good for External Digital Services. These
services are typically pre-built and would require a lot of refactoring to work with the Framework Based
Component and Web Component techniques. The Framework Based Component and Web Component
approaches force the Digital Services to execute within the same security context, which is unlikely to be
appropriate. The Framework Based Component and Web Component approaches are not recommended
for External Digital Services for these reasons.
Internal Digital Services are developed by, or on behalf of the NHS (they are not necessarily prebuilt).
The NHS has control over the implementation approach. Internal Digital Services may share the same natural security boundary, as they may be presented as features within the same application, rather than
independent applications. Sitekit recommends that the Framework Based Component approach is
included as an option for Internal Digital Services.
For the avoidance of doubt and misinterpretation - Sitekit does not recommend that all Internal Digital
Services are developed using the Framework Based Component technique. Rather, Sitekit recommends
that each Internal Digital Service is considered independently, and the Framework Based Component
approach is offered as one integration option, as well as the Micro App / Web Integration approach.


## 7. Process View

The process view decomposes the system into communicating processes, showing how the system
works. UML sequence diagrams will be used to articulate this view.

## 7.1. Processing Consent


Processing consent describes a type of consent given by a user. Processing consent grants a Digital
Service the legal right to process the user’s personal data. There are typically terms that the user must
meet before they can use the Digital Service, conditions that they must abide by whilst using the service,
and perhaps additional, optional ways in which their data may be processed. The Digital Service must
clearly describe the purpose or purposes for processing the user’s personal data. The Digital Service
must clearly describe the manner in which the personal data will be processed and define legal roles and
responsibilities. These concepts are typically presented to a user in the form of terms and conditions. The
user is able to read the terms and conditions and decide if they are prepared to accept them. This
acceptance is defined as the user providing processing consent.


The Processing Consent Service has been designed to allow Digital Services to delegate the
responsibility of displaying, capturing and recording a user’s processing consent. The Processing
Consent Service is optional – Digital Services can display, capture and record a user’s processing
consent within their own bounded context if they wish.
Delegated processing consent can be broken down into three related processes:

1. Management: a Digital Service managing its terms, conditions and options.
2. Capture: a Digital Service delegating (redirecting) the responsibility for displaying terms,
    conditions and options, and capturing processing consent from the user.
3. Query: a Digital Service querying the Processing Consent Service, to ascertain whether a user
    has agreed to the latest terms and conditions, and which options have been agreed to.

### 7.1.1. Management


The following contributors are involved in the delegated processing consent management process:
Digital Service
NHS and third-party services. For example, Wellness and Prevention, Patient Knows Best (PKB) which
are accessed by digital means. In this context, the Digital Service represents some software written by the
Digital Service Developer, which can be used to manage their terms and conditions.
NHS Account Authorization Service
Provides a technical implementation of the user consented access control policy.
Processing Consent Service Management API













Provides Digital Services with a web API to complete delegated processing consent management
operations.


Pre-conditions:
The Digital Service has been onboarded and granted access to use the delegated Processing Consent
Service. Client credentials are issued to the Digital Service as part of the onboarding process.
Trigger:
The Digital Service decides to publish a new version of its terms, conditions and options.













Post-conditions:
The Digital Service’s latest terms, conditions and options are published and a T&C entry point URL is
provided back to the Digital Service.
Process Steps
1) Authorisation request
The Digital Service make an authorisation request to the NHS Account Authorization Service
(client credential grant flow). The scope of the authorisation request is “processing-consent-
management”.
2) Authenticate client credentials and evaluate access control policy
The NHS Account Authorization Service validates the client credentials and makes sure the client
is authorised to use the “processing-consent-management” scope.
3) Authorisation response + access Token
An access token is issued by the NHS Account Authorization Service and returned back to the
Digital Service in an authorisation response.


4) POST new version of this Digital Service client's terms, conditions, options, and return
URL + Access Token
The Digital Service posts a new version of their terms, conditions and options. The access token
issued in step 3 is passed in the HTTP request header.
5) Validate access token and check request is authorised


The Processing Consent Service Management API validates the access token and makes sure
that the request is in scope.
6) Validate new terms, conditions and options
The Processing Consent Service Management API validates the post payload – it makes sure
that the terms, conditions and options pass validation.


7) Store new version of Digital Service client's terms, conditions and options


The Processing Consent Service Management API stores the new version of terms, conditions
and options for this Digital Service.
8) HTTP 201 Created Response includes T&C URL
The Processing Consent Service Management API responds back to the Digital Service to notify
it that the new T&Cs have been created. A T&C URL is also provided as part of the response.
The Digital Service can use this URL as an entry point to capture process (described below).


9) Store T&C URL













The Digital Service stores the T&C URL for later use.

### 7.1.2. Capture


The following contributors are involved in the delegated processing consent capture process:


Digital Service
NHS and third-party services. For example, Wellness and Prevention, Patient Knows Best (PKB) which
are accessed by digital means.
Processing Consent Service T&C Endpoint
Provides Digital Services with a delegated processing consent capture service.
NHS Login
Provides NHS Patient identity assurance and authentication services.













Pre-conditions:
The Digital Service has been onboarded and granted access to use the delegated Processing Consent
Service. The Digital Service has used the Processing Consent Service Management API to publish the
latest version of their terms, conditions and options.
The user is logged into the channel with NHS Login.













Trigger:
A user adds the Digital Service to their NHS Account, based on a suggestion. The user opens the Digital
Service for the first time. The Digital Service registration process is that the user must agree to terms and
conditions, before the user is allowed to use the Digital Service.
Post-conditions:
The Digital Service’s latest terms, conditions and options are agreed to by the user and a record of this is
stored in the Processing Consent Service.
Process Steps
1) Processing Consent Request HTTP 302 Redirect to T&C URL Includes client id & Return
URL + NHS Login "SSO token"
The Digital Service redirects (HTTP 302) the user to the Processing Consent Service T&C
Endpoint. The NHS Login “SSO token” is passed over as part of the redirect request.


2) Authentication request + SSO token
Processing Consent Service redirects the user to NHS Login for authentication (with the SSO
token).
3) Authentication response + ID Token


NHS Login authenticates the user based on the SSO token and passes an ID token back to the
Processing Consent Service in an authentication response. The protocol has been abbreviated.
4) Validate client id and return URL
The Processing Consent Service validates the Digital Service’s client id, which is passed across
in the processing consent request (step 1). The Processing Consent Service ensures that the
return URL passed in the request is an exact match for the return URL stored for the Digital
Service client in its store. The Processing Consent Service also checks that the version of the
terms and conditions referenced in the URL belong to this Digital Service.


5) Display Digital Service client's T&Cs and options on screen to user
The Processing Consent Service retrieves the correct version of the terms, conditions and
options, based on the processing consent URL. It displays the terms, conditions and options to
the user and asks the user to consent, by ticking boxes on a web form.


6) Capture (and store) processing consent and options from user
The user reads the terms, conditions and options and completes the web form by agreeing to the
terms and conditions, and selecting zero, one or more optional consents.













7) Processing Consent Response HTTP 302 Redirect to return URL Includes signed
processing consent token
Processing consent response is sent back to the Digital Service, as a HTTP 302 redirect, using
the return URL provided in the request (step 1). A signed JSON Web Token (JWT) is used in the
response to provide a number of consent claims – the user identifier, the version of the T&C’s,
the date and time of the agreement and any optional consents given.
8) Validate processing consent token
The Digital Service validates the processing consent token, to ensure that it is trusted.
9) Record processing consent given


The Digital Service makes a record of the user’s agreement to it’s processing consent terms and
conditions, and any optional consents given.
10) Move on with Digital Service registration steps...
The Digital Service moves on with the user registration process.

### 7.1.3. Query


The following contributors are involved in the delegated processing consent query process:


Digital Service
NHS and third-party services. For example, Wellness and Prevention, Patient Knows Best (PKB) which
are accessed by digital means.
NHS Account Authorization Service
Provides a technical implementation of the user consented access control policy.
Processing Consent Service Management API
Provides Digital Services with a web API to complete delegated processing consent management
operations.













Pre-conditions:
The Digital Service has been onboarded and granted access to use the delegated Processing Consent
Service. Client credentials are issued to the Digital Service as part of the onboarding process.
The Digital Service has used the Processing Consent Service Management API to publish the latest
version of their terms, conditions and options.
The user has agreed to the Digital Service’s latest published terms and conditions.
Trigger:













The Digital Service needs to know if a user has agreed to the most recent version of their terms and
conditions.
Post-conditions:
The Digital Service is aware that the user has agreed to the most recent version of their terms and
conditions. Hence, it does not need to ask the user to agree to the terms and conditions again.
Process Steps
1) Authorisation request
The Digital Service make an authorisation request to the NHS Account Authorization Service
(client credential grant flow). The scope of the authorisation request is “processing-consent-
management”.
2) Authenticate client credentials and evaluate access control policy
The NHS Account Authorization Service validates the client credentials and makes sure the client
is authorised to use the “processing-consent-management” scope.


3) Authorisation response + access Token
An access token is issued by the NHS Account Authorization Service and returned back to the
Digital Service in an authorisation response.
4) GET /Consent?nhsnumber=<nhsnumber>. Find out is a user has agreed to current
version of terms and conditions. Also, which options have been selected.
The Digital Service queries the Processing Consent Service Management API to find out if a user
has agreed to the latest version of the Digital Service’s published T&Cs. The access token
obtained in step 3 is passed into the request via the HTTP header.


5) Validate access token and check request is authorised
The Processing Consent Service Management API validates the access token and makes sure
that the request is in scope.
6) Get user processing consent status for this Digital Service client, from the database


The Processing Consent Service looks up the user’s consent status for this Digital Service.
7) Return consent resource
The Processing Consent Service returns a processing consent resource back to the Digital
Service. The processing consent resource contains a number of attributes, which are a
representation of the user’s current consent status – for example, the user identifier, the version
of the T&Cs, the date and time of the agreement and any optional consents given.













8) User has agreed to current version of T&Cs so can proceed...


The Digital Service reads the processing consent resource, concludes that the user has agreed to
the latest version of its terms and conditions, so continues on with its data processing (as
consented).

## 7.2. Sharing Consent


Sharing consent describes a type of consent given by a user. Sharing consent is not the same as
processing consent (see section 7.1 for a description of processing consent). Sharing consent grants a
Digital Service access to some or all of the information held within the subject’s User Profile. The subject
controls their sharing consent – they control which Digital Services have access to their user profile and
how much access is granted.
Once a Digital Service has gained authorised access to a user’s User Profile, copied a data item instance
from the NHS Account Health Profile Service API and / or NHS Account Demographic Profile Service API,
and started to process this data item instance within the bounded context of the Digital Service, this
processing becomes subject to processing consent (described separately in sections 5.10, 6.3.4 and 7.1).
The following contributors are involved in the Sharing Consent process:
User Agent / Web Browser
Software that the NHS Identified User uses to access the web (e.g. Safari, Google Chrome).


Digital Service (client)
NHS and third-party services. For example, Wellness and Prevention, Patient Knows Best (PKB) which
are accessed by digital means.


NHS Account Authorization Service
The Authorization Service is responsible for responding to authorisation requests, evaluating the access
control policy and issuing access tokens (where applicable). The authorisation service exists within the
bounded context of the NHS Account.


NHS Login Identity Provider (IDP)
Provides NHS Patient identity assurance and authentication services.
























Pre-conditions:
The Digital Service has been onboarded and granted access to use the NHS Account User Profile. Client
credentials are issued to the Digital Service as part of the onboarding process.
The Digital Service has authenticated the NHS Identified User via NHS Login and has an SSO token.
The Digital Service has registered the NHS Identified User and has the right to process the user’s data (in
whichever way the Digital Service chooses to establish this).
Trigger:
The Digital Service wishes to access data within the NHS Identified User’s User Profile.
Post-conditions:
The Digital Service is able to access the personal data, held within the NHS Identified User’s User Profile,
for the scopes of access granted (consented) by the NHS Identified User.
Process Steps
1) Authorisation request (302 redirect) with NHS Login SSO Token
The Digital Service initiates an OAuth 2.0. authorisation request to the NHS Account
Authorization Service. This is the first time the Digital Service has made an authorisation request
for this user. Rather than have the user see multiple sharing consent screens, one each time a
new scope of access is requested, the Digital Service opts to ask for sharing consent to all the
scopes of access it might need in future use cases.
Subsequently, when the Digital Service makes future authorisation requests for this user, the
scopes should be limited to what the Digital Service is trying to do at that time. The consent view
should not be displayed by the authorisation service as sharing consent is captured through this
initial authorisation request. However, it should be noted that sharing consent can be revoked or
changed (increased / decreased) by the user at any time, so it is not possible to suppress the
consent UI view, as part of each authorisation request.
2) Authorisation request (302 redirect) Authorise endpoint with NHS Login SSO Token +
session cookie
The web browser posts the authorisation request to the NHS Account Authorization Service. A
session cookie is also posted (based on an earlier interaction).
3) Authorisation session open based on session cookie
The NHS Account Authorization Service checks the session cookie and retrieves the NHS Login

been active the NHS Account Authorization Service would have delegated to NHS Login, starting
an Open ID Connect authentication request (with the SSO token passed). However, in this
scenario, this additional authentication is unnecessary.
4) Check access scopes. User has NOT consented to this Digital Service Client having this
scope of access
The NHS Account Authorization Service detects that the user has not consented to the requested
scopes of access for this Digital Service. This is based on (the lack of) sharing consent records
held within the NHS Account Authorization Service.
5) Display processing consent form













The NHS Account Authorization Service sends a sharing consent view to the user’s browser. This
may look something like (restyled to NHS.uk branding and ignoring the specific scopes given in
this screenshot):


6) Select processing consent options in check boxes and click "Yes, allow" button
The NHS Identified User interacts with the web form. They uncheck any sharing consent option
that they do not wish to grant the Digital Service. Each scope of access requested is displayed as
a separate sharing consent check box. The UX view may be improved, for example by including a
“Select All and Continue” button.
7) Post processing consent form + session cookie
The NHS Identified User’s sharing consent options are posted back to the NHS Account
Authorization Service.
8) Validate post. Record processing consent against authenticated user, Digital Service
client (id), and scope(s) that have been granted
The NHS Identified User’s sharing consent options are validated. They are then recorded in the
NHS Account Authorization Service’s sharing consent store.
9) Authorisation response HTTP 302 redirect + code to client's return URL
NHS Account Authorization Service creates a code and returns it to the Digital Service via the
return URL (this is a standard OAuth 2.0. authorisation response – authorisation code flow).
10) Authorisation response + code
The authorisation code is posted onto the Digital Service.
11) Token request to token endpoint + code +client id & secret













The Digital Service sends the authorisation code to the NHS Account Authorization Service token
endpoint (on the back channel). The Digital Service includes their client credentials in this post.
12) Validate client credentials
The NHS Account Authorization Service validates the Digital Service’s client credentials.
13) Token response + access token
The NHS Account Authorization Service issues a new access token, matching the scopes that
were requested by the Digital Service (step 1) and granted by the NHS Identified User (step 6).
The access token is sent back to the Digital Service on the back channel. As bearer of this
access token, the Digital Service can now access the NHS Identified User’s User Profile, for the
scope(s) of access granted in the access token. The Digital Service makes onward requests to
the NHS Account Health User Profile API and Demographic User Profile API, passing the access
token in the HTTP header (as per the OAuth 2.0. standard).

## 7.3. Service Suggestion


The following contributors are involved in the Service Suggestion process:


Client App NHS Account
A Single Page Application (SPA) that initiates user authentication and serves as a container for imported
components and provides user context


Service Suggestion Service JavaScript Component
Provides Digital Services suggestions to NHS Identified Users, based on their user profile (frontend).


BFF (Backend for Frontend)
Provides a reusable session management, token management and authorisation capability to internal
Digital Services.
Authorisation Service


Provides a technical implementation of the user consented access control policy.
Service Suggestion Service
Provides service suggestion functionality via a JSON/HTTPS and XML/HTTPS API.
Digital Service Registry Service
Provides a registry of NHS Account approved Digital Services, along with metadata describing each
Digital Service.
Digital Service Eligibility JavaScript Component













A JavaScript component developed by a specific Digital Service developer. The purpose of this
JavaScript component is to allow the Digital Service developer to express their own Digital Service
eligibility rules. This mechanism is optional. A Digital Service developer may or may not provide their own
eligibility rules.


Pre-conditions:
The NHS Identified User has signed in to the Client App NHS Account, using NHS Login as a federated

The Client App NHS Account has established a session with the BFF and tokens (identity token, access
token, and perhaps refresh token) are cached on the server side by the BFF.
Trigger:
The NHS Identified User browses to the service suggestion view (e.g. whilst using the NHS App).













Post-conditions:
The NHS Identified User is shown the correct list of eligible Digital Service suggestions. Further business
rules should be defined specifying whether “Added” services should appear in the suggestions list (see
8.1 service suggestions logical view).
Process Steps
1) Import JavaScript
The Service Suggestion Service JavaScript Component is imported by the Client App. This
implements the JavaScript Component approach to the micro-frontend pattern.
2) JavaScript Component
The Service Suggestion Service JavaScript Component is returned.
3) JavaScript executes (initialisation)
The Service Suggestion Service JavaScript Component executes and initialises itself.
4) Get Digital Service suggestions
The Service Suggestion Service JavaScript Component calls the BFF to get Digital Service
suggestions. The Service Suggestion Service JavaScript Component is not aware of the
BFF’s role, it is just aware that there is an endpoint responsible for returning Digital Service
suggestions. This is an implementation of the backend for frontend pattern (BFF), which is a
best-practice approach to managing non-confidential clients.
5) OAuth 2.0 Token Exchange
The BFF component looks up the user’s session, based on the session cookie posted back to
the BFF server. The BFF holds the user’s tokens on the server side. It uses these tokens to
orchestrate a token exchange authorisation process with the Authorization Service. This is
with a view to obtaining an access token which grants access to the Service Suggestion
Service.
6) Access Token
The BFF client is authenticated, the access control policy is evaluated, and an access token
is returned to the BFF, granting access to the Service Suggestion Service on behalf of the
NHS Identified User.
7) Get Digital Service suggestions + Access Token
The BFF calls the Service Suggestion Service to get service suggestions. The access token
obtained in step 6 is passed in the HTTP header.
8) Get all Digital Service metadata
The Service Suggestion Service calls the Digital Service Registry Service to get a collection
of all the onboarded Digital Services (and their metadata). This collection may be cached for
future use (not shown – for brevity).
9) Digital service metadata
A collection of all the onboarded Digital Services (and their metadata) is returned.













10) Filter Digital Services based on eligibility rules
(expressed within metadata)
The Service Suggestion Service filters down the number of Digital Services, based on the
eligibility rules defined within the metadata of each service. The Service Suggestion Service
may need to make external calls to the Demographic and Health Profile Services as part of
this step (not shown in the diagram for brevity). The Demographic Profile, Health Profile, and
eligibility rules are used by the rules engine to calculate whether the user is eligible to use
each Digital Service.
11) 1x Digital Service suggestion returned
(as Digital Service metadata instance)
In this scenario, the user is found to be eligible for one Digital Service. The metadata for this
Digital Service is returned to the BFF.
12) 1x Digital Service suggestion returned
(as Digital Service metadata instance)
The BFF passes the response back to the Service Suggestion Service JavaScript
Component.
13) Import JavaScript based on metadata
Digital Services are offered the option of specifying their own (additional) eligibility rules. This
provides the Digital Service Developer with additional control over their own service’s
eligibility criteria. If a Digital Service uses this feature, then the service must develop, publish,
and maintain their own Digital Service Eligibility JavaScript Component. This JavaScript
component must contain one function, the signature of which conforms to an interface which
will be specified as part of the onboarding procedure. The URL location of this JavaScript
component is specified as part of the Digital Service metadata. If the URL location is empty,
this means that the Digital Service Developer does not want to apply their own rules. In this
scenario, the Digital Service suggestion metadata returned in step 12 does contain a URL to
a Digital Service Eligibility JavaScript Component. The Service Suggestion Service imports
this component from the URL specified.
14) JavaScript Component
The Digital Service Eligibility JavaScript Component is imported.
15) Invoke JavaScript Function
var isUserEligibleForService = isUserEligible(userCoreProfile);
The Service Suggestion Service JavaScript Component executes the isUserEligible function,
defined within the Digital Service Eligibility JavaScript Component. The core profile is passed
in as a parameter. The core profile is a collection of health and demographic attributes. The
core profile does not contain the entire history of the user, but the head version of a number
of key attributes (e.g. the latest weight observation, not all weight observations over time).













16) Evaluate rules defined within isUserEligible function
The Digital Service Eligibility JavaScript Component is now executing within the security
context of the Service Suggestion Service JavaScript Component, and by extension the
Client App NHS Account. This means that it has become part of the NHS Account security
boundary and is not executed as part of the Digital Service from which it originates. The
JavaScript function contains one or more eligibility rules. Each rule applies a logical operator
over the code user profile (e.g. AND, OR, and NOT). Once the rules have been evaluated,
the function returns back true or false. This indicates whether the user is eligible to use the
Digital Service (true) or not (false). In this scenario, the function computes that the user is
eligible to use the Digital Service, so true is returned.
17) return true;
(user is eligible for this Digital Service)
The Digital Service Eligibility JavaScript Component returns true (the user is eligible to use
the Digital Service).
18) Render Digital Service suggestion in view
As the user is eligible to use the Digital Service, the Service Suggestion Service JavaScript
Component renders an icon for the Digital Service (and perhaps a title and description), in the
Service Suggestions View.












## 7.4. Eligibility Extension with Digital Services


The following contributors are involved in the Digital Service Eligibility Extension process:


Digital Service
Software created by a third-party Service Provider that is registered with the NHS Account Authorisation
Service and configured to be granted access to a “service suggestion” scope (of access) using the OAuth
2.0. client credential grant (offline access). In this context, the Digital Service may not be the same piece
of software that NHS Identified User’s use. It may be a separate component which is used by Digital
Service administrators.


Authorisation Service
The Authorization Service is responsible for responding to authorisation requests, evaluating the access
control policy and issuing access tokens (where applicable). The authorisation service exists within the
bounded context of the NHS Account.


NHS Account Service Suggestion Service
A service that provides a suggestion API (web service). The suggestion API allows authorised clients
(Digital Services) to suggest their service to individual NHS Identified Users.













Process Steps

1. Suggestion Trigger
    The Digital Service implements its own mechanism to trigger when it should suggest itself.
    For example, this could be triggered by an administrator completing a web form.
2. Authorisation Request
    The Digital Service uses the OAuth2 client credentials grant flow to request an access token
    from the NHS Account Authorization Service. Client credentials are passed as part of the
    request (the nature of these client credentials is outside the scope of this specification).
3. Client Authentication & Access Control Policy Evaluation
    The NHS Account Authorization Service authenticates the client and evaluates the access
    control policy to check that the client is allowed to access to the requested scope of access
    (e.g. “service-suggestion” scope). It is assumed that Digital Services will only be able to
    suggest themselves (not other Digital Services).
4. Authorisation Response
    An access token is issued and returned to the client.
5. Suggestion Request
    The Digital Service uses the Service Suggestion Service Suggestion API to make a













suggestion request. The suggestion request instructs the service suggestion service to
suggest the Digital Service to one NHS Identified User. The access token obtained in step 4
is passed as part of the HTTP request header.

6. Validate Access Token
    The Service Suggestion Service validates the access token and the permission to execute
    the request being made.
7. Store Suggestion
    The Digital Service suggestion for one NHS Identified User is stored for future use. NOTE:
    further validation may be required at this stage – for example, validating the NHS Number of
    the NHS Identified User.
8. Suggestion Response
    A HTTP 201 response is sent back to the Digital Service to signify that the service suggestion
    has been created.












## 7.5. Record Interactions with Care Services


The following contributors are involved in the Record Interactions with Care Services process:


Health Profile Service
A micro-service that manages the health bounded context, within NHS Account user profile.


APIM Authorization Service
An Authorisation Service that is responsible for authorising access to a number of NHS protected
resources (where the same access control policy applies).


Record Registry Repository
A service that enables authorised clients to locate patient records that are held on different NHS health
care systems.


Electronic Patient Record (EPR)
An electronic record of periodic health care of a single individual, provided mainly by one institution
(healthcare provider) in one computer system.













Trigger
An NHS Identified User interacts with the Digital Service in such a way as to trigger the Digital Service
needing to read the NHS Identified User’s Health User Profile.
Preconditions

1. An NHS Account User Profile authorised client (Digital Service) has an NHS Identified User using
    their service in real time.
2. The Digital Service has authenticated the user via federation with NHS Login.
3. The Digital Service completes an authorisation protocol and becomes the bearer of an access
    token. As bearer it is granted access to the NHS Identified User’s use profile for a limited amount
    of time and for a limited scope (in this case, the health scope).
Process Steps
1. Get (user profile)
The Digital Service sends a HTTP GET request to the Health Profile API. The access token is
passed in the HTTP header.
2. Validate access token against request scope













The health profile service checks that it trusts the token and that the request is covered within
the context of what is granted (i.e. that the request is authorised).

3. Retrieve stored profile for scoped NHS Identified User
    The health profile service retrieves health data items stored in the NHS Identified User’s user
    profile.
4. Authorisation request (client credential grant) "application"
    The health profile service must supplement health data items that are stored in the user
    profile, with external health interaction data items. In order to retrieve these external health
    interaction data items, the health profile service must first request authorisation to access the
    Record Registry Repository. It does this by sending an authorization request to the APIM
    Authorization Service, which is assumed to be in the same bounded context as the Record
    Registry Repository (the Record Registry Repository, the APIM Authorization Service and
    their relationship is outside the scope of this design).
5. Authenticate client & evaluate access control policy
    The Authorization Service authenticates the client’s credentials and evaluates the access
    control policy to ensure that the authenticated client is allowed to access this scope of
    access.
6. Authorisation response (access token)
    The Authorization Service send an authorisation response back to the Health Profile Service,
    which includes an access token, granting the bearer access to the requested scope for a
    limited amount of time.
7. Lookup patient pointers + access token
    The health profile service sends a request to the Record Registry Repository to query for
    pointers registered for the logged in NHS Identified User.
8. Check authorisation
    The Record Registry Repository checks that the request is authorised, based on the access
    token passed in the HTTP request header.
9. 1x patient pointer returned
    The Record Registry Repository finds 1x pointer for the NHS Identified User, so this pointer is
    returned to the Health Profile Service.
10. Check cache
    The Health Profile Service checks it’s cache to see if it holds a cached version of the record,
    referenced by the pointer. The cached version must not be stale. No cached record is found.
    This is subject to a caching policy, which is outside the scope of this document.
11. Request record













The Health Profile Service requests a copy of the data, based on the reference URL held in
the pointer. This URL refers to the EPRs web service interface. The authorisation details are
out of the scope of this document.

12. Record response
    The EPR authorises the request and returns the data.
13. Cache record
    The Health Profile Service caches the data returned by the EPR, subject to the caching
    policy.
14. Coalesce user profile and pointer record(s)
    The Health Profile Service coalesces the user profile data (step 3) with the “interaction” data
    (step 12).
15. Profile response (aggregated)
    An aggregated user profile response is returned to the Digital Service. It is an aggregate of
    the stored health profile data and the “interaction” data held across any number of NHS
    systems.












## 8. Logical View

## 8.1. Service Suggestion


The logical view is concerned with the functional requirements – what the system will do. UML state
machine diagram will be used to articulate behavioural aspects of the system.


The above state machine diagram articulates the various states that a Digital Service may take, within the
context of an individual NHS Account (one user). The arrows provide details of the triggers and transitions
between states.












## 9. Appendix

## 9.1. Eligibility Use Case Email Exchange


From: Rob Walker
Sent: 10 February 2022 17:12
To: emily.beach <emily.beach@nhsx.nhs.uk>
Cc: abdel.elsheikh <abdel.elsheikh@nhsx.nhs.uk>; karen.miles <karen.miles@nhsx.nhs.uk>; Mike
Smith (mike.smith@nhsx.nhs.uk) <mike.smith@nhsx.nhs.uk>; Thomas Mallon
<thomas.mallon@nhsx.nhs.uk>; James Butcher <james.butcher@nhsx.nhs.uk>;
steven.dodd@nhsx.nhs.uk; andy.payne@nhsx.nhs.uk; Corinna Dymond
<corinna.dymond@sitekit.co.uk>
Subject: Eligibility use cases
Dear Emily,
We have been through the eligibility use cases this afternoon with Abdel and Tom. The below is our
joint understanding of the current problems and limitations with eligibility. We have stated in each case
what the proposed solutions are.
Please can you review and let us know whether you share the same understanding of the problems. I
hope that it will help to allay any fears that you might have, that we have considered these cases and
they are accounted for in the NHS Account design work.
Problem 1
People that don't have an ODS code can't get into NHS App today.
Solution: allow people into the NHS App without an ODS code (NHS App team job). The existing
service journey rules are being replaced by the service suggestion service, which will not require a GP
registration / ODS code (NHS Account work - included in existing design). Each Digital Service will
need to specify their own eligibility criteria, based on the user profile information available.
Problem 2
There are Digital Service categories - e.g., video conferencing, care planning, appointment booking. A
patient can current only see one category of service. This is not a technical constraint. Digital services
have not been onboarded that offer the same category of Digital Service to the same patient. In the
future patient's should be able to select from a choice of multiple service which are in the same
category (e.g., choose 1 of 2 care planning Digital Services).
Solution: allow onboarding of Digital Services in the same category (NHS App team job) and display
them through the proposed service suggestion service (NHS Account work - included in existing
design).
Problem 3
Patients must be P5 minimum to get into the NHS App. In the future we want to let patients’ login at P0.
Solution: allow patients into the NHS App at P0 (NHS App team job).
Problem 4
You have to login to the NHS App before you can use anything. In the future you should be able to
access some features in some Digital Services before you login. In this case, you will have an
anonymous experience. By logging in and asserting your profile, you improve your experience.
Solution: allow patients to access some services in the NHS App without logging in (NHS App team job
+ on a per Digital Service basis).
Problem 5
I may want to access a smoking cessation service. However, I don't want to have to say that I smoke in
my user profile, in order for this to be suggested to me.













Solution: The service suggestion service will allow users to see all the available services in a list, in
addition to the filtered suggestions (based on their profile) (NHS Account work - included in existing
design))
Problem 6
Patients are treated all over the country in specialist clinical services. These may not be close to where
you live. Each of these clinical service may want to give you access to a Digital Service as part of your
care package (regardless of where you live). This is not supported today.
In future, there may be exceptions to geographic eligibility. For example, self-referred, or clinically
referred.
Solution: NHS Account work - subject to further design.
Best regards,
Rob.


From: Steven Dodd <steven.dodd@nhsx.nhs.uk>
Sent: 11 February 2022 09:37
To: Rob Walker <rob.walker@sitekit.co.uk>
Cc: emily.beach <emily.beach@nhsx.nhs.uk>; abdel.elsheikh <abdel.elsheikh@nhsx.nhs.uk>;
karen.miles <karen.miles@nhsx.nhs.uk>; Mike Smith (mike.smith@nhsx.nhs.uk)
<mike.smith@nhsx.nhs.uk>; Thomas Mallon <thomas.mallon@nhsx.nhs.uk>; James Butcher
<james.butcher@nhsx.nhs.uk>; andy.payne@nhsx.nhs.uk; Corinna Dymond
<corinna.dymond@sitekit.co.uk>
Subject: Re: Eligibility use cases
Hi Rob
I've commented below
On Thu, 10 Feb 2022 at 17:12, Rob Walker <rob.walker@sitekit.co.uk> wrote:
Dear Emily,


We have been through the eligibility use cases this afternoon with Abdel and Tom. The below is our
joint understanding of the current problems and limitations with eligibility. We have stated in each case
what the proposed solutions are.
Please can you review and let us know whether you share the same understanding of the problems. I
hope that it will help to allay any fears that you might have, that we have considered these cases and
they are accounted for in the NHS Account design work.


Problem 1
People that don't have an ODS code can't get into NHS App today.


Solution: allow people into the NHS App without an ODS code (NHS App team job). The existing
service journey rules are being replaced by the service suggestion service, which will not require a GP
registration / ODS code (NHS Account work - included in existing design). Each Digital Service will
need to specify their own eligibility criteria, based on the user profile information available.


The issue here is not that each service needs to specify its eligibility criteria, it's that the high level rule
to require a GP practice registration needs to be removed from the top level design. We don't need the
service suggestion service to sort that













Problem 2


There are Digital Service categories - e.g., video conferencing, care planning, appointment booking. A
patient can current only see one category of service. This is not a technical constraint. Digital services
have not been onboarded that offer the same category of Digital Service to the same patient. In the
future patient's should be able to select from a choice of multiple service which are in the same
category (e.g., choose 1 of 2 care planning Digital Services).
Solution: allow onboarding of Digital Services in the same category (NHS App team job) and display
them through the proposed service suggestion service (NHS Account work - included in existing
design).


This statement is a bit confused, there are multiple services that have been onboarded in the same
category, i.e. Online Consultation products. In some circumstances, the patients will only have one, in
others the App needs to be able to cope with multiple instances. e.g. PHRs and (problem 6) needs to
know which services the patient should have


Problem 3
Patients must be P5 minimum to get into the NHS App. In the future we want to let patients’ login at P0.


Solution: allow patients into the NHS App at P0 (NHS App team job).


agreed, but a lower priority than problem 4 as it doesn't offer any value to patients


Problem 4
You have to login to the NHS App before you can use anything. In the future you should be able to
access some features in some Digital Services before you login. In this case, you will have an
anonymous experience. By logging in and asserting your profile, you improve your experience.


Solution: allow patients to access some services in the NHS App without logging in (NHS App team job
+ on a per Digital Service basis).


agreed


Problem 5
I may want to access a smoking cessation service. However, I don't want to have to say that I smoke in
my user profile, in order for this to be suggested to me.
Solution: The service suggestion service will allow users to see all the available services in a list, in
addition to the filtered suggestions (based on their profile) (NHS Account work - included in existing
design))













agreed but not priority yet


Problem 6
Patients are treated all over the country in specialist clinical services. These may not be close to where
you live. Each of these clinical service may want to give you access to a Digital Service as part of your
care package (regardless of where you live). This is not supported today.


In future, there may be exceptions to geographic eligibility. For example, self-referred, or clinically
referred.


There are also areas where geographic eligibility do apply, such as self referral to IAPTS that need to
be surfaced
This is a priority to resolve as it is impacting patients experience of the NHS App.


Solution: NHS Account work - subject to further design.
Best regards,


Rob.
From: Abdel Elsheikh <abdel.elsheikh@nhsx.nhs.uk>
Sent: 11 February 2022 12:06
To: Steven Dodd <steven.dodd@nhsx.nhs.uk>; Rob Walker <rob.walker@sitekit.co.uk>
Cc: Thomas Mallon <thomas.mallon@nhsx.nhs.uk>; karen.miles <karen.miles@nhsx.nhs.uk>; Mike
Smith <mike.smith@nhsx.nhs.uk>
Subject: Re: Eligibility use cases
Hi Both,
Thanks for this; very useful. As it's suggested that the solution to the "Access without GP ODS code"
needs to be delivered by the NHS App team, I think we need to surface this requirement and discuss.
We can use next Tuesday's Account/W&P tech catch up for this.

### Regards,

### Abdel Elsheikh | Senior Architect | NHSX

### abdel.elsheikh@nhsx.nhs.uk


