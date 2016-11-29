(function () {
    "use strict";

    $.getJSON("api/getaccounts", {}, function (d) {
        
        var txt = "";
        for (var i = 0; i < d.length; i++) {
            txt += d[i].Name + " ";
        }
        $("#container").html(txt);

    });

    $.getJSON("api/getaccount", {id: 100}, function (d) {
        console.log(d);
    });

    $("#btn").click(function () {
        var id= $("#txtId").val();
        $.getJSON("api/getaccount", { id: id  }, function (d) {
            console.log(d);
        });
    });
    



})();