window.onload = function() {
    const gallery = document.querySelectorAll("img") 
    gallery.forEach(image => 
        { 
            let src = image.getAttribute('src') 
          
            image.addEventListener('click', function () 
            { 
                window.open(src) 
            } )

            image.addEventListener('mouseover', (event) => 
            { 
                event.target.style.cursor = "pointer";
            });
        }) 
};
      