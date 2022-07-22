---
title: NHS Account Discovery Report
layout: page
parent: NHS Account
nav_order: 1
author: Sitekit
last_modified_date: Jul 22 2022 at 07:51 AM
tags: 
    - report 
    - external 
    - proxy
description: A discovery into the possibilities for NHS Account Proxy, authored by Sitekit, April 2022. Focussing on the identification of relationships between people and how Verifiable Credentials could be utilised.
todo:
    - verify docx export to markdown
    - images to extract and add
    - additional tables are missing
    - All claims made in the report are yet to be independently verified

---


<details open markdown="block">
  <summary>
    Table of contents
  </summary>
  {: .text-delta }
1. TOC
{:toc}
</details>

# Executive Summary
## Introduction

The NHS does not currently have a digital proxy service that can meet the needs of the different users of NHS clinical records systems, broadly these are:

1. An **INDIVIDUAL** with legally, personally or professionally delegated proxy access cannot currently: 
   1. view or use, all or part of a subject's digital NHS Account, and/or NHS Account connected digital services to assist in managing digital care records, and/or their wider care.
   2. digitally demonstrate their proxy relationship in a physical care setting so that they can make decisions with the service and receive information on behalf of the subject. 

2. A **DESIGNATED HEALTH OR SOCIAL CARE PROFESSIONAL** cannot currently access all or part of someone’s digital NHS Account when or how it is deemed in their best interests by their organisation.
3. An approved<sup>#</sup> representative of an **AUTHORISED<sup>##</sup> HEALTH AND SOCIAL CARE INSTITUTION**cannot currently digitally issue and revoke proxy access to a person’s records within or across care settings where it is deemed through formal routes to be in the best interests of the patient.

**An approved representative is a person within an organisation who has been granted administration rights over issuing proxy access e.g. a Care Home manager.**

**An authorised institution is one that has been granted the rights to issue proxy access through the NHS Proxy Service.**

A significant aspect of the NHS Account development work is to develop a consistent, function-rich digital NHS Proxy Access service which enables users to access all their health and care services using the devices and channels of their choice, giving appropriately tiered access to the individuals they trust or for whom they have a responsibility.

This report sets out how a digital NHS Proxy Access Service can be set up, identifying what issues and risks remain to be resolved.

## Background

A limited digital proxy access service is provided through some local systems (such as Patients Know Best), eRedbook (DPCHR) and nationally through the NHS App (through ‘linked’ accounts). These are focused on record sharing (where one person shares with another), a clinician making a connection, or for eRedbook, the use of a birth notification message which may quickly become out of date.

There is no formal digital way of establishing whether a person has a legal right to act as a proxy which can be used by digital services to establish and maintain relationships. 

In General Practice, access is managed manually with GPs choosing to give trusted individuals access to their primary care medical records and perform a limited range of functions on their behalf, such as managing appointments and ordering repeat prescriptions.

Despite an existing policy being in place for sharing of GP records, the method of validating and assigning proxy access varies and has not been standardised. Patients either don’t know that they can request proxy access, or see the process as too hard. As a result it is believed that there is considerable sharing of usernames and passwords between individuals to bypass the perceived bureaucracy of gaining proxy access.

A straightforward ‘frictionless’ method of assigning such access is needed.



## Vision for digital NHS Proxy Access Service

The vision is to create a standard approach to allow people to act on behalf of patients and the people and dependents they care for and to allow users of NHS digital services to share their records with those they trust to act on their behalf. The principles underpinning the service are:



* Access will be simple to use and consistent across all digital health and care settings.
* Patients will be able to digitally nominate trusted individuals (proxies) to act on their behalf to manage their care.
* People with proxy access rights will be able to access health and care services and be able to manage parts of the user’s patient’s clinical record based on their legal status in relation to the user and granular controls that define their level of proxy access.
* Access by personally nominated trusted individuals will be owned and digitally controlled by the user so that they can empower their proxy to help them monitor and manage their own health and care needs in a way that best works for them.
## What we were asked to deliver 

The objective of the work is to deliver a detailed scope for a digital NHS Proxy Access Service, aligned to the NHS Account Future Design version 2.0 Alpha work, so that the NHSX programme team can proceed to procurement for an Alpha phase of an NHS Proxy Access Service.

Specifically, the work covers: 



* A thematic analysis of the research conducted to date
* Analysis of accreditation data sources, including how they can be used and the difficulties to be overcome (such as General Register Office, Ministry of Justice)
* Mapping of the existing systems
* A requirements catalogue
* A set of business rules
* An outline architecture design, such that alpha prototyping can immediately follow this work
* Detailed scope of work for the alpha phase

The report and its appendices build on the discovery work conducted to date through NHSX and NHS Digital, which included user research and desk research (see Appendix A) and initial architecture design work (see Appendix B) ad covers the following types of proxy relationship:



* Parent to child 
* Adult to adult 
* Adult to adult without mental capacity 
* Personally delegated authority 
* Legally delegated authority (e.g. Lasting Power of Attorney) 
## What we found

The next steps to developing a proxy service for the NHS are Policy and IG related rather than purely technical. It is not possible to develop a technical solution in isolation without these foundations. Conversely, it will not be possible to deliver comprehensive Policy and IG infrastructure without information about the proposed architecture.

The next steps should therefore be to develop effective Policy and IG infrastructure with technical involvement throughout.



## What we recommend

We recommend that financial year 2022/23 is spent developing and delivering the foundations for the Proxy Service, namely:



* Engagement and agreement with credible data sources (e.g. GRO) that they are willing to work with the NHS to deliver a proxy service.
* Development and internal approval of Proxy Policy
* IG Framework and Agreements with credible data sources
* Trust Framework
* Liability Framework
* Outline Architecture based on an extension of the work done during this project and inputs from discussions with credible data sources

Note that there is currently a team in NHS Digital working on CP-IS IG agreements which will conclude summer 2022. There is a small window of opportunity for this to include the agreements that would be needed for the proxy service.



# NHS Proxy Design: About this Project
The Proxy Design project was commissioned to understand the next steps required for delivering an NHS Proxy Service taking the NHS Account project into consideration. 



## Deliverables

This work builds on the discovery work conducted to date through NHSX and NHS Digital, which includes previously conducted user and desk research and initial architecture design work. It aligns to the NHS Account Future Design version 2.0 Alpha work currently also being conducted by Sitekit.

This report, with accompanying appendices and presentation cover:



* A thematic analysis of the research conducted to date
* Analysis of credible data sources, including how they can be used and the difficulties to be overcome
* Mapping of the existing systems
* A requirements catalogue
* A set of business rules
* An outline architecture design
* Detailed scope of work for the alpha phase

Note that the following were out of scope for this work:



* Testing and prototyping of the design
* Bespoke new user research
### Scope 

The potential proxy types and relationships listed below were in scope: 


**Personally delegated Proxy**



* Adult with capacity issues proxy to adult with capacity
* Gillick Competent young person issues proxy to adult

**Legally delegated proxy**

* Parent as proxy for Child 
* Lasting Power of Attorney

**Professionally delegated proxy**

* Adult proxy for adult without mental capacity (Where a clinician or other professional issues the access as a result of a best interests decision)

The relationships listed below were out of scope:



* Residential care 
* In-home care/ambulatory care/assisted living 



# Background in Detail
A number of previous discoveries have been done into proxy access. A full summary of this body of work can be found in the document “Proxy access work stocktake November 2021” available from the NHS Account team in NHS England. General findings and those from the two main pieces of work are included below as they form the starting point for this piece of work.



## Previous General Findings 

A manual Proxy Access service is currently available through GP practices for patients to give trusted individuals access to their primary care medical records and perform a limited range of functions such as managing appointments and ordering repeat prescriptions on their behalf. As with a number of services available across our digital channels, despite policy being in place, this service varies between General Practices in terms of the functionality allowed, the interpretation of policy/GDPR/case law and, in some cases, is not offered at all. 

 A limited digital service is provided through some local services (such as Patients Know Best) and nationally through the NHS App (through ‘linked’ accounts). 

 A significant aspect of the NHS Account development work is to develop a consistent, function-rich digital Proxy Access service which enables users to access all their health and care services using the devices and channels of their choice, giving appropriately tiered access to the individuals they trust. 

A number of service types have been identified including; Adult to Adult with capacity, Adult to Adult with reduced capacity, Parent to Child, Young Carer, Professional bodies (including care homes). These can also be classified within a) those with legally delegated authority and b) those which are personally delegated and c) those with clinical or institutionally delegated authority. 

This work will align to the NHS Account Future Design version 2.0 Alpha work currently being conducted by Sitekit and will need to be developed in conjunction with that work. 



## NHS Digital Discovery (March 2020)

Issues specifically identified in the March 2020 discovery:



* Inconsistencies in the process of establishing and managing a proxy relationship, and a lack of clarity around what a valid relationship is, which lowers trust in established proxy relationships.
* Relationships between users are not shared across care settings and services. This leads to a duplication of effort and a disjointed user experience.
* The business model of the NHS allows NHS services and trusts to set business policy and processes at a local level. These policies and processes are often inconsistently followed by staff and don’t necessarily align to national guidance set by NHS England, or guidelines set out by associated clinical and regulatory bodies, such as the Royal College of General Practitioners (RCGP). This results in disjointed local solutions that are difficult to manage and administer centrally. 
* Relationships established within local care setting are not often trusted outside of their local organisation. 
* Identity verification is area that inconsistencies exist and are noted to be those that are also evident in the process of establishing a proxy relationship. 
* There are numerous opportunities for information about a relationship, between a patient and their proxy, to be captured at the start of a patient’s life, which are currently not utilised. This leads to a duplication of effort by staff processing the same information more than once, or simply results in a series of missed opportunities to set up a trusted relationship.
* Adults and children with long term or chronic healthcare needs are more likely to need assistance from a proxy across multiple healthcare settings.
* An adult can be proxy for more than one person. A patient may have more than one proxy.
    11. HIPPO digital NHS Proxy Access Discovery Report (March 2021)

The HIPPO digital NHS Proxy Access Discovery was an 8 week exercise took place in February 2021. Its aim was to evaluate the current drivers for centralised digital facilities that would support access to a patient’s health records and services by a third party (proxy).

Their findings were as follows:



* Proxy solutions have existed for some time in the NHS (both the technology and process) and are being used mostly for relatively simple cases within GP practices such as mothers / fathers with children, or Power of Attorney.
* A lack of awareness about proxy access and its value was observed, as was inconsistent adoption of processes and technology between practices - often based on the philosophical approaches of the practice.
* The need for proxy access is typically driven by a need for digitised Health Services - often due to more complex relationships or health settings.
* There is a balance to be met; proxy authentication is currently based mainly on GP decisions and point in time documents, where patient safeguarding needs to take into account situation fluctuations over time - such as life events and domestic changes.
* The true value for proxy access will be found when health care content and its access consider patient care as a whole across all settings - NHS, Social Care, Courts, etc. 
* **Improved experience will be achieved when access is less reliant on a single point of decision such as GPs.**



# The Vision in Detail
The vision is to create a standard approach to allow people to act on behalf of patients and the people and dependents they care for and to allow users of NHS digital services to share their records with those they trust to act on their behalf. The principles underpinning the service are:



* Access will be simple to use and consistent across all digital health and care settings.
* Patients will be able to digitally nominate trusted individuals (proxies) to act on their behalf to manage their care.
* People with proxy access rights will be able to access health and care services and be able to manage parts of the user’s patient’s clinical record based on their legal status in relation to the user and granular controls that define their level of proxy access.
* Access by nominated trusted individuals will be owned and digitally controlled by the user so that they can empower their proxy to help them monitor and manage their own health and care needs in a way that best works for them.
## Users

The NHS Proxy service will provide users with a way to consistently and securely give trusted individuals the right to access digital NHS services on their behalf, referred to in this report as personally delegating proxy access.

Users will be able to specify what a proxy can do on their behalf at a granular level within, and managed by a 3<sup>rd</sup> party application.

## Proxies

The NHS Proxy Service will provide people who have a legal right to access another person’s health records an easy way to authenticate their proxy relationship digitally. They will then be able to use this authentication to gain access to records both within the NHS App/NHS Account and within other NHS commissioned and approved digital services, and carry out transactions such as order repeat prescriptions and book appointments on behalf of the patient. This is referred to in this report as legally delegated proxy access.	

## Clinical and Care Services

The NHS Proxy Service will provide clinical and care services with proxy data they can rely on based on legal data sources, reducing the burden of proxy verification for front line services.

## 3<sup>rd</sup> party digital services

The NHS Proxy Service will provide approved digital services with a source of information about a proxy’s right to access a subject’s health records on their behalf. 

It will be a sister service sitting alongside NHS Login that 3<sup>rd</sup> party suppliers can connect in to and rely upon for accurate proxy data. 



## Technical

The NHS Proxy Service will digitally establish, authenticate and revoke the relationship between a data subject and a proxy at the time of need. All NHS approved digital services will be able to use the service. The Proxy Service will Resource Servers (such as NHS clinical record systems) to delegate the responsibility for authenticating the proxy relationship in a standard way reducing repeated local manual validation of relationships.

The NHS Proxy service will verify assertions made by other national agencies (e.g. MoJ, GRO) to establish the authenticity of the proxy relationship. Rather than the NHS Proxy Service integrating directly with these agencies, the NHS Proxy Service will adopt a decentralised approach preserving privacy and overcoming data protection governance concerns. 



## Vision Principles
* One national Proxy Access Policy approved by appropriate clinical and regulatory bodies.
* One national service to establish proxy relationship that is trusted and used across the NHS.
* High level of integrity around method to establish proxy relationship
* Trusted by Primary care, secondary care and digital suppliers as an accurate source of information
* Clearly specified legal framework that apportions risk and provides appropriate coverage
5. Glossary

Sitekit compiled a glossary to assist with the process of standardising terms for the NHS Proxy Access Service. These terms are used throughout the report.

We recognise the findings of previous investigations that parents may not understand the term “Proxy” in relationship to their access to child records. However for the purposes of standardising internal language for this project the term proxy is used throughout. It will be valid to carry out research to understand what language works best for each of the user groups. 


<table>
  <tr>
   <td>Term
   </td>
   <td>Detail
   </td>
  </tr>
  <tr>
   <td>NHS Proxy Access Service
   </td>
   <td>The NHS Proxy Access Services defines and implements proxy arrangements for access to healthcare records - TBC based on outcome of Alpha
   </td>
  </tr>
  <tr>
   <td>Subject
   </td>
   <td>The Subject is the person about whom the Health Record pertains. The subject may be giving proxy access (personally delegated access), or the person about whom legally delegated or professionally delegated proxy relates.
   </td>
  </tr>
  <tr>
   <td>(the) Proxy
   </td>
   <td>The Proxy is the person (who may be a member of an organisation) who is accessing the subject’s record using access rights. The access rights may have either been personally delegated to them by the subject, have been legally delegated to them, or professionally delegated to them.
   </td>
  </tr>
  <tr>
   <td>(Adult) Nominated
   </td>
   <td>A person who is named in advance (appointed) as someone the subject trusts to manage their personal welfare on their behalf (an attorney) in a Lasting Power of Attorney document for the subject in the event that the subject experiences loss of Capacity.
   </td>
  </tr>
  <tr>
   <td>Jurisdiction
   </td>
   <td>The governance process of the Jurisdiction provides the 'legal basis' for the Proxy Types that it defines. This 'Legal Basis' consists of policies, laws and regulations. NHS England may be the Jurisdiction for the Proxy Access Service - TBC in Alpha Phase
   </td>
  </tr>
  <tr>
   <td>Proxy Arrangement/ Relationship
   </td>
   <td>The outcome of actions undertaken to establish the proxy relationship between two people. 
   </td>
  </tr>
  <tr>
   <td>Proxy Type
   </td>
   <td>The name used to describe a set of characteristics and restrictions that are associated with a specific type of Proxy Arrangement e.g. Parent or Guardian with PR vs Adult
   </td>
  </tr>
  <tr>
   <td>Basis Type
   </td>
   <td>The name used to describe the set or class of duties/rights that the proxy arrangement will be made on the basis of e.g Parental Responsibility Claim, Lack of Capacity
   </td>
  </tr>
  <tr>
   <td>Proxy Role
   </td>
   <td>The role the stakeholder will play in the Proxy Arrangement e.g. Subject, Nominee, Second Degree Nominee, GRO 
   </td>
  </tr>
  <tr>
   <td>Delegation (of proxy)
   </td>
   <td>The action of authorising a person to act on someone elses behalf.
   </td>
  </tr>
  <tr>
   <td>Personal Delegation
   </td>
   <td>Where the subject delegates another person to act on their behalf.
   </td>
  </tr>
  <tr>
   <td>Legal Delegation
   </td>
   <td>Where a person (proxy) has the authority to act on behalf of someone else (subject) conferred to them as the result of the proxy's legal status i.e. as a parent, guardian etc.
   </td>
  </tr>
  <tr>
   <td>Professional Delegation
   </td>
   <td>Where a person (proxy) is delegated the authority to act on behalf of someone else (subject) by a professional working in a healthcare or Local Authority capacity.
   </td>
  </tr>
  <tr>
   <td>Parental Responsibility (PR)
   </td>
   <td>The rights, duties, powers, responsibilities and authority parents have for their child.
   </td>
  </tr>
  <tr>
   <td>Capacity
   </td>
   <td>Capacity means the ability to use and understand information to make a decision.
   </td>
  </tr>
  <tr>
   <td>Lack of Capacity
   </td>
   <td>A person lacks capacity if their mind is impaired or disturbed in some way, which means they're unable to make a decision at that time.
   </td>
  </tr>
  <tr>
   <td>Capacity Assessment
   </td>
   <td>A clinical assessment of whether a subject has capacity. The capacity assessment may follow formal assessment procedures and be reported to the Local Authority, or may reside in the clinical system only.
   </td>
  </tr>
  <tr>
   <td>Onward Granting
   </td>
   <td>Onward Granting is the granting of proxy access to the subject’s record by the proxy to a second proxy known as a second degree proxy.
   </td>
  </tr>
  <tr>
   <td>Second Degree Proxy
   </td>
   <td>A second degree proxy is a person who is accessing the subject’s record using access rights that have been personally delegated to them by a Proxy. 
   </td>
  </tr>
  <tr>
   <td>Proxy Arrangement Duration
   </td>
   <td>The length of time for which a proxy arrangement is set to run. 
   </td>
  </tr>
  <tr>
   <td>Proxy Arrangement Termination Event
   </td>
   <td>An event that terminates a proxy access arrangement e.g. Death of Proxy, Child being deemed Gillick Competent.
   </td>
  </tr>
</table>


# Thematic Analysis of Previous Research

Sitekit carried out an analysis of the research previously done on proxy access, combining this with our own domain knowledge gained by working on the DPCHR Child Health Programme, and on the NHS Account programme. 

We analysed information looking for common topics, drawing them together and reaching a consensus for this report. 

This analysis was then augmented with information gathered from discussions with key stakeholders from NHS Digital (programmes relevant to Proxy Access), Health and Social Care, GPs, and individuals who have worked on previous projects where proxy access was needed.

The aim of this analysis was to understand:



* Who needs a proxy access service
* What end users want to be able to do with it
* What the health and social care sectors need from it (including clinical, care and local authority staff)
## What are the scenarios when someone might want/need a Proxy Access Service?

Sitekit created a full list of all of the use cases that we encountered during the project taking inputs from the draft policy, discussions with key stakeholders, review of previous research etc. The list is extensive and covers a wide range of family and personal circumstances for the subject, and a wide range of ways in which a proxy may provide support to them. Note that the list of detailed use cases considers the following, and more:



* Birth parents
* Same sex parents
* Adoption
* Fostering
* Unmarried parents
* Adults with changing capacity assessments
* Adults with Lasting Power of Attorney for another person
* Teenagers access
* Clinician delegated proxy access

This list captures the edge cases as well as the mainstream cases and provides a basis to evaluate architecture designs and define required data sources. 

_<span style="text-decoration:underline;">These can be found on the Detailed Use Case tab in Appendix 1: NHS Proxy Requirements and Business Rules Catalogue (excel)</span>_

The needs of proxy service users can be grouped into the following:


    


![alt_text](images/image1.png "image_tooltip")




## Users: subject and proxy types

The end users of the proxy service are either subjects (the person about whom the Health Record pertains) or proxies (the person, who may be a member of an organisation, who is accessing the subject’s record using delegated access rights).



### How many different types of subject are there?

Creating a detailed list of use cases enabled us to identify four types of subject shown in the table below. A subject is always one of these four types and cannot hold more than one subject type at a time. Identifying these four subject types enables the application of business rules. Note also that the age at which a child has capacity will be concluded by the outcome of the Policy Development work within the Alpha. Where this age is referenced in the definitions it is marked by (*).

_<span style="text-decoration:underline;">Full information on Proxy Types can be found on the Subject and Proxy Types tab in Appendix 1: NHS Proxy Requirements and Business Rules Catalogue (excel)</span>_


<table>
  <tr>
   <td>Subject Type
   </td>
   <td>Subject Description
   </td>
  </tr>
  <tr>
   <td>Child
   </td>
   <td>Child Under 13* - Assumed not to have capacity
   </td>
  </tr>
  <tr>
   <td>Young Person
   </td>
   <td>Person aged between 13* and 16, may or may not have capacity
   </td>
  </tr>
  <tr>
   <td>Adult
   </td>
   <td>A person over the age of 16.
   </td>
  </tr>
  <tr>
   <td>LPA Subject
   </td>
   <td>A person over the age of 13* who is the subject in a legal LPA (initiated)
   </td>
  </tr>
</table>




## How many different types of proxy access are there?

The detailed list of use cases enabled us to identify seven key types of proxy access as shown in the table below. These proxy types are discrete and should be used within the proxy access credentials issued to enable 3<sup>rd</sup> party digital services to manage access rights to each of these groups. 

_<span style="text-decoration:underline;">Full information on Proxy Types can be found on the Subject and Proxy Types tab in Appendix 1: NHS Proxy Requirements and Business Rules Catalogue (excel)</span>_


<table>
  <tr>
   <td>Proxy Type
   </td>
   <td>Description of Proxy Type
   </td>
  </tr>
  <tr>
   <td>Birth Mother
   </td>
   <td>This proxy type can only be issued to the mother who gave birth to the baby. It can be used in lieu of Parent / Guardian (PR) up to 42 days after the baby is born AND prior to the issue of the birth certificate (both conditions must be met). The proxy type can be used to enable services to provide early access to limited data sets. 
   </td>
  </tr>
  <tr>
   <td>Parent / Guardian (PR)
   </td>
   <td>This proxy type can only be issued to a parent named on the birth certificate. It can be used to enable services specific to parents and to define authorisation granularity within 3rd party applications.
   </td>
  </tr>
  <tr>
   <td>Adult
   </td>
   <td>Issued to an adult (16+) by the subject, holders of this proxy type can carry out actions on behalf of the subject where authorised by the subject.
   </td>
  </tr>
  <tr>
   <td>Child Carer
   </td>
   <td>Proxy type issued where Clinician identifies child aged 13*-15 acting as carer for a child Under 13* and identifies child proxy as in subject's best interests.
   </td>
  </tr>
  <tr>
   <td>Professional With Access
   </td>
   <td>Used where a clinicial or LA representative is acting on behalf of the subject, either with parental responsibility or for adults without capacity.
   </td>
  </tr>
  <tr>
   <td>Adult Nominated
   </td>
   <td>Issued to a person who has been Nominated in a Lasting Power of Attorney, or via Advanced Choice Nomination. Initiation of the Nomination revokes all previous personal delegations. Proxies with this proxy type may be able to do more on behalf of a subject than a personally delegated proxy can.
   </td>
  </tr>
  <tr>
   <td>Adult Professionally Delegated
   </td>
   <td>Issued by a professional where an adult subject does not have capacity and no Adult Nominated proxy is in place. 
   </td>
  </tr>
</table>






## Grouping of detailed use cases by action

The Detailed Use Cases indicate that there are 6 actions that can be taken by NHS Proxy Service. The diagram below shows the 6 actions, and the events that may trigger each action:



![alt_text](images/image2.png "image_tooltip")


Note that this list can be simplified to the following:



* Issue Proxy Access Credential (Issue, Resume)
* Revoke Proxy Access Credential (Revoke, Pause)
* No Action (Block, No Action)


##  What policies exist for Proxy Access?

A document currently exists which pulls together the currently known work on policy relating to proxy services. This is not a policy document in itself but could act as the basis for one. 

_<span style="text-decoration:underline;">The Proxy Access Policy Framework V.3 Draft is included with this report in Appendix 2.</span>_

Work is required to develop this into a functioning proxy service policy (see below).


## Analysis of Draft Policy

Sitekit compared information gathered from the analysis of previous research and the compiled use case list to the draft policy to create a list of items that could require consideration during the development of a full policy. 

During the next phase the NHS Policy experts will need to work in consultation with key stakeholders and those with relevant law expertise to fully understand what is required to create a complete policy.


# As Is Process Maps
## Existing Birth Registration Process

Birth registration is the process of recording a child’s birth. It is a permanent and official record of a child’s existence and provides legal recognition of that child’s identity. At a minimum, it establishes a legal record of where the child was born and who his or her parents are. Birth registration is required for a child to get a birth certificate – his or her first legal proof of identity.

All births in England, Wales and Northern Ireland must be registered within 42 days of the child being born. This should be done at the local register office for the area where the baby was born or at the hospital before the mother leaves. The hospital notifies the mother if she can register the birth there. If she cannot register the birth in the area where the baby was born, you can go to another register office, and they will send your details to the correct office.


#### Initial Registration of a Birth – Married Parent or Civil-Partner Parents

If the parents of the child were married to each other, or in a legal Civil Partnership, when the baby was born, either parent may register the birth on their own and will include both parents' names in the register. 


#### Registration of a Birth – Unmarried Parent of the Child

If the parents are not married, the father's details can only be entered in the register in the following circumstances:



* The mother and father go to the registration office and sign the birth register together
* Where either the mother or father is unable to go to the registration office - they may make a statutory declaration acknowledging the father's paternity which the other parent must take to the registration office. 
* Where the mother and father have made a parental responsibility agreement or either has obtained an appropriate court order - the agreement or order should be taken to the registration office by either parent.

#### Registration of a Birth – Other People who may Register Births


If the mother or father are not able to register the birth, the registrar will arrange for the registration to be completed by whichever of the following people is best able to do so:



* The occupier of the house or hospital where the child was born
* A person who was present at the birth
* A person who is responsible for the child

#### Information needed to register a birth




![drawing](https://docs.google.com/drawings/d/12345/export/png)


#### Information to be registered for Father and Mother



![drawing](https://docs.google.com/drawings/d/12345/export/png)

 




![alt_text](images/image3.png "image_tooltip")





![alt_text](images/image4.png "image_tooltip")


Reference: [https://www.gov.uk/register-birth](https://www.gov.uk/register-birth)



##  Existing Record Sharing in NHS App
### Linked Profiles 

Proxy access allows parents, family members and carers to access health services on behalf of other people. For example, children, dependents, and relatives. Currently, a user can use linked profiles in the NHS App to act on behalf of another person if they meet all of the following conditions:



* They are both registered at the same GP surgery.
* They are both patients at a GP surgery that uses either TPP (SystmOnline) or EMIS (Patient Access) the GP surgery has registered you for proxy access.
* Depending on the level of access given by the surgery, the user can switch profiles in the NHS App to act on behalf of another person and book an appointment, order a repeat prescription and view their GP health record, where appropriate

Note that children cannot have access directly to the app themselves.


#### GP Surgery Systems and Linked Profiles


The Surgeries in England use different systems to provide GP online services. Currently, switching to a linked profile in the NHS App is available to patients registered with a GP surgery that uses either:



* TPP (SystmOnline)
* EMIS (Patient Access)

#### Adding Children, Relatives and Dependants to Profile


Access is controlled by the GP surgery where the person the user wishes to act on behalf of is registered. The user needs to ask the person's GP surgery to register them for proxy access. They will be guided by the surgery through the registration. The user will need to provide identification to the GP surgery so they can:



* Confirm who they are
* Check if they are the correct person to act on the patient's behalf

When the surgery has verified the identity and registered the person for proxy access, there will be a new option within the NHS App called Linked profiles. A four digit code provided by the person sharing the health record will be needed by the user to have access to the record.


#### Switching to a Linked Profile

After the GP surgery has registered the person for proxy access for one or more people, they can switch to a linked profile in the NHS App. They do not need to log in and out each time. To act on behalf of another person within the NHS App,



* Go to More.
* Select Linked profiles, then choose the person you want to act on behalf of.
* Switch to their profile.
* When switched to another person's profile, a yellow banner at the top will reflect saying Acting on behalf of and the patient's name.

#### Switching Back to User’s Profile


When the user have finished using the services in the NHS App on behalf of another person, they will; select the yellow banner that says Acting on behalf of and select switch to my profile.


#### Removing Access to Profile – A Child

Until a child's 11th birthday, it's usual for the child's parents to control access to the child's medical record and GP online services. However, when the child is aged between 11 and 16, parents may be allowed proxy access to their child's online services after discussion with the GP, where appropriate.

Note that as per NHS Digital Discovery March 2020 research these policies often vary locally and processes may be inconsistently followed by staff. Locally defined processes may not necessarily align to national guidance set by NHS England.

If parents still have access to their child's medical record and online services, access is turned off when the child reaches their 16th birthday. A child between 11 and 16 could contact their GP surgery if they have questions about who can access their medical record or online services. 


#### Reference

[https://www.nhs.uk/nhs-app/nhs-app-help-and-support/linked-profiles-in-the-nhs-app/](https://www.nhs.uk/nhs-app/nhs-app-help-and-support/linked-profiles-in-the-nhs-app/) 




![alt_text](images/image5.png "image_tooltip")




##  Proxy access to records in eRedbook
### eRedbook vouching (establishing proxy access)

To obtain access to a child’s records (and act as their proxy) a parent must be authenticated and authorised. This is established in eRedbook by a process called "vouching”. This can happen in one of two ways:



1. Automatic - the birth parent registers antenatally for an eRedbook account, using NHS Login (P9), and creates a maternal record. Once the baby is born a birth notification message is sent from PDS (patient demographic service), via NEMS (national events management service), to the maternal record and this creates an explicit relationship which in turn allows eRedbook to auto create a child record, which the birth parent can access.
    1. Authentication = NHS Login
    2. Authorisation = Birth notification
2. Manual – the parent or guardian registers for eRedbook and creates a child record, to get this connected they must ask their health professional (midwife or health visitor) to connect the record. The health professional makes a decision as to whether they have sufficient evidence to say whether the parent or guardian is who they say they are and that they are appropriate to access the child record. The health professional then uses eRedbook Pro to assert this information on behalf of the parent or guardian and connects the child record. 
    3. Authentication = Health professional
    4. Authorisation = Health professional


#### Safeguarding

Child records do not receive address change messages to safeguard a situation where a child is taken into care and the new address is shared with the parent.

Records can be disconnected by Sitekit when a health professional informs the support desk that a child has been taken into care / their parent responsibility has changed. This is carried out manually by the software supplier with an internal audit trail. 


![alt_text](images/image6.png "image_tooltip")




## Record sharing in eRedbook
### eRedbook 

eRedbook is a parent-held personal child health record, beginning at birth that supports children through the healthy child programme. It empowers parents to take control of their child's health and enables professionals to interact with parents digitally. 


#### eRedbook Records Sharing 

The eRedbook is connected to the NHS National Event Management System allowing parents nationally to receive their child’s important screening and immunisation records. Parents can share these records within the eRedbook with professionals or can choose to share their child’s record with their partner and other carers, enabling them to work together to keep their child healthy. Record sharing can be in the form of read only or read/write, meaning other carers can contribute to the record with the parent permission. 


#### eRedbook Records Sharing Process 

Parents can share eRedbook records with a family member or a carer following these steps: 



* Login to eRedbook with either their NHS login, facebook account or email address 
* Select the option to share the child’s record 
* Select the share the health record on an ongoing basis e.g., with a family member/carer option 
* Enter details of the person with whom they would like to share access with. 
* Create a four-digit code and share with the person 
* Choose the level of access this person should have to the record 
* Click the send invitation to access option 
* The family member receives an email of invitation to access the child’s record 
* They login to eRedbook if they already have an eRedbook account or register for an eRedbook using the email address to which this invitation was sent if they don't have an eRedbook account. 
* Select the option to add new child profile/I'm pregnant under the profile card or select the option to access an existing health record that has been shared. 
* Enter the four digit code provided by the person sharing the health record and they have access to the child’s record. 

 


#### Reference 

[https://app.eredbook.org.uk/](https://app.eredbook.org.uk/) 

[https://www.eredbook.org.uk/for-professionals/](https://www.eredbook.org.uk/for-professionals/) 

[https://www.nelft.nhs.uk/0-19-eredbook/](https://www.nelft.nhs.uk/0-19-eredbook/) 


![alt_text](images/image7.png "image_tooltip")




## Death Registration Process
### Death Registration 

The registration of the death is the formal record of the death. Registering the death is done by the Registrar of Births, Deaths and Marriages, which is situated at the local register office. 

If someone dies at home, the death should be registered at the register office in the district where they lived. If the death took place in hospital, nursing home or other public building, the death must be registered at the register office for the district in which the hospital or home is situated. In the case where the person registering the death is unsure of where to register a death, there is a need to find a register office closest to where the person died and make an appointment to register the death. The details will be passed on to the correct office. As part of the process, a copy of the death certificate will be given as the certificate will be needed to deal with other steps such as bank accounts, mortgages and wills. 


#### Documents Issued 

The death certificate will be issued at the registration appointment. When the death has been successfully registered, the following certificate will be issued: 



* Certificate of Registration of Death (form BD8) – The person registering the death may need to fill this in and return it if the person was getting a State Pension or benefits (the form will come with a pre-paid envelope to know where to send it back to) 

Additional death certificates can be purchased as it will be needed for sorting out the person’s affairs. 





![alt_text](images/image8.png "image_tooltip")






# Analysis of Credible Data Sources

There is no single data source that can provide a definitive answer on whether a person is eligible to act as another person’s proxy. This is true for parents acting as children’s proxies and adults with a Lasting Power of Attorney for others.



## Data changes with time

The answer to the question “should person A have access to person B’s records as a proxy” needs to be established using data from multiple locations. This data needs to be evaluated based on a set of business rules, and proxy access issued based on the outcome.

This statement is true for all types of Proxy Access, whether they be legally delegated based on the proxy’s legal status as a parent or a carer, personally delegated by the subject themselves, or clinically delegated based on the best interests of the subject as a patient.

The timeline shown below illustrates how circumstances can change as time passes. With each change in circumstance comes a change in the data available to the NHS Proxy Service evaluate who in this example should have proxy access to Albert’s records.



![alt_text](images/image9.png "image_tooltip")


The data shown in the diagram above comes from a number of data sources, some held by the NHS and others not. 

Note also that the eligibility for proxy access needs to be checked frequently as the data held about the parent and the child can change.



## Different data sets needed to establish each of the proxy types

Different sets of information are needed to establish each of the proxy arrangement types. 

For example, for a parent to be given proxy Access to their Child’s records the service needs to do all of the following:



* Prove that they are the parent of the child (GRO) OR Prove that they are the mother of the child prior to GRO registration (PDS)
* Check that the child is under 11 (GRO) Or Is under 16 and not Gillick Competent (Professionally Entered Data Store)
* Check that there is no current CPIS court order for their child (CP-IS) OR prove that they are not named in the court order (Professionally Entered Data Store)
* Check that they as a proxy have not been marked as not having capacity to act as a proxy (Professionally Entered Data Store)

    Depending on the use, they may also need to:

* Prove that the proxy and the subject are both still alive (GRO) 

The chart below illustrates which data sources need to be checked prior to issuing proxy access for each of the proxy types.


![alt_text](images/image10.png "image_tooltip")


This report will now examine each of these potential data sources individually.



## Establishing Parental Responsibility

When understanding how to establish parental responsibility using the NHS Proxy Service it is important to recognise:



* The people who have parental responsibility for a baby / child may change over time. 
* The people named on the child’s birth certificate are the people who have parental responsibility for the child
* If the father is not on the birth certificate they do not have Parental Responsibility.
* A father can be added to a birth certificate at a later date – the birth certificate is updated.
* A new birth certificate is issued when a baby is adopted.

The following diagram shows who has parental responsibility in a range of circumstances including after adoption, children born to same sex couples etc. **In each of these cases the birth certificate held by the GRO is updated to reflect the change in legal status following a court order**:

![alt_text](images/image11.png "image_tooltip")




### GRO LEV api

The General Register Office issues birth certificates (see Existing Birth Registration Process) when a baby’s birth is registered, or updates them when a change occurs (see above).

The GRO has an API which could be used by the NHS Proxy Service as a source of parental responsibility data. This is called the Live Event Verification (LEV) api. It allows digital access to Registrations Online (RON data).

_<span style="text-decoration:underline;">The details of the api output can be found in Appendix 1: NHS Proxy Requirements and Business Rules Catalogue (excel): tab GRO API Output</span>_

The GRO api as it stands today does not contain enough information to act as a standalone source. Specifically it doesn’t contain:



* NHS numbers for either parent or baby
* Date of Birth for mum or dad

Without the NHS number for either parent it is not possible to make a direct link between the individuals named on a birth certificate and the individual requesting proxy access / the subject of the proxy access.

Parental birth dates are also absent meaning that the birth dates can’t be used to help verify that the individual named as a parent on the birth certificate is the individual requesting proxy access.

See below Using PDS and GRO RON Data in combination to establish Parental Responsibility.



### Personal Demographics Service (PDS)

PDS is a potential data source for Parental proxy access, specifically linking the birth mother to the baby/child. This method is in use today in eRedbook (see eRedbook Vouching). 

Problems with PDS as a data source:



* PDS birth linkage is not updated if Parental Responsibility for the child changes. This is therefore not a reliable data source for parental responsibility to be used on an ongoing basis. 
* PDS Birth linkage only applies to the birth mother.


#### Proposal:



* PDS is used to cross check birth registration data
* PDS is used for establishing proxy access for the birth mother (Proxy Type: Birth Mother) in lieu of establishing full Parent / Guardian (PR) Proxy Type up to 42 days after the baby is born AND prior to the issue of the birth certificate (both conditions must be met). The proxy type can be used to enable services to provide early access to limited data sets.
* PDS is used to informally establish death (see GRO RON Death Notification section)
* PDS is not used beyond 42 days after birth for birth mother.

**Note that longer term there may be a requirement for the NHS Proxy Service to write legal proxy information back to PDS. This needs to be evaluated and the potential benefits understood. Note that it may alter IG arrangements so is worth considering sooner rather than later.**



### Using PDS and GRO RON Data in combination to establish Parental Responsibility

As we have seen neither the PDS data set, nor the GRO RON data set are enough on their own to establish parental responsibility at a given point some time after birth. 


#### Proxy Issue: Proxy Type Birth Mother

In all cases[^1], the birth mother is the first person who can have proxy access granted by virtue of both her identity and her relationship to the child being verified in the birth episode and the birth notification being issued which makes the link between her NHS number and the baby’s NHS number. This ‘automatic’ proxy capability, can only be revoked by parental order, adoption or court order (such as in child protection orders).

The birth episode therefore generates the initial data which could prime the NHS Proxy Service and be used to validate the existence of parental responsibility for the birth mother. On that basis the PDS data source as it exists today could be used to authorise the first issue of proxy access to a child’s record of Proxy Type: Birth Mother.


#### Proxy Issue: Proxy Type non-birth parent


##### Step 1: Birth Notification to PDS to General Register Office – creating the initial proxy capability

Mother gives birth and the Maternity unit overseeing the birth registers it via their Maternity system or the Birth Notification Application (BNA) which generates the new NHS number for the baby and sends a notification to both the National Event Management Service (NEMS) and the partner Child Health Information Service (CHIS) which links the mother and baby NHS numbers.

This is usually done within 24 hours of birth and sets up a new PDS record for the child and the General Register Office GRO) also takes a feed of new births from PDS which thus primes their systems with the mother and baby information.

NHS Digital shares the birth notification to ensure that all births known to the NHS are shared with the GRO and are used to match mothers presenting at the register office with the correct existing records. This is done by comparing the mother’s details presented at the registry office against the birth notification within the Registration Online system. 


**<span style="text-decoration:underline;">Note at this point the GRO has the mother’s and baby’s NHS number although it is not included in the GRO RON api.</span>**

Once this birth mother validation is complete, the father’s / second parent’s details are collected and recorded on GRO systems.


**<span style="text-decoration:underline;">Note that the GRO do not ask for the father’s (or other non-birth parent’s) NHS number and it is not known whether the GRO asks for the non-birth parent’s date of birth. </span>**


##### Step 2: Birth Certificate issued by General Register Office – creating the second proxy capability

In this step the parents (usually) attend the register office to register the baby and receive the birth certificate. It is at this point that a second parent is added and named on the birth certificate. Identification is based on presentation of documents, which can be:



* passport
* birth certificate
* deed poll
* driving licence
* proof of address (for example, a utility bill)
* Council Tax bill
* marriage or civil partnership certificate

Additionally, the registrar could ask for the child’s personal child health record (‘red book’). If the birth is being registered by only one parent, proof of paternity may be requested.


**<span style="text-decoration:underline;">Note that there is no currently trace of the second parent NHS number.</span>**

This could be done in a number of ways:


* GRO carries out a PDS trace with the second parent present to identify their NHS Number stores it and provides it to the NHS Proxy Service 
* Second parent could be asked to present documentation containing their NHS Number to the GRO which the GRO could then provide to the proxy service – issues with forgetting to bring information, needing to come back at a later date etc. 
* GRO could issue a link to allow a user to claim a digital credential, sent as a text message to their phone (this means no exchange of NHS numbers would be necessary) or to an email address – possible issues of credential expiry prior to use.


##### Step 3: Birth Certificate amended by General Register Office – creating the subsequent proxy capabilities and revoking others


There are situations where a birth may be re-registered, which results in an amendment to the birth entry held against the child. There are numerous scenarios where this may happen: 


* The natural father may be added to the birth certificate at a later date by means of a GRO185 form where they weren’t on the birth certificate before

* A father may be removed from the birth certificate if it is proven via a DNA test that they weren’t the biological father of the child 

* A father is automatically added to the birth certificate if they obtain a declaration of parentage - however, a declaration of parentage doesn’t grant parental responsibility, so when they are added to the birth certificate on this basis, the birth certificate should not be accepted as proof of parental responsibility. 

* The attainment of a parental order- which is the primary route to parental responsibility for parents conceiving through surrogacy - also involves a re-registration of the birth since the original birth will be registered by the surrogate mother and her partner. In cases where the surrogate mother doesn’t have a partner, the birth will be registered by the surrogate mother and one of the child’s intended parents. In either of the cases, a parental order will be required for both intended parents to obtain parental responsibility, and this will necessarily involve a re-registration of the birth.
* Adoption - The NHS Proxy service will need to check that the birth certificate data is still accurate on a regular basis, revoking proxy access if necessary. 



## Establishing Death of Subject or Proxy

There are arguments that it may be beneficial for the Proxy Access Service to use death information to terminate proxy access either because the subject has died or the proxy has died.



* A proxy may find out about the death of a subject as a result of proxy access to their record.
* A third party digital service may want to withhold the showing of new data to a proxy of someone who has died to prevent information about their death being shared unnecessarily.
* Third party suppliers may want to cease messaging in sensitivity to the bereavement.
* Clinicians may want to be notified when a person who is acting as a clinically delegated proxy dies as this will mean a replacement proxy will need to be instated.
* Someone who is deceased is unable to consent to record access and cannot manage the proxy access on an ongoing basis.
* Blocking proxy access to a deceased person’s records may limit fraudulent activity
* Blocking access by a proxy who is deceased may limit fraudulent activity (someone pretending to be a deceased person)

Death of a subject or a proxy should revoke the proxy access granted.

Within health and care systems linked to the Spine (Personal Demographics Service) there is both an informal death notification and a formal death notification which have different timelines:



* “Informal” death notifications data collected through the Personal Demographic Service (PDS) managed by NHS Digital which can provide an early record that an individual has died
* Civil Registration data from the Office for National Statistics (ONS) which is the statutory, official record of the time, location and cause of death

Information sourced from: Death notification (PDS and GRO) [https://digital.nhs.uk/coronavirus/coronavirus-data-services-updates/mortality-data-review](https://digital.nhs.uk/coronavirus/coronavirus-data-services-updates/mortality-data-review)



### PDS: Source of Informal Death Notification

Healthcare IT systems may be used to record deaths before they are formally registered with a local register office. These systems, although timely, are not complete because they are not a legally enforced method of reporting deaths. 

As well as local recording of death in a patient’s medical records, which is not routinely shared with other systems, early indication of a death can be obtained from an “informal” death flag on NHS Digital’s Personal Demographics Service (PDS). The informal death flag on PDS can be set by any NHS Spine-connected institution. It is predominantly set by Primary Care institutions but is also set by a number of Secondary Care organisations:



* 48% of deaths are notified to PDS within 2 days, rising to 71% within 7 days. The purpose of the informal death flag is administrative, for example, to suppress communications to patients who have died or cancel appointments. 
* 80% of registered deaths are captured by this method, meaning that a number of organisations do not use the flag
* Analysis has shown that the dataset has national coverage across all places of death such as home, care home and hospital, with no significant variation in timeliness or completeness.
### GRO RON: Source of Formal Death Notification

The statutory process for reporting deaths in England is through the civil registration route. This process, while comprehensive, has not been designed for speed:



* 23% of deaths are registered within 2 days of occurring, rising to 77% within 7 days. 
* Legally 5 days are allowed for a death to be registered (increased from 2 days in 2018) with the timing affected by weekday registry office opening hours and the need to report certain deaths to the coroner.
* However, even deaths registered within the statutory 5-day requirement can take up to 20 days to appear in official reports from the Office for National Statistics (ONS) due to the weekly reporting cycles that ensure that data is complete and quality assured for the latest period.
* To improve processes for reporting deaths during the COVID-19 period, a number of changes were made, including the ability to verify that death has occurred via remote consultation, and electronic sending of Medical Certificates of Cause of Death (MCCD) to the local registry office, with telephone rather than physical appointments with the next of kin to complete registration. It appears that these measures have reduced the time it takes to register a death, although impact cannot be verified at this early stage

Recommendations made since the COVID-19 period to improve timeliness of death notification include increasing the use of informal PDS flag and expediting data flows through the civil registration route, including by providing additional weekend administrative support.


![alt_text](images/image12.png "image_tooltip")

![alt_text](images/image13.png "image_tooltip")

![alt_text](images/image14.png "image_tooltip")



#### Recommendations for an NHS Proxy Service processing death notifications

As it seems likely that an NHS Proxy Service will need to either to revoke proxy access on either the death of a subject or a proxy or to pass death information on to 3<sup>rd</sup> party services, the service should retrieve both informal and formal death notifications. An informal death notification could be used to place a hold on issuing of any further proxy access and/or a warning that revocation will be imminent. The formal death notification should be used to revoke access.



## Establishing Child Protection status 

From a safeguarding perspective it is paramount that people do not have access to information about children that they are not supposed to have access to. This includes scenarios where a child has been removed from the care of their parent and the parent has lost parental responsibility for the child.

It is not sufficient to rely solely on birth certificate information to establish the current situation when issuing proxy access to a record. In circumstances where a parent has lost Parental Responsibility there can be considerable delay between the issuing of a court order and the amendment of a birth certificate. There may also be circumstances where a parent still has parental responsibility for a child but is prohibited from knowing where the child is. 



### CP-IS - Use of the Child Protection Information Systems as a data source 

The prime function of CP-IS is to help health and social care staff in England to share information about child protection (CP) plans securely, to better protect society's most vulnerable children. When a child is known to social services and is a looked after child, on a child protection plan or unborn child protection plan, basic information about that plan is shared securely with the NHS through CP-IS.

During the COVID-19 pandemic, the sharing of this data was extended and information from CP-IS was extracted and sent to school nurses and health visitors in order to improve safeguarding. The information that NHS Digital is extracting from CP-IS is NHS Number and date of birth so the child or mother (if the mother is pregnant with an unborn child protection plan) can be identified. The type of plan that exists is collected (or if a looked after child) and the start and end date of that plan so that healthcare professionals knows whether or not it is still in place.

The dataset already being shared in this way, is the same one that is needed to establish whether parental responsibility for the child has been changed at any point, which would create an ‘area for investigation’ if a proxy access request is received for that child. As the CP-IS data is being repositoried by NHS Digital, the repository can act as a ‘look-up’ table when a digital proxy access request is made and flag requests for back office scrutiny when an entry is found.

Data collected from Local Authorities for .1 CP-IS:





#### Legal Basis for Collection, Disclosure and Processing

It should be noted that NHSD is not the Data Controller for CP-IS, data controllership remains with the local authorities.

Schedule 1 of the Data Protection Act 2018 contains 'safeguarding of children and individuals at risk' as a processing condition that allows practitioners to share information, including without consent (where, in the circumstances consent cannot be given, it cannot be reasonably expected that a practitioner obtains consent, or if to gain consent would place a child at risk).

General lawfulness of processing [of personal data]:



* Article 6(1)c: processing is necessary for compliance with a legal obligation to which the controller is subject
* Article 6(1)e: processing is necessary for the performance of a task carried out in the public interest or the exercise of the official authority vested in the controller 

Processing of special categories of personal data: 



* Article 9(2)h: processing is necessary for the purposes of preventive or occupational medicine, for the assessment of the working capacity of the employee, medical diagnosis, the provision of health or social care or treatment or the management of health or social care systems and services on the basis of Union or Member State law or pursuant to contract with a health professional and subject to the conditions and safeguards referred to with the Schedule 1, Part 2 of the DPA 2018 substantial public interest condition being paras 6 (6. Statutory and government purposes) and 18 (Safeguarding of children and individuals at risk) with the underlying law being the Children Act 2004 and the statutory guidance Working Together to Safeguard Children
* Article 9(g) Reasons of substantial public interest (with a basis in law), Data Protection Act 2018 with the Schedule 1, Part 2 of the DPA 2018 substantial public interest condition being paras 6 (6. Statutory and government purposes) and 18 (Safeguarding of children and individuals at risk) with the underlying law being the Children Act 2004 and the statutory guidance Working Together to Safeguard Children.


#### Information Governance Status

The original agreement between local Authorities and NHS England for the CP-IS data collection is currently undergoing a refresh in light of the extensions to data-sharing that were made during the COVID-19 pandemic.

**The CP-IS programme in NHS Digital is responsible for managing the refresh and began work in summer 2021 and anticipates finishing this working summer 2022. It would be highly advantageous to a new national NHS Proxy Service to intercept this timeline and get the additional sharing and processing agreed, given that refresh will always likely be a year-long programme due to having to liaise with 152 local authorities who wish to ensure no secondary uses of their data and manage additional use through change control and full consultation/sign-off with each LA.**


#### How could this data source be used?

CP-IS data could be used to block the issue of Parent/Guardian (PR) proxy access where the subject of that access is subject to an child protection plan. 

This would mean that no parent of the child could access their child’s record while an active plan is in place. This will not be acceptable in the circumstance where only one parent is subject to the protection plan. 

It is therefore suggested that it should be possible to “override” the CP-IS court order either through a NHS Proxy Service Back Office who would manually action the override, or through a clinical/Local Authority interface where authorised personnel could issue an override and evidence the reason why. The override should relate to a specific court order and not be generic. 


#### Proposal:

The NHS Digital CP-IS data source appears to be usable from a technical perspective although as highlighted there will be considerable IG work to be complete – this should start as soon as possible.



* Use the NHS Digital CH-IS repository as a data source 
* Create an override process either through backoffice or LA interface
* Piggyback onto NHS Digital’s current project to resolve data sharing and processing agreements
## Lasting Power of Attorney (LPA) and The Office of the Public Guardian (OPG) 

Lasting Power of Attorney (LPA) can be set up when there is a need for someone to make decisions on a subject’s behalf because they are temporarily or permanently unable to make their own decisions for example: 

**Temporary** – A subject is in hospital for an episode of care and cannot take care of their financial affairs such as bill-paying 

**Permanent** – A subject may need to make longer-term plans if they have been diagnosed with dementia and may lose the mental capacity to make their own decisions in the future. 

There are two types of LPA: 



* LPA for financial decisions 
* LPA for health and care decisions 

It is the LPA for health and care decisions which is pertinent for NHS Proxy Access decisions although other government services may be interested in a proxy service that identifies people with an LPA for financial decisions. 



### LPA for health and care decisions 

This type of LPA can only be used when it is determined a subject has lost mental capacity. Mental capacity assessments are carried out by health and care professionals and are specific to a time period and context. 

With this type of LPA an attorney can generally make decisions about things such as: 



* where you should live 
* your medical care 
* what you should eat 
* who you should have contact with 
* what kind of social activities you should take part in. 

Special permission can also be given to the attorney to make decisions about life-saving treatment. 



### The Office of the Public Guardian (OPG) 

The Office of the Public Guardian (OPG) is a government body and an executive agency of the Ministry of Justice (MoJ) which carries out the legal functions of the Mental Capacity Act 2005 and the Guardianship (Missing Persons) Act 2017. 

It is responsible for: 



* registering lasting and enduring powers of attorney, so that people can choose who they want to make decisions for them. 
* investigating reports and concerns about abuse made against registered attorneys, deputies or guardians 
* maintaining the registers of attorneys, deputies and guardians 
* supervising deputies and guardians appointed by the courts, and making sure they carry out their legal duties 

In July 2020 the OPG introduced a new digital tool ‘Use a lasting power of attorney’ to help those acting as an attorney to contact organisations like banks and healthcare providers more easily. The aim of this was to improve the speed with which they can make important decisions, such as those related to their loved ones’ care. The tool maintains existing checks, including to confirm whether someone has the legal right to act as an attorney and the powers they may be entitled to. 



### The Use a lasting power of attorney’ digital tool : how it works 

Subjects whose LPAs were registered by the OPG on or after the 17 July 2020 automatically received an LPA reference number and activation key in their registration letter. Both attorneys and donors on the LPA receive these details. 

They can then visit www.gov.uk/use-lpa to create an account and add the LPA by using the reference number and activation key, along with their date of birth. 

Once the LPA is added, the customer can choose to share the details by generating a secure access code to provide to third party organisations. 

The third party can then view the LPA details by going to www.gov.uk/view-lpa, adding the customer name and secure access code. This enables the organisation to check the LPA is valid and offers a downloadable version of the LPA summary to save for their records. 

Any organisation can access the summary of the LPA once they have been provided with a secure access code from the user. The don’t need to register to use the service. So long as they have the donor’s name and the access code, they will be able to view the summary of the LPA and see if the LPA is valid. 

The Use an LPA service is an additional means of sharing the details of an LPA with a third party. All previous routes, like sharing certified copies, are still available to subject. While the OPG doesn’t require third-party organisations or other government departments to officially 'sign up' to use the Use an LPA service, their team is working with different sectors to raise awareness of this new service and encourage its use 

**The availability of the tool therefore means that the OPG has a repository of registered LPAs plus a register of those who have created an account and who wish to use a digital LPA. However, the coverage of all LPAs is still partial (although being extended gradually) and not all of those who have an LPA in place will register for its online use**[^2]**.

**This partial coverage means that the OPG LPA registry is not a candidate for the Alpha build of an NHS Proxy Access Service. This is also the case as there is a currently a consultation out on the digital tool and how to improve it which is due to report in Spring 2022.**

The consultation will look at: 



* How witnessing works, and whether remote witnessing or other safeguards are desirable. 
* How to reduce the chance of an LPA being rejected due to avoidable errors. 
* Whether the OPG’s remit should be expanded to have the legal authority to carry out further checks such as identification verification. 
* How people can object to an LPA and the process itself, as well as when is the right time for an objection to be made. 
* Whether a new urgent service is needed to ensure those who need an LPA granted quickly can get one. 
* How solicitors access the service and the best way to facilitate this. 

As any substantial changes will require amendments to the Mental Capacity Act 2005 which may have ramifications on how mental capacity assessments are carried out or registered, awaiting the outcome of the consultation is recommended before investigating this aspect of proxy access further. The recommendation is to pursue further information from the OPG once the consultation is published. 



## Capacity Source

There is currently no central record of capacity assessments. Furthermore, a variety of approaches are in place to assess capacity and depend on setting and the reason for carrying out the assessment. 


#### Formal recorded assessments

Capacity assessments may be carried out through a formal process via assessments that are recorded with the Local Authority and periodically reviewed. Local Authorities keep a record of these assessments within their own records.


#### Clinical assessments of capacity

Clinicians carry out assessments of capacity for their patients as part of their care. The outcome of these assessments are recorded in clinical records and used by the clinicians and the organisations they work for to manage the care of the patient. There is no central record of such capacity assessments. 


#### Proposal:

As there is no source for this information the NHS Proxy Service would need to create and use a Professionally entered data store to manually capture the information. See Professionally Entered Data Store.



## Personally Entered Data Store

It will be necessary for some personally entered data to be stored. It will need to contain the following:



* Personal delegation of proxy access
* Authorisation data showing what a proxy is and isn’t allowed to do on their behalf
* History pertaining to who has accessed records using the NHS Proxy Service and when. 

Where this data is stored will depend on the outcome of the finalisation of the architecture design. It is likely that it will reside with NHS Account / 3<sup>rd</sup> party applications.



## Professionally Entered Data Store

Depending on the outcome of policy decisions, there may be a need for a professionally entered data store. 

The professionally entered data store may need to contain the following:



* Clinically recorded subject capacity + evidence
* Professionally recorded (LA) subject capacity + evidence
* Clinically recorded proxy capacity + evidence
* Professionally recorded (LA) proxy capacity + evidence
* Clinically recorded proxy suitability + evidence
* Clinically approved proxy access (where local approval is required in addition to national proxy service – see Liability Framework)


#### Proposal: 

It will only be possible to assess whether the professionally entered data store is necessary once the Proxy Policy is approved and the detailed use cases list has been re-evaluated.



# Requirements catalogue

Sitekit used the information gathered from the draft Proxy Policy, research previously carried out on proxy access, interviews carried out with Proxy Stakeholders and our own domain knowledge gained by working on the DPCHR Child Health Programme, and on the NHS Account programme to inform the development of the first draft of the Proxy Service Functional and Non-functional Requirements. 

_<span style="text-decoration:underline;">These can be found in Appendix 1: NHS Proxy Requirements and Business Rules Catalogue (excel)</span>_

These requirements should be considered as a working document that will develop with time. Many of the functional requirements are dependent on decisions that will be made in the next phase by the IG and Policy definition processes. Others will be informed by further user testing. 

The level of certainty column indicates the degree to which we have confidence in the requirement. This ranking has been applied based on whether or not we have been able to find consensus within the materials we have read and / or within the groups of people we have spoken to regarding the future functionality of the service.

We recommend that more user research is carried out. It may be useful as part of that research to clarify the requirements in relation to the following questions that arose during the project:



* (FR 5) What should the interface that subjects use to delegate access look like?
* (FR 11) How should health records look so that it is clear when a user is acting as a proxy rather than looking at their own record?
* (FR 12) What does a clinical NHS Proxy Service UI need to look like?
* (FR 13) What do clinicians need to be able to record when they record a person’s lack of capacity?
* (FR 13) Do clinicians have expectations that the proxy service will prompt them to review capacity statements periodically?
* (FR 16) Should a clinician be able to see who has proxy access to a subject’s records? Should they be able to see legally delegated and clinically delegated proxies, but not personally delegated proxies? Or, if clinicians are locally approving personally delegated access should the be able to see personally delegated proxies as well?
* (FR 27 - NHS Account) To what extent do users want a history of who has accessed their records and what they have viewed or updated?
## Proxy Service UI

        It is proposed that a user will centrally administer Proxy Access to their records through the NHS Account interface specifically they will be able to:

* Add or remove a proxy (personally delegated)
* See who has (and had previously) proxy access to their records (including legally delegated access)
* Control (set up and change) what a personally delegated proxy can do on their behalf in
    * NHS Account
    * Any other 3<sup>rd</sup> party services the subject is using that have connection to the NHS Proxy Service
## Clinical Administration UI

It is proposed that clinicians (GPs initially but may be expanded in the future) will need to have access to the proxy service to:



* Locally approve proxy access (see Liability section)
* Record Capacity assessments (with evidence)
* “Break Glass” option to block a proxy if they are acting in a way that isn’t in the subject’s best interest 
* Clinicians may also want to be able to see who has been granted access to act as a subject’s proxy(ies). 
# Business rules

The Business Rules for the Proxy Access Service will need to be based on the new Proxy Access Policy, the Proxy Access Rights Standard Framework (derived as part of the policy and detailing what access rights people of different proxy types will have) and the Proxy Service Trust Framework. These will be generated in the next phase.

However, many potential business rules have emerged during the discovery phase which have been captured to enable discussion during the next phase of the programme.

_<span style="text-decoration:underline;">The Business Rules Catalogue can be found in Appendix 1: NHS Proxy Requirements and Business Rules Catalogue (excel)</span>_

Note that many of these rules are not fully expressed as business rules due to uncertainty of policy and technical solution. They are retained in this list to act as a reminder.

During this phase of the programme we have identified the concept of Onward Granting of proxy access. Onward Granting will need to be covered within the business rules in the future. As it is a new concept and a number of different potential scenarios have been explored during this phase the findings are documented below for future reference.



## Onward Granting of Proxy Access

**Onward granting** is the granting of proxy access to the subject’s record by the proxy to a second proxy, known as the second degree proxy.


![alt_text](images/image15.png "image_tooltip")


During this phase we looked at the circumstances under which someone should or should not be able to onward grant proxy access. These business rules were captured in the business rules catalogue. We suggest that onward granting of proxy access be considered as part of the policy definition. 



###  Onward Granting of Personally delegated Proxy Access 

Personally delegated proxy access is granted by adults with full capacity. If the adult wishes to grant personally delegated proxy access to another adult they would do that themselves. There should be no onward granting of Personally Delegated Proxy Access.


![alt_text](images/image16.png "image_tooltip")

Proposed Business Rule: No onward granting of Personally Delegated Proxy Access



###  Onward Granting of Legally delegated access – Parent / Child

Parents (with parental responsibility and legally delegated proxy access) may need to be able to give proxy access to their children’s records to other adults (second degree proxies) or potentially young carers. 

Examples: 

* A step parent may be heavily involved in the healthcare of a step child and need proxy access to their NHS Account and connected services.
* A grandparent may look after a child while the parent is posted abroad as a member of the armed forces.
* A close friend may look after a child whilst a single mother is in hospital 


![alt_text](images/image17.png "image_tooltip")


3<sup>rd</sup> party services connected to the NHS Account may want the option to limit what services a second degree proxy can view or do relative to parent’s granted Legally Delegated Proxy. 

Proposed Business Rule: A parent with legally delegated proxy access to a child’s records can onward grant proxy access to a second degree proxy.

Proposed Business Rule: No onward granting of Personally Delegated Proxy Access by Second Degree Proxies 

Proxy Service API: Proxy or Second Degree Proxy identified in API

There are many circumstances in which Legally Delegated access may be revoked to protect the child. A parent who has lost parental responsibility may try to access the child’s records using the login of someone who had been granted second degree proxy access. It would therefore be necessary to remove any second degree proxy access when legally delegated access is revoked.

Example: 



* A child is removed from a parent as the result of a court order the parent loses parental responsibility for the child. Prior to the removal, the parent has granted her partner with personally delegated proxy access to the child’s records. The parent could use the partner’s access as a way of viewing the child’s records on an ongoing basis. 



![alt_text](images/image18.png "image_tooltip")
Business Rule: Onward Granted Proxy Access to Second Degree Proxies are revoked when legally delegated proxy access is removed from the proxy



#  Architecture
## Representation & Approach

The technical design for the NHS Proxy Service is represented in this document using several architectural views. Each view is intended to describe one or more concerns involved in the system.


<table>
  <tr>
   <td>View Name
   </td>
   <td>
   </td>
   <td>Concern
   </td>
  </tr>
  <tr>
   <td>Scenario View
   </td>
   <td>
   </td>
   <td>Consists of a set of use cases or scenarios, which guide the design of the architecture. The view specifies the actors (users) involved and what system and functionality they have access to. Unified Modelling Language (UML) use case diagrams will be used to articulate this view.
   </td>
  </tr>
  <tr>
   <td>Development View
   </td>
   <td>
   </td>
   <td>Decomposes the solution into layers, subsystems, and components, showing how it is structured. C4 context and container diagrams will be used to articulate this view.
   </td>
  </tr>
</table>


The technical design represents the progress at the end of the NHS Proxy discovery phase. Further work should be carried out in the alpha and beta phases, to further develop the scenario view and development view, and to introduce the logical, process and physical views. 



## Decentralised Identity Overview

The NHS Proxy solution is based on a technology called “Decentralised Identity”. Decentralised Identity has been designed to address limitations with the current approaches that organisations use to communicate with individuals, digitally. For individuals, the technology is simple to use and improves privacy and security. For organisations, the technology lowers friction and provides higher security. It does this by simplifying regulatory compliance, improving interoperability across silos, removing the need for large data lakes, and creating a secure, private digital relationship with each user.

Decentralised Identity is the technology that underpins the NHS Digital Staff Passport. Part of technology is referenced in the [Government’s UK digital identity and attributes trust framework](https://www.gov.uk/government/publications/uk-digital-identity-attributes-trust-framework-updated-version/uk-digital-identity-and-attributes-trust-framework-alpha-version-2#table-of-standards-guidance-and-legislation) (see Making your products and services interoperable with others: W3C Verifiable Credentials). Meetings have been held between the NHS and GOV.uk Department for Digital, Culture, Media & Sport (DCMS) team to coordinate on a cross government Decentralised Identity approach.

Establishing a proxy relationship, providing access to medical records, and revoking proxy access at the right time is complex. A scalable solution cannot be implemented by the NHS in isolation as it requires coordination and trust across multiple agencies. Decentralised Identity provides standard framework for this type of digital communication and trust.

The technology is based on the concept of digital credentials. These are digital equivalents to the paper-based / plastic credentials that we hold today – drivers’ licence, passport, identity card, birth certificate, etc. Individuals hold and manage their own digital credentials in a digital wallet (typically an app installed by the individual on their mobile phone). Anyone can issue a digital credential about anything, to anyone (subject to the holder’s consent). Anyone can verify the authenticity and integrity of any digital credential (subject to the holder’s consent). Digital credentials answer the question – “says who?”. You might hold a drivers licence digital credential, but who issued this credential to you? Did the UK DVLA issue the drivers licence, or did the Andorran Driving Agency issue the drivers licence?

The NHS needs information from other agencies to ascertain whether a proxy relationship should exist. The type of information needed, and the agencies trusted to issue these pieces of information may differ between use cases – for example birth certificates may be needed for children and powers of attorney may be needed for adults. Rather than the NHS integrating directly with the GRO (for example), the GRO works directly with the parent to issue them with a digital birth certificate credential. The NHS can then ask the parent for proof of the birth certificate (and any other credentials the NHS may need from the parent to establish this type of proxy relationship). Once the NHS is happy that all the credentials have been provided to satisfy a given use case, then the NHS will issue its own identity credential back to the parent. This identity credential will establish the authenticity of the proxy relationship and can therefore be used by the proxy to access the medical records of the subject. The solution also involves the monitoring of the status of the proxy relationship and the revocation of the identity credential at the right time.



![alt_text](images/image19.png "image_tooltip")




##   Scenario View

![alt_text](images/image20.png "image_tooltip")


![alt_text](images/image21.png "image_tooltip")

![alt_text](images/image22.png "image_tooltip")

![alt_text](images/image23.png "image_tooltip")

![alt_text](images/image24.png "image_tooltip")

![alt_text](images/image25.png "image_tooltip")




##  Development View

![alt_text](images/image26.png "image_tooltip")




##  Authentication and Authorisation

The process by which someone gains access to another person’s records is based Authorisation. Authorisation is dependent on authentication.

**Authentication**: the process of verifying who someone (or something) is.

**Authorisation:** the process of verifying what someone (or something) is allowed to do.

In context of proxy access to a 3<sup>rd</sup> party service, both authentication and authorisation are necessary. 

It is proposed in the architectural design that an NHS Resource Server can delegate the responsibility of authenticating the existence of a proxy relationship to the NHS Proxy Service. The responsibility for authorising access to the Protected Resource remains the responsibility of the  Resource Server (typically an authorisation service operated by the Resource Server). The diagram illustrates this below:

![alt_text](images/image27.png "image_tooltip")


What an authenticated proxy user is authorised to do within with a Resource Server (e.g. NHS Account User Profile), using a Digital Service (e.g. Wellness Hub) will need to be governed by the access control policy of the Resource Server.

In the future healthcare professionals may be able to use the NHS Proxy Service to issue proxy access. In order to do so, they will need to authenticate (sign-in) to the NHS Proxy Service. A federation with a professional identity provider will be needed to allow this to happen.

The type of authentication that will be needed will depend on what capacity you are acting in within the Proxy service. 



###  Authentication and Level of Assurance

The Proxy Access Service must be able to assert the proxies level of assurance. This should be in line with the levels currently use within NHS Login. This will allow downstream authorisation decisions to be made on the same basis. 



### Data and Action parameters

The things a proxy can do on behalf of a subject can be grouped into two groups:

**Data Access:** A proxy views a subject’s data 

**Action:** Where a proxy takes an action on behalf of a subject e.g. book appointment, order prescription

The Proxy Service asserts the existence of the proxy relationship (it authenticates the relationship). This trusted assertion can be used by Resource Servers or by client applications for both data access and action authorisation decisions. The example below visualises how a Resource Server’s authorisation policy may work).


The NHS Digital Discovery report (appendix A) came to the following conclusions:


- In looking at the types of transactions and interactions supported by digital health services, we realised the current approach of letting the patient and their proxy have the same view of data presents a number of safeguarding issues for patients. 
- To address these concerns, we developed the following model to segment high-level transactions to manage the risks introduced by proxy access. The model uses cumulative risk levels for each of the broad transaction groups, as well as risk levels for specific transactions within these groups (defined as RAG statuses).
- This approach would enable high-risk transactions, such as requests for proxy record access, to be assessed for risk and enable local safeguarding procedures to be applied, protecting the patient.
- It proposed the following as a way of segmenting activities a proxy might undertake:


![alt_text](images/image28.jpg "image_tooltip")

Sitekit envisage that it will be up to the 3rd party service to define how access rights will work within their digital service, conforming to the Proxy Access Rights Standard Framework. 

The information included above should be used as a starting point for the definition of the Proxy Access Rights Standard Framework.


###  What might 3rd party Digital Service Access Rights look like?

The NHS Account Alpha programme has looked at how NHS Account data may be segregated into Scopes, enabling users to elect to share blocks of their data with digital services outside NHS Account under the normal operating processes within NHS Account. 

Within the NHS Account Digital Service, these scopes could be used to enable the segregation of data access rights for proxies. See NHS Account MDS Specification for the latest version of the scopes of access.


<table>
  <tr>
   <td>Proposed NHS Account Scopes 
   </td>
   <td>Grants access to the following attributes (via API) 
   </td>
  </tr>
  <tr>
   <td rowspan="8" >Demographics 
   </td>
   <td><strong>NHS number </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Date of birth </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Surname </strong>
   </td>
  </tr>
  <tr>
   <td><strong>First name </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Sex </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Gender </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Ethnicity </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Postcode </strong>
   </td>
  </tr>
  <tr>
   <td rowspan="4" >Contact preferences 
   </td>
   <td><strong>Phone number </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Email address </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Address </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Postcode </strong>
   </td>
  </tr>
  <tr>
   <td rowspan="2" >GP 
   </td>
   <td><strong>GP Practice name </strong>
   </td>
  </tr>
  <tr>
   <td><strong>GP ODS code </strong>
   </td>
  </tr>
  <tr>
   <td rowspan="4" >Physical.Health * 
   </td>
   <td><strong>Smoking status </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Height </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Weight </strong>
   </td>
  </tr>
  <tr>
   <td><strong>Condition </strong>
   </td>
  </tr>
</table>


* Future scopes could include mental.health or sexual.health 



### Access Rights: What will the NHS Proxy Service need to know to onboard a new Resource Server?

The NHS Proxy service will need to:



* Have assurance that the Resource Server operator has implemented an authorisation policy in line with the **Proxy Access Rights Standard Framework.**

The NHS Proxy service should not:



* Define the access control policies for individual Resource Servers. That is the responsibility of the 3<sup>rd</sup> party supplier working within the Proxy Access Rights Standard Framework.





# Proposed Scope of Work for the Next Phase

We recommend that financial year 2022/23 is spent developing and delivering the foundations for the Proxy Service, agreeing detailed Architecture definition and carrying out some additional User Research. 

_<span style="text-decoration:underline;">The proposed Gantt chart for 2022/2023 can be found in Appendix 4 </span>_

We recommend that the initial focus is on Adult to Adult Personally Delegated Proxy access and Parental Proxy Access.

This recommendation is based on the availability of data sources required for each of the proxy types, the complexity of implementing the NHS Proxy Service and the need for the service (as established in previous research carried out prior to this project).

![alt_text](images/image29.png "image_tooltip")




## Proxy Service Foundations

In order to develop the proxy service it is necessary to establish policy and framework foundations shown in the diagram below in red:



![alt_text](images/image30.png "image_tooltip")
 



### NHS Proxy Service Policy 

In order to develop and deliver an NHS Proxy Service it is first necessary to create an NHS Proxy Service Policy. The NHS Proxy Service Policy will be a high-level, NHS approved document, that defines how legal rights and responsibilities defined in legislation will be met through the proxy service in a way that is safe and meets the needs of users and relevant NHS and Social Care parties. It will need to be developed by the Policy team.

The policy document will shape how the Proxy service functions by: 



* Defining high-level user experience

e.g. how the rights of parents to access their child’s records will be met, how the rights of someone with LPA to access records on behalf of someone else will be met, how the rights of a child to privacy at various ages will be met.

* Defining stakeholders high level behaviours and capabilities when using the service
* Providing the basis for trust, IG and legal liability frameworks
* Determining the structure onto which a technical solution will be built
* Providing a basis for an enforceable set of business rules against which a solution can be tested


#### Why does it need to be done first?

The policy directly impacts how the technical architecture is designed, what components are required including user interfaces, and what the user will be able to do in the User Interface. 

The act of writing the policy will enable stakeholder engagement across a wide range of clinical applications, requiring consultation and co-development, and ultimately will enable buy-in. 

Policy discussions will also enable discussion around how the service should work prior to the expense of building the service.

It may take time to reach agreement as the stakeholder list is wide. The groups shown in the diagram below will need to be consulted during the creation and approval of the policy. Each will have a unique perspective which will inform the development of the policy and make it practicable in a digital scenario.

Note that this list of stakeholders may increase during the Alpha.

![alt_text](images/image31.png "image_tooltip")




###  Liability Framework

In order for the NHS Proxy Service to operate it will need to have an established liability framework that states who is liable if an error is made and someone incorrectly gains access to a subject’s health records and causes harm. 

Article 82(1) GDPR – which is applicable in the UK – provides any person who has suffered a material or non-material damage because of an infringement of the GDPR with a claim for compensation from the controller (see Article 4(7) GDPR) or processor (see Article 4(8) GDPR) for the damage suffered.

Any NHS service providing a proxy access to a subject’s medical records has potential, if given incorrectly to cause harm. 

Where services currently allow any form proxy access they have assessed the risk posed by a potential error and have made arrangements to put legal support in place to manage the risk, or have worked to mitigate the risk so as to deem it low, potentially at the expense of data access. 

Two existing scenarios are discussed here to illustrate some of the issues that will need to be addressed as a result of the development of the liability framework: Access to GP records and Access to Digital Personal Child Health Records.


#### Proxy Access to GP Records: Current Scenario

GPs in the current scenario, GPs provide proxy access to their patient’s records on a case by case basis, often only where the proxy and subject are registered with the same practice, and with manual verification of the proxy. 

GPs are the data controller of the data held in their clinical systems, so should an issue occur they would be liable for the damage suffered. By acting as the gatekeepers to proxy access in this way the GPs can limit the risk of harm.

Furthermore, GPs have worked to develop the legal support they need to run this service and manage the risk. 

Centralising a proxy service would essentially be outsourcing the proxy access decision removing their opportunity to act as gatekeeper to the records they keep. This will significantly alter the risk for GPs and disrupt the legal support and processes they currently have in place.

Without clear legal definition of liability and the appropriate legal support in place at national level, GP (and other digital) services want to and wouldn’t be able to move from the existing process to using externally defined proxy relationships.

Questions remain as to whether GPs would ever want to move away from approving proxy access to records. 


#### Digital Personal Child Health Record (DPCHR) Current Scenario

For DPCHR providers who are providing parents access to their child’s health records, the health visiting or midwifery service who make the initial connection are responsible for validating that the parent should have access to the record prior to manually making that connection. The exception to this is for mothers who sign up antenatally who automatically have their child’s record connected at birth using the PDS Birth Linkage data. If for safeguarding reasons a parent needs to be disconnected from their child’s record in the future the health visiting or midwifery service follows their own service defined process to remove this access.

As a mitigation put in place at national level to manage the slim risk that parents may not be correctly disconnected from their child’s records, DPCHR NEMS messages have had location information removed from the messages reducing the impact that may be caused by a parent continuing to have access to a child’s records when they shouldn’t. 

Mitigating risk in this way by reducing the data available to parents isn’t ideal as it means that parents don’t have access to all the data they could have access to e.g. change of GP information. 

DPCHR providers are keen for centrally administered proxy access (where safeguarding data is used as part of the proxy evaluation) as it has potential to alter the risk profile around data that contains address details, meaning more data could be received by parents. This would need to be accompanied by a liability framework that provided clear guidance on which organisation is liable in the event of an error. 


#### Creating a liability framework for NHS Proxy Service

The Proxy legal liability Framework will define the legal responsibility of participating organisations including which organisation is liable if an issue arises from the wrong person being given access to data. 

Establishing whether or not a proxy should have access to a subject’s medical records requires a complex evaluation of data from multiple sources. The NHS Proxy Service will facilitate the receiving and evaluation of data and will ultimately translate it access credentials, which will then used by the proxy to access medical and health records again across multiple systems on behalf of the subject. 

Within the proxy framework an organisation may play one or more of the following roles:

**Credential data issuer:** Issue data to the NHS Proxy Service that is used to establish whether someone should be given proxy access to a subject’s records - liabilities may include the quality of the data issued to the proxy service, maintaining a continuous service, providing a complete data set.

**Health Record data controller:** liable for providing appropriate access to data.


#### Liability Models

The diagram below shows 3 basic liability models that may apply to the NHS Proxy Service. At present the GP Proxy issue process follows the “Local Proxy Approval Only” model, while the DPCHR process follows a very basic version of the “National Proxy Issue only” approach for mothers who are connected to their records via the PDS birth linkage route and the “local Proxy Approval Only” process where health visitors manually connect the records.

With the NHS Proxy Service it is proposed that digital services would follow either the “National Proxy Issue only” route or a hybrid “National Data Evaluation with Local Approval” route. Using the “National data Evaluation with Local Approval” process the NHS Proxy Service would be used to establish basic proxy eligibility which would then be applied in conjunction with a local validation of the relationship. 

![alt_text](images/image32.png "image_tooltip")




###  IG Framework 

From the perspective of the NHS Proxy Service, Information Governance is the legal framework governing the use of the personal confidential information needed to allow a proxy safe, secure and appropriate access to a subject’s records.

As this data crosses multiple organisational boundaries the IG framework will need to include formal IG agreement between organisations. This has already been achieved on national scale with the NEMS. Trusts IG teams have approved remote connection of mothers to their children’s records using NEMS so it is expected that an agreement could be achieved for a national service that doesn’t require local validation. 

Key areas of work:



* Establish legal basis for processing for NHS Proxy Service – Depending on final architecture, different components in the NHS Proxy Service may have different legal basis e.g. credential issuing service may be public task while 3rd party service use of proxy tokens may be personal consent. 
* Work with Credible Data Sources to establish IG agreements
* Work with 3rd party suppliers to develop template IG agreements e.g. GP clinical systems

Following on from the work the NHS Account team have carried out, we established some draft Information Governance Principles. These will need to be developed further in the next phase:


![alt_text](images/image33.png "image_tooltip")




##  User Research

We expect that you will want to carry out user research into both the policy side of the NHS Proxy Service looking at how users view the policy and capturing feedback, and User Acceptance testing looking at how the service will work and relevant UI / UX design. 


### Policy testing

We advise that the policy be user tested prior to final sign off.

It has been highlighted during this phase that there may be a discord between the finally agreed NHS Proxy Service Policy and public/GP opinion particularly in the area of child capacity and removal of parental access to records. This may especially be the case if the removal is implemented at 11 where a child is themselves unable to access their NHS Account. 

This is of concern as negative parent and/or GP response could extensively impact the rollout of the NHS Proxy Service. 

We suggest that in the next phase of the Proxy Programme you do the following:



* Test Parental and Child response to NHS Proxy Service Policy ensuring that the users sampled represent a diversity of backgrounds including those with children at a variety of maturity levels and a range of parental responses.
* Test GP response to understand what GP opinions are and how to overcome their concerns.

We suggest these results are then used to formulate communications advisory for Beta/launch phase including user data for national press (if relevant).



### User Acceptance Testing

The user acceptance testing will need to be defined as the project progresses. However, the following have been raised during this phase of the project and are captured here for review in the user research planning phase:


#### Digital credential acceptability

The digital wallet technology that is proposed for the NHS Proxy Service is new. It has been used in user facing applications within the NHS before, to some extent with Covid Passports and to a greater extent within the digital staff passport however, neither scenario are as potentially complex as the proxy scenario.

* Do users like the digital wallet approach 
* Is it simple enough to use (particularly for those with low digital literacy)

#### Proxy approval process and service behaviour

This research needs to be done alongside the Business Analysis and IG Framework workstreams. It will be necessary to test that the proposed ways of working with the GRO and CP-IS are acceptable to the end user. 

For example

* Will the modified parental user experience when registering the birth be acceptable (assuming it is modified to capture non-birth parent’s data)
* Will parents know how to access their child’s health records following the birth registration process?
* Will it be easy to do?
* What about the process for non-birth parents who are added to the birth certificate at a later date – will it work for them?


#### Other questions that could be explored

**Consent models** how do users want to be able to consent to personally delegated proxy access? How frequently do they want to be prompted to review personally delegated access? Do they want it to automatically expire after a certain time?
# Questions arising

The following questions arose during this phase that may need to be answered during a later phase:



* What will a subject want to be able to see in terms of proxy service usage history?
* Will the information added to a subject’s health record / NHS account by a personally delegated proxy, or a legally delegated proxy become part of the subject’s NHS Account? Will the Proxy be able to edit the information they added? Will they be able to view it again if the Subject changes their access rights or their legal role changes? Will this need to be included in a consent?
* Will credible data sources need some sort of interface to add data / manually update data at a record level?
* How will 3<sup>rd</sup> party suppliers interact with the NHS Proxy Service?
* Should the proxy service update PDS?
* Will the NHS Proxy Service be the "Master" for proxy access nationally – does it have a remit beyond the NHS?
* Would there ever be a situation where a social worker would help a parent learn how to manage their child's health and have access to see the child's record (with consent of the parent) in order to do so?
# Conclusion

The NHS Proxy Service is a requirement of the NHS digital estate for the future. Implementing the service is necessary for the digitisation of health records across a full range of applications. 

The NHS Proxy Service cannot be technically be implemented without first delivering the service foundations. We recommend that financial year 2022/23 is spent developing and delivering the foundations.

Once the foundations are complete it will be possible to build the service delivering something that meets peoples needs, whether they are the subject or the proxy. 





# Appendix 1: NHS Proxy Requirements and Business Rules Catalogue

This can be found in the associated excel document “NHS Proxy Requirements and Business Rules Catalogue”.

# Appendix 2: Draft Policy Document

The Proxy Access Policy Framework V.3 Draft is included as a separate document. 

# Appendix 3: CP-IS DPIA

A copy of the CP-IS DPIA is included with this report. 


# Appendix 4: Gantt Chart 2022/2023


![alt_text](images/image34.png "image_tooltip")


![alt_text](images/image35.png "image_tooltip")


<!-- Footnotes themselves at the bottom. -->
## Notes

[^1]:
    
     If the baby is born in England

[^2]:
    
     Since the service went live OPG has provided activation keys for over 1 million LPAs, attorneys on 85,000 LPAs have registered to use the service and 27,000 access codes have been provided to organisations. To date, over 17,900 LPAs have been viewed online by hundreds of different organisations.
