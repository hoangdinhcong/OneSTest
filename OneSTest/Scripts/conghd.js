
//Initialization of treeviews
$('#tree3').treed({ openedClass: 'glyphicon-chevron-right', closedClass: 'glyphicon-chevron-down' });


$(function () {

    $('#show').on('click', function () {
        $('.card-reveal').slideToggle('slow');
    });

    $('.card-reveal .close').on('click', function () {
        $('.card-reveal').slideToggle('slow');
    });
});