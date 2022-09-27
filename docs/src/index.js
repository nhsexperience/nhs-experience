import { Canvg, presets} from 'canvg';
import Reveal from 'reveal.js'
import RevealMarkdown from 'reveal.js/plugin/markdown/markdown.esm.js'
import Markdown from  'reveal.js/plugin/markdown/markdown.esm.js'
import 'reveal.js/dist/reveal.css'
import 'reveal.js/dist/theme/black.css'
import '@fontsource/source-sans-pro'

const preset = presets.offscreen()

var x = RevealMarkdown;
var $ = require("jquery");
global.jQuery = $;
global.$ = $;
window.jQuery = $;
window.$ = $;

export function UseReveal(document, deckid, useMermaid, mermaidSelector = 'code.mermaid', embed = true )
{
  
    $(document).ready(LoadUpReveal(document, deckid, useMermaid, mermaidSelector, embed));
}

async function sleep(ms) {
    await new Promise(r => setTimeout(r, ms));
}

function LoadUpReveal(document, deckid, useMermaid, mermaidSelector = 'code.mermaid', embed = true )
{
    var sleepTime = 100;
    var selectorToUse = 'div.'+ deckid + ' > div.slides > section.present > div.mermaid, div.'+ deckid + ' > div.slides > section.present > pre > code.mermaid';

    let deck1 = new Reveal( document.querySelector('div.'+ deckid), {
        embedded: embed,
        keyboardCondition: 'focused',
        controls: true,
        controlsTutorial: true,
        controlsLayout: 'bottom-right',
        controlsBackArrows: 'faded',
        progress: true,
        slideNumber: true,
        showSlideNumber: 'all',
        loop: true,
        plugins: [ RevealMarkdown ],
        backgroundTransition: 'none',
        transition: 'none',
        center: false,
    } );
    deck1.initialize().then( async () => {
        if(useMermaid)
            await sleep(sleepTime);
            UseMermaidNow(document, selectorToUse);
      } )


    deck1.on('slidechanged',  async (event) => {
        if(useMermaid)
        {
            await sleep(sleepTime);
            RemoveProcessed(event.previousSlide);
            UseMermaidNow(document, selectorToUse);
        }
      } );
    
    deck1.on('slidetransitionend', event => {
       
        // event.previousSlide, event.currentSlide, event.indexh, event.indexv
      } );
}

function RemoveProcessed(deckid)
{
    var processedAttribName = 'data-processed';
    var selectorToUse = 'div.'+ deckid + ' > div.slides > section > div.mermaid[data-processed], div.'+ deckid + ' > div.slides > section > pre > code.mermaid[data-processed]';
    var toRender = document.querySelectorAll(selectorToUse);
    toRender.forEach((item)=>
    {
        if(item.hasAttribute(processedAttribName))
        {
            while (item.firstChild) {
                item.removeChild(item.firstChild);
              }
            item.removeAttribute(processedAttribName);        
            
            var rawCode = item.getAttribute('rawCode');
            item.innerHTML = rawCode;
        }
    });
    var toRenderCheck = document.querySelectorAll(selectorToUse);
}

export function MermaidInit(addlinks=true)
{
    mermaid.initialize({
        logLevel: 1,
        startOnLoad: true,
        flowchart: { useMaxWidth: false, htmlLabels: false },
        mermaid: {
            callback: function(id) {
                if(addlinks)
                {
                    console.log(id);
                    addLinks(id);
                }
            },
        },
    });
}

function UseMermaidNow(document, selector='.language-mermaid', excludeSelector='')
{
    if(excludeSelector!='')
    {        
        var toExclude = document.querySelectorAll(excludeSelector);
    }
    var toRender = document.querySelectorAll(selector);
    toRender.forEach(item =>
        {
            if(!item.hasAttribute('rawCode'))
                item.setAttribute('rawCode', item.innerHTML);
        });

    window.mermaid.init(undefined, toRender);
}

export function UseMermaid(document, addlinks=true, selector='.language-mermaid', excludeSelector='div.slides > section')
{
    $(document).ready(function() {
        MermaidInit(addlinks);
        UseMermaidNow(document, selector, excludeSelector);
    });
}

function addLinks(id)
{
    var svg = document.getElementById(id);
    var btn = document.createElement('button'); 
    btn.id = id +"_button";
    var pre = svg.parentNode.parentNode;
    pre.id = id + "_pre";
    btn.innerHTML = "View diagram as PNG (" + id + ")";

    //Remove to enable the png button.
    btn.style.display = "none";

    svg.parentNode.parentNode.before(btn);
   
    svg.addEventListener('mouseover', (event) => 
    { 
        event.target.style.cursor = "pointer";
    });

    svg.addEventListener('click', (event) => 
    { 
        console.log(event);
        var pngVersion = document.getElementById(id+"_png");
        if(pngVersion)
        {
            window.open(pngVersion.src)
        }
        else
        {
            drawCanvas(id, (img)=>
            {
                img.style.display = "none";
                var p = document.createElement('p'); 
                btn.after(p);
                p.appendChild(img);
                window.open(img.src); 
            });
        }
    });

    btn.addEventListener('click', function () 
    { 
        var pngVersion = document.getElementById(id+"_png");
        if(pngVersion)
        {
            if (pngVersion.style.display === "none") {
                pngVersion.style.display = "block";
                pre.style.display = "none";
                btn.innerHTML = "View diagram as SVG (" + id + ")";
              } 
              else {
                pngVersion.style.display = "none";
                pre.style.display = "block";
                btn.innerHTML = "View diagram as PNG (" + id + ")";
              }
        }
        else
        {
            btn.innerHTML = "View diagram as SVG (" + id + ")";
            drawCanvas(id, (img)=>
            {
                img.style.display = "block";
                var p = document.createElement('p'); 
                btn.after(p);
                p.appendChild(img);
                pre.style.display = "none";
            });
        }
    });
}

function drawCanvas(id, callback)
{

    var svg = document.getElementById(id);
    var { width, height } = svg.getBoundingClientRect();
    var pixelRatio = 2;//window.devicePixelRatio || 1;

    // lets scale the canvas and change its CSS width/height to make it high res.
      //  canvas.style.width = canvas.width +'px';
    var newWidth = width * pixelRatio;
    var newHeight = height * pixelRatio;

        
    var canvas =  canvas = new OffscreenCanvas(newWidth, newHeight);// document.createElement('canvas'); // Create a Canvas element.
    var ctx = canvas.getContext('2d'); // For Canvas returns 2D graphic.

   // ctx.fillStyle = 'white'; // background color for the canvas
   // ctx.fillRect(0, 0, width, height); // fill the color on the canvas


// Now that its high res we need to compensate so our images can be drawn as 
//normal, by scaling everything up by the pixelRatio.
  //  ctx.setTransform(pixelRatio,0,0,pixelRatio,0,0);

    var img =  document.createElement('img');
    var data = svg.outerHTML; // Get SVG element as HTML code.
    Canvg.from(ctx, data, preset)
        .then(result =>
            {
                result.resize(canvas.width, canvas.height, 'xMidYMid meet');
                result.render()
                    .then(function()
                    {
                       // toDataURL return DataURI as Base64 format.
                         img.id=id+"_png";
                         
                         canvas.convertToBlob()
                            .then(blobresult=>
                                {
                                    img.src = URL.createObjectURL(blobresult);
                                    callback(img);
                                });

                         //img.style.width = width +'px';
                       
                    });
        });
}