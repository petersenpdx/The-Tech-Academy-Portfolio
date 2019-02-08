function totalSize() {
    var receipt = []; // this will show a list of selected items
    var total = 0; // keeps a running total of numeric cost
    var sizeArray = document.getElementsByClassName("pizza_size");
    
    for (var i = 0; i < sizeArray.length; i++) { // declare counter variable set to 0, increment countery until it is no longer less than the size of the array
        if (sizeArray[i].checked) {
            var selectedSize = sizeArray[i].value;
            receipt = receipt + "<strong>Size: </strong>" + selectedSize + "<br>";
        };
    };

    if (selectedSize === "Personal") {
        total += 6;
    } else if (selectedSize === "Medium") {
        total += 10;
    } else if (selectedSize === "Large") {
        total += 14;
    } else if (selectedSize === "Extra Large") {
        total += 16;
    };

    totalMeat(receipt,total);
};

function totalMeat(receipt,total) {
    var meatArray = document.getElementsByClassName("meat_type");
    var mySelectedMeats = []
    var meatTotal = 0

    for (var i = 0; i < meatArray.length; i++) {
		if (meatArray[i].checked) {
			mySelectedMeats.push(meatArray[i].value);
			receipt = receipt + "+ " + meatArray[i].value + "<br>";
		};
	};

    var meatCount = mySelectedMeats.length;
	if (meatCount > 1) {
		meatTotal = (meatCount - 1);
	} else {
		meatTotal = 0;
    };
    
    total = total + meatTotal;

    totalCheese(receipt,total)
};

function totalCheese(receipt,total) {

    var cheeseArray = document.getElementsByClassName("cheese_choice");
    
    for (var i = 0; i < cheeseArray.length; i++) { // declare counter variable set to 0, increment countery until it is no longer less than the size of the array
        if (cheeseArray[i].checked) {
            var selectedCheese = cheeseArray[i].value;
            receipt = receipt + "+ " + selectedCheese + "<br>";
        };
    };

    // total = total does not affect total, but this leaves the code ready for quickly updating costs in the future
    if (selectedCheese === "Regular") {
        total = total
    } else if (selectedCheese === "No Cheese") {
        total = total
    } else if (selectedCheese === "Extra Cheese") {
        total += 3;
    };

    totalCrust(receipt,total);
};

function totalCrust(receipt,total) {

    var crustArray = document.getElementsByClassName("crust_choice");
    
    for (var i = 0; i < crustArray.length; i++) { // declare counter variable set to 0, increment countery until it is no longer less than the size of the array
        if (crustArray[i].checked) {
            var selectedCrust = crustArray[i].value;
            receipt = receipt + "+ " + selectedCrust + "<br>";
        };
    };

    // total = total does not affect total, but this leaves the code ready for quickly updating costs in the future
    if (selectedCrust === "Plain Crust") {
        total = total
    } else if (selectedCrust === "Garlic Butter Crust") {
        total = total
    } else if (selectedCrust === "Cheese Stuffed Crust") {
        total += 3
    } else if (selectedCrust === "Spicy Crust") {
        total = total
    } else if (selectedCrust === "House Special Crust") {
        total = total
    };

    totalSauce(receipt,total);
};

function totalSauce(receipt,total) {

    var sauceArray = document.getElementsByClassName("sauce_choice");
    
    for (var i = 0; i < sauceArray.length; i++) { // declare counter variable set to 0, increment countery until it is no longer less than the size of the array
        if (sauceArray[i].checked) {
            var selectedSauce = sauceArray[i].value;
            receipt = receipt + "+ " + selectedSauce + "<br>";
        };
    };

    // there is no cost change for different sauces, but this code is here for quickly updating costs in the future
    // if (selectedSauce === "Marinara Sauce") {
    //     total = total
    // } else if (selectedSauce === "White Sauce") {
    //     total = total
    // } else if (selectedSauce === "Barbeque Sauce") {
    //     total = total
    // } else if (selectedSauce === "No Sauce") {
    //     total = total
    // };

    totalVeggies(receipt,total);
};

function totalVeggies(receipt,total) {
    var veggiesArray = document.getElementsByClassName("veggies_type");
    var mySelectedVeggies = []
    var veggiesTotal = 0

    for (var i = 0; i < veggiesArray.length; i++) {
		if (veggiesArray[i].checked) {
			mySelectedVeggies.push(veggiesArray[i].value);
			receipt = receipt + "+ " + veggiesArray[i].value + "<br>";
		};
	};

    var veggiesCount = mySelectedVeggies.length;
	if (veggiesCount > 1) {
		veggiesTotal = (veggiesCount - 1);
	} else {
		veggiesTotal = 0;
    };
    
    total = total + veggiesTotal;

    printInvoice(receipt,total);
};

function printInvoice(receipt,total) {
    document.getElementById("your_order").innerHTML = receipt + "<hr>" + "<strong>Your total will be:</strong> $" + total;
};

function clearForm() {
    document.getElementById("your_order").innerHTML = "Place your order today!";
    document.getElementById("size_form").reset(); 
    document.getElementById("meat_form").reset(); 
    document.getElementById("cheese_form").reset(); 
    document.getElementById("crust_form").reset(); 
    document.getElementById("sause_form").reset(); 
    document.getElementById("veggies_form").reset(); 
};