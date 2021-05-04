
$(document).ready(function(){
    $("#btnRut").click(function(){
      var rut = $("rutForm").val();
      var request = {
        rut:rut
      }
      alert(rut);
      $.ajax({
        type: "POST",
        url:'http://localhost/Projects/New%20Rest/Rest%20Web/public/api/rut',
        data:JSON.stringify(request),
        dataType: 'json',
        contentType: 'application/json',
        success:function(data){
          $("#dv").html(data);
        }
      });
    });
  });
