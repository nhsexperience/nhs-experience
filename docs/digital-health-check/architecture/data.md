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
```mermaid!
flowchart TB
    Cohort --> Notify
    Notify --> DHC
    DHC --> HC
    DHC --> SendToGp
    WebClientApi --> Account

    subgraph DHC
    WebApp -->WebClientApi
    
    end

    subgraph Account
    NHSLogin
    API
    DataStore

    end
```
# Sequence
```mermaid!
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
```mermaid!
classDiagram
    Citizen "1"-->"*"  HealthCheck
    Citizen "1"-->"1"  Demographics
    Citizen "1"-->"1" Observations
    Observations "1"-->"*" Observation
    BasicObs "1"-->"1" BMI
    HeartRisk "1"-->"1" QRisk2
    HeartRisk "1"-->"1" QRisk3
    HealthCheck "1"-->"1" BasicObs
    HealthCheck "1"-->"1" HeartRisk
    HealthCheck "1"-->"1" FamilyHistory
    HealthCheck "1"-->"1" SmokingStatus
    HealthCheck "1"-->"1" Cholesterol
    HealthCheck "1"-->"1" Sugar
    HealthCheck "1"-->"1" Bp
    HealthCheck "1"-->"1" Alcohol
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
        + HeartRisk HeartRisk
        + FamilyHistory FamilyHistory
        + SmokingStatus SmokingStatus
        + SmokingStatus SmokingStatus
        + Cholesterol Cholesterol
        + Sugar Sugar      
        + Bp Bp  
        + Alcohol Alcohol
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