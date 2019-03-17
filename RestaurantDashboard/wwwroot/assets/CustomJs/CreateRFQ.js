

function AddRowsToRFQItemsTable(List) {

    var mailingListTableData = $("#tblListFieldData").children('thead').children('tr');

    mailingListTableData.each(function (i, el) {
        var $tds = $(this).find('th');
        var $trs = $('#tblListFieldData tr');

        var k = $('#tblListFieldData tr').length - 1;

        var rowsData = "";
        if (k == 0) {
            rowsData = "<tr id=Row_" + k + ">";
            rowsData += "<td id=ProductDiv_" + k + "><select name='ProductId' id=ProductName_" + k + " class='select2'></select></td>";
        }
        else {

            k = parseInt($trs[k].cells[0].children[0].id.toString().substring(12)) + 1;
            rowsData = "<tr id=Row_" + k + ">";
            rowsData += "<td id=ProductDiv_" + k + "></td>";
        }
        rowsData += "<td><input name='Description' id=Description_" + k + " class=\"form-control \" value=\"\"  /></td>";
        rowsData += "<td><input name='Sku' id=Sku_" + k + " class=\"form-control \" value=\"\"/></td>";
        rowsData += "<td><input name='Quantity' id=Quantity_" + k + " class=\"form-control \" value=\"\"  /></td>";
     
      
        rowsData += "<td><a id = remove_" + k + "> <i class=\"s-24 icon-cancel red-text\"></i></a ></td>";
        rowsData += "</tr>";


        if (k != 0) {

            var ddlId = $trs[1].cells[0].children[0].id;
            var ddl = $("#" + ddlId.toString()).clone();


            //Set the ID and Name
            ddl.attr("id", "ProductName_" + k);
            ddl.attr("name", "ProductId");

            $("#divListFieldRows").append(rowsData);
            $("#ProductDiv_" + k).append(ddl);
            ddl.select2();


        }
        else {
            $("#divListFieldRows").append(rowsData);
            $("#ProductName_0").html("");
            $("#ProductName_0").append(
                $('<option></option>').val("0").html("Select Product"));
            $.each(List.data, function (i, item) {
                $("#ProductName_0").append(
                    $('<option></option>').val(item.value).html(item.text + " ( " + item.Column2 + " )"));
            });

            $("#ProductName_0").select2();
        }


        $("#remove_" + k + "").click(function () {
            $("#Row_" + k + "").remove();
           
        });
        $("#ProductName_" + k + "").change(function () {

            var arrayindex = List.data.findIndex(function (row) {
                return row.value == $("#ProductName_" + k + "").val();;
            });
            var arrayData = List.data[arrayindex];
            document.getElementById("Quantity_" + k + "").value = "1";
            document.getElementById("Description_" + k + "").value = arrayData.Column4;
            document.getElementById("Sku_" + k + "").value = arrayData.Column2 ;
          

        });


   

    });


    function PostAddItemToRFQ(k, RfqId) {

        var jsonData = {
            RfqId: RfqId,
            ProductName: $("#ProductName_" + k).val(),
            Quantity: $("#Quantity_" + k).val(),
            Sku: $("#Sku_" + k).val(),
            Description: $("#Description_" + k).val(),
        };

        $.post("/Customer/AddProductToOrderDetails",

            jsonData
            ,
            function (data, status) {

            });
        SumOfInvoiceBill();
    }



}

//function AddRowsToRFQItemsTable(List) {

//    var ProductTableData = $("#tblListFieldData").children('thead').children('tr');

//    ProductTableData.each(function (i, el) {
//        var $tds = $(this).find('th');
//        var $trs = $('#tblListFieldData tr');

//        var k = $('#tblListFieldData tr').length - 1;

//        var rowsData = "";
//        if (k == 0) {
//            rowsData = "<tr id=Row_" + k + ">";
//            rowsData += "<td id=ProductDiv_" + k + "><select name='ProductId' id=ProductName_" + k + " class='select2'></select></td>";
//        }
//        else {

//             k = parseInt($trs[k].cells[0].children[0].id.toString().substring(12)) + 1;
//            rowsData = "<tr id=Row_" + k + ">";
//            rowsData += "<td id=ProductDiv_" + k + "></td>";
//        }
//        rowsData += "<td><input name='Description' id=Description_" + k + " class=\"form-control \" value=\"\"  /></td>";
//        rowsData += "<td><input name='Sku' id=Sku" + k + " class=\"form-control \" value=\"\"/></td>";
//        rowsData += "<td><input name='Quantity' id=Quantity_" + k + " class=\"form-control \" value=\"\"  /></td>";
       
//            rowsData += "<td><a id = remove_" + k + "> <i class=\" mr-3 icon-cancel red-text\"></i></a ></td>";
      
      
//        rowsData += "</tr>";


//        if (k != 0) {

//            var ddlId = $trs[1].cells[0].children[0].id;
//            var ddl = $("#" + ddlId.toString()).clone();


//            //Set the ID and Name
//            ddl.attr("id", "ProductName_" + k);
//            ddl.attr("name", "ProductId");
//            ddl.attr("style", "display:none");
//            $("#divListFieldRows").append(rowsData);
//            $("#ProductDiv_" + k).append(ddl);
//            ddl.select2();


//        }
//        else {
//            $("#divListFieldRows").append(rowsData);
//            $("#ProductName_0").html("");
//            $("#ProductName_0").append(
//                $('<option></option>').val("0").html("Select Product"));
//            $.each(List.data, function (i, item) {
//                $("#ProductName_0").append(
//                    $('<option></option>').val(item.value).html(item.text + " ( " + item.Column2 + " )"));
//            });

//            $("#ProductName_0").select2();
//        }
//        $("#remove_" + k + "").click(function () {
//            $("#Row_" + k + "").remove();

//        });

//    });
   



