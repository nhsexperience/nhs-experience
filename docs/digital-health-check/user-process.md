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
        direction TB
        Stage1 -->Stage2
        subgraph Stage1
            direction LR
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
                StartCardio[Start Cardio] -->BMI[Calculate BMI]
                BMI-->Cholesterol[Test cholesterol]
                Cholesterol <-->|Meets HR criteria|ColRefToPrim((refer to primary))
                Cholesterol-->BP
                BP <-->|Meets HR criteria|BPRefToPrim((refer to primary))
                BP -->EndCario[End Cardio, Move to Physical]          
            end
            subgraph Physical
                direction TB
                StartPhysical[Start Physical] -->AssessPhysical
                AssessPhysical -->ConsiderExercise
                AssessPhysical -->PhysicalAdvice
                AssessPhysical --> EndPhysical
                ConsiderExercise --> EndPhysical
                PhysicalAdvice --> EndPhysical
                EndPhysical[End Physical]
            end
            subgraph Alcohol
                direction TB
                AssessAlcoholRisk
            end            
        end
        subgraph Stage2
            direction LR
            Diabetic -->Dementia
            subgraph Diabetic
                direction TB
                AssessDiabetic
            end 
            subgraph Dementia
                direction TB
                AssessDementia
            end 
        end
    end
```