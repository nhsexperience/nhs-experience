---
title: User Process
layout: page
parent: NHS Digital Health Check
nav_order: 1.2
---

> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.

# Health Check User Flow
Diagram being built from https://github.com/RossBugginsNHS/nhs-experience/issues/1

```mermaid!
flowchart TB
    
    Ready((Invitee Ready For Health Check))-->HCP

    subgraph Patient
        direction TB
        Ready((Invitee Ready For Health Check))
    end

    subgraph HCP
        Prelim -->Cardio
        Cardio -->Physical
        Physical -->Alcohol
        subgraph Prelim[Prelim Details]
            direction TB
            ConfirmA[Confirm Age] -->Gender[Record Gender]
            Gender-->Ethnicity
            Ethnicity-->Smoking
            Smoking-->FamilyCardio
        end        
        
        subgraph Cardio[Cardio Test]
            direction TB
            StartCardio{Start Cardio} -->BMI
            BMI-->Colesterol
            Colesterol-->BP
            BP -->EndCario{End Cardio}
        
        end

        subgraph Physical
            direction TB
            StartPhysical{Start Physical} -->AssessPhysical
            AssessPhysical -->ConsiderExcecise
            AssessPhysical -->PhysicalAdvice
            AssessPhysical --> EndPhysical
            ConsiderExcecise --> EndPhysical
            PhysicalAdvice --> EndPhysical
            EndPhysical{End Physical}
        end

        subgraph Alcohol
            direction TB
            AssessAlcoholRisk
            
        end        
    end
```