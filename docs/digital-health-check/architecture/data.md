---
title: Data
layout: page
grand_parent: NHS Digital Health Check
parent: Architecture
nav_order: 7
todo:
    - Complete Data Classes
    - Complete Data to snowmed mapping table
    - 
---

> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.


# Interactions
```mermaid
flowchart TB
    linkStyle default interpolate basis
    Cohort --> Notify
    Notify --> DHC
    DHC --> HC
    DHC --> SendToGp
    WebClientApi --> Account

    subgraph DHC[Digital Health Check]
    WebApp -->WebClientApi
    
    end

    subgraph Account
    NHSLogin
    API
    DataStore
    end

    subgraph Intervention
    OfferedInterventions
    end
```
# Sequence
```mermaid
sequenceDiagram
    NHS->>Citizen: Invite
    Citizen->>HP: Complete HC
    HP->>GP: SendResults
    HP-->Citizen: Send for furthur
    Citizen-->Pro: Furthur Screening
    GP->>Record: Update Details
    GP->>HP: Send update
    HP->>Citizen: Discuss Results
```

# Health Check Data Classes
```mermaid
%%{init: 
    { 
        "flowchart": 
        {
            "curve": "linear",
            "rightAngles": "false",
            "wrap": "true",
            "diagramPadding": "50"
        }
    } 
}%%
classDiagram-v2
    direction LR
    Citizen "1"-->"*"  HealthCheck
    Citizen "1"-->"1"  Demographics
    Citizen "1"-->"1" Observations
    Observations "1"-->"*" Observation
    BasicObs "1"-->"1" BMI
    HeartRisk "1"-->"1" QRisk2
    HeartRisk "1"-->"1" QRisk3
    HealthCheck "1"-->"1" HealthCheckStatuses
    HealthCheck "1"-->"1" HealthCheckInterventions
    HealthCheck "1"-->"1" BasicObs
    HealthCheck "1"-->"1" FamilyHistory
    HealthCheckStatuses "1"-->"1" HeartRisk
    HealthCheckStatuses "1"-->"1" SmokingStatus
    HealthCheckStatuses "1"-->"1" Cholesterol
    HealthCheckStatuses "1"-->"1" Sugar
    HealthCheckStatuses "1"-->"1" Bp
    HealthCheckStatuses "1"-->"1" Alcohol
    HealthCheckStatuses "1"-->"1" PhysicalActivity

    HealthCheckInterventions "1"-->"1" SmokingIntervention
    HealthCheckInterventions "1"-->"1" DiabetesIntervention
    HealthCheckInterventions "1"-->"1" BpIntervention
    HealthCheckInterventions "1"-->"1" WeightIntervention
    HealthCheckInterventions "1"-->"1" DietIntervention
    HealthCheckInterventions "1"-->"1" PhysicalActivityIntervention
    HealthCheckInterventions "1"-->"1" LifestyleIntervention
    HealthCheckInterventions "1"-->"1" AlcoholIntervention
    HealthCheckInterventions "1"-->"1" DementiaIntervention


    class Citizen{
        +Demographics Demographics
        +Observations Observations
        +List~HealthCheck~ HealthChecks
    }
    class Demographics{
        +string Name
        +int Age
    }
    class Observations{
         +List~Observation~ Observations
    }
    
    class Observation{
        
    }

    class HealthCheck{
        + BasicObs BasicObs
        + FamilyHistory FamilyHistory
        + HealthCheckStatuses HealthCheckStatuses
    }

    class HealthCheckStatuses{
        + HeartRisk HeartRisk
        + SmokingStatus SmokingStatus
        + Cholesterol Cholesterol
        + Sugar Sugar      
        + Bp Bp  
        + Alcohol Alcohol
        +PhysicalActivity PhysicalActivity
    }

    class HealthCheckInterventions{
        + SmokingIntervention SmokingIntervention
        + DiabetesIntervention DiabetesIntervention
        + BpIntervention BpIntervention
        + WeightIntervention WeightIntervention
        + DietIntervention DietIntervention
        + PhysicalActivityIntervention PhysicalActivityIntervention
        + LifestyleIntervention LifestyleIntervention
        + AlcoholIntervention AlcoholIntervention
        + DementiaIntervention DementiaIntervention
    }

    class BasicObs{
        + distance Height
        + mass Weight
        + distance WaistCircumference
        + BMI Bmi

    }

    class BMI {
        + int Value
    }

    class HeartRisk{
        + qrisk2 QRisk2
        + qrisk3 QRisk3
    }

    class QRisk2{
        + int HeartAge
        + int RiskScore
    }

    class QRisk3{
        + int HeartAge
        + int RiskScore
    }    

    class FamilyHistory{
     + string History?
    }   

    class SmokingStatus{
        + bool Ex
        + bool Heavy
        + bool HeavyCig
        + bool VeryHeavy
        + bool Light
        + bool Moderate
        + bool Non
        + bool Never
    }

    class Cholesterol{
        + int total
        + int TotalSerum
        + int HDL
        + int noHDL
        + int Ration
    }

    class Sugar{
        + int Triglycerides
        + int SerumTriglycerides
        + int hb1
        + int fpg
    }

    class Bp{
        + int Systolic
        + int Diastolic
    }

    class Alcohol{
        + int ConsumtionScore
        + int ScreeningTestScore
    }

    class PhysicalActivity{
        + bool Declined
        + bool Active
        + bool Inactive
        + bool ModeratelyActive
        + bool ModeratelyInactive
    }

    class SmokingIntervention{
        + bool CessationEducation
        + bool EffectsEducation
        + bool BriefIntervention
        + bool Signposting
        + bool Referral
    }   

    class DiabetesIntervention{
        + bool ReferralLifeStyle
        + bool ReferralPrevention
        + bool referralPreventionDeclined
    } 

    class BpIntervention{
        + bool LifestyleEducation
    }

    class WeightIntervention{
        + bool Advised
        + bool Signposts
        + bool Intervention
        + bool InterventionDeclined
        
    }

    class DietIntervention{
        + bool Education
        + bool Referral
    }

    class PhysicalActivityIntervention{
        + bool guidance
        + bool Signposted
        + bool Intervention
        + bool InterventionDeclined        
    }

    class LifestyleIntervention{
        + bool Education
        + bool ReferralEducation
        + bool ReferralProgram
    }

    class AlcoholIntervention{
        + bool EducationDeclined
        + bool Education
        + bool Signposting
        + bool Intervention
        + bool InterventionDeclined
        + bool Referral
    }

    class DementiaIntervention{
        + bool Signposted
        + bool Awareness
    }


```

[View Swaggerhub OpenAPI v3]({% link digital-health-check/data-swagger/html2/index.html %})

[Swaggerhub Source](https://app.swaggerhub.com/apis/RossBugginsNHS/hc1/v0.1#/)

## Data Mapping to SNOWMED Codes

QRISK Snowmed lookup: https://termbrowser.nhs.uk/?perspective=full&conceptId1=810931000000108&edition=uk-edition&release=v20220706


[View it on GitHub]({{ site.gh_edit_repository }}/{{ site.gh_edit_view_mode }}/{{ site.gh_edit_branch }}{% if site.gh_edit_source %}/{{ site.gh_edit_source }}{% endif %}/_data/dhc-class-properties.tsv){: .btn .fs-5 .mb-4 .mb-md-0 }

<table>
  {% for row in site.data.dhc-class-properties  %}
    {% if forloop.first %}
    <tr>
      {% for pair in row %}
        <th>{{ pair[0] }}</th>
      {% endfor %}
    </tr>
    {% endif %}

    {% tablerow pair in row %}
      {{ pair[1] }}
    {% endtablerow %}
  {% endfor %}
</table>