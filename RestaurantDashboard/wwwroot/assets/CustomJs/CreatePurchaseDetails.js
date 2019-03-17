

function AddRowsToPurchaseOrderTable(List)
{

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
        rowsData += "<td><input name='UnitOfMeasure' id=UnitOfMeasure_" + k + " class=\"form-control \" value=\"\"  /></td>";     
        rowsData += "<td><input name='Description' id=Description_" + k + " class=\"form-control \" value=\"\"  /></td>";     
        rowsData += "<td><input name='Quantity' id=Quantity_" + k + " class=\"form-control \" value=\"\"  /></td>";
        rowsData += "<td><input name='UnitPrice' id=UnitPrice_" + k + " class=\"form-control \" value=\"\" onChange='SumOfInvoiceBill()' /></td>";
        rowsData += "<td><input name='Tax' id=Tax_" + k + " class=\"form-control \" value=\"\"  /></td>";
        rowsData += "<td><input name='TotalAmount' id=TotalAmount_" + k + " class=\"form-control \" value=\"\"  /></td>";


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
                    $('<option></option>').val(item.value).html(item.text + " ( " + item.Column4 + " )"));
            });

            $("#ProductName_0").select2();
        }


        $("#remove_" + k + "").click(function () {
            $("#Row_" + k + "").remove();
            SumOfInvoiceBill();
        });
        $("#ProductName_" + k + "").change(function () {

            var arrayindex = List.data.findIndex(function (row) {
                return row.value == $("#ProductName_" + k + "").val();;
            });
            var arrayData = List.data[arrayindex];
            document.getElementById("UnitOfMeasure_" + k + "").value = arrayData.Column2;
            document.getElementById("Quantity_" + k + "").value = "1";
            document.getElementById("Description_" + k + "").value = arrayData.Column3;
            document.getElementById("UnitPrice_" + k + "").value = arrayData.Column5;
            document.getElementById("TotalAmount_" + k + "").value = arrayData.Column5;  
            SumOfInvoiceBill();
        });

        $("#Quantity_" + k + "").change(function () {

            var qts = $("#Quantity_" + k + "").val();
            var untprc = $("#UnitPrice_" + k + "").val();
            var totamt = qts * untprc;          
            document.getElementById("TotalAmount_" + k + "").value = totamt;
            SumOfInvoiceBill();
        });


        $("#UnitPrice_" + k + "").change(function () {

            var qts = $("#Quantity_" + k + "").val();
            var untprc = $("#UnitPrice_" + k + "").val();
            var totamt = qts * untprc;
            document.getElementById("TotalAmount_" + k + "").value = totamt;
            SumOfInvoiceBill();
        });

    });

}

var subtotal, taxable, tax, freight, insurance, consular, inspection, other;

function Calculate() {

    subtotal = document.getElementById('subtotal').value;
    if (subtotal == "") { subtotal = 0; }
    taxable = document.getElementById('taxable').value;
    if (taxable == "") { taxable = 0; }
    taxrate = document.getElementById('taxrate').value;
    if (taxrate == "") { taxrate = 0; }
    tax = document.getElementById('tax').value;
    if (tax == "") { tax = 0; }
    freight = document.getElementById('freight').value;
    if (freight == "") { freight = 0; }
    insurance = document.getElementById('insurance').value;
    if (insurance == "") { insurance = 0; }
    consular = document.getElementById('consular').value;
    if (consular == "") { consular = 0; }
    inspection = document.getElementById('inspection').value;
    if (inspection == "") { inspection = 0; }
    other = document.getElementById('other').value;
    if (other == "") { other = 0; }
    document.getElementById('total').value = (parseFloat(subtotal) + parseFloat(taxable) + parseFloat(taxrate) + parseFloat(tax) + parseFloat(freight) + parseFloat(insurance) + parseFloat(consular) + parseFloat(inspection) + parseFloat(other));
    //document.getElementById('total').value = (parseFloat(subtotal) + parseFloat(taxable) + parseFloat(taxrate) + parseFloat(tax) + parseFloat(freight));
}

function SumOfInvoiceBill() {
    var totalAmount = computeTableColumnTotal("tblListFieldData", 6);
    //var taxable = document.getElementById('taxable').value;
    document.getElementById('subtotal').value = totalAmount;
    //document.getElementById('taxable').value = totalAmount;
    //var TaxAmount = Math.round((parseFloat(totalTaxAmount)));
    //document.getElementById('TaxAmount').innerText = "$" + TaxAmount.toString();
    //document.getElementById('TotalAmount').innerText = "$" + (totalAmountExclTax + TaxAmount).toString();
}

function computeTableColumnTotal(tableId, colNumber) {
    // find the table with id attribute tableId
    // return the total of the numerical elements in column colNumber
    // skip the top row (headers) and bottom row (where the total will go)

    var result = 0;

    try {
        var tableElem = window.document.getElementById(tableId);
        var tableBody = tableElem.getElementsByTagName("tbody").item(0);
        var i;
        var howManyRows = tableBody.rows.length;
        for (i = 0; i < (howManyRows); i++) // skip first and last row (hence i=1, and howManyRows-1)
        {
            var thisTrElem = tableBody.rows[i];
            var thisTdElem = thisTrElem.cells[colNumber];
            var thisTextNode = thisTdElem.childNodes.item(0).value;

            // try to convert text to numeric
            var thisNumber = parseFloat(thisTextNode);
            // if you didn't get back the value NaN (i.e. not a number), add into result
            if (!isNaN(thisNumber))
                result += thisNumber;
        } // end for

    } // end try
    catch (ex) {
        window.alert("Exception in function computeTableColumnTotal()\n" + ex);
        result = 0;
    }
    finally {
        return result;
    }

}