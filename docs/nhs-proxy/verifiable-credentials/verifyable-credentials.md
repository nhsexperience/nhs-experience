---
title: Verifiable Credentials
layout: page
parent: NHS Account Proxy
nav_order: 4
has_children: true
todo:
  - Investigate VC for children who do not have Digital Wallets
---
> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.

<details open markdown="block">
  <summary>
    Table of contents
  </summary>
  {: .text-delta }
1. TOC
{:toc}
</details>

<hr/>

# A requirement outside of the NHS
For VC's to be truely useful, the current issuer of traditional proofs of identities and relationships (eg Driving licence, birth certificate, court issues) also need to be issuers of Digital Verifiable Credentials.

## A Lifetime of credentials
Mapping out where credentials could be issued and by who

```mermaid!
sequenceDiagram
    actor Child as Child (Subject)
    actor Mother as Mother
    actor Father
    actor Midwife
    actor Registrar
    participant BNS as Birth Notification Service (BNS)
    participant NHSNno as NHS Number Service
    participant GRO
    participant PR as Office of PR
    participant NHSProxy as NHS Proxy Service
    participant MyNHS as NHS Api 

    Mother->>Child: Gives birth
    Mother-->>Mother: Generate Credential
    Mother-->>Mother: Issues Credential
    Note over Mother,Mother: Issuer: Mother. Credential Type: Relationship
    Note over Mother,Mother:  Holder: Mother. Subject: Mother
    Note over Mother,Mother:  Claims: Relationship=Biological Mother,From=Mother,To=Child
    Note over Mother,Mother:  Warning: "Self Issued" - will not be trusted elsewhere

    Midwife->>+BNS: Registers Child, assigns Mother
    
    BNS-->>Child: NHS Number assigned
    BNS->>-NHSNno: New VC Needed

    NHSNno->>+NHSNno: Generate Credential
    NHSNno-->>-Mother: Issues Credential  
    Note over NHSNno,Mother: Issuer: NHS Number Service. Credential Type: Identity
    Note over NHSNno,Mother: Holder: Mother. Subject: Child
    Note over NHSNno,Mother: Claims: NHS Number, Date of Birth, Birth Location    

    NHSNno->>+NHSNno: Generate Credential
    NHSNno-->>-Mother: Issues Credential 
    Note over NHSNno,Mother: Issuer: NHS Number Service. Credential Type: Relationship
    Note over NHSNno,Mother: Holder: Mother. Subject: Mother
    Note over NHSNno,Mother: Claims: Relationship=Biological Mother,From=Mother,To=Child

    par Paper Based Birth Registration
        Child->>Registrar : Registrar Sees the Child
        Mother->>Registrar : Registrar sees Mothers Paper Id
        Father->>Registrar : Registrar sees Fathers Paper Id
        Registrar->>Registrar: Validates Identities 
        Registrar->>+GRO : Submits Birth Registration
        GRO-->>Child: Birth Cert no Assigned
        GRO->>-Registrar: Issues Birth Certificate                   
    end




    par Mother Issued GRO Credentials
        Registrar->>+ GRO: Registrar Starts Process with GRO System
        Mother->>GRO: Mother Shares Identity Credential with GRO
        Note over Mother,GRO: Issuer: DVLA. Credential Type: Identity        
        GRO->>GRO: Generate Credential
        GRO-->>-Mother : GRO Issues Child Identity Credential for Mother to hold
        Note over GRO,Mother: Issuer: GRO. Credential Type: Identity
        Note over GRO,Mother: Holder: Mother. Subject: Child
        Note over GRO,Mother: Claims: Name, Date of Birth, Birth Location 

        Registrar->>+ GRO: Registrar Starts Process with GRO System
        Mother->>GRO: Mother Shares Identity Credential with GRO
        Note over Mother,GRO: Issuer: DVLA. Credential Type: Identity        
        GRO->>GRO: Generate Credential  
        GRO-->>-Mother : GRO Issues ParentChild Relationship Credential for Mother
        Note over GRO,Mother: Issuer: GRO. Credential Type: Relationship
        Note over GRO,Mother: Holder: Mother. Subject: Mother
        Note over GRO,Mother: Claims: Relationship=ParentChild,From=Mother,To=Child         

        and Father Issued GRO Credentials
        Registrar->>+ GRO: Registrar Starts Process with GRO System
        Father->>GRO: Father Shares Identity Credential with GRO
        Note over Father,GRO: Issuer: Passport Office. Credential Type: Identity        
        GRO->>GRO: Generate Credential
        GRO-->>-Father : GRO Issues Child Identity Credential for Father to hold
        Note over GRO,Father: Issuer: GRO. Credential Type: Identity
        Note over GRO,Father: Holder: Father. Subject: Child
        Note over GRO,Father: Claims: Name, Date of Birth, Birth Location 

        Registrar->>+ GRO: Registrar Starts Process with GRO System
        Father->>GRO: Father Shares Identity Credential with GRO
        Note over Father,GRO: Issuer: Passport Office. Credential Type: Identity        
        GRO->>GRO: Generate Credential  
        GRO-->>-Father : GRO Issues ParentChild Relationship Credential for Father
        Note over GRO,Father: Issuer: GRO. Credential Type: Relationship
        Note over GRO,Father: Holder: Father. Subject: Father
        Note over GRO,Father: Claims: Relationship=ParentChild,From=Father,To=Child             
    end 

    Father->>+PR: Father Applies for PR of Child
    PR->>Father: Request for Proofs of Id and relationship
    par Father Identity
        Father->>PR: Shares Credential
        Note over Father,PR: Issuer: DVLA. Credential Type: Identity
    and Child Identity
        Father->>PR: Shares Credential      
        Note over Father,PR: Issuer: GRO. Credential Type: Identity
    and ParentChild Relationship
        Father->>PR: Shares Credential      
        Note over Father,PR: Issuer: GRO. Credential Type: Relationship                
    end
    PR->>PR: Generate Credential
    PR->>-Father: Issues Credential
    Note over PR,Father: Issuer: PR VC. Credential Type: Relationship
    Note over PR,Father: Holder: Father. Subject: Father
    Note over PR,Father: Claims: Relationship=ParentalResponsibility,From=Father,To=Child         

    Father->>+NHSProxy: Father Applies for NHSProxy access to Child(for Parental responsibility)
    NHSProxy->>Father: Request for Proofs of Id and Parental responsibility
    par Father Identity
        Father->>NHSProxy: Shares Credential
        Note over Father,NHSProxy: Issuer: DVLA. Credential Type: Identity
    and Child Identity
        Father->>NHSProxy: Shares Credential      
        Note over Father,NHSProxy: Issuer: GRO. Credential Type: Identity   
    and Parental Responsibility Relationship
        Father->>NHSProxy: Shares Credential      
        Note over Father,NHSProxy: Issuer: PR Office. Credential Type: Relationship                
    end
    NHSProxy->>NHSProxy: Generate Credential
    NHSProxy->>-Father: Issues Credential
    Note over NHSProxy,Father: Issuer: PR Office. Credential Type: Relationship
    Note over NHSProxy,Father: Holder: Father. Subject: Father
    Note over NHSProxy,Father: Claims: Relationship=ParentalResponsibility,From=Father,To=Child    

    Father->>+MyNHS: Attempts access medical records for child
    MyNHS->>Father: Requests proof
    Father->>MyNHS: Shares credential
    Note over Father,MyNHS: Issuer: PR Office. Credential Type: Relationship    
    MyNHS->>-Father: Child medical records accessed 


```


# What do we need Proving to allow access?

## Access to own records

## Access to anther's records

We need proved:
- The targets identity
- The accessors identity
- The relationship
- That there are no "Restrictions" in places

### What relationships are there?
- Parent to Child
- Power of Attorney
  
### What are restrictions?
- Court Orders
- GP Objections?

### Identifiers
- NHS - NHS Numbers

## Verifiable Credentials for Children - No Digital Wallet
A child (the subject) needs a digital verfiable credential. But without a digital wallet, it needs to be held by someone else (the holder).

https://sphereon.com/verifiable-credentials-example/

Anand is still a toddler and does not have his own digital wallet to hold his Verifiable Credentials. That is not a problem in the W3C Digital Identities system, as it accommodates the concept of Guardianship for minors or incapacitated individuals.

### dId's
A portable URL-based identifier, also known as a DID, associated with an entity. These identifiers are most often used in a verifiable credential and are associated with subjects such that a verifiable credential itself can be easily ported from one repository to another without the need to reissue the credential. An example of a DID is did:example:123456abcdef.

https://www.w3.org/TR/vc-data-model/#dfn-decentralized-identifiers




## Dependency on external issuers for proof of identity, relationships and eligibility restrictions.
```mermaid!
    graph LR
        IdentityCred -->Cit1
        IdentityCred -->Cit2
        RelationshipAToBCred -->Cit1
        AllEligibilitiesCred -->Cit1
        Cit1 ---->|BundlesCreds|NHSProxyCred
        NHSProxyCred ----> |Creds Issued|Cit1

        subgraph Citizens    
            Cit1
            Cit2
            Cit2 -->|SharesIdentity|Cit1
        end
        subgraph ExternalIssuers  
            subgraph Identity
                BirthCert --> IdentityCred
                DVLA --> IdentityCred
                NHSLogin --> IdentityCred
                Passport --> IdentityCred
                DVLA
                NHSLogin
                Passport
            end
            subgraph Relationships
                ParentChildCred -->RelationshipAToBCred
                PoACred --> RelationshipAToBCred

                subgraph ParentChild
                    BirthCertificate --> ParentChildCred
                    AdoptionCertificate --> ParentChildCred
                    NHSBiologicalMother --> ParentChildCred
                end
                subgraph PoA
                    CourtPoACert --> PoACred
                    
                end
                
            end
            subgraph Eligibility
                NoCourtRestrictions -->AllEligibilitiesCred
                NoLocalCouncilRestrictions -->AllEligibilitiesCred
                AllEligibilitiesCred
            end
        end
        subgraph NHS Citizen Authorisation
            NHSProxyCred
        end
```