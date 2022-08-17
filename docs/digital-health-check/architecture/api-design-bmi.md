---
title: API Design - BMI
layout: page
grand_parent: NHS Digital Health Check
parent: Architecture
nav_order: 10.2
---

> ⚠️ **Warning**
>  
> **Draft Documents**: May not represent real world scenarios, may not be fully accurate or complete.
>
> Please contact the author for more information.

<div id="swagger-ui"></div>
<script src="/swagger-ui/swagger-ui-bundle.js" charset="UTF-8"> </script>
<script src="/swagger-ui/swagger-ui-standalone-preset.js" charset="UTF-8"> </script>

<script>
    window.onload = function() {
        window.ui = SwaggerUIBundle({
        url: "https://raw.githubusercontent.com/RossBugginsNHS/nhs-experience/latest/src/projects/digital-health-check/discovery/dhc/src/bmiapi/swagger-v0.1.json",
        dom_id: '#swagger-ui',
        deepLinking: true,
        presets: [
            SwaggerUIBundle.presets.apis,
            SwaggerUIStandalonePreset
        ],
        plugins: [
            SwaggerUIBundle.plugins.DownloadUrl
        ],
        layout: "BaseLayout"
        });
    };
</script>