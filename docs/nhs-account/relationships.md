---
title: Relationships
layout: page
grand_parent: NHS Account
parent:  Verifyable Credentials
nav_order: 4.1
author: Ross Buggins
last_modified_date: Jul 21 2022 at 11:59 PM
---

> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.

## Relationships for Medical Record Access

|                                                             | From                                 | To    | Proof                                          | Issuer |
| ----------------------------------------------------------- | ------------------------------------ | ----- | ---------------------------------------------- | ------ |
| [🔗]({% link nhs-account/relationships-parent-child.md %}) | Biological Mother                    | Child | NHS "At Birth"                                 | NHS    |
|                                                             | Parent                               | Child | Birth Certificate                              | GRO    |
|                                                             | Parent                               | Child | Adoption Certificate                           | GRO    |
|                                                             | Guardian                             | Child | Guardianship                                   | ???    |
|                                                             | Married Partner of Biological Mother | Child | Marriage Certificate + (Mother to Child Proof) | GRO    |

# Diagrams of Parental Responsibility
**Key**
- Circle - Holder of rights
- Diamond - Subject of the rights
- Hexagon - Rights gained
- Parallelogram - Not a rights holder  
 ---

```mermaid!
flowchart LR
Male[/Male/]
Female((Female))
Conceive
Birth
Child{Child}
MothersRight{{Mothers Parental Responsibility}}

Male-->Conceive
Female-->Conceive
Conceive-->Birth
Birth -.->MothersRight
MothersRight -.->Female
MothersRight -.->Child
```
*Figure [^motherFatherUnmarried].  Unmarried Mother and Father* 

---
```mermaid!
flowchart LR
Male[/Male/]
Female[/Female/]
MarriedMale((Married Male))
MarriedFemale((Married Female))
Married
Conceive
Birth
Child{Child}
MothersRight{{Mothers Parental Responsibility}}
FathersRight{{Fathers Parental Responsibility}}

Birth -.->MothersRight
Birth -.->FathersRight
Male-->Married
Female-->Married
Married-->MarriedMale
Married-->MarriedFemale
MarriedMale-->Conceive
MarriedFemale-->Conceive
Conceive-->Birth
MothersRight -.->Child
FathersRight -.->Child

FathersRight -.->MarriedMale
MothersRight -.->MarriedFemale
```
*Figure [^marriedmotherandfather].  Married Mother and married biological Father* 

---
```mermaid!
flowchart LR
Male
Female
MarriedMale((Married Male))
MarriedFemale((Married Female))
OtherMale[/Other Male/]
Married
Conceive
Birth
Child{Child}
MothersRight{{Mothers Parental Responsibility}}
FathersRight{{Fathers Parental Responsibility}}

Male-->Married
Female-->Married
Married-->MarriedMale
Married-->MarriedFemale
OtherMale-->Conceive
MarriedFemale-->Conceive
Conceive-->Birth
Birth -.->MothersRight
Birth -.->FathersRight
MothersRight -.->Child
FathersRight -.->Child
FathersRight -.->MarriedMale
MothersRight -.->MarriedFemale
```
*Figure [^marriedmotherandotherfather].  Married Mother and other biological Father* 

---

```mermaid!
flowchart LR
Male((Male))
Female((Female))
Conceive
Birth
Child{Child}
MothersRight{{Mothers Parental Responsibility}}
BirthCertificate
FathersRights{{Fathers Parental Responsibility}}

Birth -.->MothersRight
Birth --> BirthCertificate
Male-->Conceive
Female-->Conceive
Conceive-->Birth
MothersRight -.->Female
MothersRight -.->Child
Male-->BirthCertificate
Female-->BirthCertificate
Child-->BirthCertificate
BirthCertificate-.->FathersRights

FathersRights -.->Male
FathersRights -.->Child
```
*Figure [^motherFatherUnmarried-with-birth-cert].  Unmarried Mother and Father with birth certificate* 

[^motherFatherUnmarried]: Unmarried Mother and Father
[^marriedmotherandfather]: Married Mother and biological Father
[^marriedmotherandotherfather]: Married Mother and other biological Father
[^motherFatherUnmarried-with-birth-cert]:  Unmarried Mother and Father with birth certificate