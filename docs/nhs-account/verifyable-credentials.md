---
title: Verifyable Credentials
layout: page
parent: NHS Account
nav_order: 4
has_children: true
---
> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.

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
- 

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