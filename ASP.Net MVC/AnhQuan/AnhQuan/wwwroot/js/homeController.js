var homeController = {
    init: function () {
        homeController.registerEvent();
       
    },
    registerEvent: function () {
        homeController.loadData();
    },
    loadData: function () {
        $.ajax({
            url: '/Home/LoadData',
            type: 'GEt',
            dataType: 'json',
            success: function (response) {
                if (response.status) {
                   
                    var data = response.data;
                    var html = '';
                    var template = $('#data-template').html();
                    $.each(data, function (i, item) {                    
                        html += Mustache.render(template, {
                            ID: item.ID,
                            Name: item.Name,
                            Salary: item.Salary,
                            Status: item.Status
                               
                        });
                        alert(1);
                    });
                    $('#tblData').html(html);
                }
            }
        })
    }
}
homeController.init();