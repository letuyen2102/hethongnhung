$(function () {

    // First register any plugins
    $.fn.filepond.registerPlugin(FilePondPluginImagePreview);

    // Turn input element into a pond
    $('#employeer_avatar').filepond();

    // Set allowMultiple property to true
    $('#employeer_avatar').filepond('allowMultiple', true);

    // Listen for addfile event
    $('#employeer_avatar').on('FilePond:addfile', function (e) {
        console.log('file added event', e);
    });

});