$(document).ready(function () {
    setModelErrors();
});

function setModelErrors() {

    $('button').click(function () {
        setModelErrorCss();        
    });

    setModelErrorCss();
}


function setModelErrorCss() {
    var container = $('.validation-summary-errors');
    container.addClass('ui message');
    container.children('.header')
        .remove();
    container.prepend(`
                        <div class="header">
                            Invalid Attempt
                        </div>
                        `);
    container.children('ul')
        .addClass('list');
}