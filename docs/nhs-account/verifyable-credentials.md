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

## Dependency on external issuers for proof of identity, relationships and eligibility restrictions.
```mermaid!
    graph LR
        IdentityCred -->Cit1
        IdentityCred -->Cit2
        RelationshipAToBCred -->Cit1
        AllEligabilitiesCred -->Cit1
        Cit1 <-->|BundlesCreds and is issued|NHSProxyCred

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
            subgraph Eligability
                NoCourtRestrictions -->AllEligabilitiesCred
                NoLocalCouncilRestrictions -->AllEligabilitiesCred
                AllEligabilitiesCred
            end
        end
        subgraph NHS Citizen Authorisation
            NHSProxyCred
        end
```