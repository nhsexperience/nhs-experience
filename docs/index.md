---
title: Home
layout: home
nav_order: 1
last_modified_date: Jul 15 2022 at 03:39 PM
---
> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.

> ⚠️ **Warning**
>  
> **FORK**: This is a fork of https://github.com/nhsexperience/nhs-experience.
> - [Origin github - https://github.com/RossBugginsNHS/nhs-experience/tree/v0.1.2-alpha](https://github.com/RossBugginsNHS/nhs-experience/tree/v0.1.2-alpha)
> - [Upstream site - https://zealous-beach-05e189903.1.azurestaticapps.net](https://zealous-beach-05e189903.1.azurestaticapps.net)
> - [Upstream github - https://github.com/nhsexperience/nhs-experience](https://github.com/nhsexperience/nhs-experience)
>
> [Fork Etiquette](/process/fork-etiquette.html)
> 
> Please contact the author for more information.
# Todo:

- Auto build .drawio to .svg
- OpenAPI support
- Add items to todo

# Citizen Experience

{% if
    site.gh_edit_link and
    site.gh_edit_link_text and
    site.gh_edit_repository and
    site.gh_edit_branch and
    site.gh_edit_view_mode
%}
[Get started now](/contributing.html){: .btn .btn-primary .fs-5 .mb-4 .mb-md-0 .mr-2 } [View it on GitHub]({{ site.gh_edit_repository }}/{{ site.gh_edit_view_mode }}/{{ site.gh_edit_branch }}{% if site.gh_edit_source %}/{{ site.gh_edit_source }}{% endif %}/{{ page.path }}){: .btn .fs-5 .mb-4 .mb-md-0 }
{% endif %}


## What is Citizen Experience?

---
# Posts
<ul>
    {% for post in site.posts %}
      <li>
        <a href="{{ post.url }}">{{post.date| date: "%-d %B %Y" }}: {{post.author }} - {{ post.title }}</a>
      </li>
    {% endfor %}
</ul>
# Source and build details
  
  
[View it on GitHub]({{ site.gh_edit_repository }}/{{ site.gh_edit_view_mode }}/{{ site.gh_edit_branch }}/samples/nhs-login-client/Client){: .btn .fs-5 .mb-4 .mb-md-0 }


## Open Source Location


|                           | Source and build details                                                             |
| :------------------------ | :----------------------------------------------------------------------------------- |
| Repo                      | {{ site.gh_edit_repository }}                                                        |
| Branch                    | {{ site.gh_edit_branch }}                                                            |
| Link                      | {{ site.gh_edit_repository }}/{{ site.gh_edit_view_mode }}/{{ site.gh_edit_branch }} |
| Site                      | {{ site.published_url }}                                                             |
| Latest Release            | Test release v0.1.0-alpha                                                            |
| Latest Release Tag        | v0.1.0-alpha                                                                         |
| Latest Stable Release     | n/a                                                                                  |
| Latest Stable Release Tag | n/a                                                                                  |

- [Latest Release]({{ site.gh_edit_repository }}/releases/latest)
- ![Azure CI/CD]({{ site.gh_edit_repository }}/actions/workflows/{{ site.gh_action_build_file_name }}/badge.svg?branch={{ site.gh_edit_branch }})

## Upstream Open Source Location

|                           | Source and build details                              |
| :------------------------ | :---------------------------------------------------- |
| Owner                     | nhsexperience                                         |
| Repo                      | nhs-experience                                        |
| Branch                    | main                                                  |
| Link                      | https://github.com/nhsexperience/nhs-experience       |
| Site                      | https://zealous-beach-05e189903.1.azurestaticapps.net |
| Latest Release            | Test release v0.1.0-alpha                             |
| Latest Release Tag        | v0.1.0-alpha                                          |
| Latest Stable Release     | n/a                                                   |
| Latest Stable Release Tag | n/a                                                   |

- [Latest Release](https://github.com/nhsexperience/nhs-experience/releases/latest)
- ![Azure CI/CD](https://github.com/nhsexperience/nhs-experience/actions/workflows/azure-static-web-apps-zealous-beach-05e189903.yml/badge.svg?branch=main)