---
title: User Process
layout: page
parent: NHS Digital Health Check
nav_order: 1.2
author: Ross Buggins
last_modified_date: Jul 21 2022 at 03:39 PM
---

> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.


# Health Check User Flow
Diagram being built from https://github.com/RossBugginsNHS/nhs-experience/issues/1

```mermaid!
%%{init: 
    { 
        "theme": "dark", 
        "flowchart": 
        {
            "curve": "stepAfter",
            "rightAngles": "false",
            "wrap": "true",
            "diagramPadding": "50"
        }
    } 
}%%
flowchart TB
    Ready-->HCP
    HCP --> |ReqestUpdate|GP
    GP --> |ConfirmedUpdate|HCP
    subgraph Patient
        direction TB
        Ready((Invitee Ready For Health Check))
    end
    
    subgraph HCP
        HCPStartsCheck -->CompleteHC
        CompleteHC --> HCPFinishHC
        HCPFinishHC ---->postHC
        direction TB
        subgraph CompleteHC
            direction TB
            Stage1 -->Stage2
            subgraph Stage1
                direction LR    
                Prelim -->Cardio
                Cardio -->Physical
                    
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
                    EndPhysical[End Physical, Move to Alcohol]
                    
                end
            end    
            subgraph Stage2
                direction LR
                Alcohol -->Diabetic  
                Diabetic -->Dementia
                subgraph Alcohol
                    direction TB
                    StartAlchol -->AssessAlcoholRisk
                    AssessAlcoholRisk --> |Score >8|GiveBriefAlcoholAdvice
                    AssessAlcoholRisk --> |Score >16|SendForCirrhosisAss
                    SendForCirrhosisAss -->|Score>20|ConsiderSpecilistReferal
                    ConsiderSpecilistReferal -->|RiskMeetsHR Criteria|AlchRefToPrimary((refer to primary))
                    GiveBriefAlcoholAdvice --> EndAlcohol[EndAlcohol, Move to Dementia]
                    ConsiderSpecilistReferal --> EndAlcohol
                end          
                subgraph Diabetic
                    direction TB
                    AssessDiabetic --> EndDiabetic
                    AssessDiabetic --> |If required|Complete2ndStage
                    Complete2ndStage -->EndDiabetic
                end 
                subgraph Dementia
                    direction TB
                    RaiseDementiaAwareness
                end 
            end
        end
        subgraph postHC
            direction TB
            CanUpdateRecord{Updates the record}-->|Yes|UpdateRecord
            CanUpdateRecord{Updates the record}-->|No|ToGp   
            ToGp[Send Reuslts to GP to enter] -->|Wait For Response|WaitForConfirmation{{WaitForConfirmation}}
            UpdateRecord -->ResultsAvaliable
            WaitForConfirmation -->|Confirmed|ResultsAvaliable
            ResultsAvaliable{ResultsAvaliable}  
            ResultsAvaliable -->|Yes|Discuss[Discuss Results]
             ResultsAvaliable -->|No|Schedule[Schedule Return Date]
        end    
    end
    
    subgraph GP
        direction TB
        RequestedToUpdateRecord -->GPUpdateRecord
        Asked==>A
    end
```