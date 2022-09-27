<!-- .slide: data-background-image="https://images.pexels.com/photos/814544/pexels-photo-814544.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" -->
## PROXY <!-- .element: class="r-fit-text" style="color:red;" -->

---
### What does the word  mean to you?

The OED states: <!-- .element: class="fragment" data-fragment-index="1"  -->

*"Authority given to a person to act for someone else"* <!-- .element: class="fragment" data-fragment-index="2"  -->

---
## But is there more to it?

---
## Confusion of Proxy and Authorisation

---
## The Act of "Giving Proxy"

The act of giving someone proof that they can act for you

---
## Proxy Service: Taking that proof....

And Updating Roles....

---
## A Citizen RBAC

---
## That's all well and good

But... The Data

What resources/data is going to use the RBAC?

---

<div class="mermaid r-stretch">
flowchart LR;
</div>

---

<div class="mermaid r-stretch">
flowchart LR;
SomeExternalProof-->ProxyService;
</div>

---

<div class="mermaid r-stretch">
flowchart LR;
SomeExternalProof-->ProxyService;
ProxyService-->RBAC;
</div>

---

### So why is proxy needed?

When if you have RBAC - someone can just give the roles

---

### Proxy Service

- Forces an update to those roles

--- 

# The "Proof" is the "easy" part

- Verifyable Creds
- Distributed Ids
- Fairly standard Tech now

---

# A Citizen RBAC on the other hand...

- Assume its been tried before?
- Can we look at Solid Pods to store the Role assignments?

--- 

# Data Data Data

- "The NHS" - biggest misconception that citizens have?
- Does this illusion lead to high expectations of citizen data access?

