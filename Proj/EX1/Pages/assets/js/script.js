$(function() {

    var owner = $('#owner');
    var cardNumber = $('#cardNumber');
    var cardNumberField = $('#card-number-field');
    var CVV = $("#cvv");
    var mastercard = $("#mastercard");
    var confirmButton = $('#confirm-purchase');
    
    var visa = $("#visa");
    var amex = $("#amex");

    // Use the payform library to format and validate
    // the payment fields.

    cardNumber.payform('formatCardNumber');
    CVV.payform('formatCardCVC');


    cardNumber.keyup(function() {

        amex.removeClass('transparent');
        visa.removeClass('transparent');
        mastercard.removeClass('transparent');

        if ($.payform.validateCardNumber(cardNumber.val()) == false) {
            cardNumberField.addClass('has-error');
        } else {
            cardNumberField.removeClass('has-error');
            cardNumberField.addClass('has-success');
        }

        if ($.payform.parseCardType(cardNumber.val()) == 'visa') {
            mastercard.addClass('transparent');
            amex.addClass('transparent');
        } else if ($.payform.parseCardType(cardNumber.val()) == 'amex') {
            mastercard.addClass('transparent');
            visa.addClass('transparent');
        } else if ($.payform.parseCardType(cardNumber.val()) == 'mastercard') {
            amex.addClass('transparent');
            visa.addClass('transparent');
        }
    });

    confirmButton.click(function(e) {

        e.preventDefault();

        var isCardValid = $.payform.validateCardNumber(cardNumber.val());
        var isCvvValid = $.payform.validateCardCVC(CVV.val());

        if(owner.val().length < 5){
            alert("Wrong owner name");
        } else if (!isCardValid) {
            alert("Wrong card number");
        } else if (!isCvvValid) {
            alert("Wrong CVV");
        } else {
            
            let saveToPayment = {
                Name: $("#formName").val(),
                Email: $("#formEmail").val(),
                Owner: $("#owner").val(),
                Cvv: $("#cvv").val(),
                CardNumber: $("#cardNumber").val(),
                ExpirationDate: $("#month option:selected").text() + $("#year option:selected").text(),
                Amount: finalPrice
            }

            ajaxCall("POST", "../api/Payments", JSON.stringify(saveToPayment), paySuccess, payError);

        }
    });

    function paySuccess() {
        swal({
            title: "! תודה על קנייתך",
            text: "נציג ייצור איתך קשר בהקדם",
            icon: "success",
           
        })
            .then((value) => {

                window.open("Flights.html");
                window.close("TisotPlus.html");
            });

    }

   
    function payError() {
        swal("! כניסתך נדחיתה", "נסה שנית", "error");
    }

  
});



