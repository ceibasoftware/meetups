$(document).ready(function()
{
    load();
});

function load()
{
    $.ajax(
    {
        type: 'get',
        url: 'api/image'
    }).done(function(result)
    {
        $(result).each(function(index, obj)
        {
            $('#tableBody').append('<tr>');
            $('#tableBody').append("<td><img alt='" + obj.Name + "' src='" + obj.Url + "' title='" + obj.Name + "' /></td>");
            $('#tableBody').append('<td>' + obj.Name +'</td>');
            $('#tableBody').append('<td>' + obj.UploadDate + '</td>');
            $('#tableBody').append('</tr>');
        });
    }).fail(function(xhr, status, error)
    {
        alert(error);
    });
}