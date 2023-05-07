var fs = require('fs');

// Load Asciidoctor.js and the reveal.js converter
var asciidoctor = require('@asciidoctor/core')()
var asciidoctorRevealjs = require('@asciidoctor/reveal.js')
asciidoctorRevealjs.register()

// Enable Diagram support via Kroki
var kroki = require('asciidoctor-kroki')
kroki.register(asciidoctor.Extensions)
const registry = asciidoctor.Extensions.create()
kroki.register(registry)

// Convert the document 'presentation.adoc' using the reveal.js converter
var options = { 
    safe: 'unsafe',
    backend: 'revealjs', 
    mkdirs: true, 
    to_dir: 'public', 
    to_file: 'index.html',
    base_dir: '.'
}
asciidoctor.convertFile('presentation.adoc', options)

// copy directory
fs.cp('./assets', './public/assets', { recursive: true }, (err) => {
    if (err) {
      console.error(err);
    }
});

// https://docs.asciidoctor.org/reveal.js-converter/latest/converter/revealjs-options/
// https://docs.asciidoctor.org/reveal.js-converter/latest/converter/syntax/syntax-highlighting/
// https://docs.asciidoctor.org/reveal.js-converter/latest/converter/syntax/admonitions/