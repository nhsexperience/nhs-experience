---
title: Posts
layout: home
nav_order: 600
---
> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.
> 
# Latest Posts
<ul>
    {% for post in site.posts %}
      <li>
        <a href="{{ post.url }}">{{post.date| date: "%-d %B %Y" }}: {{post.author }} - {{ post.title }}</a>
      </li>
    {% endfor %}
</ul>